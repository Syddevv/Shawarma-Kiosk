using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class receiptMultiple : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";

        // Properties to receive data
        public List<cart.CartItem> CartItems { get; set; }
        public string AddOns { get; set; }
        public string SpecialInstructions { get; set; }
        public decimal Total { get; set; }
        public receiptMultiple()
        {
            InitializeComponent();
        }

        private void receiptMultiple_Load(object sender, EventArgs e)
        {
            PopulateReceiptPanel();
            totalLabel.Text = $"₱{Total:F2}";
            addonsLabel.Text = $"{AddOns}";
            specialLabel.Text = $"{SpecialInstructions}";

            // Generate a random order ID
            Random random = new Random();
            int orderId = random.Next(100, 1000);
            orderIdLabel.Text = $"{orderId}";

            SaveOrderToDatabase(orderId);
        }

        private void PopulateReceiptPanel()
        {
            receiptPanel.Controls.Clear();

            foreach (var item in CartItems)
            {
                Label receiptItem = new Label
                {
                    Text = $"{item.ProductName} - ₱{item.ProductPrice:F2} x {item.Quantity} = ₱{item.ProductPrice * item.Quantity:F2}",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                    Margin = new Padding(5),
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                receiptPanel.Controls.Add(receiptItem);
            }
        }

        private void SaveOrderToDatabase(int orderId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO orders ([Order ID], [Order List and Quantity], [Special Instructions], [Add Ons], Total, [Status], [Date and Time]) " +
                               "VALUES (@orderId, @orderListQuantity, @specialInstructions, @addons, @total, @status, @dateTime)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Prepare the order list string
                    string orderListQuantity = string.Join(", ", CartItems.Select(item => $"{item.ProductName} - {item.Quantity} pcs"));

                    // Default status
                    string status = "Processing";

                    // Get the current date and time
                    DateTime currentDateTime = DateTime.Now;

                    // Add parameters
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.Parameters.AddWithValue("@orderListQuantity", orderListQuantity);
                    command.Parameters.AddWithValue("@specialInstructions", SpecialInstructions);
                    command.Parameters.AddWithValue("@addons", AddOns);
                    command.Parameters.AddWithValue("@total", Total);
                    command.Parameters.AddWithValue("@status", status);

                    // Add the DateTime parameter with correct type
                    OleDbParameter dateTimeParam = new OleDbParameter("@dateTime", OleDbType.Date);
                    dateTimeParam.Value = currentDateTime;
                    command.Parameters.Add(dateTimeParam);

                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.Close(); // Close the form
        }
    }
}

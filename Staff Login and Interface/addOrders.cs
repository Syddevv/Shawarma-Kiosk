using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Login_and_Interface
{
    public partial class addOrders : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";
        private decimal total = 0;
        public addOrders()
        {
            InitializeComponent();
        }

        private void addOrders_Load(object sender, EventArgs e)
        {
            LoadProducts(); // Populate the product list
            LoadAddOns();

            productList.ItemCheck += productList_ItemCheck;
            addOnsList.ItemCheck += addOnsList_ItemCheck;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            int orderId = new Random().Next(100, 1000);
            string orderList = selectedProductsLabel.Text.Trim();
            string addOns = string.Join(", ", addOnsList.CheckedItems.Cast<string>()
                             .Select(item => {
                                 string addOnName = item.Split('-')[0].Trim(); // Extract name
                                 decimal addOnPrice = ExtractPriceFromItem(item); // Extract price
                                 return $"{addOnName} (₱{addOnPrice:F2})"; // Format as desired
                             }));
            string specialInstructions = specialTB.Text;
            DateTime currentDateTime = DateTime.Now;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO orders ([Order ID], [Order List and Quantity], [Add Ons], [Special Instructions], Total, [Date and Time], [Status]) " +
                                   "VALUES (@orderId, @orderList, @addOns, @specialInstructions, @total, @dateTime, @status)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Explicitly define parameter types and values
                        command.Parameters.Add("@orderId", OleDbType.Integer).Value = orderId; // Order ID as number
                        command.Parameters.Add("@orderList", OleDbType.VarChar).Value = orderList; // Order List as short text
                        command.Parameters.Add("@addOns", OleDbType.VarChar).Value = addOns; // Add Ons as short text
                        command.Parameters.Add("@specialInstructions", OleDbType.VarChar).Value = specialInstructions; // Special Instructions as short text
                        command.Parameters.Add("@total", OleDbType.Decimal).Value = total; // Total as decimal
                        command.Parameters.Add("@dateTime", OleDbType.Date).Value = currentDateTime; // Date and Time as DateTime
                        command.Parameters.Add("@status", OleDbType.VarChar).Value = "Processing"; // Status as "Processing"

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order saved successfully!");
                this.Close(); // Close the form after successful save
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        } 

        private void LoadProducts()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [product_name], [product_price] FROM Products";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string productName = reader["product_name"].ToString();
                        decimal price = Convert.ToDecimal(reader["product_price"]);
                        productList.Items.Add($"{productName} - ₱{price:F2}");
                    }
                }
            }
        }

        private void LoadAddOns()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [product_name], [product_price] FROM add_ons";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string addOnName = reader["product_name"].ToString();
                        decimal price = Convert.ToDecimal(reader["product_price"]);
                        addOnsList.Items.Add($"{addOnName} - ₱{price:F2}"); // Original format
                    }
                }
            }
        }

        private void productList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                var quantityForm = new quantity();

                // Extract product name and price
                string productInfo = productList.Items[e.Index].ToString();
                string productName = productInfo.Split('-')[0].Trim();
                decimal productPrice = ExtractPriceFromItem(productInfo);

                // Pass name and price to the quantity form
                quantityForm.ProductName = productName;
                quantityForm.ProductPrice = productPrice;

                if (quantityForm.ShowDialog() == DialogResult.OK) // Wait for user input
                {
                    if (quantityForm.Quantity > 0)
                    {
                        // Update labels and total based on user input
                        selectedProductsLabel.Text += $"{quantityForm.ProductName} - {quantityForm.Quantity} pcs\n";
                        total += quantityForm.ProductPrice * quantityForm.Quantity; // Update total
                        totalLabel.Text = $"₱ {total:F2}";
                    }
                }
            }
        }

        private void addOnsList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string addOnInfo = addOnsList.Items[e.Index].ToString();
            decimal addOnPrice = ExtractPriceFromItem(addOnInfo);
            string addOnName = addOnInfo.Split('-')[0].Trim(); // Original name extraction

            if (e.NewValue == CheckState.Checked)
            {
                selectedAddOns.Text += $"{addOnName} (₱{addOnPrice:F2})\n"; // Desired format
                total += addOnPrice;
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                selectedAddOns.Text = selectedAddOns.Text.Replace($"{addOnName} (₱{addOnPrice:F2})\n", "");
                total -= addOnPrice;
            }

            totalLabel.Text = $"₱ {total:F2}";
        }

        private decimal ExtractPriceFromItem(string item)
        {
            // Extract the price part of the item, assuming it's in the format "Name - ₱Price"
            string pricePart = item.Split('₱')[1].Trim();  // Extract after "₱"
            return decimal.Parse(pricePart);
        }


    }
}

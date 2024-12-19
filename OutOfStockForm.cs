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
using Admin_Login;

namespace Admin_Login
{
    public partial class inStockForm : Form
    {
        public inStockForm()
        {
            InitializeComponent();
        }

        private int _productId;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";


        public event Action<int> ProductMarkedInStock;

        public inStockForm(int productId, Image productImage, string productName, decimal productPrice)
        {
            InitializeComponent();

            // Initialize values
            _productId = productId;
            productPictureBox.Image = productImage;
            nameLabel.Text = productName;
            priceLabel.Text = $"₱{productPrice:F2}";
        }

        private void markasInStock_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show(
       "Are you sure you want to mark this product as in stock?",
       "Confirm In Stock",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (confirmationResult == DialogResult.Yes)
            {
                ProductMarkedInStock?.Invoke(_productId); // Trigger the event
                this.Close(); // Close the form
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Set the labels' alignment to center
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;

            nameLabel.AutoSize = false;
            priceLabel.AutoSize = false;

            // Adjust the size and position to center in the form
            nameLabel.Width = this.Width;
            nameLabel.Location = new Point(0, nameLabel.Location.Y); // Center horizontally

            priceLabel.Width = this.Width;
            priceLabel.Location = new Point(0, priceLabel.Location.Y); // Center horizontally

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Prompt user with a confirmation message box
            var confirmationResult = MessageBox.Show(
                "Are you sure you want to remove this product?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    // Remove product from the database
                    DeleteProductFromDatabase();

                    // Optionally, you can close the form here
                    MessageBox.Show("Product successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the inStockForm
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while removing the product: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteProductFromDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // SQL DELETE query to remove the product from the database
                string deleteQuery = "DELETE FROM products WHERE product_id = @productId";
                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@productId", _productId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // If product is deleted successfully, trigger the event to update the UI
                        MessageBox.Show("Product removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void inStockForm_Load(object sender, EventArgs e)
        {

        }
    }
}
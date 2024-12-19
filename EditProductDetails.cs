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
using static Admin_Login.Dashboard;


namespace Admin_Login
{
    public partial class EditProductDetails : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductId { get; set; }


        public EditProductDetails()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Populate the controls with product details
            if (ProductImage != null)
                productPictureBox.Image = ProductImage;

            nameTB.Text = ProductName ?? string.Empty; // Set product name
            priceTB.Text = ProductPrice > 0 ? ProductPrice.ToString("0") : string.Empty; // Set product price
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new ProductDetailsForm().Show();
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // Get the updated values from textboxes
            string updatedName = nameTB.Text.Trim();
            decimal updatedPrice;
            bool isValidPrice = decimal.TryParse(priceTB.Text.Trim(), out updatedPrice);

            if (string.IsNullOrEmpty(updatedName))
            {
                MessageBox.Show("Product name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isValidPrice || updatedPrice <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the local properties
            ProductName = updatedName;
            ProductPrice = updatedPrice;

            // Update the database
            try
            {
                UpdateProductInDatabase();
                MessageBox.Show("Product details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after updating
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProductInDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Database connection established.");

                    // SQL Update query to update the product details
                    string updateQuery = "UPDATE products SET product_name = @productName, product_price = @productPrice WHERE product_id = @productId";
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@productName", ProductName);
                        command.Parameters.AddWithValue("@productPrice", ProductPrice);
                        command.Parameters.AddWithValue("@productId", ProductId);

                        Console.WriteLine($"Executing query: {updateQuery}");
                        Console.WriteLine($"Parameters: productName = {ProductName}, productPrice = {ProductPrice}, productId = {ProductId}");

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        // Display a message based on the result
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No product was updated. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception
                    Console.WriteLine($"Exception: {ex.Message}");
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


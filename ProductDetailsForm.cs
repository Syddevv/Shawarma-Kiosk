using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Admin_Login.Dashboard;

namespace Admin_Login
{
    public partial class ProductDetailsForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductId { get; set; }

        public ProductDetailsForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Dynamically populate the controls
            if (ProductImage != null)
                productPictureBox.Image = ProductImage;
            nameLabel.Text = ProductName ?? "Unknown Product";
            priceLabel.Text = $"₱ {ProductPrice:0.00}"; // Format price with peso symbol

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditProductDetails editForm = new EditProductDetails
            {
                ProductName = ProductName, // Pass product name
                ProductPrice = ProductPrice, // Pass product price
                ProductImage = ProductImage, // Pass product image
                ProductId = ProductId // Pass product ID
            };

            // Show the EditProductDetails form
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Update product details after editing
                ProductName = editForm.ProductName;
                ProductPrice = editForm.ProductPrice;
                ProductImage = editForm.ProductImage;

                // Update the UI with the new values
                nameLabel.Text = ProductName;
                priceLabel.Text = $"₱ {ProductPrice:0.00}";
                productPictureBox.Image = ProductImage;

                // Optionally: Refresh product details in the database if necessary
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Prompt user with a confirmation message box
            var confirmationResult = MessageBox.Show(
                "Are you sure you want to remove this product?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    // Delete the product from the database
                    DeleteProductFromDatabase();

                    // Optionally: Remove the product from the UI (if you want to handle UI updates)
                    this.Close(); // Close the ProductDetailsForm if it is being used to display the product
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the product: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteProductFromDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Delete product from the database
                string deleteQuery = "DELETE FROM products WHERE product_id = @productId";
                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@productId", ProductId);
                    Console.WriteLine("Deleting ProductId: " + ProductId);  // Log the ProductId to verify

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Rows affected: " + rowsAffected);  // Log the number of affected rows
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public event Action<int> ProductMarkedOutOfStock;
        private void outofStockBTN_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show(
                 "Are you sure you want to mark this product as out of stock?",
                 "Confirm Out of Stock",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
             );

            if (confirmationResult == DialogResult.Yes)
            {
                ProductMarkedOutOfStock?.Invoke(ProductId);
                this.Close();
            }
        }


        private void openInStockForm_Click(object sender, EventArgs e)
        {
            inStockForm stockForm = new inStockForm(ProductId, ProductImage, ProductName, ProductPrice);

            stockForm.ProductMarkedInStock += id => ProductMarkedOutOfStock?.Invoke(id);
            stockForm.ShowDialog();
        } 
    }

}




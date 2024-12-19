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

namespace Admin_Login
{
    public partial class addProduct : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";
        private string imageFilePath = ""; // To store the selected image file path
        public addProduct()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // Gather input data
            string productName = productnameTB.Text.Trim();
            decimal productPrice;

            // Validate the product price input
            if (!decimal.TryParse(priceTB.Text, out productPrice))
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Category is now required
            string productCategory = categoryTB.Text.Trim();

            // Check if any required field (product name, category, or image) is missing
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(imageFilePath) || string.IsNullOrEmpty(productCategory))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the product to the database
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Update SQL query to insert into 'category' column instead of 'product_size'
                    string query = "INSERT INTO products (product_name, product_price, category, product_image, stock_status) " +
                                   "VALUES (@name, @price, @category, @imagePath, 'In Stock')";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", productName);
                        command.Parameters.AddWithValue("@price", productPrice);
                        command.Parameters.AddWithValue("@category", productCategory);  // Save to category column
                        command.Parameters.AddWithValue("@imagePath", imageFilePath);

                        command.ExecuteNonQuery();
                    }
                }

                // Clear fields after successful addition
                productnameTB.Clear();
                priceTB.Clear();
                categoryTB.Clear();  // Clear the category input as well
                productPictureBox.Image = null;
                imageFilePath = "";

                // Notify the user of success
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the dashboard by calling LoadProductsToDashboard on the Dashboard form
                if (this.Owner != null && this.Owner is Dashboard dashboard)
                {
                    dashboard.LoadProductsToDashboard();
                }

                // Close the addProduct form
                this.Close();
            }
            catch (Exception ex)
            {
                // Display error message if something goes wrong
                MessageBox.Show($"Error adding product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png",
                Title = "Select a Product Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = openFileDialog.FileName;
                productPictureBox.Image = Image.FromFile(imageFilePath); // Show the image in PictureBox
            }
        }

        private void addProduct_Load(object sender, EventArgs e)
        {

        }
    }
}

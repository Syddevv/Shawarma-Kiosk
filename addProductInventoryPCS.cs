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
    public partial class addProductInventoryPCS : Form
    {
        private inventoryPerPiece parentForm;
        public addProductInventoryPCS(inventoryPerPiece parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = productnameTB.Text;
                int quantity = int.Parse(quantityTB.Text);

                // Get current date and time
                DateTime dateTimeUpdated = DateTime.Now;

                // Call the method to save data to the database
                AddProductToInventory(productName, quantity, dateTimeUpdated);

                // Update parent form's inventory list by calling the LoadInventoryData method
                parentForm.LoadInventoryData();  // Refresh the DataGridView in the parent form

                // Close the form after saving
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductToInventory(string productName, int quantity, DateTime dateTimeUpdated)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Use a parameterized SQL query to insert the new product into existing columns
                    string insertQuery = @"
                INSERT INTO [Inventory Per Piece] 
                ([material_name], [quantity], [date_time_updated], [quantity_update]) 
                VALUES (@productName, @quantity, @dateTimeUpdated, @quantityUpdate)";

                    using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                    {
                        // Add parameters to the query to insert values
                        command.Parameters.Add("@productName", OleDbType.VarChar).Value = productName;
                        command.Parameters.Add("@quantity", OleDbType.Integer).Value = quantity;
                        command.Parameters.Add("@dateTimeUpdated", OleDbType.DBDate).Value = dateTimeUpdated;
                        command.Parameters.Add("@quantityUpdate", OleDbType.Integer).Value = quantity; // For new product, quantity update is the same as the quantity

                        // Execute the query to insert the new row
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to add product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

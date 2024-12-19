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
    public partial class updateInventoryPerPiece : Form
    {
        private string ingredientName;
        private int currentQuantity;
        public updateInventoryPerPiece()
        {
            InitializeComponent();
        }

        public updateInventoryPerPiece(string ingredientName, int currentQuantity)
        {
            InitializeComponent();
            this.ingredientName = ingredientName;
            this.currentQuantity = currentQuantity;

            // Assign the text to the label
            ingredientNameTextBox.Text = ingredientName;
            ingredientNameTextBox.TextAlign = ContentAlignment.MiddleCenter; // Center the text inside the label

            qtyTB.Text = currentQuantity.ToString(); // Ensure qtyTB exists

            // Center the label using Anchor property and Location adjustment
            CenterLabel(ingredientNameTextBox);
        }

        // CenterLabel Method to center the Label
        private void CenterLabel(Label label)
        {
            // Set the Label's anchor to keep it centered horizontally
            label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Adjust the label width to a proportion of the form width (e.g., 60% of form width)
            label.Width = (int)(this.ClientSize.Width * 0.6); // Adjust this proportion as needed

            // Update the label's location to be centered horizontally
            label.Location = new Point((this.ClientSize.Width - label.Width) / 2, label.Location.Y);
        }

        private void updateInventoryPerPiece_Load(object sender, EventArgs e)
        {

        }

        private void increaseQtyBTN_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(qtyTB.Text);
            qtyTB.Text = (qty + 1).ToString();
        }

        private void dercreaseQtyBTN_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(qtyTB.Text);
            if (qty > 0)
            {
                qtyTB.Text = (qty - 1).ToString();
            }
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int newQuantity = int.Parse(qtyTB.Text);
                int quantityDifference = newQuantity - currentQuantity;

                // Format the quantity difference with a + or - sign
                string formattedQuantityDifference = (quantityDifference >= 0 ? "+" : "") + quantityDifference;

                // Debugging: Check the values being passed
                MessageBox.Show($"New Quantity: {newQuantity}, Quantity Difference: {formattedQuantityDifference}");

                // Update the database with the correct parameters
                UpdateInventoryDatabase(ingredientName, newQuantity, formattedQuantityDifference);

                // Close the form after saving
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle any parsing errors or logic errors
                MessageBox.Show($"Error in confirming the update: {ex.Message}");
            }
        }


        private void UpdateInventoryDatabase(string ingredientName, int newQuantity, string formattedQuantityDifference)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Use a parameterized SQL query to update the inventory
                    string updateQuery = @"
                UPDATE [Inventory Per Piece] 
                SET [quantity] = @newQuantity, 
                    [date_time_updated] = @dateTime, 
                    [quantity_update] = @quantityDifference 
                WHERE [material_name] = @ingredientName";

                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        // Explicitly set parameter data types
                        command.Parameters.Add("@newQuantity", OleDbType.Integer).Value = newQuantity;
                        command.Parameters.Add("@dateTime", OleDbType.DBDate).Value = DateTime.Now;
                        command.Parameters.Add("@quantityDifference", OleDbType.VarChar).Value = formattedQuantityDifference; // Update the field with the formatted value
                        command.Parameters.Add("@ingredientName", OleDbType.VarChar).Value = ingredientName;

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Inventory updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Ask for confirmation before deleting
                var confirmResult = MessageBox.Show($"Are you sure you want to delete the product '{ingredientName}' from the inventory?",
                                                    "Confirm Deletion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Call the method to delete the product from the database
                    DeleteProductFromDatabase(ingredientName);

                    // Close the form after deletion
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteProductFromDatabase(string ingredientName)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to delete the product based on the ingredient name
                    string deleteQuery = "DELETE FROM [Inventory Per Piece] WHERE [material_name] = @ingredientName";

                    using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                    {
                        command.Parameters.Add("@ingredientName", OleDbType.VarChar).Value = ingredientName;

                        // Execute the delete query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Product not found, deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

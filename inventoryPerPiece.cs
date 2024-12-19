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
    public partial class inventoryPerPiece : Form
    {
        public inventoryPerPiece()
        {
            InitializeComponent();
            inventoryTable.CellClick += inventoryTable_CellClick;
        }

        private void productsLabel_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }

        private void historyLabel_Click(object sender, EventArgs e)
        {
            new history().Show();
            this.Close();
        }

        private void salesLabel_Click(object sender, EventArgs e)
        {
            new sales().Show();
            this.Close();
        }

        public void LoadInventoryData()
        {
            try
            {
                string query = "SELECT [material_ID], [material_name], [quantity], [date_time_updated], [quantity_update] FROM [Inventory Per Piece]";

                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb"))
                {
                    connection.Open();
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);

                    // Create a DataTable to hold the data
                    DataTable inventoryData = new DataTable();
                    dataAdapter.Fill(inventoryData);

                    // Clear the DataGridView to avoid duplication
                    inventoryTable.Rows.Clear();

                    // Populate the DataGridView rows manually
                    foreach (DataRow row in inventoryData.Rows)
                    {
                        inventoryTable.Rows.Add(
                            row["material_ID"],
                            row["material_name"],
                            row["quantity"],
                            row["date_time_updated"],
                            row["quantity_update"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading inventory data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inventoryPerPiece_Load_1(object sender, EventArgs e)
        {
            inventoryTable.RowTemplate.Height = 50;
            LoadInventoryData();
        }

        private void inventoryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Get the selected product name or ID from the clicked row
                    string selectedIngredientName = inventoryTable.Rows[e.RowIndex].Cells["material_name"].Value?.ToString();
                    int currentQuantity = Convert.ToInt32(inventoryTable.Rows[e.RowIndex].Cells["quantity"].Value);

                    if (string.IsNullOrEmpty(selectedIngredientName))
                    {
                        MessageBox.Show("No ingredient name found.");
                        return;
                    }

                    // Show the updateInventory form and pass the data
                    updateInventoryPerPiece updateForm = new updateInventoryPerPiece(selectedIngredientName, currentQuantity);
                    updateForm.ShowDialog();

                    // Optionally, refresh the DataGridView after closing the form to reflect changes
                    LoadInventoryData(); // Reload the inventory data into the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while opening the update form: " + ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new inventory().Show();
            this.Close();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            addProductInventoryPCS addProductForm = new addProductInventoryPCS(this);
            addProductForm.ShowDialog();
        }
    }
}

     
 
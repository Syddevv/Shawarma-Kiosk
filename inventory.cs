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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
            inventoryTable.CellClick += inventoryTable_CellClick;
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            inventoryTable.RowTemplate.Height = 50;
            LoadInventoryData();
        }

        private void historyLabel_Click(object sender, EventArgs e)
        {
            new history().Show();
            this.Close();
        }

        private void productsLabel_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }

        public void LoadInventoryData()
        {
            try
            {
                string query = "SELECT [ingredients_ID], [ingredients_name], [ingredients_measurement_grams], [date_time_updated], [quantity_update] FROM [Inventory Per Measurement]";

                // Fetch data and load it into the DataGridView
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
                            row["ingredients_ID"],
                            row["ingredients_name"],
                            row["ingredients_measurement_grams"],
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


        // Event handler for clicking a cell in the DataGridView
        private void inventoryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Get the selected product name or ID from the clicked row
                    string selectedIngredientName = inventoryTable.Rows[e.RowIndex].Cells["ingredients_name"].Value?.ToString();
                    int currentQuantity = Convert.ToInt32(inventoryTable.Rows[e.RowIndex].Cells["ingredients_measurement_grams"].Value);

                    if (string.IsNullOrEmpty(selectedIngredientName))
                    {
                        MessageBox.Show("No ingredient name found.");
                        return;
                    }

                    // Show the updateInventory form and pass the data
                    updateInventory updateForm = new updateInventory(selectedIngredientName, currentQuantity);
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
        private void salesLabel_Click(object sender, EventArgs e)
        {
            new sales().Show();
            this.Close();
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            new Settings().Show();  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new inventoryPerPiece().Show();
            this.Close();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            addProductInventory addProductForm = new addProductInventory(this);
            addProductForm.ShowDialog();
        }

        public void RefreshInventoryList()
        {
            // Example method to reload the inventory data and refresh the display
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";
            string query = "SELECT * FROM [Inventory Per Measurement]";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Assuming you have a DataGridView or other control to show the inventory
                    inventoryTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to refresh inventory list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}


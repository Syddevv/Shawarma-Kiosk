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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
            sortInventoryType.SelectedIndex = 0;
        }

        private void historyLabel_Click(object sender, EventArgs e)
        {
            new history().Show();
            this.Close();
        }

        private void productsLabel_Click(object sender, EventArgs e)
        {
            new orders().Show();
            this.Close();
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            inventoryTable.RowTemplate.Height = 50;
            LoadInventoryData();
            sortInventoryType.SelectedIndexChanged += sortInventoryType_SelectedIndexChanged;
        }

        private void LoadInventoryData()
        {
            try
            {
                string query = "";

                // Determine which inventory type to load based on the combo box selection
                if (sortInventoryType.SelectedIndex == 0) // "Inventory Per Measurement"
                {
                    query = "SELECT [ingredients_ID], [ingredients_name], [ingredients_measurement_grams], [date_time_updated], [quantity_update] FROM [Inventory Per Measurement]";
                }
                else if (sortInventoryType.SelectedIndex == 1) // "Inventory Per Piece"
                {
                    query = "SELECT [ingredients_ID], [ingredients_name], [ingredients_per_piece], [date_time_updated], [quantity_update] FROM [Inventory Per Piece]";
                }

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
                            row["ingredients_measurement_grams"], // or ingredients_per_piece for Inventory Per Piece
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



        private void sortInventoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortInventoryType.SelectedIndex == 0) // "Inventory Per Measurement"
            {
                LoadInventoryData();  // Load inventory data for Inventory Per Measurement
            }
            else if (sortInventoryType.SelectedIndex == 1) // "Inventory Per Piece"
            {
                // Show the InventoryPerPiece form
                inventoryPerPiece inventoryPerPieceForm = new inventoryPerPiece();
                inventoryPerPieceForm.Show();
            }
        }

    }
}

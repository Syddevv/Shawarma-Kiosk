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
    public partial class inventoryPerPiece : Form
    {
        public inventoryPerPiece()
        {
            InitializeComponent();
        }

        private void inventoryPerPiece_Load(object sender, EventArgs e)
        {
            inventoryTable.RowTemplate.Height = 50;
            sortInventoryType.SelectedIndex = 1; // Default to "Inventory Per Piece"
            sortInventoryType.SelectedIndexChanged += SortInventoryType_SelectedIndexChanged; // Handle ComboBox selection change
            LoadInventoryData();
        }

        private void LoadInventoryData(string inventoryType = "Inventory Per Piece")
        {
            try
            {
                string query = "";

                if (inventoryType == "Inventory Per Measurement")
                {
                    query = "SELECT [ingredients_ID], [ingredients_name], [ingredients_measurement_grams], [date_time_updated], [quantity_update] FROM [Inventory Per Measurement]";
                }
                else if (inventoryType == "Inventory Per Piece")
                {
                    query = "SELECT [material_ID], [material_name], [quantity], [date_time_updated], [quantity_update] FROM [Inventory Per Piece]";
                }

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
                        if (inventoryType == "Inventory Per Measurement")
                        {
                            inventoryTable.Rows.Add(
                                row["ingredients_ID"],
                                row["ingredients_name"],
                                row["ingredients_measurement_grams"],
                                row["date_time_updated"],
                                row["quantity_update"]
                            );
                        }
                        else if (inventoryType == "Inventory Per Piece")
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading inventory data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inventoryPerPiece_Load_1(object sender, EventArgs e)
        {
            inventoryTable.RowTemplate.Height = 50;
            sortInventoryType.SelectedIndex = 1; // Default to "Inventory Per Piece"
            sortInventoryType.SelectedIndexChanged += SortInventoryType_SelectedIndexChanged; // Handle ComboBox selection change
            LoadInventoryData();
        }


        private void SortInventoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the change of selection in ComboBox
            if (sortInventoryType.SelectedIndex == 0) // "Inventory Per Measurement"
            {
                LoadInventoryData("Inventory Per Measurement");
            }
            else if (sortInventoryType.SelectedIndex == 1) // "Inventory Per Piece"
            {
                LoadInventoryData("Inventory Per Piece");
            }
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
            this .Close();
        }
    }
}

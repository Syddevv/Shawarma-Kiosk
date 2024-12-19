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
    public partial class history : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";

        public history()
        {
            InitializeComponent();
        }

        private void productsLabel_Click(object sender, EventArgs e)
        {
            new orders().Show();
            this.Close();
        }

        private void inventoryLabel_Click(object sender, EventArgs e)
        {
            new inventory().Show();
            this.Close();
        }

        private void LoadHistory()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Query to load history data sorted by Date and Time in descending order
                    string query = "SELECT [Order ID], [Order List and Quantity], [Add Ons], [Special Instructions], [Date and Time], Total, [Status] " +
                                   "FROM history ORDER BY [Date and Time] DESC";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable historyDataTable = new DataTable();
                        adapter.Fill(historyDataTable);

                        historyTable.RowTemplate.Height = 40;

                        // Clear existing rows before adding new data
                        historyTable.Rows.Clear();

                        // Add rows from the DataTable to the historyTable
                        foreach (DataRow dataRow in historyDataTable.Rows)
                        {
                            historyTable.Rows.Add(
                                dataRow["Order ID"],
                                dataRow["Order List and Quantity"],
                                dataRow["Add Ons"],
                                dataRow["Special Instructions"],
                                dataRow["Date and Time"],
                                dataRow["Total"],
                                dataRow["Status"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void history_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }
    }
}

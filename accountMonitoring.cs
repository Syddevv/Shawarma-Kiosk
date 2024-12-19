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
    public partial class accountMonitoring : Form
    {
        public accountMonitoring()
        {
            InitializeComponent();
        }

        private void accountMonitoring_Load(object sender, EventArgs e)
        {
            LoadLogTimeData();
        }


        private void LoadLogTimeData()
        {
            // Database connection string
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Query to fetch log_time data
                    string query = "SELECT [account ID], [Login Time], [Logout Time] FROM log_time";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        // Clear existing rows
                        logTable.Rows.Clear();

                        // Read data and add it to the DataGridView
                        while (dr.Read())
                        {
                            logTable.Rows.Add(
                                dr["account ID"].ToString(),  // Map to account_ID column
                                dr["Login Time"].ToString(),  // Map to loginTime column
                                dr["Logout Time"].ToString()  // Map to logoutTime column
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void backToSettings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
            this.Hide();
        }
    }
}

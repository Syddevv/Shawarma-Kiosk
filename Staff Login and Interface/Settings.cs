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
using static Staff_Login_and_Interface.Form1;

namespace Staff_Login_and_Interface
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to logout?", "Choose an option",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                // Record logout time before closing forms
                RecordLogoutTime(CurrentUser.AccountID);

                List<Form> formsToClose = new List<Form>();

                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name != "Form1")
                    {
                        formsToClose.Add(form);
                    }
                }

                foreach (Form form in formsToClose)
                {
                    form.Close();
                }

                new Form1().Show();
                this.Close();
            }
            else
            {
                new Settings().Show();
            }
        }

        private void RecordLogoutTime(string accountId)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string updateQuery = "UPDATE log_time SET [Logout Time] = @logoutTime WHERE accountID = @accountId AND [Logout Time] IS NULL";
                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, con))
                    {
                        cmd.Parameters.Add("@logoutTime", OleDbType.Date).Value = DateTime.Now; // Capture current time
                        cmd.Parameters.Add("@accountId", OleDbType.VarChar).Value = accountId;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Logout time recorded successfully.", "Logout Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No active session found to record logout time.", "Logout Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error recording logout time: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new orders().Show();
            this.Close();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            new forgotPass_Email().Show();
            this.Hide();
        }

        private void changePass_Icon_Click(object sender, EventArgs e)
        {
            new forgotPass_Email().Show();
            this.Hide();
        }
    }
}

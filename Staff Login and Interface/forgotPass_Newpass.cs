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
    public partial class forgotPass_Newpass : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private string email;
        private string userEmail;
        public forgotPass_Newpass(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            new forgotPass_Pin(userEmail).Show();
            this.Hide();
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            string new_Password = newPassword.Text.Trim();
            string retypePassword = retypePass.Text.Trim();

            // Validate the passwords
            if (string.IsNullOrWhiteSpace(new_Password) || string.IsNullOrWhiteSpace(retypePassword))
            {
                MessageBox.Show("Both password fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (new_Password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (new_Password != retypePassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Open the database connection
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();

                    // Update the password in the database
                    string updateQuery = "UPDATE staff_acc SET [password] = @password WHERE [email_address] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@password", new_Password);
                        cmd.Parameters.AddWithValue("?", userEmail);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new Form1().Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

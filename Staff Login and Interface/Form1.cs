using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Staff_Login_and_Interface
{
    public partial class Form1 : Form
    {
        public static class CurrentUser
        {
            public static string AccountID { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb");
            OleDbCommand cmd = new OleDbCommand();

            try
            {
                con.Open();

                // Use parameterized query to prevent SQL injection
                string loginQuery = "SELECT * FROM staff_acc WHERE username = @username AND password = @password";
                cmd = new OleDbCommand(loginQuery, con);

                // Add parameters to the command to avoid SQL injection
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Store the account ID of the logged-in user
                    CurrentUser.AccountID = dr["account ID"].ToString();

                    // Record login time
                    RecordLoginTime(CurrentUser.AccountID);

                    // Open the orders form and hide the login form
                    new orders().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

    

       

        private void RecordLoginTime(string accountId)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb");

            try
            {
                con.Open();

                // Check if there's an incomplete login record for this accountID
                string checkQuery = "SELECT COUNT(*) FROM log_time WHERE [account ID] = @accountId AND [Logout Time] IS NULL";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, con))
                {
                    checkCmd.Parameters.Add("@accountId", OleDbType.VarChar).Value = accountId;

                    int incompleteLogins = (int)checkCmd.ExecuteScalar();

                    if (incompleteLogins > 0)
                    {
                        MessageBox.Show("There is an existing session without a logout time. Please log out before logging in again.", "Duplicate Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Insert a new login record if no incomplete logins exist
                string insertQuery = "INSERT INTO log_time ([account ID], [Login Time]) VALUES (@accountId, @loginTime)";
                using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, con))
                {
                    insertCmd.Parameters.Add("@accountId", OleDbType.VarChar).Value = accountId;
                    insertCmd.Parameters.Add("@loginTime", OleDbType.Date).Value = DateTime.Now; // Capture current time
                    insertCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recording login time: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }




        // this is simply for the x icon, for closing the form.
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new forgotPass_Email().Show();
            this.Hide();
        }

        private void CheckbxShowPas_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}

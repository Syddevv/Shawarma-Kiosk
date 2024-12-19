using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Admin_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        // for connecting the data base - which is Admin Account
        private void loginBTN_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb");
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();

            try // for checking the username and password in the data base - if they match, proceeds to the next step "catch".
            {
                con.Open();
                string login = "SELECT * FROM admin_acc WHERE username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
                cmd = new OleDbCommand(login, con);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true) // if username and password matches, the orders form will open and the login form will be hidden.
                {
                    new Dashboard().Show();
                    this.Hide();
                }
                else // if username and password does not match, message box will show and the textbox of username and pass will be cleared.
                {
                    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }

                dr.Close();
            }
            catch (Exception ex) // this is for the errors.
            {
                MessageBox.Show(ex.Message);
            }
            finally // this will close the data base after using it.
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    
        // this for the show password
        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
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
    }
}

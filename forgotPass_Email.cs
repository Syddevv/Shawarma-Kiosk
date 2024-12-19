 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Login
{
    public partial class forgotPass_Email : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public forgotPass_Email()
        {
            InitializeComponent();
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void continueBTN_Click(object sender, EventArgs e)
        {
            string enteredEmail = emailTextBox.Text.Trim(); 
            if (IsEmailValid(enteredEmail))
            {
               
                string verificationCode = GenerateVerificationCode(); 
                if (SendVerificationCode(enteredEmail, verificationCode))
                {
                    
                    forgotPass_Pin pinForm = new forgotPass_Pin(enteredEmail);
                    pinForm.SetVerificationCode(verificationCode);
                    pinForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to send verification code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
               
                MessageBox.Show("The email address you entered does not match any records. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextBox.Clear();
            }
        }
        private bool IsEmailValid(string email)
        {
            try
            {
                con.Open(); 

                
                string query = "SELECT COUNT(*) FROM admin_acc WHERE email_address = @Email";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);

                
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0; 
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close(); 
            }
        }
        private string GenerateVerificationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); // Generate a 6-digit random code
        }

        private bool SendVerificationCode(string toEmail, string code)
        {
            try
            {
                
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("sydbackup08@gmail.com", "qeoo ctot xiqv aqym"),
                    EnableSsl = true
                };

                // Create the email
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("sydbackup08@gmail.com"), 
                    Subject = "Your Verification Code",
                    Body = $"Your verification code is: {code}",
                    IsBodyHtml = false
                };

                mailMessage.To.Add(toEmail);

                smtpClient.Send(mailMessage);
                return true; 
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Failed to send email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
    
}

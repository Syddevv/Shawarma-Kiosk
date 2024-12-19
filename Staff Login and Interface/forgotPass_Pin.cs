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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Staff_Login_and_Interface
{
    public partial class forgotPass_Pin : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private string verificationCode;
        private string userEmail;
        public forgotPass_Pin(string email)
        {
            InitializeComponent();
            userEmail = email;
        }
        public void SetVerificationCode(string code)
        {
            verificationCode = code;
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            new forgotPass_Email().Show();
            this.Hide();
        }

        private void verifyBTN_Click(object sender, EventArgs e)
        {
            string enteredCode = pinTextBox.Text.Trim(); // Get the code entered by the user

            // Check if the entered code matches the verification code
            if (enteredCode == verificationCode)
            {
                MessageBox.Show("Verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to the forgotPass_Newpass form and pass the email
                forgotPass_Newpass newPassForm = new forgotPass_Newpass(userEmail);
                newPassForm.Show(); // Show the new password form
                this.Hide(); // Hide the current form
            }
            else
            {
                // Code is incorrect
                MessageBox.Show("Invalid verification code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pinTextBox.Clear();
            }
        }

        private void reSendPin_Click(object sender, EventArgs e)
        {
            string newVerificationCode = GenerateVerificationCode();

            // Send the new verification code to the user's email
            if (SendVerificationCode(userEmail, newVerificationCode))
            {
                // Update the local verification code variable
                verificationCode = newVerificationCode;

                // Notify the user that the code has been resent
                MessageBox.Show("A new verification code has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to resend the verification code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrEmpty(toEmail))
                {
                    MessageBox.Show("The email address is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

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

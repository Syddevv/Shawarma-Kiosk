using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Login
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
           DialogResult = MessageBox.Show("Are you sure you want to logout?", "Choose an option",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
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



        private void changePass_Icon_Click(object sender, EventArgs e)
        {
            new forgotPass_Email().Show();
            this.Hide();
;        }

        private void changePass_Click(object sender, EventArgs e)
        {
            new forgotPass_Email().Show();
            this.Hide();
        }

        private void accmonitoringIcon_Click(object sender, EventArgs e)
        {
            new accountMonitoring().Show();
            this.Hide();
        }

        private void accmonitoringLabel_Click(object sender, EventArgs e)
        {
            new accountMonitoring().Show();
            this.Hide();
        }
    }
}

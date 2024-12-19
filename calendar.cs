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
    public partial class calendar : Form
    {
        public DateTime SelectedDate { get; private set; }
        public calendar()
        {
            InitializeComponent();
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            SelectedDate = datePicker.Value;

            // Close the Calendar form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

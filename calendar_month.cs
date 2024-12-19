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
    public partial class calendar_month : Form
    {
        public DateTime SelectedMonth { get; private set; }
        public calendar_month()
        {
            InitializeComponent();
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "MMMM yyyy";  // Display only month and year
            datePicker.ShowUpDown = true;  // Use up/down control instead of calendar view

            // Set the default value to the current month and year
            datePicker.Value = DateTime.Now;
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            // Get the selected date (first day of the selected month)
            DateTime selectedDate = datePicker.Value;
            SelectedMonth = new DateTime(selectedDate.Year, selectedDate.Month, 1);

            // Close the form and pass the selected date back to the calling form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

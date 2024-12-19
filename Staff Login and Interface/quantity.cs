using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Staff_Login_and_Interface
{
    public partial class quantity : Form
    {
        public string ProductName { get; set; } // Product name passed from the main form
        public int Quantity { get; set; } = 1;
        public decimal ProductPrice { get; set; }
        public quantity()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void increaseQtyBTN_Click(object sender, EventArgs e)
        {
            Quantity++;
            UpdateQuantityLabel();
        }

        private void decreaseQtyBTN_Click(object sender, EventArgs e)
        {
            if (Quantity > 1) // Ensure quantity doesn't go below 1
            {
                Quantity--;
                UpdateQuantityLabel();
            }
        }


        private void UpdateQuantityLabel()
        {
            quantityLabel.Text = Quantity.ToString(); // Assuming `quantityLabel` is the label showing the quantity
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            // Close the form when the user clicks 'SAVE'
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void quantity_Load(object sender, EventArgs e)
        {
            // Display product name (if there's a label or textbox for it)
            productNameLabel.Text = ProductName;

            // Ensure ProductPrice is set before calculation
            if (ProductPrice <= 0)
            {
                MessageBox.Show("Error: Product price is not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}

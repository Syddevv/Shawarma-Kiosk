using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class orderSummary : Form
    {
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; } // Current price (includes add-ons)
        public int Quantity { get; set; }
        public string AddOns { get; set; }
        public string SpecialInstructions { get; set; }
        public decimal Total { get; set; }
        public decimal BaseProductPrice { get; set; }
        public orderSummary()
        {
            InitializeComponent();
        }

        private void AlignLabels()
        {
            productName.Width = 300; // Set a width for the name label (you can adjust this value as needed)
            productName.Location = new Point((this.Width - productName.Width) / 2, productName.Location.Y);

            // Center-align the product price label horizontally
            productPrice.Width = 300; // Set a width for the price label (you can adjust this value as needed)
            productPrice.Location = new Point((this.Width - productPrice.Width) / 2, productPrice.Location.Y);

            // Optional: Adjust the Y-positions of the labels if necessary to make them look better
            productName.Top = 200; // Adjust Y position for product name
            productPrice.Top = productName.Bottom + 10;
        }

        private void orderSummary_Load(object sender, EventArgs e)
        {
            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;
            productPrice.Text = $"₱ {ProductPrice:F2}"; // Use ProductPrice as the base price
            qtyLabel.Text = Quantity.ToString();
            addonsLabel.Text = AddOns;
            specialLabel.Text = SpecialInstructions;
            totalLabel.Text = $"₱ {Total:F2}"; // Use the passed Total value
            AlignLabels();
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            var orderReceiptForm = new orderReceipt
            {
                ProductImage = ProductImage,
                ProductName = ProductName,
                ProductPrice = ProductPrice,
                Quantity = Quantity,
                AddOns = AddOns,
                SpecialInstructions = SpecialInstructions,
                Total = Total
            };
            orderReceiptForm.Show();
            this.Close();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            var orderDetailsForm = new orderDetails
            {
                ProductImage = ProductImage,                // Retain product image
                ProductName = ProductName,                  // Retain product name
                BaseProductPrice = BaseProductPrice,        // Pass the original base price
                ProductPrice = BaseProductPrice,            // Reset to the base product price
                AddOns = AddOns,                            // Pass the add-ons
                SpecialInstructions = SpecialInstructions,  // Pass the special instructions
                Quantity = Quantity                         // Retain the current quantity
            };

            // Reapply the add-ons to the ProductPrice
            if (!string.IsNullOrEmpty(AddOns))
            {
                // Assume add-ons were calculated based on (ProductPrice - BaseProductPrice)
                decimal addOnsPrice = ProductPrice - BaseProductPrice;
                orderDetailsForm.ProductPrice += addOnsPrice; // Re-add the add-ons price
            }

            // Show the orderDetails form
            orderDetailsForm.Show();
            this.Close();  
        }
    }
}

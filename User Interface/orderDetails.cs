using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace User_Interface
{
    public partial class orderDetails : Form
    {
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public string AddOns { get; set; }
        public string SpecialInstructions { get; set; }
        public int Quantity { get; set; } = 1; // Default quantity to 1
        public decimal BaseProductPrice { get; set; }

        public orderDetails()
        {
            InitializeComponent();
        }

        private void orderDetails_Load(object sender, EventArgs e)
        {
            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;

            // Display ProductPrice which should now correctly reflect the base price + add-ons
            productPrice.Text = $"₱ {ProductPrice:F2}";
            quantityLabel.Text = Quantity.ToString();

            if (!string.IsNullOrEmpty(AddOns))
            {
                addOnsContainer.Text = AddOns.Contains("Add Ons:") ? AddOns : $"Add Ons: {AddOns}";
            }

            specialTB.Text = SpecialInstructions;
            UpdateTotal();
            AlignLabels();
            CenterAddOnsContainer();
        }

        private void AlignLabels()
        {
            productName.Width = 300; // Set a width for the name label (you can adjust this value as needed)
            productName.Location = new Point((this.Width - productName.Width) / 2, productName.Location.Y);

            // Center-align the product price label horizontally
            productPrice.Width = 300; // Set a width for the price label (you can adjust this value as needed)
            productPrice.Location = new Point((this.Width - productPrice.Width) / 2, productPrice.Location.Y);

            // Optional: Adjust the Y-positions of the labels if necessary to make them look better
            productName.Top = 190; // Adjust Y position for product name
            productPrice.Top = productName.Bottom + 10;
        }


        private void increaseQtyBTN_Click(object sender, EventArgs e)
        {
            Quantity++;
            quantityLabel.Text = Quantity.ToString();
            UpdateTotal();
        }

        private void decreaseQtyBTN_Click(object sender, EventArgs e)
        {
            if (Quantity > 1)
            {
                Quantity--;
                quantityLabel.Text = Quantity.ToString();
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            // Calculate the add-ons price
            decimal addOnsPrice = ProductPrice - BaseProductPrice;

            // Calculate the total
            decimal total = (BaseProductPrice * Quantity) + addOnsPrice;

            // Update the total label
            totalLabel.Text = $"₱ {total:F2}";
        }


        public void nextBTN_Click(object sender, EventArgs e)
        {
            decimal addOnsPrice = ProductPrice - BaseProductPrice; // Calculate add-ons price
            decimal total = (BaseProductPrice * Quantity) + addOnsPrice; // Correct total calculation

            var orderSummaryForm = new orderSummary
            {
                ProductImage = ProductImage,
                ProductName = ProductName,
                BaseProductPrice = BaseProductPrice, // Ensure base price consistency
                ProductPrice = ProductPrice,         // Keep the adjusted price with add-ons
                Quantity = Quantity,
                Total = (BaseProductPrice * Quantity) + (ProductPrice - BaseProductPrice),
                AddOns = addOnsContainer.Text.Replace("Add Ons: ", string.Empty),
                SpecialInstructions = specialTB.Text
            };

            orderSummaryForm.Show();
            this.Hide();  // Hide the current orderDetails form
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            var productOrderOptionForm = new productOrderOption
            {
                ProductImage = ProductImage,
                ProductName = ProductName,
                ProductPrice = BaseProductPrice // Reset to the original price
            };

            productOrderOptionForm.Show();
            this.Close();
        }

        private void CenterAddOnsContainer()
        {
            // Center the AddOns container horizontally
            addOnsContainer.Location = new Point((this.Width - addOnsContainer.Width) / 2, addOnsContainer.Location.Y);
        }

        private void addOnsBTN_Click_1(object sender, EventArgs e)
        {
            var addOnsForm = new addOns();
            addOnsForm.FormClosed += (s, args) =>
            {
                if (addOnsForm.SelectedAddOns != null)
                {
                    // Generate a display string for add-ons, including their names and prices
                    AddOns = string.Join(", ", addOnsForm.SelectedAddOns.Select(addOn => $"{addOn.Name} (₱{addOn.Price:F2})"));
                    addOnsContainer.Text = $"Add Ons: {AddOns}";

                    // Update the product price with add-ons price
                    ProductPrice += addOnsForm.TotalAddOnsPrice;
                    UpdateTotal();
                    CenterAddOnsContainer();
                }
            };

            addOnsForm.ShowDialog();
        }
    }
}
 


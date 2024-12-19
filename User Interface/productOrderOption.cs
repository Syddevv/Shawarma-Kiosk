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

    public partial class productOrderOption : Form
    {
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public productOrderOption()
        {
            InitializeComponent();
        }

        private void productOrderOption_Load(object sender, EventArgs e)
        {
            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;
            productPrice.Text = $"₱ {ProductPrice:F2}";
            AlignLabels();
        }

        private void AlignLabels()
        {
            productName.Width = 300; // Set a width for the name label (you can adjust this value as needed)
            productName.Location = new Point((this.Width - productName.Width) / 2, productName.Location.Y);

            // Center-align the product price label horizontally
            productPrice.Width = 300; // Set a width for the price label (you can adjust this value as needed)
            productPrice.Location = new Point((this.Width - productPrice.Width) / 2, productPrice.Location.Y);

            // Optional: Adjust the Y-positions of the labels if necessary to make them look better
            productName.Top = 220; // Adjust Y position for product name
            productPrice.Top = productName.Bottom + 10;
        }

        private void orderBTN_Click(object sender, EventArgs e)
        {
            // Ensure ProductPrice is initialized correctly
            // Ensure ProductPrice is correctly set before navigating to the next form
            if (ProductPrice <= 0)
            {
                MessageBox.Show("Invalid product price. Please ensure the price is set correctly.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var orderDetailsForm = new orderDetails
            {
                ProductImage = ProductImage,      // Set the product image
                ProductName = ProductName,        // Set the product name
                BaseProductPrice = ProductPrice,  // Pass the current ProductPrice as BaseProductPrice
                ProductPrice = ProductPrice,      // Initialize ProductPrice with the correct value
                AddOns = "",                      // No add-ons initially
                SpecialInstructions = "",         // No special instructions initially
                Quantity = 1                      // Default quantity is 1
            };

            orderDetailsForm.Show();
            this.Close();

        }



        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToCartBTN_Click(object sender, EventArgs e)
        {
            // Create a new CartItem object to send to the Cart form
            cart.CartItem newItem = new cart.CartItem
            {
                ProductImage = ProductImage,
                ProductName = ProductName,
                ProductPrice = ProductPrice,
                Quantity = 1 // Default quantity
            };

            // Access the Cart form or create a new instance
            cart cartForm = Application.OpenForms.OfType<cart>().FirstOrDefault() ?? new cart();

            // Add the item to the cart
            cartForm.AddToCart(newItem);

            // Show success message
            MessageBox.Show("Product successfully added to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally keep the current form open for further operations or close it:
            this.Close(); // Closes the current form after adding to cart
        }
    }
}


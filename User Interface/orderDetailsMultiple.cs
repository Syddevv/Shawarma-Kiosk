using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static User_Interface.cart;

namespace User_Interface
{
    public partial class orderDetailsMultiple : Form
    {
        public List<cart.CartItem> CartItems { get; set; }
        public orderDetailsMultiple(List<cart.CartItem> cartItems = null)
        {
            InitializeComponent();
            if (cartItems != null)
            {
                CartItems = cartItems;
            }
        }

        private void productName_Click(object sender, EventArgs e)
        {

        }

        private void addOnsBTN_Click(object sender, EventArgs e)
        {
            // Open the add-ons form and process selected add-ons
            var addOnsForm = new addOns();
            addOnsForm.FormClosed += (s, args) =>
            {
                if (addOnsForm.SelectedAddOns != null)
                {
                    var addOnsText = string.Join(", ", addOnsForm.SelectedAddOns.Select(a => $"{a.Name} (₱{a.Price:F2})"));
                    addOnsContainer.Text = $"Add Ons: {addOnsText}";

                    // Add add-ons price to the total
                    var addOnsTotal = addOnsForm.TotalAddOnsPrice;
                    UpdateTotalLabel(addOnsTotal);
                }
                CenterAddOnsContainer();
            };

            addOnsForm.ShowDialog();
        }

        private void CenterAddOnsContainer()
        {
            // Center the AddOns container horizontally
            addOnsContainer.Location = new Point((this.Width - addOnsContainer.Width) / 2, addOnsContainer.Location.Y);
        }


        private void nextBTN_Click(object sender, EventArgs e)
        {
            // Pass data to orderSummaryMultiple
            var summaryForm = new orderSummaryMultiple
            {
                CartItems = CartItems,
                AddOns = addOnsContainer.Text.Replace("Add Ons: ", string.Empty),
                SpecialInstructions = specialTB.Text,
                Total = CartItems.Sum(item => item.ProductPrice * item.Quantity)
            };

            summaryForm.Show();
            this.Close();
        }

        private void orderDetailsMultiple_Load(object sender, EventArgs e)
        {
            PopulateOrderDetailsPanel();
            UpdateTotalLabel();
        }

        private void PopulateOrderDetailsPanel()
        {
            orderDetailsPanel.Controls.Clear(); // Clear any existing controls

            foreach (var item in CartItems)
            {
                // Create a panel for the cart item
                Panel itemPanel = new Panel
                {
                    Width = orderDetailsPanel.Width - 20,
                    Height = 150,
                    Margin = new Padding(5),
                };

                // Use a TableLayoutPanel for better layout management
                TableLayoutPanel layoutPanel = new TableLayoutPanel
                {
                    ColumnCount = 2,
                    Dock = DockStyle.Fill,
                    Width = itemPanel.Width,
                    Height = itemPanel.Height,
                };

                layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

                // Product Image
                PictureBox productImage = new PictureBox
                {
                    Image = item.ProductImage,
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Margin = new Padding(5)
                };

                // Right-side details
                FlowLayoutPanel detailsPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Dock = DockStyle.Fill,
                    Margin= new Padding(10, 10, 0, 0)
                };

                Label productName = new Label
                {
                    Text = item.ProductName,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                };

                Label productPrice = new Label
                {
                    Text = $"₱{item.ProductPrice:F2}",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                };

                Label quantityLabel = new Label
                {
                    Text = $"Quantity: {item.Quantity}",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                };

                detailsPanel.Controls.Add(productName);
                detailsPanel.Controls.Add(productPrice);
                detailsPanel.Controls.Add(quantityLabel);

                layoutPanel.Controls.Add(productImage, 0, 0);
                layoutPanel.Controls.Add(detailsPanel, 1, 0);

                itemPanel.Controls.Add(layoutPanel);
                orderDetailsPanel.Controls.Add(itemPanel);
            }
        }

        private void UpdateTotalLabel(decimal addOnsTotal = 0)
        {
            decimal total = CartItems.Sum(item => item.ProductPrice * item.Quantity);
            total += addOnsTotal; // Add add-ons cost
            totalLabel.Text = $"₱{total:F2}";
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            // Set the CartItems property in the cart form instance
            cart.Instance.CartItems = this.CartItems; // Pass the CartItems to the cart instance

            // Show the cart form and close the current form
            cart.Instance.Show();
            this.Close();
        }
    }
}

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
    public partial class orderSummaryMultiple : Form
    {
        public List<cart.CartItem> CartItems { get; set; }

        public string AddOns { get; set; }
        public string SpecialInstructions { get; set; }
        public decimal Total { get; set; }

        public orderSummaryMultiple()
        {
            InitializeComponent();
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            // Pass data to the receiptMultiple form
            var receiptForm = new receiptMultiple
            {
                CartItems = CartItems,
                AddOns = AddOns,
                SpecialInstructions = SpecialInstructions,
                Total = Total
            };

            receiptForm.Show();
            this.Close();
    }

        private void orderSummaryMultiple_Load(object sender, EventArgs e)
        {
            PopulateOrderDetailsPanel();
            totalLabel.Text = $"₱{Total:F2}";
            addonsLabel.Text = $"{AddOns}";
            specialLabel.Text = $"{SpecialInstructions}";
        }

        private void PopulateOrderDetailsPanel()
        {
            orderDetailsPanel.Controls.Clear(); // Clear any existing content

            foreach (var item in CartItems)
            {
                // Create a panel for each item
                Panel itemPanel = new Panel
                {
                    Width = orderDetailsPanel.Width - 20,
                    Height = 120,
                    Margin = new Padding(5)
                };

                // TableLayoutPanel for layout
                TableLayoutPanel layoutPanel = new TableLayoutPanel
                {
                    ColumnCount = 2,
                    Dock = DockStyle.Fill,
                    Width = itemPanel.Width,
                    Height = itemPanel.Height
                };

                layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

                // Product image
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
                    Dock = DockStyle.Fill
                };

                Label productName = new Label
                {
                    Text = item.ProductName,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true
                };

                Label productPrice = new Label
                {
                    Text = $"₱{item.ProductPrice:F2} x {item.Quantity}",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true
                };

                Label itemTotal = new Label
                {
                    Text = $"Total: ₱{item.ProductPrice * item.Quantity:F2}",
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    AutoSize = true
                };

                detailsPanel.Controls.Add(productName);
                detailsPanel.Controls.Add(productPrice);
                detailsPanel.Controls.Add(itemTotal);

                layoutPanel.Controls.Add(productImage, 0, 0);
                layoutPanel.Controls.Add(detailsPanel, 1, 0);

                itemPanel.Controls.Add(layoutPanel);
                orderDetailsPanel.Controls.Add(itemPanel);
            }
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            // Create a new instance of orderDetailsMultiple
            var detailsForm = new orderDetailsMultiple
            {
                CartItems = this.CartItems // Pass the CartItems back to orderDetailsMultiple
            };

            // Show the orderDetailsMultiple form
            detailsForm.Show();
            this.Close(); // Close the current form
        }
    }
}

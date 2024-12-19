using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace User_Interface
{
    public partial class cart : Form
    {
        private static cart instance;
        public static cart Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new cart();
                }
                return instance;
            }
        }

        // List to store cart items
        public List<CartItem> cartItems = new List<CartItem>();


        public List<CartItem> CartItems
        {
            get => cartItems; // Getter for cartItems
            set
            {
                cartItems = value; // Setter for cartItems
                UpdateCartPanel(); // Update the UI whenever CartItems is set
            }
        }

        // Expose cart items as a read-only property
      
        public HashSet<Panel> selectedPanels = new HashSet<Panel>();
        public cart()
        {
            InitializeComponent();
        }

        public class CartItem
        {
            public Image ProductImage { get; set; }
            public string ProductName { get; set; }
            public decimal ProductPrice { get; set; }
            public int Quantity { get; set; } = 1;
        }

        

        private void cart_Load(object sender, EventArgs e)
        {
            UpdateCartPanel();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        public void AddToCart(CartItem newItem)
        {
            // Check if the product already exists in the cart
            var existingItem = cartItems.FirstOrDefault(item => item.ProductName == newItem.ProductName);

            if (existingItem != null)
            {
                existingItem.Quantity += newItem.Quantity;
            }
            else
            {
                cartItems.Add(newItem);
            }

            UpdateCartPanel();
        }


        private void UpdateCartPanel()
        {
            cartProductsPanel.Controls.Clear(); // Clear existing items in the panel

            foreach (var item in cartItems)
            {
                // Create a panel for the entire cart item
                Panel cartItemPanel = new Panel
                {
                    Width = cartProductsPanel.Width - 20,
                    Height = 150,
                    Margin = new Padding(0),
                    BorderStyle = BorderStyle.None,  // Initially no border
                    Tag = item // Store the CartItem as the tag
                };

                // Use a TableLayoutPanel to arrange the image and details
                TableLayoutPanel layoutPanel = new TableLayoutPanel
                {
                    ColumnCount = 2,
                    Dock = DockStyle.Fill,
                    Width = cartItemPanel.Width,
                    Height = cartItemPanel.Height,
                };

                // Set column sizes (Image: 30%, Details: 70%)
                layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

                // Product Image (left side)
                PictureBox productImage = new PictureBox
                {
                    Image = item.ProductImage,
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Margin = new Padding(5),
                    Cursor = Cursors.Hand // Change cursor to hand to indicate clickable
                };

                // Add click event to the product image PictureBox
                productImage.Click += (s, e) =>
                {
                    // Toggle the border of the panel when the image is clicked
                    if (selectedPanels.Contains(cartItemPanel))
                    {
                        selectedPanels.Remove(cartItemPanel);
                        cartItemPanel.BorderStyle = BorderStyle.None;  // Remove border

                        // Remove the total when the item is unclicked
                        totalLabel.Text = string.Empty;
                    }
                    else
                    {
                        selectedPanels.Add(cartItemPanel);
                        cartItemPanel.BorderStyle = BorderStyle.FixedSingle;  // Add border

                        // After updating the selection, recalculate and update the total
                        totalLabel.Text = $"₱{CalculateTotal():F2}";
                    }
                };

                // Right-side layout for product details
                FlowLayoutPanel rightPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                };

                // Product Name
                Label productNameLabel = new Label
                {
                    Text = item.ProductName,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Margin = new Padding(0, 5, 0, 0),
                };

                // Product Price
                Label productPriceLabel = new Label
                {
                    Text = $"₱{item.ProductPrice:F2}",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10),
                    Margin = new Padding(0, 5, 0, 0),
                };

                // Quantity Controls
                FlowLayoutPanel quantityPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    AutoSize = true,
                    Margin = new Padding(0, 5, 0, 0),
                };

                PictureBox addButton = new PictureBox
                {
                    Image = Properties.Resources.add,
                    Width = 25,
                    Height = 25,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand,
                };

                Label quantityLabel = new Label
                {
                    Text = item.Quantity.ToString(),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Padding = new Padding(10, 0, 10, 0),
                };

                PictureBox minusButton = new PictureBox
                {
                    Image = Properties.Resources.minus,
                    Width = 25,
                    Height = 25,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand,
                };

                // Event handlers for quantity buttons
                addButton.Click += (s, e) =>
                {
                    item.Quantity++; // Increase quantity
                    quantityLabel.Text = item.Quantity.ToString();
                    UpdateCartPanel(); // Update the panel after quantity change

                    // Recalculate the total based on updated quantities
                    totalLabel.Text = $"₱{CalculateTotal():F2}";
                };

                minusButton.Click += (s, e) =>
                {
                    if (item.Quantity > 1)
                    {
                        item.Quantity--; // Decrease quantity
                        quantityLabel.Text = item.Quantity.ToString();
                        UpdateCartPanel(); // Update the panel after quantity change

                        // Recalculate the total based on updated quantities
                        totalLabel.Text = $"₱{CalculateTotal():F2}";
                    }
                };

                // Add quantity controls to the quantity panel
                quantityPanel.Controls.Add(addButton);
                quantityPanel.Controls.Add(quantityLabel);
                quantityPanel.Controls.Add(minusButton);

                // Add product details to the right panel
                rightPanel.Controls.Add(productNameLabel);
                rightPanel.Controls.Add(productPriceLabel);
                rightPanel.Controls.Add(quantityPanel);

                // Add image and details to the TableLayoutPanel
                layoutPanel.Controls.Add(productImage, 0, 0);
                layoutPanel.Controls.Add(rightPanel, 1, 0);

                // Add the layout to the cart item panel
                cartItemPanel.Controls.Add(layoutPanel);

                // Add the cart item panel to the main cart panel
                cartProductsPanel.Controls.Add(cartItemPanel);
            }

            // Recalculate the total when the cart items are updated
            totalLabel.Text = $"₱{CalculateTotal():F2}";
        }

        private decimal CalculateTotal()
        {
            decimal total = 0;

            // Only include items that are selected
            foreach (var cartItemPanel in selectedPanels)
            {
                var item = cartItemPanel.Tag as CartItem;
                if (item != null)
                {
                    total += item.ProductPrice * item.Quantity;  // Add the price * quantity of each selected item
                }
            }

            return total;
        }

        private void UpdateTotal()
        {
            decimal total = 0;

            // Sum up the price of all selected items
            foreach (var panel in selectedPanels)
            {
                var cartItemPanel = panel;
                var item = cartItemPanel.Tag as CartItem;
                if (item != null)
                {
                    total += item.ProductPrice * item.Quantity;
                }
            }

            // Update the total label
            totalLabel.Text = $"₱{total:F2}";
        }


        private void orderBTN_Click(object sender, EventArgs e)
        {
            // Check if any items are selected
            if (selectedPanels.Count == 0)
            {
                MessageBox.Show("Please select at least one item to order.", "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect selected items
            List<CartItem> selectedItems = new List<CartItem>();
            foreach (var panel in selectedPanels)
            {
                var item = panel.Tag as CartItem;
                if (item != null)
                {
                    selectedItems.Add(item);
                }
            }

            // Open the orderDetailsMultiple form and pass the selected items
            var orderDetailsForm = new orderDetailsMultiple
            {
                CartItems = selectedItems
            };

            orderDetailsForm.Show();
             // Hide the cart form
        }

        private void removeProductBTN_Click(object sender, EventArgs e)
        {
            // Iterate over all selected panels and remove the corresponding CartItem
            foreach (var selectedPanel in selectedPanels.ToList())
            {
                var cartItemPanel = selectedPanel;

                // Get the CartItem associated with the selected panel
                var item = cartItemPanel.Tag as CartItem;

                if (item != null)
                {
                    // Remove the item completely from the cart regardless of its quantity
                    cartItems.Remove(item);
                }
            }

            // Clear the selected panels after removal to reset the selection
            selectedPanels.Clear();

            // Update the UI to reflect the changes
            UpdateCartPanel();

            // Recalculate and update the total
            totalLabel.Text = $"₱{CalculateTotal():F2}";
        }

        public void ClearCart()
        {
            cartItems.Clear(); // Clear the list of cart items
            selectedPanels.Clear(); // Clear any selected panels
            UpdateCartPanel(); // Update the UI
            Debug.WriteLine("Cart cleared successfully.");
        }
    }
}





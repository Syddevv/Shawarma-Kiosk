using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class ricemeals : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";
        public ricemeals()
        {
            InitializeComponent();
        }

        private void ricemeals_Load(object sender, EventArgs e)
        {
            LoadRiceProducts();
        }

        private void LoadRiceProducts()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch all products from the database
                    string query = "SELECT product_id, product_name, product_price, product_image, stock_status FROM products WHERE category = 'Rice Meals' ";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    // Set up the FlowLayoutPanel
                    flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
                    flowLayoutPanel1.WrapContents = true;
                    flowLayoutPanel1.AutoScroll = true;

                    // Loop through each product and create UI elements to display them
                    while (reader.Read())
                    {
                        int productId = reader.GetInt32(0);
                        string productName = reader["product_name"]?.ToString() ?? "Unnamed Product";
                        decimal productPrice = Convert.ToDecimal(reader["product_price"]);
                        string productImagePath = reader["product_image"]?.ToString();
                        string stockStatus = reader["stock_status"]?.ToString() ?? "In Stock";

                        // Create a panel for each product
                        Panel productPanel = new Panel
                        {
                            Width = 205,
                            Height = 300,
                            Margin = new Padding(16)
                        };

                        // Create a picture box to display the product image
                        PictureBox pictureBox = new PictureBox
                        {
                            Width = productPanel.Width,
                            Height = 218,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Cursor = Cursors.Hand,
                            Dock = DockStyle.Top
                        };

                        // Set the image for the product (fallback image if not found)
                        if (!string.IsNullOrEmpty(productImagePath) && System.IO.File.Exists(productImagePath))
                        {
                            pictureBox.Image = Image.FromFile(productImagePath);
                        }
                        else
                        {
                            pictureBox.Image = Properties.Resources.Circle_Illustrative_Burger_Restaurant_Free_Logo__1__removebg_preview;
                        }

                        // If the product is "Out of Stock", dim the image, add a label, and disable clicks
                        if (stockStatus == "Out of Stock")
                        {
                            Bitmap dimmedImage = new Bitmap(pictureBox.Image);
                            using (Graphics g = Graphics.FromImage(dimmedImage))
                            {
                                using (Brush dimBrush = new SolidBrush(Color.FromArgb(100, Color.Black)))
                                {
                                    g.FillRectangle(dimBrush, new Rectangle(0, 0, dimmedImage.Width, dimmedImage.Height));
                                }
                            }
                            pictureBox.Image = dimmedImage;

                            // Add the "Out of Stock" label
                            Label outOfStockLabel = new Label
                            {
                                Text = "Out of Stock",
                                ForeColor = Color.Red,
                                Dock = DockStyle.Bottom,
                                TextAlign = ContentAlignment.MiddleCenter
                            };
                            productPanel.Controls.Add(outOfStockLabel);

                            // Disable click events
                            pictureBox.Enabled = false;
                        }
                        else
                        {
                            // Enable click events for available products
                            pictureBox.Enabled = true;

                            // Add click event for available products
                            pictureBox.Click += (s, e) =>
                            {
                                MessageBox.Show($"Product: {productName}\nPrice: ₱{productPrice:F2}", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            };
                        }

                        // Create labels for product name and price
                        Label nameLabel = new Label
                        {
                            Text = productName,
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Height = 40,
                            Dock = DockStyle.Bottom,
                            Font = new Font("Tahoma", 11, FontStyle.Regular),
                        };

                        Label priceLabel = new Label
                        {
                            Text = $"₱{productPrice:F2}",
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Bottom,
                            Font = new Font("Tahoma", 10, FontStyle.Bold)
                        };

                        // Add the controls to the product panel
                        productPanel.Controls.Add(priceLabel);
                        productPanel.Controls.Add(pictureBox);
                        productPanel.Controls.Add(nameLabel);

                        // Add the product panel to the FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(productPanel);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wrapMealsBTN_Click(object sender, EventArgs e)
        {
            new wrapmeals().Show();
            this.Hide();
        }

        private void allProductsBTN_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void drinksBTN_Click(object sender, EventArgs e)
        {
            new drinks().Show();
            this.Hide();
        }
    }
}

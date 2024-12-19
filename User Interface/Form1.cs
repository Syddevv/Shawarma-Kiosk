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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace User_Interface
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void cartBTN_Click(object sender, EventArgs e)
        {
            new cart().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            LoadAllProducts();
        }


        private void LoadAllProducts()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT product_id, product_name, product_price, product_image, stock_status FROM products";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
                    flowLayoutPanel1.WrapContents = true;
                    flowLayoutPanel1.AutoScroll = true;

                    while (reader.Read())
                    {
                        int productId = reader.GetInt32(0);
                        string productName = reader["product_name"]?.ToString() ?? "Unnamed Product";
                        decimal productPrice = Convert.ToDecimal(reader["product_price"]);
                        string productImagePath = reader["product_image"]?.ToString();
                        string stockStatus = reader["stock_status"]?.ToString() ?? "In Stock";

                        Panel productPanel = new Panel
                        {
                            Width = 205,
                            Height = 300,
                            Margin = new Padding(10)
                        };

                        PictureBox pictureBox = new PictureBox
                        {
                            Width = productPanel.Width,
                            Height = 218,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Cursor = Cursors.Hand,
                            Dock = DockStyle.Top
                        };

                        if (!string.IsNullOrEmpty(productImagePath) && System.IO.File.Exists(productImagePath))
                        {
                            pictureBox.Image = Image.FromFile(productImagePath);
                        }
                        else
                        {
                            pictureBox.Image = Properties.Resources.Circle_Illustrative_Burger_Restaurant_Free_Logo__1__removebg_preview;
                        }

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

                            Label outOfStockLabel = new Label
                            {
                                Text = "Out of Stock",
                                ForeColor = Color.Red,
                                Dock = DockStyle.Bottom,
                                TextAlign = ContentAlignment.MiddleCenter
                            };
                            productPanel.Controls.Add(outOfStockLabel);

                            pictureBox.Enabled = false;
                        }
                        else
                        {
                            pictureBox.Enabled = true;

                            // Add event for available products
                            pictureBox.Click += (s, e) =>
                            {
                                 var productOrderForm = new productOrderOption
                                {
                                    ProductImage = pictureBox.Image,
                                    ProductName = productName,
                                    ProductPrice = productPrice
                                };
                                productOrderForm.Show();
                            };
                        }

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

                        productPanel.Controls.Add(priceLabel);
                        productPanel.Controls.Add(pictureBox);
                        productPanel.Controls.Add(nameLabel);

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

        private void riceMealsBTN_Click(object sender, EventArgs e)
        {
            new ricemeals().Show();
            this.Hide();
        }

        private void drinksBTN_Click(object sender, EventArgs e)
        {
            new drinks().Show();
            this.Hide();
        }

        private void cartBTN_Click_1(object sender, EventArgs e)
        {
            // Check if the cart form is already open
            cart cartForm = Application.OpenForms.OfType<cart>().FirstOrDefault();

            if (cartForm == null)
            {
                // Create a new instance if the cart form is not open
                cartForm = new cart();
            }

            // Show the cart form
            cartForm.Show();

            // Optionally hide the current form
            this.Hide();
        }
    }
}

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
using System.IO;

namespace Admin_Login
{
    public partial class wrapmeals : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb"; 

        public wrapmeals()
        {
            InitializeComponent();
        }

        private void allProducts_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void riceMeals_Click(object sender, EventArgs e)
        {
            new ricemeals().Show();
            this.Hide();
        }

        private void drinks_Click(object sender, EventArgs e)
        {
            new drinks().Show();    
            this.Hide();
        }

        private void historyLabel_Click(object sender, EventArgs e)
        {
            new history().Show();
        }

        private void inventoryLabel_Click(object sender, EventArgs e)
        {
            new inventory().Show();
            this.Hide();
        }

        private void salesLabel_Click(object sender, EventArgs e)
        {
            new sales().Show();
            this.Hide();
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            new Settings().Show();  
        }

        private void wrapmeals_Load(object sender, EventArgs e)
        {
            LoadWrapMeals();
        }

        private void LoadWrapMeals()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT product_id, product_name, product_price, product_image, stock_status FROM products WHERE category = 'Wrap Meals'";
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
                            Margin = new Padding(15)
                        };

                        productPanel.Tag = new Tuple<int, string, string>(productId, stockStatus, productImagePath);

                        PictureBox pictureBox = new PictureBox
                        {
                            Width = productPanel.Width,
                            Height = 218,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Cursor = Cursors.Hand,
                            Dock = DockStyle.Top,
                        };

                        if (!string.IsNullOrEmpty(productImagePath) && File.Exists(productImagePath))
                        {
                            pictureBox.Image = Image.FromFile(productImagePath);
                        }
                        else
                        {
                            pictureBox.Image = Properties.Resources.fries;
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

                        pictureBox.Click += (s, e) =>
                        {
                            var tag = (Tuple<int, string, string>)productPanel.Tag;
                            int clickedProductId = tag.Item1;
                            string clickedStockStatus = tag.Item2;

                            if (clickedStockStatus == "Out of Stock")
                            {
                                OpenInStockForm(clickedProductId);
                            }
                            else
                            {
                                OpenProductDetails(clickedProductId, productName, productPrice, productImagePath);
                            }
                        };

                        productPanel.Controls.Add(priceLabel);
                        productPanel.Controls.Add(pictureBox);
                        productPanel.Controls.Add(nameLabel);

                        flowLayoutPanel1.Controls.Add(productPanel);
                    }

                    reader.Close();
                    flowLayoutPanel1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProductStockStatus(int productId, string newStatus)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE products SET stock_status = @status WHERE product_id = @productId";
                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@status", newStatus);
                    command.Parameters.AddWithValue("@productId", productId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void OpenProductDetails(int productId, string name, decimal price, string imagePath)
        {
            ProductDetailsForm detailsForm = new ProductDetailsForm
            {
                ProductId = productId,
                ProductName = name,
                ProductPrice = price,
                ProductImage = File.Exists(imagePath) ? Image.FromFile(imagePath) : Properties.Resources.fries
            };
            detailsForm.ProductMarkedOutOfStock += MarkProductAsOutOfStock;
            detailsForm.ShowDialog();
        }

        private void OpenInStockForm(int productId)
        {
            // Fetch product details (image, name, price) from the database
            string productName = "";
            decimal productPrice = 0;
            string productImagePath = "";
            Image productImage = Properties.Resources.Circle_Illustrative_Burger_Restaurant_Free_Logo__1__removebg_preview; // Default fallback

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT product_name, product_price, product_image FROM products WHERE product_id = @productId";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            productName = reader["product_name"].ToString();
                            productPrice = Convert.ToDecimal(reader["product_price"]);
                            productImagePath = reader["product_image"].ToString();

                            // Load image if it exists
                            if (!string.IsNullOrEmpty(productImagePath) && File.Exists(productImagePath))
                            {
                                productImage = Image.FromFile(productImagePath);
                            }
                        }
                    }
                }
            }
            inStockForm stockForm = new inStockForm(productId, productImage, productName, productPrice);
            stockForm.ProductMarkedInStock += MarkProductAsInStock; // Connect event
            stockForm.ShowDialog(); // Display the form
        }

        public void MarkProductAsOutOfStock(int productId)
        {
            foreach (Control control in flowLayoutPanel1.Controls)                                                                
            {
                if (control is Panel productPanel && productPanel.Tag is Tuple<int, string, string> tag && tag.Item1 == productId)
                {
                    // Update the stock status to "Out of Stock" in the Tag property
                    productPanel.Tag = new Tuple<int, string, string>(productId, "Out of Stock", tag.Item3); // Preserve the image path

                    PictureBox pictureBox = productPanel.Controls.OfType<PictureBox>().FirstOrDefault();
                    if (pictureBox != null)
                    {
                        // Dim the product image to indicate "Out of Stock"
                        Bitmap dimmedImage = new Bitmap(pictureBox.Image);
                        using (Graphics g = Graphics.FromImage(dimmedImage))
                        {
                            using (Brush dimBrush = new SolidBrush(Color.FromArgb(100, Color.Black)))
                            {
                                g.FillRectangle(dimBrush, new Rectangle(0, 0, dimmedImage.Width, dimmedImage.Height));
                            }
                        }
                        pictureBox.Image = dimmedImage;
                    }

                    // Add "Out of Stock" label
                    Label outOfStockLabel = new Label
                    {
                        Text = "Out of Stock",
                        ForeColor = Color.Red,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    productPanel.Controls.Add(outOfStockLabel);
                    productPanel.Controls.SetChildIndex(outOfStockLabel, 0);

                    // Update stock status in the database
                    UpdateProductStockStatus(productId, "Out of Stock");

                    break; // Exit the loop once the product is found and updated
                }
            }
        }

        public void MarkProductAsInStock(int productId)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel productPanel && productPanel.Tag is Tuple<int, string, string> tag && tag.Item1 == productId)
                {
                    string productImagePath = tag.Item3;
                    productPanel.Tag = new Tuple<int, string, string>(productId, "In Stock", productImagePath); // Update Tag

                    PictureBox pictureBox = productPanel.Controls.OfType<PictureBox>().FirstOrDefault();
                    if (pictureBox != null)
                    {
                        if (!string.IsNullOrEmpty(productImagePath) && File.Exists(productImagePath))
                        {
                            pictureBox.Image = Image.FromFile(productImagePath); // Restore original image
                        }
                        else
                        {
                            pictureBox.Image = Properties.Resources.Circle_Illustrative_Burger_Restaurant_Free_Logo__1__removebg_preview;
                        }
                    }

                    Label outOfStockLabel = productPanel.Controls.OfType<Label>().FirstOrDefault(label => label.Text == "Out of Stock");
                    if (outOfStockLabel != null)
                    {
                        productPanel.Controls.Remove(outOfStockLabel);
                    }

                    // Update stock status in the database
                    UpdateProductStockStatus(productId, "In Stock");

                    break;
                }
            }
        }
    }
}

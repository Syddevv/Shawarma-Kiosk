using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace User_Interface
{
    public partial class addOns : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";
        public class AddOn
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
        public List<AddOn> SelectedAddOns { get; private set; } = new List<AddOn>();
        public decimal TotalAddOnsPrice => SelectedAddOns.Sum(addOn => addOn.Price);

        public orderDetails OrderDetailsForm { get; set; }  // Property to hold reference to the orderDetails form

        public addOns(orderDetails orderDetailsForm)
        {
            InitializeComponent();
            OrderDetailsForm = orderDetailsForm;  // Store the reference of the orderDetails form
        }
        public addOns()
        {
            InitializeComponent();
        }

        private void addOns_Load(object sender, EventArgs e)
        {
            LoadAddOnsProducts();
        }

        private void LoadAddOnsProducts()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT product_name, product_price, product_image FROM add_ons";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    addOnsPanel.Controls.Clear();
                    while (reader.Read())
                    {
                        string productName = reader["product_name"].ToString();
                        decimal productPrice = Convert.ToDecimal(reader["product_price"]);
                        string productImagePath = reader["product_image"].ToString();

                        Panel productPanel = new Panel
                        {
                            Width = 180,
                            Height = 200,
                            Margin = new Padding(15),
                           
                        };

                        PictureBox pictureBox = new PictureBox
                        {
                            Width = 150,
                            Height = 120,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Dock = DockStyle.Top,
                            Image = !string.IsNullOrEmpty(productImagePath) && System.IO.File.Exists(productImagePath)
                                ? Image.FromFile(productImagePath)
                                : Properties.Resources.Circle_Illustrative_Burger_Restaurant_Free_Logo__1__removebg_preview
                        };

                        // Attach click events to the panel and picture box
                        pictureBox.Click += (s, e) => HighlightSelectedAddOn(productPanel);
                        productPanel.Click += (s, e) => HighlightSelectedAddOn(productPanel);

                        Label nameLabel = new Label
                        {
                            Text = productName,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Bottom,
                            Height = 40,
                            Font = new Font("Tahoma", 10, FontStyle.Bold),
                        };

                        Label priceLabel = new Label
                        {
                            Text = $"₱{productPrice:F2}",
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Bottom,
                            Height = 30,
                            Font = new Font("Tahoma", 11, FontStyle.Regular),
                        };

                        productPanel.Controls.Add(nameLabel);  // Add name at the bottom
                        productPanel.Controls.Add(priceLabel); // Add price above name
                        productPanel.Controls.Add(pictureBox); // Add image at the top

                        addOnsPanel.Controls.Add(productPanel);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading add-ons: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel _currentlySelectedPanel = null;
        private HashSet<Panel> _selectedPanels = new HashSet<Panel>();
        private void HighlightSelectedAddOn(Panel selectedPanel)
        {
          
            if (_selectedPanels.Contains(selectedPanel))
            {
                
                _selectedPanels.Remove(selectedPanel);
                selectedPanel.BorderStyle = BorderStyle.None;
                selectedPanel.BackColor = Color.Empty;
            }
            else
            {
                _selectedPanels.Add(selectedPanel);
                selectedPanel.BorderStyle = BorderStyle.FixedSingle;
                selectedPanel.BackColor = Color.LightGray;
            }
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {

            SelectedAddOns.Clear();

            foreach (Panel panel in _selectedPanels)
            {
                string productName = panel.Controls.OfType<Label>()
                    .FirstOrDefault(l => l.Height == 40)?.Text ?? ""; // Match the name label
                string priceText = panel.Controls.OfType<Label>()
                    .FirstOrDefault(l => l.Height == 30)?.Text ?? "₱0"; // Match the price label

                decimal productPrice = decimal.Parse(priceText.Trim('₱'));

                SelectedAddOns.Add(new AddOn { Name = productName, Price = productPrice });
            }

            this.Close(); // Close the addOns form
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

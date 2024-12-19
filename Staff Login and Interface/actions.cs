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
using System.Text.RegularExpressions;

namespace Staff_Login_and_Interface
{
    public partial class actions : Form
    {
        private string _orderId;
        private string _currentStatus;
        public actions(string orderId)
        {
            InitializeComponent();
            _orderId = orderId;

            // Fetch the current status of the order from the database
            LoadCurrentStatus();

            // Display the Order ID and current status on the labels
            lblOrderId.Text = $"Order ID: {_orderId}";
            lblCurrentStatus.Text = $"Current Status: {_currentStatus}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new orders().Show();
            this.Close();
        }

        private void LoadCurrentStatus()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb"))
                {
                    connection.Open();
                    string query = "SELECT [Status] FROM orders WHERE [Order ID] = @orderId";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@orderId", _orderId);
                        var result = command.ExecuteScalar();
                        _currentStatus = result != null ? result.ToString() : "Unknown";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the current status: {ex.Message}");
            }
        }

        private void completeBTN_Click(object sender, EventArgs e)
        {
            // Check if the current status is already "Completed"
            if (_currentStatus == "Completed")
            {
                MessageBox.Show("Order is already completed.", "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm completion
            DialogResult result = MessageBox.Show($"Are you sure you want to complete Order {_orderId}?", "Confirm Action", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UpdateOrderStatus("Completed");
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            // Check if the current status is already "Cancelled"
            if (_currentStatus == "Cancelled")
            {
                MessageBox.Show("Order is already cancelled.", "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm cancellation
            DialogResult result = MessageBox.Show($"Are you sure you want to cancel Order {_orderId}?", "Confirm Action", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UpdateOrderStatus("Cancelled");
            }
        }

        public event Action OrderStatusUpdated;

        private void UpdateOrderStatus(string status)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb"))
                {
                    connection.Open();

                    // Update the order's status in the orders table
                    string updateQuery = "UPDATE orders SET [Status] = @status WHERE [Order ID] = @orderId";
                    using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@status", status);
                        updateCommand.Parameters.AddWithValue("@orderId", _orderId);
                        updateCommand.ExecuteNonQuery();
                    }

                    // If the order is completed, update the inventory and record sales
                    if (status == "Completed")
                    {
                        UpdateInventory(connection, _orderId);   // Update inventory
                        RecordSales(connection, _orderId);        // Record sales
                    }

                    // Save to history if the status is Completed or Cancelled
                    if (status == "Completed" || status == "Cancelled")
                    {
                        string historyQuery = @"
                    INSERT INTO history ([Order ID], [Order List and Quantity], [Add Ons], [Special Instructions], [Date and Time], [Total], [Status])
                    SELECT [Order ID], [Order List and Quantity], [Add Ons], [Special Instructions], [Date and Time], [Total], [Status]
                    FROM orders WHERE [Order ID] = @orderId";

                        using (OleDbCommand historyCommand = new OleDbCommand(historyQuery, connection))
                        {
                            historyCommand.Parameters.AddWithValue("@orderId", _orderId);
                            int rowsInserted = historyCommand.ExecuteNonQuery();

                            if (rowsInserted > 0)
                            {
                                MessageBox.Show($"Order {_orderId} has been saved to history.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Failed to save Order {_orderId} to history.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

                // Notify the parent form about the status update
                OrderStatusUpdated?.Invoke();

                // Update the _currentStatus to reflect the new status
                _currentStatus = status;

                MessageBox.Show($"Order {_orderId} has been marked as {status}.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the actions form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RecordSales(OleDbConnection connection, string orderId)
        {
            try
            {
                // Fetch order details
                string fetchOrderQuery = "SELECT [Order List and Quantity] FROM orders WHERE [Order ID] = @orderId";
                using (OleDbCommand fetchOrderCommand = new OleDbCommand(fetchOrderQuery, connection))
                {
                    fetchOrderCommand.Parameters.AddWithValue("@orderId", orderId);
                    var orderDetails = fetchOrderCommand.ExecuteScalar()?.ToString();

                    if (string.IsNullOrEmpty(orderDetails))
                    {
                        MessageBox.Show("No order details found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Use a regular expression to match product names and quantities
                    // Example pattern: "Product Name - X pcs"
                    var productPattern = @"([a-zA-Z\s]+)-\s*(\d+)\s*pcs";
                    var matches = Regex.Matches(orderDetails, productPattern);

                    foreach (Match match in matches)
                    {
                        if (match.Groups.Count == 3)
                        {
                            var productName = match.Groups[1].Value.Trim();
                            var quantityText = match.Groups[2].Value.Trim();

                            // Safely parse the quantity
                            if (int.TryParse(quantityText, out int quantity))
                            {
                                // Fetch product information from the products table
                                string productQuery = "SELECT [product_id], [product_price] FROM products WHERE [product_name] = @productName";
                                using (OleDbCommand productCommand = new OleDbCommand(productQuery, connection))
                                {
                                    productCommand.Parameters.AddWithValue("@productName", productName);
                                    using (OleDbDataReader reader = productCommand.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            // Safely retrieve and convert values
                                            int productId = Convert.ToInt32(reader["product_id"]);
                                            decimal productPrice = Convert.ToDecimal(reader["product_price"]);

                                            // Record each product sale
                                            UpdateSalesTable(connection, productId, productName, productPrice, quantity);
                                        }
                                        else
                                        {
                                            MessageBox.Show($"Product '{productName}' not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Invalid quantity for product '{productName}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            // Handle invalid item format
                            MessageBox.Show($"Invalid item format: '{match.Value}'. Expected format: 'Product Name - Quantity pcs'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while recording sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSalesTable(OleDbConnection connection, int productId, string productName, decimal productPrice, int quantitySold)
        {
            try
            {
                // Check if product exists in sales_table
                string checkQuery = "SELECT [total_sold], [total_sales] FROM sales WHERE [product_id] = @productId";
                using (OleDbCommand checkCommand = new OleDbCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@productId", productId);
                    using (OleDbDataReader reader = checkCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Safely retrieve current totals
                            int currentTotalSold = Convert.ToInt32(reader["total_sold"]);
                            decimal currentTotalSales = Convert.ToDecimal(reader["total_sales"]);

                            // Calculate new totals
                            int newTotalSold = currentTotalSold + quantitySold;
                            decimal newTotalSales = currentTotalSales + (productPrice * quantitySold);

                            // Update existing record
                            // Update existing record
                            string updateQuery = "UPDATE sales SET [total_sold] = @newTotalSold, [total_sales] = @newTotalSales WHERE [product_id] = @productId";
                            using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@newTotalSold", newTotalSold);
                                updateCommand.Parameters.AddWithValue("@newTotalSales", newTotalSales);
                                updateCommand.Parameters.AddWithValue("@productId", productId);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert new record if product doesn't exist in sales_table
                            string insertQuery = "INSERT INTO sales ([product_id], [product_name], [product_price], [total_sold], [total_sales]) VALUES (@productId, @productName, @productPrice, @quantitySold, @totalSales)";
                            using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@productId", productId);
                                insertCommand.Parameters.AddWithValue("@productName", productName);
                                insertCommand.Parameters.AddWithValue("@productPrice", productPrice);
                                insertCommand.Parameters.AddWithValue("@quantitySold", quantitySold);
                                insertCommand.Parameters.AddWithValue("@totalSales", productPrice * quantitySold);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the sales table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       


        // Check if the product exists in Inventory Per Piece (inventory_materials)
        
        private int SafeParseInt(object value)
        {
            if (value == null || value == DBNull.Value) return 0;
            return int.TryParse(value.ToString(), out int result) ? result : 0;
        }

        // Update inventory for materials (Inventory Per Piece)
        // Update inventory for ingredients (Inventory By Measurement)
        private void UpdateInventory(OleDbConnection connection, string orderId)
        {
            try
            {
                string orderQuery = "SELECT [Order List and Quantity] FROM orders WHERE [Order ID] = @orderId";
                using (OleDbCommand orderCommand = new OleDbCommand(orderQuery, connection))
                {
                    orderCommand.Parameters.AddWithValue("@orderId", orderId);
                    var orderDetails = orderCommand.ExecuteScalar()?.ToString();
                    if (string.IsNullOrEmpty(orderDetails))
                    {
                        MessageBox.Show($"Order {orderId} has no details to process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Extract main products
                    var orderItems = Regex.Matches(orderDetails, @"([a-zA-Z\s]+)-\s*(\d+)\s*pcs");
                    foreach (Match item in orderItems)
                    {
                        string productName = item.Groups[1].Value.Trim();
                        if (!int.TryParse(item.Groups[2].Value.Trim(), out int productQuantity))
                        {
                            MessageBox.Show($"Invalid quantity format for product '{productName}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        // Update inventory for the main product
                        UpdateProductIngredients(connection, productName, productQuantity);
                    }

                    // Extract add-ons
                    var addOnItems = Regex.Matches(orderDetails, @"Add-On:\s*([a-zA-Z\s]+)-\s*(\d+)");
                    foreach (Match addOn in addOnItems)
                    {
                        string addOnName = addOn.Groups[1].Value.Trim();
                        if (!int.TryParse(addOn.Groups[2].Value.Trim(), out int addOnQuantity))
                        {
                            MessageBox.Show($"Invalid quantity format for add-on '{addOnName}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        // Handle add-ons
                        HandleAddOns(connection, addOnName, addOnQuantity);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateProductIngredients(OleDbConnection connection, string productName, int productQuantity)
        {
            try
            {
                // Define items that should be checked in Inventory Per Piece
                var itemsInInventoryPerPiece = new List<string>
        {
            "Coke Mismo",
            "Royal Mismo",
            "Sprite Mismo",
            "Nature Spring"
        };

                // Check if the product is one of the predefined items
                if (itemsInInventoryPerPiece.Contains(productName, StringComparer.OrdinalIgnoreCase))
                {
                    // Directly handle these items in Inventory Per Piece
                    if (!UpdateProductMaterialIfExists(connection, productName, productQuantity))
                    {
                        MessageBox.Show($"Product '{productName}' not found or could not be updated in Inventory Per Piece.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return; // Skip further processing
                }

                // If not one of the predefined items, check the `products` table
                string productQuery = @"SELECT 
                                [ingredients_1], [ingredients_1_qty], 
                                [materials], [materials_qty], 
                                [materials_2], [materials_qty_2] 
                            FROM products 
                            WHERE [product_name] = @productName";

                using (OleDbCommand productCommand = new OleDbCommand(productQuery, connection))
                {
                    productCommand.Parameters.AddWithValue("@productName", productName);

                    using (OleDbDataReader reader = productCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Process ingredients
                            string ingredientName = reader["ingredients_1"]?.ToString();
                            string ingredientQtyStr = reader["ingredients_1_qty"]?.ToString();

                            if (!string.IsNullOrEmpty(ingredientName) && int.TryParse(ingredientQtyStr, out int ingredientQty))
                            {
                                int totalIngredientUsed = ingredientQty * productQuantity;
                                UpdateIngredient(connection, ingredientName, totalIngredientUsed);
                            }

                            // Process materials
                            string[] materialColumns = { "materials", "materials_2" };
                            string[] materialQtyColumns = { "materials_qty", "materials_qty_2" };

                            for (int i = 0; i < materialColumns.Length; i++)
                            {
                                string materialName = reader[materialColumns[i]]?.ToString();
                                string materialQtyStr = reader[materialQtyColumns[i]]?.ToString();

                                if (!string.IsNullOrEmpty(materialName) && int.TryParse(materialQtyStr, out int materialQty))
                                {
                                    int totalMaterialUsed = materialQty * productQuantity;
                                    UpdateMaterial(connection, materialName, totalMaterialUsed);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Product '{productName}' not found in the products table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update inventory for product '{productName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update inventory for ingredients in Inventory By Measurement (like Chicken Shawarma Rice

        private void UpdateIngredient(OleDbConnection connection, string ingredientName, int quantityUsed)
        {
            if (string.IsNullOrEmpty(ingredientName)) return;

            try
            {
                string measurementTable = "Inventory Per Measurement";
                string ingredientColumn = "ingredients_name";
                string measurementColumn = "ingredients_measurement_grams";

                // Query to check current stock
                string measurementCheckQuery = $"SELECT [{measurementColumn}] FROM [{measurementTable}] WHERE [{ingredientColumn}] = @ingredientName";

                using (OleDbCommand measurementCommand = new OleDbCommand(measurementCheckQuery, connection))
                {
                    // Add parameter matching Short Text type
                    measurementCommand.Parameters.Add("@ingredientName", OleDbType.VarChar).Value = ingredientName.Trim();

                    var measurementResult = measurementCommand.ExecuteScalar();

                    if (measurementResult != null && decimal.TryParse(measurementResult.ToString(), out decimal currentQuantityMeasurement))
                    {
                        // Calculate updated quantity
                        decimal updatedQuantity = currentQuantityMeasurement - quantityUsed;

                        if (updatedQuantity < 0)
                        {
                            MessageBox.Show($"Not enough inventory for ingredient '{ingredientName}'. Current stock: {currentQuantityMeasurement}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Query to update stock
                        string measurementUpdateQuery = $"UPDATE [{measurementTable}] SET [{measurementColumn}] = @updatedQuantity, [date_time_updated] = @dateTime, [quantity_update] = @negativeQuantityUsed WHERE [{ingredientColumn}] = @ingredientName";

                        using (OleDbCommand updateCommand = new OleDbCommand(measurementUpdateQuery, connection))
                        {
                            // Use OleDbType.Decimal for numeric updates
                            updateCommand.Parameters.Add("@updatedQuantity", OleDbType.Decimal).Value = updatedQuantity;
                            updateCommand.Parameters.Add("@dateTime", OleDbType.Date).Value = DateTime.Now;
                            updateCommand.Parameters.Add("@negativeQuantityUsed", OleDbType.VarChar).Value = (-quantityUsed).ToString(); // Store as Short Text
                            updateCommand.Parameters.Add("@ingredientName", OleDbType.VarChar).Value = ingredientName.Trim();

                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Ingredient '{ingredientName}' not found or invalid data in Inventory Per Measurement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update ingredient '{ingredientName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update material in Inventory Per Piece (Products like Coke Mismo)
        private bool UpdateProductMaterialIfExists(OleDbConnection connection, string productName, int productQuantity)
        {
            try
            {
                // Query to check if the product exists in Inventory Per Piece
                string productQuery = "SELECT [quantity] FROM [Inventory Per Piece] WHERE TRIM([material_name]) = @productName";
                using (OleDbCommand productCommand = new OleDbCommand(productQuery, connection))
                {
                    // Ensure the parameter matches the Short Text type
                    productCommand.Parameters.Add("@productName", OleDbType.VarChar).Value = productName.Trim();

                    var result = productCommand.ExecuteScalar();
                    if (result != null && double.TryParse(result.ToString(), out double currentQuantity))
                    {
                        // Calculate the updated quantity
                        double updatedQuantity = currentQuantity - productQuantity;

                        if (updatedQuantity < 0)
                        {
                            MessageBox.Show($"Not enough stock for product '{productName}'. Current stock: {currentQuantity}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        // Update the quantity in Inventory Per Piece
                        string updateQuery = @"UPDATE [Inventory Per Piece]
                                       SET [quantity] = @updatedQuantity, 
                                           [date_time_updated] = @dateTime, 
                                           [quantity_update] = @negativeQuantityUsed
                                       WHERE TRIM([material_name]) = @productName";

                        using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                        {
                            // Match the data types
                            updateCommand.Parameters.Add("@updatedQuantity", OleDbType.Double).Value = updatedQuantity; // Quantity field is numeric
                            updateCommand.Parameters.Add("@dateTime", OleDbType.Date).Value = DateTime.Now; // Date/Time field
                            updateCommand.Parameters.Add("@negativeQuantityUsed", OleDbType.VarChar).Value = (-productQuantity).ToString(); // Short Text field
                            updateCommand.Parameters.Add("@productName", OleDbType.VarChar).Value = productName.Trim(); // Short Text field

                            int rowsAffected = updateCommand.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                MessageBox.Show($"Material '{productName}' not found in inventory.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        return true; // Successfully updated
                    }
                    else
                    {
                        MessageBox.Show($"Product '{productName}' not found in Inventory Per Piece.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating product '{productName}' in Inventory Per Piece: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false; // Update failed or product not found
        }

        // Update material in Inventory Per Piece (Products like Coke Mismo, Royal Mismo, etc.)
        private void UpdateMaterial(OleDbConnection connection, string materialName, int quantityUsed)
        {
            if (string.IsNullOrEmpty(materialName)) return;

            try
            {
                string query = "UPDATE [Inventory Per Piece] " +
                               "SET [quantity] = [quantity] - @quantityUsed, " +
                               "[date_time_updated] = @dateTime, " +
                               "[quantity_update] = @negativeQuantityUsed " +
                               "WHERE TRIM([material_name]) = @materialName";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Ensure parameter types and values match database schema
                    command.Parameters.Add("@quantityUsed", OleDbType.Integer).Value = quantityUsed;
                    command.Parameters.Add("@dateTime", OleDbType.Date).Value = DateTime.Now;
                    command.Parameters.Add("@negativeQuantityUsed", OleDbType.Integer).Value = -quantityUsed; // Ensure it's numeric
                    command.Parameters.Add("@materialName", OleDbType.VarChar).Value = materialName.Trim(); // Trim spaces

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show($"Material '{materialName}' not found in inventory.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update material '{materialName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleAddOns(OleDbConnection connection, string addOnName, int quantity)
        {
            MessageBox.Show($"Handling add-on: {addOnName}, quantity: {quantity}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                if (string.Equals(addOnName, "Cheese (Stick)", StringComparison.OrdinalIgnoreCase))
                {
                    // Handle Cheese (Stick) in Inventory Per Piece
                    UpdateMaterial(connection, addOnName, quantity);
                }
                else if (string.Equals(addOnName, "Beef", StringComparison.OrdinalIgnoreCase))
                {
                    // Handle Beef in Inventory Per Measurement
                    UpdateIngredient(connection, "Beef", quantity * 30); // Minus 30 grams per unit
                }
                else if (string.Equals(addOnName, "Vegetables", StringComparison.OrdinalIgnoreCase))
                {
                    // Handle Vegetables in Inventory Per Measurement
                    UpdateIngredient(connection, "Vegetables", quantity * 50); // Minus 50 grams per unit
                }
                else
                {
                    MessageBox.Show($"Add-on '{addOnName}' not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing add-on '{addOnName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateInventoryForAddOns(OleDbConnection connection)
        {
            try
            {
                string historyQuery = "SELECT [Order ID], [Add Ons] FROM history WHERE [Status] = 'Completed' AND [Add Ons] IS NOT NULL AND [Add Ons] <> ''";

                using (OleDbCommand historyCommand = new OleDbCommand(historyQuery, connection))
                using (OleDbDataReader reader = historyCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string orderId = reader["Order ID"].ToString();
                        string addOns = reader["Add Ons"].ToString();

                        // Process Add-ons
                        if (!string.IsNullOrEmpty(addOns))
                        {
                            // Parse the add-ons (e.g., "Cheese (Stick)-1, Beef-30, Vegetables-50")
                            var addOnItems = Regex.Matches(addOns, @"([a-zA-Z\s\(\)]+)-\s*(\d+)");
                            foreach (Match addOnItem in addOnItems)
                            {
                                string addOnName = addOnItem.Groups[1].Value.Trim();
                                if (int.TryParse(addOnItem.Groups[2].Value.Trim(), out int quantity))
                                {
                                    // Update the inventory based on the add-on
                                    UpdateInventoryForAddOn(connection, addOnName, quantity);
                                }
                                else
                                {
                                    MessageBox.Show($"Invalid quantity format for add-on '{addOnName}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating inventory for add-ons: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateInventoryForAddOn(OleDbConnection connection, string addOnName, int quantity)
        {
            try
            {
                // Update based on the add-on name
                if (addOnName.Equals("Cheese (Stick)", StringComparison.OrdinalIgnoreCase))
                {
                    // Update Inventory Per Piece for Cheese (Stick)
                    string query = "UPDATE [Inventory Per Piece] " +
                                   "SET [quantity] = [quantity] - @quantity, " +
                                   "[date_time_updated] = @dateTime, " +
                                   "[quantity_update] = @negativeQuantityUsed " +
                                   "WHERE TRIM([material_name]) = @addOnName";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.Add("@quantity", OleDbType.Integer).Value = quantity;
                        command.Parameters.Add("@dateTime", OleDbType.Date).Value = DateTime.Now;
                        command.Parameters.Add("@negativeQuantityUsed", OleDbType.Integer).Value = -quantity;
                        command.Parameters.Add("@addOnName", OleDbType.VarChar).Value = addOnName.Trim();

                        command.ExecuteNonQuery();
                    }
                }
                else if (addOnName.Equals("Beef", StringComparison.OrdinalIgnoreCase) ||
                         addOnName.Equals("Vegetables", StringComparison.OrdinalIgnoreCase))
                {
                    // Update Inventory Per Measurement for Beef and Vegetables
                    string measurementTable = "Inventory Per Measurement";
                    string ingredientColumn = "ingredients_name";
                    string measurementColumn = "ingredients_measurement_grams";

                    string query = $"SELECT [{measurementColumn}] FROM [{measurementTable}] WHERE [{ingredientColumn}] = @addOnName";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.Add("@addOnName", OleDbType.VarChar).Value = addOnName.Trim();

                        var result = command.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out decimal currentQuantity))
                        {
                            decimal updatedQuantity = currentQuantity - (quantity);

                            // Ensure quantity doesn't go negative
                            if (updatedQuantity < 0)
                            {
                                MessageBox.Show($"Not enough inventory for add-on '{addOnName}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Update inventory
                            string updateQuery = $"UPDATE [{measurementTable}] SET [{measurementColumn}] = @updatedQuantity, [date_time_updated] = @dateTime WHERE [{ingredientColumn}] = @addOnName";

                            using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.Add("@updatedQuantity", OleDbType.Decimal).Value = updatedQuantity;
                                updateCommand.Parameters.Add("@dateTime", OleDbType.Date).Value = DateTime.Now;
                                updateCommand.Parameters.Add("@addOnName", OleDbType.VarChar).Value = addOnName.Trim();

                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Add-on '{addOnName}' not found in Inventory Per Measurement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update inventory for add-on '{addOnName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CompleteOrderAndUpdateInventory(OleDbConnection connection, string orderId)
        {
            try
            {
                // Step 1: Mark the order as 'Completed'
                string updateStatusQuery = "UPDATE orders SET [Status] = 'Completed' WHERE [Order ID] = @orderId";
                using (OleDbCommand command = new OleDbCommand(updateStatusQuery, connection))
                {
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.ExecuteNonQuery();
                }

                // Step 2: Call the function to update inventory for the main products
                UpdateInventory(connection, orderId); // This already handles products and add-ons

                // Step 3: Optionally, directly call UpdateInventoryForAddOns to update completed orders' add-ons
                UpdateInventoryForAddOns(connection);

                MessageBox.Show("Order processing complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error completing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
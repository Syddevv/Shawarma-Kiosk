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

namespace Staff_Login_and_Interface
{
    public partial class orders : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb";
        public orders()
        {
            InitializeComponent();
        }

        // this will add rows and contents in the orders table.
        private void orders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void LoadOrders()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Query to load orders sorted by Date and Time in descending order
                    string query = "SELECT [Order ID], [Order List and Quantity], [Special Instructions], [Add Ons], Total, [Status], [Date and Time] " +
                                   "FROM orders ORDER BY [Date and Time] DESC";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable ordersDataTable = new DataTable();
                        adapter.Fill(ordersDataTable);
                        ordersTable.RowTemplate.Height = 40;

                        // Clear existing rows before adding new data
                        ordersTable.Rows.Clear();

                        // Add rows from the DataTable to the ordersTable
                        foreach (DataRow dataRow in ordersDataTable.Rows)
                        {
                            ordersTable.Rows.Add(
                                dataRow["Order ID"],
                                dataRow["Order List and Quantity"],
                                dataRow["Special Instructions"],
                                dataRow["Add Ons"],
                                dataRow["Total"],
                                dataRow["Status"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading orders: {ex.Message}");
            }
        }


        private void ConfirmOrder(int rowIndex, string status, string action)
        {
            try
            {
                string orderId = ordersTable.Rows[rowIndex].Cells["Order ID"].Value?.ToString();
                if (string.IsNullOrEmpty(orderId))
                {
                    MessageBox.Show("Order ID is missing. Unable to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the current status of the order from the DataGridView
                string currentStatus = ordersTable.Rows[rowIndex].Cells["Status"].Value?.ToString();

                // Check if the order is already completed or canceled
                if (currentStatus == "Completed" && status == "Completed")
                {
                    MessageBox.Show("Order is already completed.", "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (currentStatus == "Cancelled" && status == "Cancelled")
                {
                    MessageBox.Show("Order is already cancelled.", "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string message = $"Are you sure you want to {action} this order?";
                DialogResult result = MessageBox.Show(message, "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    UpdateOrderStatus(orderId, status);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during order confirmation: {ex.Message}");
            }
        }


        private void UpdateOrderStatus(string orderId, string status)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE orders SET [Status] = @status WHERE [Order ID] = @orderId";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@orderId", orderId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No rows were updated. Check if the Order ID exists.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Update the status in the DataGridView immediately
                            UpdateRowStatusInGrid(orderId, status);
                            MessageBox.Show($"Order {orderId} has been marked as {status}.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the order: {ex.Message}");
            }
        }

        private void UpdateRowStatusInGrid(string orderId, string newStatus)
        {
            foreach (DataGridViewRow row in ordersTable.Rows)
            {
                if (row.Cells["Order ID"].Value?.ToString() == orderId)
                {
                    row.Cells["Status"].Value = newStatus;  // Update the Status cell
                    break;
                }
            }
        }

        private void historyLabel_Click(object sender, EventArgs e)
        {
            new history().Show();
            this.Close();
        }

        private void inventoryLabel_Click(object sender, EventArgs e)
        {
            new inventory().Show();
            this.Close();
        }

        private void OpenActionsForm(string orderId)
        {
            actions actionsForm = new actions(orderId);
            actionsForm.OrderStatusUpdated += ActionsForm_OrderStatusUpdated;  // Subscribe to the event
            actionsForm.ShowDialog();  // Show actions form
        }

        private void ActionsForm_OrderStatusUpdated()
        {
            LoadOrders();  // Refresh the orders list when the status is updated
        }

        private void ordersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the Order ID from the clicked row
                string orderId = ordersTable.Rows[e.RowIndex].Cells["orderId"].Value?.ToString();
                if (!string.IsNullOrEmpty(orderId))
                {
                    OpenActionsForm(orderId);  // Open the actions form and listen for updates
                }
                else
                {
                    MessageBox.Show("Order ID is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        private void addOrderBTN_Click(object sender, EventArgs e)
        {
            new addOrders().Show();
        }
    }
}



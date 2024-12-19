using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Login
{
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
            sortDates.SelectedIndexChanged += sortDates_SelectedIndexChanged;
        }

        private void sales_Load(object sender, EventArgs e)
        { 
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb"))
                {
                    connection.Open();

                    // Query to fetch the sales data
                    string query = "SELECT [product_id], [product_name], [product_price], [total_sold], [total_sales] FROM sales";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);

                    // Create a DataTable to hold the data
                    DataTable salesData = new DataTable();
                    dataAdapter.Fill(salesData);

                    // Clear the DataGridView to avoid duplication
                    salesTable.Rows.Clear();

                    // Populate the DataGridView rows manually
                    foreach (DataRow row in salesData.Rows)
                    {
                        salesTable.Rows.Add(
                            row["product_id"],
                            row["product_name"],
                            row["product_price"],
                            row["total_sold"],
                            row["total_sales"]
                        );
                    }

                    // Compute the overall total sales
                    decimal overallTotal = 0;
                    foreach (DataRow row in salesData.Rows)
                    {
                        overallTotal += Convert.ToDecimal(row["total_sales"]);
                    }

                    // Display the overall total sales
                    overallTotalLabel.Text = $"₱ {overallTotal:0.00}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if an item is selected and handle "By Day" or "By Month"
                if (sortDates.SelectedItem != null)
                {
                    // Check if the selection is "By Day"
                    if (sortDates.SelectedItem.ToString() == "By Day")
                    {
                        // Show the calendar form for selecting a single day
                        calendar calendarForm = new calendar();
                        DialogResult result = calendarForm.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            // Get the selected date from the calendar form
                            DateTime selectedDate = calendarForm.SelectedDate;

                            // Show sales data for the selected day
                            ShowSalesForDate(selectedDate);
                        }
                    }
                    // Check if the selection is "By Month"
                    else if (sortDates.SelectedItem.ToString() == "By Month")
                    {
                        // Show the calendar_month form for selecting a month
                        calendar_month monthSelectorForm = new calendar_month();
                        DialogResult result = monthSelectorForm.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            // Get the selected month from the calendar_month form
                            DateTime selectedMonth = monthSelectorForm.SelectedMonth;

                            // Show sales data for the selected month
                            ShowSalesForMonth(selectedMonth);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowSalesForDate(DateTime selectedDate)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb"))
                {
                    connection.Open();

                    // Query to get sales data for a specific date
                    string query = @"
            SELECT 
                sales.[product_id], 
                sales.[product_name], 
                sales.[product_price],
                SUM(Abs(IIf(INSTR(history.[Order List and Quantity], sales.[product_name]) > 0, 
                    Val(Mid(history.[Order List and Quantity], 
                        InStr(history.[Order List and Quantity], sales.[product_name]) + Len(sales.[product_name]), 
                        InStrRev(history.[Order List and Quantity], ' ') - (InStr(history.[Order List and Quantity], sales.[product_name]) + Len(sales.[product_name])))), 
                    0))) AS total_sold
            FROM sales
            INNER JOIN history ON INSTR(history.[Order List and Quantity], sales.[product_name]) > 0
            WHERE history.[Date and Time] >= ? AND history.[Date and Time] < ?
            GROUP BY sales.[product_id], sales.[product_name], sales.[product_price]";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Pass the selected date range as parameters
                        command.Parameters.AddWithValue("?", selectedDate.Date); // Start of selected date
                        command.Parameters.AddWithValue("?", selectedDate.Date.AddDays(1)); // End of selected date (start of next day)

                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                        DataTable salesData = new DataTable();
                        dataAdapter.Fill(salesData);

                        // Clear and populate DataGridView
                        salesTable.Rows.Clear();
                        foreach (DataRow row in salesData.Rows)
                        {
                            decimal totalSold = Convert.ToDecimal(row["total_sold"]);
                            decimal productPrice = Convert.ToDecimal(row["product_price"]);
                            decimal totalRevenue = totalSold * productPrice;

                            salesTable.Rows.Add(
                                row["product_id"],
                                row["product_name"],
                                row["product_price"],
                                totalSold,
                                totalRevenue // Add total revenue column to DataGridView
                            );
                        }

                        // Calculate and display overall total sales for the selected day
                        decimal overallTotal = salesData.AsEnumerable()
                            .Sum(row => Convert.ToDecimal(row["total_sold"]) * Convert.ToDecimal(row["product_price"]));
                        overallTotalLabel.Text = $"₱{overallTotal:0.00}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowSalesForMonth(DateTime selectedMonth)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Shawarma Kiosk System\KIOSK DATA BASE\Admin_Account.accdb"))
                {
                    connection.Open();

                    // Calculate the start and end dates for the selected month
                    DateTime startOfMonth = new DateTime(selectedMonth.Year, selectedMonth.Month, 1);
                    DateTime startOfNextMonth = startOfMonth.AddMonths(1);

                    // Query to fetch sales data for the selected month
                    string query = @"
            SELECT sales.[product_id], sales.[product_name], sales.[product_price], sales.[total_sold], sales.[total_sales]
            FROM sales
            WHERE EXISTS (
                SELECT 1
                FROM history
                WHERE history.[Date and Time] >= ? 
                AND history.[Date and Time] < ? 
                AND INSTR(history.[Order List and Quantity], sales.[product_name]) > 0)"; // Using INSTR to check if product_name exists in Order List

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add parameters for the query
                        command.Parameters.AddWithValue("?", startOfMonth); // Start of selected month
                        command.Parameters.AddWithValue("?", startOfNextMonth); // Start of next month

                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                        DataTable salesData = new DataTable();
                        dataAdapter.Fill(salesData);

                        // Clear and populate DataGridView
                        salesTable.Rows.Clear();
                        foreach (DataRow row in salesData.Rows)
                        {
                            salesTable.Rows.Add(
                                row["product_id"],
                                row["product_name"],
                                row["product_price"],
                                row["total_sold"],
                                row["total_sales"]
                            );
                        }

                        // Calculate and display overall total sales
                        decimal overallTotal = salesData.AsEnumerable()
                            .Sum(row => Convert.ToDecimal(row["total_sales"].ToString()));
                        overallTotalLabel.Text = $"₱{overallTotal:0.00}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inventoryLabel_Click(object sender, EventArgs e)
        {
            new inventory().Show();
            this.Close();
        }

        private void historyLabel_Click(object sender, EventArgs e)
        {
            new history().Show();   
            this.Close();
        }

        private void productsLabel_Click(object sender, EventArgs e)
        {
            new Dashboard().Show(); 
            this.Close();
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }
    }
}

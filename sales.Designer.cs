namespace Admin_Login
{
    partial class sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.salesTable = new System.Windows.Forms.DataGridView();
            this.product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsBTN = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.overallTotalLabel = new System.Windows.Forms.Label();
            this.sortDates = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.salesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // salesTable
            // 
            this.salesTable.AllowUserToAddRows = false;
            this.salesTable.AllowUserToDeleteRows = false;
            this.salesTable.AllowUserToResizeColumns = false;
            this.salesTable.AllowUserToResizeRows = false;
            this.salesTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salesTable.ColumnHeadersHeight = 30;
            this.salesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_ID,
            this.product_name,
            this.product_price,
            this.total_sold,
            this.total_sales});
            this.salesTable.EnableHeadersVisualStyles = false;
            this.salesTable.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.salesTable.Location = new System.Drawing.Point(109, 171);
            this.salesTable.Name = "salesTable";
            this.salesTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.salesTable.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.salesTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.salesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesTable.Size = new System.Drawing.Size(953, 421);
            this.salesTable.TabIndex = 109;
            // 
            // product_ID
            // 
            this.product_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.product_ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.product_ID.FillWeight = 40F;
            this.product_ID.HeaderText = "PRODUCT ID";
            this.product_ID.Name = "product_ID";
            this.product_ID.ReadOnly = true;
            this.product_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.product_ID.Width = 161;
            // 
            // product_name
            // 
            this.product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.product_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.product_name.FillWeight = 60F;
            this.product_name.HeaderText = "PRODUCT NAME";
            this.product_name.Name = "product_name";
            this.product_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // product_price
            // 
            this.product_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.product_price.DefaultCellStyle = dataGridViewCellStyle4;
            this.product_price.FillWeight = 70F;
            this.product_price.HeaderText = "PRICE";
            this.product_price.Name = "product_price";
            this.product_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // total_sold
            // 
            this.total_sold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.total_sold.DefaultCellStyle = dataGridViewCellStyle5;
            this.total_sold.FillWeight = 40F;
            this.total_sold.HeaderText = "TOTAL SOLD";
            this.total_sold.Name = "total_sold";
            this.total_sold.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.total_sold.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // total_sales
            // 
            this.total_sales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.total_sales.DefaultCellStyle = dataGridViewCellStyle6;
            this.total_sales.FillWeight = 40F;
            this.total_sales.HeaderText = "TOTAL SALES";
            this.total_sales.Name = "total_sales";
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabel.Location = new System.Drawing.Point(852, 59);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(61, 26);
            this.salesLabel.TabIndex = 108;
            this.salesLabel.Text = "SALES";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(675, 59);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(101, 26);
            this.inventoryLabel.TabIndex = 106;
            this.inventoryLabel.Text = "INVENTORY";
            this.inventoryLabel.Click += new System.EventHandler(this.inventoryLabel_Click);
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLabel.Location = new System.Drawing.Point(514, 59);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(83, 26);
            this.historyLabel.TabIndex = 105;
            this.historyLabel.Text = "HISTORY";
            this.historyLabel.Click += new System.EventHandler(this.historyLabel_Click);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(331, 59);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(101, 26);
            this.productsLabel.TabIndex = 104;
            this.productsLabel.Text = "PRODUCTS";
            this.productsLabel.Click += new System.EventHandler(this.productsLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 101;
            // 
            // settingsBTN
            // 
            this.settingsBTN.BackColor = System.Drawing.Color.Transparent;
            this.settingsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBTN.Image = global::Admin_Login.Properties.Resources.setting__1_;
            this.settingsBTN.Location = new System.Drawing.Point(1022, 56);
            this.settingsBTN.Name = "settingsBTN";
            this.settingsBTN.Size = new System.Drawing.Size(40, 35);
            this.settingsBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsBTN.TabIndex = 107;
            this.settingsBTN.TabStop = false;
            this.settingsBTN.Click += new System.EventHandler(this.settingsBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Admin_Login.Properties.Resources.Circle_Illustrative_Burger_Restaurant_Free_Logo__1__removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(116, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 664);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1161, 50);
            this.panel3.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(823, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 112;
            this.label3.Text = "Overall Sales:";
            // 
            // overallTotalLabel
            // 
            this.overallTotalLabel.AutoSize = true;
            this.overallTotalLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.overallTotalLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallTotalLabel.Location = new System.Drawing.Point(971, 618);
            this.overallTotalLabel.Name = "overallTotalLabel";
            this.overallTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.overallTotalLabel.TabIndex = 113;
            this.overallTotalLabel.Text = "₱ 12, 340";
            // 
            // sortDates
            // 
            this.sortDates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortDates.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortDates.FormattingEnabled = true;
            this.sortDates.Items.AddRange(new object[] {
            "By Day",
            "By Month"});
            this.sortDates.Location = new System.Drawing.Point(937, 130);
            this.sortDates.Name = "sortDates";
            this.sortDates.Size = new System.Drawing.Size(121, 24);
            this.sortDates.TabIndex = 114;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 26);
            this.panel1.TabIndex = 115;
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sortDates);
            this.Controls.Add(this.overallTotalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.salesTable);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsBTN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesTable;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox settingsBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label overallTotalLabel;
        private System.Windows.Forms.ComboBox sortDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_sales;
        private System.Windows.Forms.Panel panel1;
    }
}
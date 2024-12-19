namespace Staff_Login_and_Interface
{
    partial class inventoryPerPiece
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sortInventoryType = new System.Windows.Forms.ComboBox();
            this.inventoryTable = new System.Windows.Forms.DataGridView();
            this.ingredients_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredients_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredients_measurement_grams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time_updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsBTN = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sortInventoryType
            // 
            this.sortInventoryType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortInventoryType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortInventoryType.FormattingEnabled = true;
            this.sortInventoryType.Items.AddRange(new object[] {
            "Inventory Per Measurement",
            "Inventory Per Piece"});
            this.sortInventoryType.Location = new System.Drawing.Point(897, 139);
            this.sortInventoryType.Name = "sortInventoryType";
            this.sortInventoryType.Size = new System.Drawing.Size(207, 24);
            this.sortInventoryType.TabIndex = 147;
            // 
            // inventoryTable
            // 
            this.inventoryTable.AllowUserToAddRows = false;
            this.inventoryTable.AllowUserToDeleteRows = false;
            this.inventoryTable.AllowUserToResizeColumns = false;
            this.inventoryTable.AllowUserToResizeRows = false;
            this.inventoryTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.inventoryTable.ColumnHeadersHeight = 40;
            this.inventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.inventoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredients_ID,
            this.ingredients_name,
            this.ingredients_measurement_grams,
            this.date_time_updated,
            this.quantity_update});
            this.inventoryTable.EnableHeadersVisualStyles = false;
            this.inventoryTable.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.inventoryTable.Location = new System.Drawing.Point(55, 179);
            this.inventoryTable.Name = "inventoryTable";
            this.inventoryTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.inventoryTable.RowHeadersVisible = false;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Black;
            this.inventoryTable.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.inventoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryTable.Size = new System.Drawing.Size(1050, 480);
            this.inventoryTable.TabIndex = 146;
            // 
            // ingredients_ID
            // 
            this.ingredients_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ingredients_ID.DefaultCellStyle = dataGridViewCellStyle34;
            this.ingredients_ID.FillWeight = 15F;
            this.ingredients_ID.HeaderText = "PRODUCT ID";
            this.ingredients_ID.Name = "ingredients_ID";
            this.ingredients_ID.ReadOnly = true;
            this.ingredients_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ingredients_name
            // 
            this.ingredients_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ingredients_name.DefaultCellStyle = dataGridViewCellStyle35;
            this.ingredients_name.FillWeight = 60F;
            this.ingredients_name.HeaderText = "PRODUCT NAME";
            this.ingredients_name.Name = "ingredients_name";
            this.ingredients_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ingredients_measurement_grams
            // 
            this.ingredients_measurement_grams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ingredients_measurement_grams.DefaultCellStyle = dataGridViewCellStyle36;
            this.ingredients_measurement_grams.FillWeight = 30F;
            this.ingredients_measurement_grams.HeaderText = "MEASUREMENT (GRAMS)";
            this.ingredients_measurement_grams.Name = "ingredients_measurement_grams";
            this.ingredients_measurement_grams.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // date_time_updated
            // 
            this.date_time_updated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.date_time_updated.DefaultCellStyle = dataGridViewCellStyle37;
            this.date_time_updated.FillWeight = 40F;
            this.date_time_updated.HeaderText = "DATE AND TIME UPDATED";
            this.date_time_updated.Name = "date_time_updated";
            this.date_time_updated.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date_time_updated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quantity_update
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantity_update.DefaultCellStyle = dataGridViewCellStyle38;
            this.quantity_update.HeaderText = "QTY UPDATE";
            this.quantity_update.Name = "quantity_update";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(821, 79);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(101, 26);
            this.inventoryLabel.TabIndex = 142;
            this.inventoryLabel.Text = "INVENTORY";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 42);
            this.panel2.TabIndex = 112;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(331, 79);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(77, 26);
            this.productsLabel.TabIndex = 140;
            this.productsLabel.Text = "ORDERS";
            this.productsLabel.Click += new System.EventHandler(this.productsLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 138;
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLabel.Location = new System.Drawing.Point(580, 79);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(83, 26);
            this.historyLabel.TabIndex = 141;
            this.historyLabel.Text = "HISTORY";
            this.historyLabel.Click += new System.EventHandler(this.historyLabel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 689);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1161, 25);
            this.panel3.TabIndex = 145;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 42);
            this.panel1.TabIndex = 144;
            // 
            // settingsBTN
            // 
            this.settingsBTN.BackColor = System.Drawing.Color.Transparent;
            this.settingsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBTN.Image = global::Staff_Login_and_Interface.Properties.Resources.setting__1_;
            this.settingsBTN.Location = new System.Drawing.Point(1022, 76);
            this.settingsBTN.Name = "settingsBTN";
            this.settingsBTN.Size = new System.Drawing.Size(40, 35);
            this.settingsBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsBTN.TabIndex = 143;
            this.settingsBTN.TabStop = false;
            this.settingsBTN.Click += new System.EventHandler(this.settingsBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Staff_Login_and_Interface.Properties.Resources.Circle_Illustrative_Burger_Restaurant_Free_Logo__1__removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(91, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // inventoryPerPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 714);
            this.Controls.Add(this.sortInventoryType);
            this.Controls.Add(this.inventoryTable);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settingsBTN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventoryPerPiece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventoryPerPiece";
            this.Load += new System.EventHandler(this.inventoryPerPiece_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTable)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sortInventoryType;
        private System.Windows.Forms.DataGridView inventoryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredients_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredients_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredients_measurement_grams;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time_updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_update;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox settingsBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace Admin_Login
{
    partial class inventory
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
            this.inventoryTable = new System.Windows.Forms.DataGridView();
            this.ingredients_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredients_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredients_measurement_grams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time_updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsBTN = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryTable
            // 
            this.inventoryTable.AllowUserToAddRows = false;
            this.inventoryTable.AllowUserToDeleteRows = false;
            this.inventoryTable.AllowUserToResizeColumns = false;
            this.inventoryTable.AllowUserToResizeRows = false;
            this.inventoryTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.inventoryTable.Location = new System.Drawing.Point(55, 146);
            this.inventoryTable.Name = "inventoryTable";
            this.inventoryTable.ReadOnly = true;
            this.inventoryTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.inventoryTable.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.inventoryTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.inventoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryTable.Size = new System.Drawing.Size(1050, 480);
            this.inventoryTable.TabIndex = 100;
            // 
            // ingredients_ID
            // 
            this.ingredients_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ingredients_ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ingredients_ID.FillWeight = 15F;
            this.ingredients_ID.HeaderText = "PRODUCT ID";
            this.ingredients_ID.Name = "ingredients_ID";
            this.ingredients_ID.ReadOnly = true;
            this.ingredients_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ingredients_name
            // 
            this.ingredients_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ingredients_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.ingredients_name.FillWeight = 60F;
            this.ingredients_name.HeaderText = "PRODUCT NAME";
            this.ingredients_name.Name = "ingredients_name";
            this.ingredients_name.ReadOnly = true;
            this.ingredients_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ingredients_measurement_grams
            // 
            this.ingredients_measurement_grams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ingredients_measurement_grams.DefaultCellStyle = dataGridViewCellStyle4;
            this.ingredients_measurement_grams.FillWeight = 30F;
            this.ingredients_measurement_grams.HeaderText = "MEASUREMENT (GRAMS)";
            this.ingredients_measurement_grams.Name = "ingredients_measurement_grams";
            this.ingredients_measurement_grams.ReadOnly = true;
            this.ingredients_measurement_grams.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // date_time_updated
            // 
            this.date_time_updated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.date_time_updated.DefaultCellStyle = dataGridViewCellStyle5;
            this.date_time_updated.FillWeight = 40F;
            this.date_time_updated.HeaderText = "DATE AND TIME UPDATED";
            this.date_time_updated.Name = "date_time_updated";
            this.date_time_updated.ReadOnly = true;
            this.date_time_updated.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date_time_updated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quantity_update
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantity_update.DefaultCellStyle = dataGridViewCellStyle6;
            this.quantity_update.HeaderText = "QTY UPDATE";
            this.quantity_update.Name = "quantity_update";
            this.quantity_update.ReadOnly = true;
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabel.Location = new System.Drawing.Point(852, 59);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(61, 26);
            this.salesLabel.TabIndex = 99;
            this.salesLabel.Text = "SALES";
            this.salesLabel.Click += new System.EventHandler(this.salesLabel_Click);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(675, 59);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(101, 26);
            this.inventoryLabel.TabIndex = 97;
            this.inventoryLabel.Text = "INVENTORY";
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLabel.Location = new System.Drawing.Point(514, 59);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(83, 26);
            this.historyLabel.TabIndex = 96;
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
            this.productsLabel.TabIndex = 95;
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
            this.label7.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 92;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 687);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1161, 27);
            this.panel3.TabIndex = 112;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 26);
            this.panel1.TabIndex = 113;
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.Black;
            this.addBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBTN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.ForeColor = System.Drawing.Color.Transparent;
            this.addBTN.Location = new System.Drawing.Point(502, 641);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(141, 40);
            this.addBTN.TabIndex = 116;
            this.addBTN.Text = "Add Product";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(937, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "Inventory Per Piece";
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
            this.settingsBTN.TabIndex = 98;
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
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Admin_Login.Properties.Resources.right_arrow__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(1064, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 118;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 714);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.inventoryTable);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventory";
            this.Load += new System.EventHandler(this.inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryTable;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox settingsBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredients_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredients_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredients_measurement_grams;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time_updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_update;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
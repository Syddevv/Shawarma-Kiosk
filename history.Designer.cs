namespace Admin_Login
{
    partial class history
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            this.historyTable = new System.Windows.Forms.DataGridView();
            this.settingsBTN = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderListandQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addOns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialInstructions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 62;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(331, 59);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(101, 26);
            this.productsLabel.TabIndex = 86;
            this.productsLabel.Text = "PRODUCTS";
            this.productsLabel.Click += new System.EventHandler(this.productsLabel_Click_1);
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLabel.Location = new System.Drawing.Point(514, 59);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(83, 26);
            this.historyLabel.TabIndex = 87;
            this.historyLabel.Text = "HISTORY";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(675, 59);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(101, 26);
            this.inventoryLabel.TabIndex = 88;
            this.inventoryLabel.Text = "INVENTORY";
            this.inventoryLabel.Click += new System.EventHandler(this.inventoryLabel_Click);
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabel.Location = new System.Drawing.Point(852, 59);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(61, 26);
            this.salesLabel.TabIndex = 90;
            this.salesLabel.Text = "SALES";
            this.salesLabel.Click += new System.EventHandler(this.salesLabel_Click);
            // 
            // historyTable
            // 
            this.historyTable.AllowUserToAddRows = false;
            this.historyTable.AllowUserToDeleteRows = false;
            this.historyTable.AllowUserToResizeColumns = false;
            this.historyTable.AllowUserToResizeRows = false;
            this.historyTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.historyTable.ColumnHeadersHeight = 40;
            this.historyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.historyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.orderListandQuantity,
            this.addOns,
            this.specialInstructions,
            this.dateAndTime,
            this.total,
            this.status});
            this.historyTable.EnableHeadersVisualStyles = false;
            this.historyTable.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.historyTable.Location = new System.Drawing.Point(26, 133);
            this.historyTable.Name = "historyTable";
            this.historyTable.ReadOnly = true;
            this.historyTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.historyTable.RowHeadersVisible = false;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.historyTable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.historyTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyTable.Size = new System.Drawing.Size(1102, 518);
            this.historyTable.TabIndex = 91;
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
            this.settingsBTN.TabIndex = 89;
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
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 26);
            this.panel1.TabIndex = 112;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 672);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1161, 42);
            this.panel3.TabIndex = 113;
            // 
            // orderID
            // 
            this.orderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderID.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderID.FillWeight = 40F;
            this.orderID.HeaderText = "ORDER ID";
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            this.orderID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // orderListandQuantity
            // 
            this.orderListandQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderListandQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderListandQuantity.FillWeight = 170.3333F;
            this.orderListandQuantity.HeaderText = "ORDER LIST AND QUANTITY";
            this.orderListandQuantity.Name = "orderListandQuantity";
            this.orderListandQuantity.ReadOnly = true;
            this.orderListandQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addOns
            // 
            this.addOns.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.addOns.DefaultCellStyle = dataGridViewCellStyle4;
            this.addOns.FillWeight = 60F;
            this.addOns.HeaderText = "ADD ONS";
            this.addOns.Name = "addOns";
            this.addOns.ReadOnly = true;
            // 
            // specialInstructions
            // 
            this.specialInstructions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.specialInstructions.DefaultCellStyle = dataGridViewCellStyle5;
            this.specialInstructions.FillWeight = 80F;
            this.specialInstructions.HeaderText = "SPECIAL INSTRUCTIONS";
            this.specialInstructions.Name = "specialInstructions";
            this.specialInstructions.ReadOnly = true;
            // 
            // dateAndTime
            // 
            this.dateAndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateAndTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.dateAndTime.FillWeight = 55F;
            this.dateAndTime.HeaderText = "DATE AND TIME";
            this.dateAndTime.Name = "dateAndTime";
            this.dateAndTime.ReadOnly = true;
            this.dateAndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.total.DefaultCellStyle = dataGridViewCellStyle7;
            this.total.FillWeight = 40.22223F;
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle8;
            this.status.FillWeight = 40F;
            this.status.HeaderText = "STATUS";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 714);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.historyTable);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.settingsBTN);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "history";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "history";
            this.Load += new System.EventHandler(this.history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.PictureBox settingsBTN;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.DataGridView historyTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderListandQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn addOns;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialInstructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
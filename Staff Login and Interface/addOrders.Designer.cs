namespace Staff_Login_and_Interface
{
    partial class addOrders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBTN = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addOnsList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.specialTB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedProductsLabel = new System.Windows.Forms.Label();
            this.selectedAddOns = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADD ORDERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(247, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Product";
            // 
            // saveBTN
            // 
            this.saveBTN.BackColor = System.Drawing.Color.LightGreen;
            this.saveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.Location = new System.Drawing.Point(232, 428);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(111, 30);
            this.saveBTN.TabIndex = 8;
            this.saveBTN.Text = "SAVE";
            this.saveBTN.UseVisualStyleBackColor = false;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // productList
            // 
            this.productList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(162, 75);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(276, 47);
            this.productList.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(266, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Add Ons";
            // 
            // addOnsList
            // 
            this.addOnsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addOnsList.FormattingEnabled = true;
            this.addOnsList.Location = new System.Drawing.Point(162, 229);
            this.addOnsList.Name = "addOnsList";
            this.addOnsList.Size = new System.Drawing.Size(276, 32);
            this.addOnsList.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(224, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Special Instructions";
            // 
            // specialTB
            // 
            this.specialTB.BackColor = System.Drawing.Color.White;
            this.specialTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specialTB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialTB.Location = new System.Drawing.Point(174, 346);
            this.specialTB.Multiline = true;
            this.specialTB.Name = "specialTB";
            this.specialTB.Size = new System.Drawing.Size(247, 30);
            this.specialTB.TabIndex = 121;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(162, 336);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 48);
            this.textBox1.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(237, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 122;
            this.label5.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Black;
            this.totalLabel.Location = new System.Drawing.Point(287, 399);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(38, 18);
            this.totalLabel.TabIndex = 123;
            this.totalLabel.Text = "100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Staff_Login_and_Interface.Properties.Resources.delete;
            this.pictureBox1.Location = new System.Drawing.Point(550, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 14);
            this.label6.TabIndex = 124;
            this.label6.Text = "SELECTED PRODUCTS:";
            // 
            // selectedProductsLabel
            // 
            this.selectedProductsLabel.AutoSize = true;
            this.selectedProductsLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedProductsLabel.Location = new System.Drawing.Point(207, 153);
            this.selectedProductsLabel.Name = "selectedProductsLabel";
            this.selectedProductsLabel.Size = new System.Drawing.Size(0, 14);
            this.selectedProductsLabel.TabIndex = 125;
            // 
            // selectedAddOns
            // 
            this.selectedAddOns.AutoSize = true;
            this.selectedAddOns.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedAddOns.Location = new System.Drawing.Point(231, 270);
            this.selectedAddOns.Name = "selectedAddOns";
            this.selectedAddOns.Size = new System.Drawing.Size(0, 14);
            this.selectedAddOns.TabIndex = 126;
            // 
            // addOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 480);
            this.Controls.Add(this.selectedAddOns);
            this.Controls.Add(this.selectedProductsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.specialTB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addOnsList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addOrders";
            this.Load += new System.EventHandler(this.addOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.CheckedListBox productList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox addOnsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox specialTB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label selectedProductsLabel;
        private System.Windows.Forms.Label selectedAddOns;
    }
}
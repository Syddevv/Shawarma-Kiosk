namespace Admin_Login
{
    partial class addProductInventoryPCS
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
            this.confirmBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBTN = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productnameTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmBTN
            // 
            this.confirmBTN.BackColor = System.Drawing.Color.LightGreen;
            this.confirmBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBTN.Location = new System.Drawing.Point(153, 213);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(113, 36);
            this.confirmBTN.TabIndex = 135;
            this.confirmBTN.Text = "CONFIRM";
            this.confirmBTN.UseVisualStyleBackColor = false;
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.closeBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 37);
            this.panel1.TabIndex = 134;
            // 
            // closeBTN
            // 
            this.closeBTN.Image = global::Admin_Login.Properties.Resources.delete;
            this.closeBTN.Location = new System.Drawing.Point(389, 4);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(28, 28);
            this.closeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBTN.TabIndex = 119;
            this.closeBTN.TabStop = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD PRODUCT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(94, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 139;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 138;
            this.label3.Text = "Product Name";
            // 
            // quantityTB
            // 
            this.quantityTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTB.Location = new System.Drawing.Point(189, 150);
            this.quantityTB.Multiline = true;
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(40, 27);
            this.quantityTB.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(141, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 133;
            this.label2.Text = "INVENTORY PIECE";
            // 
            // productnameTB
            // 
            this.productnameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productnameTB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnameTB.Location = new System.Drawing.Point(189, 98);
            this.productnameTB.Multiline = true;
            this.productnameTB.Name = "productnameTB";
            this.productnameTB.Size = new System.Drawing.Size(172, 27);
            this.productnameTB.TabIndex = 136;
            // 
            // addProductInventoryPCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 261);
            this.Controls.Add(this.confirmBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productnameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addProductInventoryPCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addProductInventoryPCS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productnameTB;
    }
}
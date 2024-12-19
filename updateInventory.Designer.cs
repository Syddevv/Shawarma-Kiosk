namespace Admin_Login
{
    partial class updateInventory
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
            this.qtyTB = new System.Windows.Forms.TextBox();
            this.ingredientNameTextBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dercreaseQtyBTN = new System.Windows.Forms.PictureBox();
            this.increaseQtyBTN = new System.Windows.Forms.PictureBox();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dercreaseQtyBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseQtyBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmBTN
            // 
            this.confirmBTN.BackColor = System.Drawing.Color.LightGreen;
            this.confirmBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBTN.Location = new System.Drawing.Point(89, 186);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(113, 36);
            this.confirmBTN.TabIndex = 124;
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
            this.panel1.TabIndex = 123;
            // 
            // closeBTN
            // 
            this.closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.label1.Location = new System.Drawing.Point(109, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE INVENTORY";
            // 
            // qtyTB
            // 
            this.qtyTB.BackColor = System.Drawing.SystemColors.Control;
            this.qtyTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qtyTB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTB.Location = new System.Drawing.Point(194, 128);
            this.qtyTB.Multiline = true;
            this.qtyTB.Name = "qtyTB";
            this.qtyTB.Size = new System.Drawing.Size(40, 22);
            this.qtyTB.TabIndex = 125;
            // 
            // ingredientNameTextBox
            // 
            this.ingredientNameTextBox.AutoSize = true;
            this.ingredientNameTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.ingredientNameTextBox.Location = new System.Drawing.Point(85, 75);
            this.ingredientNameTextBox.Name = "ingredientNameTextBox";
            this.ingredientNameTextBox.Size = new System.Drawing.Size(0, 19);
            this.ingredientNameTextBox.TabIndex = 133;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(181, 121);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 33);
            this.textBox1.TabIndex = 134;
            // 
            // dercreaseQtyBTN
            // 
            this.dercreaseQtyBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dercreaseQtyBTN.Image = global::Admin_Login.Properties.Resources.minus;
            this.dercreaseQtyBTN.Location = new System.Drawing.Point(245, 121);
            this.dercreaseQtyBTN.Name = "dercreaseQtyBTN";
            this.dercreaseQtyBTN.Size = new System.Drawing.Size(36, 32);
            this.dercreaseQtyBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dercreaseQtyBTN.TabIndex = 132;
            this.dercreaseQtyBTN.TabStop = false;
            this.dercreaseQtyBTN.Click += new System.EventHandler(this.dercreaseQtyBTN_Click);
            // 
            // increaseQtyBTN
            // 
            this.increaseQtyBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.increaseQtyBTN.Image = global::Admin_Login.Properties.Resources.add;
            this.increaseQtyBTN.Location = new System.Drawing.Point(140, 121);
            this.increaseQtyBTN.Name = "increaseQtyBTN";
            this.increaseQtyBTN.Size = new System.Drawing.Size(36, 32);
            this.increaseQtyBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.increaseQtyBTN.TabIndex = 131;
            this.increaseQtyBTN.TabStop = false;
            this.increaseQtyBTN.Click += new System.EventHandler(this.increaseQtyBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.White;
            this.deleteBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.ForeColor = System.Drawing.Color.Red;
            this.deleteBTN.Location = new System.Drawing.Point(225, 186);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(113, 36);
            this.deleteBTN.TabIndex = 135;
            this.deleteBTN.Text = "DELETE";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(159, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 138;
            this.label2.Text = "1000 grams = 1kg";
            // 
            // updateInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.ingredientNameTextBox);
            this.Controls.Add(this.dercreaseQtyBTN);
            this.Controls.Add(this.increaseQtyBTN);
            this.Controls.Add(this.qtyTB);
            this.Controls.Add(this.confirmBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateInventory";
            this.Load += new System.EventHandler(this.updateInventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dercreaseQtyBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseQtyBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qtyTB;
        private System.Windows.Forms.PictureBox dercreaseQtyBTN;
        private System.Windows.Forms.PictureBox increaseQtyBTN;
        private System.Windows.Forms.Label ingredientNameTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Label label2;
    }
}
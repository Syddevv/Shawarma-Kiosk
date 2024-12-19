namespace Staff_Login_and_Interface
{
    partial class quantity
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
            this.quantityLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.decreaseQtyBTN = new System.Windows.Forms.PictureBox();
            this.increaseQtyBTN = new System.Windows.Forms.PictureBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreaseQtyBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseQtyBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 27);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUANTITY";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(119, 73);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(19, 19);
            this.quantityLabel.TabIndex = 115;
            this.quantityLabel.Text = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Staff_Login_and_Interface.Properties.Resources.delete;
            this.pictureBox2.Location = new System.Drawing.Point(225, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Staff_Login_and_Interface.Properties.Resources.delete;
            this.pictureBox1.Location = new System.Drawing.Point(288, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // decreaseQtyBTN
            // 
            this.decreaseQtyBTN.BackColor = System.Drawing.Color.Transparent;
            this.decreaseQtyBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decreaseQtyBTN.Image = global::Staff_Login_and_Interface.Properties.Resources.minus;
            this.decreaseQtyBTN.Location = new System.Drawing.Point(148, 66);
            this.decreaseQtyBTN.Name = "decreaseQtyBTN";
            this.decreaseQtyBTN.Size = new System.Drawing.Size(30, 30);
            this.decreaseQtyBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.decreaseQtyBTN.TabIndex = 114;
            this.decreaseQtyBTN.TabStop = false;
            this.decreaseQtyBTN.Click += new System.EventHandler(this.decreaseQtyBTN_Click);
            // 
            // increaseQtyBTN
            // 
            this.increaseQtyBTN.BackColor = System.Drawing.Color.Transparent;
            this.increaseQtyBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.increaseQtyBTN.Image = global::Staff_Login_and_Interface.Properties.Resources.add;
            this.increaseQtyBTN.Location = new System.Drawing.Point(81, 66);
            this.increaseQtyBTN.Name = "increaseQtyBTN";
            this.increaseQtyBTN.Size = new System.Drawing.Size(30, 30);
            this.increaseQtyBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.increaseQtyBTN.TabIndex = 113;
            this.increaseQtyBTN.TabStop = false;
            this.increaseQtyBTN.Click += new System.EventHandler(this.increaseQtyBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.BackColor = System.Drawing.Color.LightGreen;
            this.saveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.Location = new System.Drawing.Point(83, 107);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(93, 29);
            this.saveBTN.TabIndex = 116;
            this.saveBTN.Text = "SAVE";
            this.saveBTN.UseVisualStyleBackColor = false;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.Color.Black;
            this.productNameLabel.Location = new System.Drawing.Point(63, 34);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(0, 16);
            this.productNameLabel.TabIndex = 6;
            // 
            // quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 147);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.decreaseQtyBTN);
            this.Controls.Add(this.increaseQtyBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quantity";
            this.Load += new System.EventHandler(this.quantity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreaseQtyBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseQtyBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.PictureBox decreaseQtyBTN;
        private System.Windows.Forms.PictureBox increaseQtyBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Label productNameLabel;
    }
}
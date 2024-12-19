namespace User_Interface
{
    partial class productOrderOption
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
            this.productName = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.orderBTN = new System.Windows.Forms.Button();
            this.addToCartBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.PictureBox();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(69, 225);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(263, 19);
            this.productName.TabIndex = 1;
            this.productName.Text = "Large Chicken Shawarma Wrap";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.Location = new System.Drawing.Point(178, 258);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(41, 19);
            this.productPrice.TabIndex = 2;
            this.productPrice.Text = "₱ 70";
            // 
            // orderBTN
            // 
            this.orderBTN.BackColor = System.Drawing.Color.Black;
            this.orderBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderBTN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBTN.ForeColor = System.Drawing.Color.White;
            this.orderBTN.Location = new System.Drawing.Point(62, 366);
            this.orderBTN.Name = "orderBTN";
            this.orderBTN.Size = new System.Drawing.Size(133, 40);
            this.orderBTN.TabIndex = 7;
            this.orderBTN.Text = "Order Now";
            this.orderBTN.UseVisualStyleBackColor = false;
            this.orderBTN.Click += new System.EventHandler(this.orderBTN_Click);
            // 
            // addToCartBTN
            // 
            this.addToCartBTN.BackColor = System.Drawing.Color.White;
            this.addToCartBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartBTN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartBTN.ForeColor = System.Drawing.Color.Black;
            this.addToCartBTN.Location = new System.Drawing.Point(211, 366);
            this.addToCartBTN.Name = "addToCartBTN";
            this.addToCartBTN.Size = new System.Drawing.Size(133, 40);
            this.addToCartBTN.TabIndex = 8;
            this.addToCartBTN.Text = "Add to Cart";
            this.addToCartBTN.UseVisualStyleBackColor = false;
            this.addToCartBTN.Click += new System.EventHandler(this.addToCartBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBTN.Image = global::User_Interface.Properties.Resources.left_arrow1;
            this.backBTN.Location = new System.Drawing.Point(-8, 6);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(61, 24);
            this.backBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBTN.TabIndex = 9;
            this.backBTN.TabStop = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(112, 42);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(175, 166);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            // 
            // productOrderOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 430);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.addToCartBTN);
            this.Controls.Add(this.orderBTN);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productOrderOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productOrderOption";
            this.Load += new System.EventHandler(this.productOrderOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Button orderBTN;
        private System.Windows.Forms.Button addToCartBTN;
        private System.Windows.Forms.PictureBox backBTN;
    }
}
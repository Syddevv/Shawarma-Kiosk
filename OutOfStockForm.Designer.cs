namespace Admin_Login
{
    partial class inStockForm
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
            this.markasInStock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // markasInStock
            // 
            this.markasInStock.BackColor = System.Drawing.Color.Black;
            this.markasInStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.markasInStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markasInStock.ForeColor = System.Drawing.Color.White;
            this.markasInStock.Location = new System.Drawing.Point(82, 322);
            this.markasInStock.Name = "markasInStock";
            this.markasInStock.Size = new System.Drawing.Size(209, 38);
            this.markasInStock.TabIndex = 149;
            this.markasInStock.Text = "Mark as In Stock";
            this.markasInStock.UseVisualStyleBackColor = false;
            this.markasInStock.Click += new System.EventHandler(this.markasInStock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Admin_Login.Properties.Resources.left_arrow2;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(147, 248);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 19);
            this.priceLabel.TabIndex = 145;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(63, 212);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 19);
            this.nameLabel.TabIndex = 144;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(94, 35);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(186, 148);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 143;
            this.productPictureBox.TabStop = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.White;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.DarkRed;
            this.removeButton.Location = new System.Drawing.Point(117, 368);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(138, 38);
            this.removeButton.TabIndex = 150;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // inStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 426);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.markasInStock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.productPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutOfStockForm";
            this.Load += new System.EventHandler(this.inStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button markasInStock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Button removeButton;
    }
}
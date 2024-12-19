namespace Admin_Login
{
    partial class ProductDetailsForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.outofStockBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(66, 210);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 19);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(150, 246);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 19);
            this.priceLabel.TabIndex = 2;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Black;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.Transparent;
            this.editButton.Location = new System.Drawing.Point(207, 301);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(138, 38);
            this.editButton.TabIndex = 139;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.White;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.DarkRed;
            this.removeButton.Location = new System.Drawing.Point(51, 301);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(138, 38);
            this.removeButton.TabIndex = 140;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Admin_Login.Properties.Resources.left_arrow2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(97, 33);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(186, 148);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            // 
            // outofStockBTN
            // 
            this.outofStockBTN.BackColor = System.Drawing.Color.White;
            this.outofStockBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outofStockBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outofStockBTN.ForeColor = System.Drawing.Color.Black;
            this.outofStockBTN.Location = new System.Drawing.Point(86, 355);
            this.outofStockBTN.Name = "outofStockBTN";
            this.outofStockBTN.Size = new System.Drawing.Size(209, 38);
            this.outofStockBTN.TabIndex = 142;
            this.outofStockBTN.Text = "Mark as Out of Stock";
            this.outofStockBTN.UseVisualStyleBackColor = false;
            this.outofStockBTN.Click += new System.EventHandler(this.outofStockBTN_Click);
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 426);
            this.Controls.Add(this.outofStockBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.productPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetailsForm";
           
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button outofStockBTN;
    }
}
namespace User_Interface
{
    partial class orderSummaryMultiple
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
            this.orderDetailsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.specialLabel = new System.Windows.Forms.Label();
            this.addonsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDetailsPanel
            // 
            this.orderDetailsPanel.AutoScroll = true;
            this.orderDetailsPanel.Location = new System.Drawing.Point(12, 51);
            this.orderDetailsPanel.Name = "orderDetailsPanel";
            this.orderDetailsPanel.Size = new System.Drawing.Size(433, 269);
            this.orderDetailsPanel.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 132;
            this.label2.Text = "Order Summary";
            // 
            // confirmBTN
            // 
            this.confirmBTN.BackColor = System.Drawing.Color.Black;
            this.confirmBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBTN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBTN.ForeColor = System.Drawing.Color.White;
            this.confirmBTN.Location = new System.Drawing.Point(160, 426);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(133, 40);
            this.confirmBTN.TabIndex = 130;
            this.confirmBTN.Text = "Confirm";
            this.confirmBTN.UseVisualStyleBackColor = false;
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBTN.Image = global::User_Interface.Properties.Resources.left_arrow1;
            this.backBTN.Location = new System.Drawing.Point(-8, 5);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(61, 24);
            this.backBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBTN.TabIndex = 131;
            this.backBTN.TabStop = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 48;
            this.label7.Text = "Add Ons:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(62, 400);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(36, 16);
            this.totalLabel.TabIndex = 47;
            this.totalLabel.Text = "₱ 75";
            // 
            // specialLabel
            // 
            this.specialLabel.AutoSize = true;
            this.specialLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialLabel.Location = new System.Drawing.Point(152, 373);
            this.specialLabel.Name = "specialLabel";
            this.specialLabel.Size = new System.Drawing.Size(62, 16);
            this.specialLabel.TabIndex = 46;
            this.specialLabel.Text = "no mayo";
            // 
            // addonsLabel
            // 
            this.addonsLabel.AutoSize = true;
            this.addonsLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addonsLabel.Location = new System.Drawing.Point(80, 346);
            this.addonsLabel.Name = "addonsLabel";
            this.addonsLabel.Size = new System.Drawing.Size(57, 16);
            this.addonsLabel.TabIndex = 45;
            this.addonsLabel.Text = "cheese ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 43;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 14);
            this.label5.TabIndex = 42;
            this.label5.Text = "Special Instructions: ";
            // 
            // orderSummaryMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 478);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.orderDetailsPanel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.specialLabel);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.addonsLabel);
            this.Controls.Add(this.confirmBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderSummaryMultiple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderSummaryMultiple";
            this.Load += new System.EventHandler(this.orderSummaryMultiple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel orderDetailsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox backBTN;
        private System.Windows.Forms.Button confirmBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label specialLabel;
        private System.Windows.Forms.Label addonsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
namespace User_Interface
{
    partial class addOns
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
            this.label2 = new System.Windows.Forms.Label();
            this.addOnsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.confirmBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Add-Ons";
            // 
            // addOnsPanel
            // 
            this.addOnsPanel.AutoScroll = true;
            this.addOnsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.addOnsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addOnsPanel.Location = new System.Drawing.Point(12, 69);
            this.addOnsPanel.Name = "addOnsPanel";
            this.addOnsPanel.Size = new System.Drawing.Size(433, 323);
            this.addOnsPanel.TabIndex = 33;
            // 
            // confirmBTN
            // 
            this.confirmBTN.BackColor = System.Drawing.Color.Black;
            this.confirmBTN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBTN.ForeColor = System.Drawing.Color.White;
            this.confirmBTN.Location = new System.Drawing.Point(158, 416);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(133, 40);
            this.confirmBTN.TabIndex = 34;
            this.confirmBTN.Text = "Confirm";
            this.confirmBTN.UseVisualStyleBackColor = false;
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBTN.Image = global::User_Interface.Properties.Resources.x_mark1;
            this.closeBTN.Location = new System.Drawing.Point(419, 6);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(32, 27);
            this.closeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBTN.TabIndex = 142;
            this.closeBTN.TabStop = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // addOns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(457, 478);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.confirmBTN);
            this.Controls.Add(this.addOnsPanel);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addOns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addOns";
            this.Load += new System.EventHandler(this.addOns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel addOnsPanel;
        private System.Windows.Forms.Button confirmBTN;
        private System.Windows.Forms.PictureBox closeBTN;
    }
}
namespace User_Interface
{
    partial class orderDetailsMultiple
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
            this.nextBTN = new System.Windows.Forms.Button();
            this.specialTB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderDetailsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backBTN = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.addOnsBTN = new System.Windows.Forms.Button();
            this.addOnsContainer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 122;
            this.label2.Text = "Order Details";
            // 
            // nextBTN
            // 
            this.nextBTN.BackColor = System.Drawing.Color.Black;
            this.nextBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBTN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBTN.ForeColor = System.Drawing.Color.White;
            this.nextBTN.Location = new System.Drawing.Point(157, 447);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(133, 40);
            this.nextBTN.TabIndex = 120;
            this.nextBTN.Text = "Next";
            this.nextBTN.UseVisualStyleBackColor = false;
            this.nextBTN.Click += new System.EventHandler(this.nextBTN_Click);
            // 
            // specialTB
            // 
            this.specialTB.BackColor = System.Drawing.SystemColors.Control;
            this.specialTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specialTB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialTB.Location = new System.Drawing.Point(27, 367);
            this.specialTB.Multiline = true;
            this.specialTB.Name = "specialTB";
            this.specialTB.Size = new System.Drawing.Size(384, 29);
            this.specialTB.TabIndex = 119;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(19, 359);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 47);
            this.textBox1.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 117;
            this.label1.Text = "Special Instructions";
            // 
            // orderDetailsPanel
            // 
            this.orderDetailsPanel.AutoScroll = true;
            this.orderDetailsPanel.BackColor = System.Drawing.Color.White;
            this.orderDetailsPanel.Location = new System.Drawing.Point(12, 51);
            this.orderDetailsPanel.Name = "orderDetailsPanel";
            this.orderDetailsPanel.Size = new System.Drawing.Size(433, 220);
            this.orderDetailsPanel.TabIndex = 126;
            // 
            // backBTN
            // 
            this.backBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBTN.Image = global::User_Interface.Properties.Resources.left_arrow1;
            this.backBTN.Location = new System.Drawing.Point(-8, 5);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(61, 24);
            this.backBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBTN.TabIndex = 121;
            this.backBTN.TabStop = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 115;
            this.label3.Text = "TOTAL:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(210, 418);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 19);
            this.totalLabel.TabIndex = 116;
            // 
            // addOnsBTN
            // 
            this.addOnsBTN.BackColor = System.Drawing.Color.LightGreen;
            this.addOnsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOnsBTN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOnsBTN.Location = new System.Drawing.Point(179, 277);
            this.addOnsBTN.Name = "addOnsBTN";
            this.addOnsBTN.Size = new System.Drawing.Size(93, 33);
            this.addOnsBTN.TabIndex = 14;
            this.addOnsBTN.Text = "Add Ons";
            this.addOnsBTN.UseVisualStyleBackColor = false;
            this.addOnsBTN.Click += new System.EventHandler(this.addOnsBTN_Click);
            // 
            // addOnsContainer
            // 
            this.addOnsContainer.AutoSize = true;
            this.addOnsContainer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOnsContainer.Location = new System.Drawing.Point(167, 313);
            this.addOnsContainer.Name = "addOnsContainer";
            this.addOnsContainer.Size = new System.Drawing.Size(0, 16);
            this.addOnsContainer.TabIndex = 127;
            // 
            // orderDetailsMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 499);
            this.Controls.Add(this.addOnsContainer);
            this.Controls.Add(this.addOnsBTN);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderDetailsPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.nextBTN);
            this.Controls.Add(this.specialTB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderDetailsMultiple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderDetailsMultiple";
            this.Load += new System.EventHandler(this.orderDetailsMultiple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox backBTN;
        private System.Windows.Forms.Button nextBTN;
        private System.Windows.Forms.TextBox specialTB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel orderDetailsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button addOnsBTN;
        private System.Windows.Forms.Label addOnsContainer;
    }
}
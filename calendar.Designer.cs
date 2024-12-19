namespace Admin_Login
{
    partial class calendar
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBTN = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(110, 74);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 116;
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
            this.panel1.TabIndex = 117;
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
            this.label1.Location = new System.Drawing.Point(142, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT DATE";
            // 
            // confirmBTN
            // 
            this.confirmBTN.BackColor = System.Drawing.Color.LightGreen;
            this.confirmBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBTN.Location = new System.Drawing.Point(156, 196);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(113, 36);
            this.confirmBTN.TabIndex = 118;
            this.confirmBTN.Text = "CONFIRM";
            this.confirmBTN.UseVisualStyleBackColor = false;
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 261);
            this.Controls.Add(this.confirmBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calendar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmBTN;
        private System.Windows.Forms.PictureBox closeBTN;
    }
}
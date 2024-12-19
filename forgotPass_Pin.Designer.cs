namespace Admin_Login
{
    partial class forgotPass_Pin
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
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.verifyBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reSendPin = new System.Windows.Forms.Label();
            this.backToLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backToLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pinTextBox
            // 
            this.pinTextBox.BackColor = System.Drawing.Color.LightGray;
            this.pinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pinTextBox.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinTextBox.Location = new System.Drawing.Point(229, 219);
            this.pinTextBox.Multiline = true;
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(282, 38);
            this.pinTextBox.TabIndex = 19;
            this.pinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // verifyBTN
            // 
            this.verifyBTN.BackColor = System.Drawing.Color.Black;
            this.verifyBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyBTN.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBTN.ForeColor = System.Drawing.Color.White;
            this.verifyBTN.Location = new System.Drawing.Point(260, 296);
            this.verifyBTN.Name = "verifyBTN";
            this.verifyBTN.Size = new System.Drawing.Size(214, 42);
            this.verifyBTN.TabIndex = 18;
            this.verifyBTN.Text = "Verify";
            this.verifyBTN.UseVisualStyleBackColor = false;
            this.verifyBTN.Click += new System.EventHandler(this.verifyBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(219, 206);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 51);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Please enter the one-time PIN (OTP) that we sent to your email address.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "One-Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(415, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "PIN";
            // 
            // reSendPin
            // 
            this.reSendPin.AutoSize = true;
            this.reSendPin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reSendPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reSendPin.Location = new System.Drawing.Point(292, 350);
            this.reSendPin.Name = "reSendPin";
            this.reSendPin.Size = new System.Drawing.Size(145, 16);
            this.reSendPin.TabIndex = 22;
            this.reSendPin.Text = "Re-send one time PIN?";
            this.reSendPin.Click += new System.EventHandler(this.reSendPin_Click);
            // 
            // backToLogin
            // 
            this.backToLogin.BackColor = System.Drawing.Color.Transparent;
            this.backToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLogin.Image = global::Admin_Login.Properties.Resources.left_arrow;
            this.backToLogin.Location = new System.Drawing.Point(12, 14);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(43, 24);
            this.backToLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backToLogin.TabIndex = 20;
            this.backToLogin.TabStop = false;
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // forgotPass_Pin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 449);
            this.Controls.Add(this.reSendPin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.verifyBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "forgotPass_Pin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgotPass_Pin";
            ((System.ComponentModel.ISupportInitialize)(this.backToLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backToLogin;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Button verifyBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label reSendPin;
    }
}
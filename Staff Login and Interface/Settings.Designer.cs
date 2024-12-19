namespace Staff_Login_and_Interface
{
    partial class Settings
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changePass = new System.Windows.Forms.Label();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.changePass_Icon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.changePass_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 73;
            this.label4.Text = "SETTINGS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 72;
            this.label3.Text = "STAFF";
            // 
            // changePass
            // 
            this.changePass.AutoSize = true;
            this.changePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePass.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePass.Location = new System.Drawing.Point(150, 275);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(158, 23);
            this.changePass.TabIndex = 70;
            this.changePass.Text = "Change Password";
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // logoutBTN
            // 
            this.logoutBTN.BackColor = System.Drawing.Color.Black;
            this.logoutBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBTN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBTN.ForeColor = System.Drawing.Color.Transparent;
            this.logoutBTN.Location = new System.Drawing.Point(103, 448);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(202, 49);
            this.logoutBTN.TabIndex = 67;
            this.logoutBTN.Text = "LOG OUT";
            this.logoutBTN.UseVisualStyleBackColor = false;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // changePass_Icon
            // 
            this.changePass_Icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePass_Icon.Image = global::Staff_Login_and_Interface.Properties.Resources.padlock;
            this.changePass_Icon.Location = new System.Drawing.Point(80, 269);
            this.changePass_Icon.Name = "changePass_Icon";
            this.changePass_Icon.Size = new System.Drawing.Size(64, 34);
            this.changePass_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changePass_Icon.TabIndex = 68;
            this.changePass_Icon.TabStop = false;
            this.changePass_Icon.Click += new System.EventHandler(this.changePass_Icon_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Staff_Login_and_Interface.Properties.Resources.profile;
            this.pictureBox2.Location = new System.Drawing.Point(140, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Staff_Login_and_Interface.Properties.Resources.left_arrow1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changePass);
            this.Controls.Add(this.changePass_Icon);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.changePass_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label changePass;
        private System.Windows.Forms.PictureBox changePass_Icon;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
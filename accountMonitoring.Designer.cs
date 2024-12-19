namespace Admin_Login
{
    partial class accountMonitoring
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.logTable = new System.Windows.Forms.DataGridView();
            this.account_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backToSettings = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backToSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 664);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1161, 50);
            this.panel3.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(459, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "ACCOUNT MONITORING";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 61);
            this.panel2.TabIndex = 111;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 61);
            this.panel1.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(453, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "SALES REPORT FOR OCTOBER 1 - 7";
            // 
            // logTable
            // 
            this.logTable.AllowUserToAddRows = false;
            this.logTable.AllowUserToDeleteRows = false;
            this.logTable.AllowUserToResizeColumns = false;
            this.logTable.AllowUserToResizeRows = false;
            this.logTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.logTable.ColumnHeadersHeight = 40;
            this.logTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.logTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.account_ID,
            this.loginTime,
            this.logoutTime});
            this.logTable.EnableHeadersVisualStyles = false;
            this.logTable.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.logTable.Location = new System.Drawing.Point(114, 133);
            this.logTable.Name = "logTable";
            this.logTable.ReadOnly = true;
            this.logTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.logTable.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.logTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.logTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logTable.Size = new System.Drawing.Size(946, 431);
            this.logTable.TabIndex = 120;
            // 
            // account_ID
            // 
            this.account_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.account_ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.account_ID.FillWeight = 40F;
            this.account_ID.HeaderText = "ACCOUNT ID";
            this.account_ID.Name = "account_ID";
            this.account_ID.ReadOnly = true;
            this.account_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // loginTime
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.loginTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.loginTime.FillWeight = 60F;
            this.loginTime.HeaderText = "LOG IN TIME";
            this.loginTime.Name = "loginTime";
            this.loginTime.ReadOnly = true;
            this.loginTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.loginTime.Width = 333;
            // 
            // logoutTime
            // 
            this.logoutTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.logoutTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.logoutTime.FillWeight = 60F;
            this.logoutTime.HeaderText = "LOG OUT TIME";
            this.logoutTime.Name = "logoutTime";
            this.logoutTime.ReadOnly = true;
            this.logoutTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 112;
            // 
            // backToSettings
            // 
            this.backToSettings.Image = global::Admin_Login.Properties.Resources.left_arrow1;
            this.backToSettings.Location = new System.Drawing.Point(12, 76);
            this.backToSettings.Name = "backToSettings";
            this.backToSettings.Size = new System.Drawing.Size(62, 26);
            this.backToSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backToSettings.TabIndex = 123;
            this.backToSettings.TabStop = false;
            this.backToSettings.Click += new System.EventHandler(this.backToSettings_Click);
            // 
            // accountMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 714);
            this.Controls.Add(this.backToSettings);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "accountMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accountMonitoring";
            this.Load += new System.EventHandler(this.accountMonitoring_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backToSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView logTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox backToSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn logoutTime;
    }
}
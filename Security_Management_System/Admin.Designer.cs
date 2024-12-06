namespace Security_Management_System
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserManagement_button = new System.Windows.Forms.Button();
            this.SystemLogs_button = new System.Windows.Forms.Button();
            this.Settings_button = new System.Windows.Forms.Button();
            this.Reports_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // UserManagement_button
            // 
            this.UserManagement_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserManagement_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManagement_button.Location = new System.Drawing.Point(277, 139);
            this.UserManagement_button.Name = "UserManagement_button";
            this.UserManagement_button.Size = new System.Drawing.Size(227, 35);
            this.UserManagement_button.TabIndex = 1;
            this.UserManagement_button.Text = "User Management";
            this.UserManagement_button.UseVisualStyleBackColor = true;
            this.UserManagement_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // SystemLogs_button
            // 
            this.SystemLogs_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemLogs_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemLogs_button.Location = new System.Drawing.Point(277, 207);
            this.SystemLogs_button.Name = "SystemLogs_button";
            this.SystemLogs_button.Size = new System.Drawing.Size(227, 35);
            this.SystemLogs_button.TabIndex = 2;
            this.SystemLogs_button.Text = "System Logs";
            this.SystemLogs_button.UseVisualStyleBackColor = true;
            this.SystemLogs_button.Click += new System.EventHandler(this.SystemLogs_button_Click);
            // 
            // Settings_button
            // 
            this.Settings_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_button.Location = new System.Drawing.Point(277, 267);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Size = new System.Drawing.Size(227, 35);
            this.Settings_button.TabIndex = 3;
            this.Settings_button.Text = "Settings";
            this.Settings_button.UseVisualStyleBackColor = true;
            this.Settings_button.Click += new System.EventHandler(this.Settings_button_Click);
            // 
            // Reports_button
            // 
            this.Reports_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Reports_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports_button.Location = new System.Drawing.Point(277, 335);
            this.Reports_button.Name = "Reports_button";
            this.Reports_button.Size = new System.Drawing.Size(227, 35);
            this.Reports_button.TabIndex = 4;
            this.Reports_button.Text = "Reports";
            this.Reports_button.UseVisualStyleBackColor = true;
            this.Reports_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reports_button);
            this.Controls.Add(this.Settings_button);
            this.Controls.Add(this.SystemLogs_button);
            this.Controls.Add(this.UserManagement_button);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserManagement_button;
        private System.Windows.Forms.Button SystemLogs_button;
        private System.Windows.Forms.Button Settings_button;
        private System.Windows.Forms.Button Reports_button;
    }
}
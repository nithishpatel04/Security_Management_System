using System;

namespace Security_Management_System
{
    partial class AssignShifts
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.ComboBox comboShift;
        private System.Windows.Forms.Button btnAssignShift;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblShift = new System.Windows.Forms.Label();
            this.comboShift = new System.Windows.Forms.ComboBox();
            this.btnAssignShift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Shifts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(348, 246);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(463, 246);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(222, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(348, 310);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(35, 16);
            this.lblShift.TabIndex = 3;
            this.lblShift.Text = "Shift:";
            // 
            // comboShift
            // 
            this.comboShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboShift.FormattingEnabled = true;
            this.comboShift.Location = new System.Drawing.Point(463, 307);
            this.comboShift.Name = "comboShift";
            this.comboShift.Size = new System.Drawing.Size(225, 24);
            this.comboShift.TabIndex = 4;
            // 
            // btnAssignShift
            // 
            this.btnAssignShift.Location = new System.Drawing.Point(509, 388);
            this.btnAssignShift.Name = "btnAssignShift";
            this.btnAssignShift.Size = new System.Drawing.Size(100, 30);
            this.btnAssignShift.TabIndex = 5;
            this.btnAssignShift.Text = "Assign Shift";
            this.btnAssignShift.UseVisualStyleBackColor = true;
            this.btnAssignShift.Click += new System.EventHandler(this.btnAssignShift_Click);
            // 
            // AssignShifts
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.comboShift);
            this.Controls.Add(this.btnAssignShift);
            this.Name = "AssignShifts";
            this.Text = "Assign Shifts";
            this.Load += new System.EventHandler(this.AssignShifts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}

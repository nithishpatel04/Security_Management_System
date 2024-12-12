namespace Security_Management_System
{
    partial class AddShiftsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.TextBox txtShiftName;
        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblShiftName;
        private System.Windows.Forms.Label lblShiftDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;

        private void InitializeComponent()
        {
            this.btnAddShift = new System.Windows.Forms.Button();
            this.txtShiftName = new System.Windows.Forms.TextBox();
            this.dtpShiftDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblShiftName = new System.Windows.Forms.Label();
            this.lblShiftDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddShift
            // 
            this.btnAddShift.Location = new System.Drawing.Point(487, 510);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(100, 30);
            this.btnAddShift.TabIndex = 0;
            this.btnAddShift.Text = "Add Shift";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // txtShiftName
            // 
            this.txtShiftName.Location = new System.Drawing.Point(433, 234);
            this.txtShiftName.Name = "txtShiftName";
            this.txtShiftName.Size = new System.Drawing.Size(200, 22);
            this.txtShiftName.TabIndex = 1;
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Location = new System.Drawing.Point(433, 291);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(200, 22);
            this.dtpShiftDate.TabIndex = 2;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(433, 364);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(200, 22);
            this.dtpStartTime.TabIndex = 3;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(433, 426);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(200, 22);
            this.dtpEndTime.TabIndex = 4;
            // 
            // lblShiftName
            // 
            this.lblShiftName.AutoSize = true;
            this.lblShiftName.Location = new System.Drawing.Point(295, 240);
            this.lblShiftName.Name = "lblShiftName";
            this.lblShiftName.Size = new System.Drawing.Size(72, 16);
            this.lblShiftName.TabIndex = 5;
            this.lblShiftName.Text = "Shift Name";
            // 
            // lblShiftDate
            // 
            this.lblShiftDate.AutoSize = true;
            this.lblShiftDate.Location = new System.Drawing.Point(295, 297);
            this.lblShiftDate.Name = "lblShiftDate";
            this.lblShiftDate.Size = new System.Drawing.Size(64, 16);
            this.lblShiftDate.TabIndex = 6;
            this.lblShiftDate.Text = "Shift Date";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(295, 370);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(68, 16);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(294, 432);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(65, 16);
            this.lblEndTime.TabIndex = 8;
            this.lblEndTime.Text = "End Time";
            // 
            // AddShiftsForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1096, 658);
            this.Controls.Add(this.btnAddShift);
            this.Controls.Add(this.txtShiftName);
            this.Controls.Add(this.dtpShiftDate);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.lblShiftName);
            this.Controls.Add(this.lblShiftDate);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblEndTime);
            this.Name = "AddShiftsForm";
            this.Text = "Add Shift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

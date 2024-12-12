using System;
using System.Windows.Forms;

namespace Security_Management_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navigate to UserManagement form
            UserManagement userManagement = new UserManagement();
            userManagement.FormClosed += (s, args) => this.Show(); // Show Admin form after UserManagement is closed
            userManagement.Show();
            this.Hide(); // Hide Admin form while UserManagement is open
        }

       

        private void SystemLogs_button_Click(object sender, EventArgs e)
        {
            // Navigate to SystemLogs form
            SystemLogs systemLogs = new SystemLogs();
            systemLogs.FormClosed += (s, args) => this.Show(); // Show Admin form after SystemLogs is closed
            systemLogs.Show();
            this.Hide(); // Hide Admin form while SystemLogs is open
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}

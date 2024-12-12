using System;
using System.Windows.Forms;
using static Mysqlx.Error.Types;

namespace Security_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Event handler for Admin button click
        private void adminButton_Click(object sender, EventArgs e)
        {
            // Open the Admin Login Form
            AdminLoginForm adminLoginForm = new AdminLoginForm("Admin");
            adminLoginForm.FormClosed += (s, args) => this.Show();
            adminLoginForm.Show();
            this.Hide();
        }

        // Event handler for Manager button click
        private void managerButton_Click(object sender, EventArgs e)
        {
            // Open the Manager Login Form
            ManagerLoginForm managerLoginForm = new ManagerLoginForm("Manager");
            managerLoginForm.FormClosed += (s, args) => this.Show();
            managerLoginForm.Show();
            this.Hide();
        }

        // Event handler for Security Officer button click
        private void officerButton_Click(object sender, EventArgs e)
        {
            // Open the Security Officer Login Form
            SecurityLoginForm officerLoginForm = new SecurityLoginForm("Security Officer");

            officerLoginForm.FormClosed += (s, args) => this.Show();
            officerLoginForm.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

namespace Security_Management_System
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }
        private string userType;

        public AdminLoginForm(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            // Simple validation
            if (userType == "Admin" && username == "admin" && password == "admin123")
            {
                MessageBox.Show("Admin Login Successful!");
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

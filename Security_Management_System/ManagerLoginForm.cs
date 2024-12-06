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
    public partial class ManagerLoginForm : Form
    {
        public ManagerLoginForm()
        {
            InitializeComponent();
        }

        private void ManagerLoginForm_Load(object sender, EventArgs e)
        {

        }
        private string userType;

        public ManagerLoginForm(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            if (userType == "Manager" && username == "manager" && password == "manager123")
            {
                Manager manager = new Manager();
                manager.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }
    }
}

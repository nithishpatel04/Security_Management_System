using System;
using System.Windows.Forms;

namespace Security_Management_System
{
    public partial class SecurityLoginForm : Form
    {
        public SecurityLoginForm()
        {
            InitializeComponent();
        }

        private void SecurityLoginForm_Load(object sender, EventArgs e)
        {

        }
        private string userType;

        public SecurityLoginForm(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            if (userType == "Security Officer" && username == "officer" && password == "officer123")
            {
                MessageBox.Show("Security Officer Login Successful!");
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }
    }
}

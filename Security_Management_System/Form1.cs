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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminButton_Click_Click(object sender, EventArgs e)
        {
            AdminLoginForm loginForm = new AdminLoginForm("Admin");
            loginForm.Show();
        }

        private void managerButton_Click_Click(object sender, EventArgs e)
        {
            ManagerLoginForm loginForm2 = new ManagerLoginForm("Manager");
            loginForm2.Show();
        }

        private void officerButton_Click(object sender, EventArgs e)
        {
            SecurityLoginForm loginForm3 = new SecurityLoginForm("Security Officer");
            loginForm3.Show();
        }
    }
}

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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void SystemLogs_button_Click(object sender, EventArgs e)
        {
            SystemLogs systemLogs = new SystemLogs();
            systemLogs.Show();
        }

        private void Settings_button_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}

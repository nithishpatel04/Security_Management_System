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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Add_user add_User = new Add_user();
            add_User.Show();

        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            Edit_User edit_User = new Edit_User();
            edit_User.Show();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Delete_User delete_User = new Delete_User();
            delete_User.Show();
        }

        private void Assign_button_Click(object sender, EventArgs e)
        {
            Assign_Roles assign_Roles = new Assign_Roles();
            assign_Roles.Show();
        }
    }
}

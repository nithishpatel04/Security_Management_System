using System;
using System.Windows.Forms;

namespace Security_Management_System
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the Security Reports window
            View_Security_Reports view_Security_Reports = new View_Security_Reports();
            view_Security_Reports.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show the Add Shifts window
            AddShiftsForm addShiftsForm = new AddShiftsForm();
            addShiftsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show the Assign Shifts window
            AssignShifts assignShiftsForm = new AssignShifts();
            assignShiftsForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Label click event, can be used to add functionality
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // Perform any operations when the form is loaded
        }
    }
}

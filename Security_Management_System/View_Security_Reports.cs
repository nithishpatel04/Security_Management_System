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
    public partial class View_Security_Reports : Form
    {
        public View_Security_Reports()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Security_Reports_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Report Id", typeof(int));         // Integer column
            table.Columns.Add("Type Of Incident", typeof(string)); // String column
            table.Columns.Add("Location", typeof(string));       // String column
            table.Columns.Add("Date", typeof(DateTime));         // DateTime column

            table.Rows.Add(1, "Fire", "Warehouse A", DateTime.Now);
            table.Rows.Add(2, "Break-in", "Office B", DateTime.Now);

            dataGridView1.DataSource = table;

        }
    }
}

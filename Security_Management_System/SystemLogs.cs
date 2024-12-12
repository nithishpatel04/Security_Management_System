using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Security_Management_System
{
    public partial class SystemLogs : Form
    {
        public SystemLogs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fetch and display logs when the button is clicked
            LoadSystemLogs();
        }

        private void LoadSystemLogs()
        {
            string query = "SELECT * FROM system_logs ORDER BY log_time DESC"; // Adjust table name and columns as per your schema

            try
            {
                DatabaseHelper.Instance.OpenConnection();

                // Fetch logs
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseHelper.Instance.Connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable logsTable = new DataTable();
                    adapter.Fill(logsTable);

                    // Bind logs to DataGridView
                    dataGridView1.DataSource = logsTable; // Ensure you have added a DataGridView to the form and named it "dataGridView1"
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs: " + ex.Message);
            }
            finally
            {
                DatabaseHelper.Instance.CloseConnection();
            }
        }
    }
}
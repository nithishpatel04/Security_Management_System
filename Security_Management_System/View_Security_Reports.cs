using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Security_Management_System
{
    public partial class View_Security_Reports : Form
    {
        public View_Security_Reports()
        {
            InitializeComponent();
        }

        private void View_Security_Reports_Load(object sender, EventArgs e)
        {
            string query = "SELECT IncidentId, IncidentType, IncidentDescription, IncidentDate, Username FROM incidentreports";

            try
            {
                DatabaseHelper.Instance.OpenConnection();

                // Create a MySqlDataAdapter to execute the query and set the DataGridView's DataSource directly
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.Connection))
                {
                    // Directly set the DataSource to the result of the adapter
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                DatabaseHelper.Instance.CloseConnection();
            }
        }
    }
}
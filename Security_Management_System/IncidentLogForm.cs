using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  // Import the MySQL Data namespace

namespace Security_Management_System
{
    public partial class IncidentLogForm : Form
    {
        // Username of the person submitting the report
        private string currentUsername;

        public IncidentLogForm(string username)
        {
            InitializeComponent();
            this.currentUsername = username;  // Store the username of the logged-in user
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close the current form (Back button)
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Submit the incident report

            string incidentType = textBox1.Text; // Get the incident type from the textbox
            string incidentDescription = textBox2.Text; // Get the incident description from the textbox

            if (string.IsNullOrEmpty(incidentType) || string.IsNullOrEmpty(incidentDescription))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Call the method to insert the incident into the database
            if (InsertIncident(incidentType, incidentDescription, currentUsername))
            {
                MessageBox.Show("Incident report submitted successfully.");
                this.Close(); // Close the form after successful submission
            }
            else
            {
                MessageBox.Show("An error occurred while submitting the report.");
            }
        }

        private bool InsertIncident(string incidentType, string incidentDescription, string username)
        {
            bool isSuccess = false;

            // SQL query to insert the incident into the database
            string query = "INSERT INTO IncidentReports (IncidentType, IncidentDescription, Username) VALUES (@IncidentType, @IncidentDescription, @Username)";

            try
            {
                DatabaseHelper.Instance.OpenConnection();

                // Create a MySqlCommand to execute the query
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseHelper.Instance.Connection))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@IncidentType", incidentType);
                    cmd.Parameters.AddWithValue("@IncidentDescription", incidentDescription);
                    cmd.Parameters.AddWithValue("@Username", username);

                    // Execute the query and check if it was successful
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
            }
            finally
            {
                DatabaseHelper.Instance.CloseConnection();
            }

            return isSuccess;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Incident type (optional handling if needed)
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Incident description (optional handling if needed)
        }

        private void IncidentLogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
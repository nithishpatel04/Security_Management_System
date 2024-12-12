using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Security_Management_System
{
    public partial class ManagerLoginForm : Form
    {
        private string userType;

        // Constructor accepting userType
        public ManagerLoginForm(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void ManagerLoginForm_Load(object sender, EventArgs e)
        {

        }

        // Login button click event
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            // Check if the fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Call the database to check for valid credentials
            if (ValidateLogin(username, password))
            {
                // If credentials are valid, show the Manager form
                Manager manager = new Manager();
                manager.Show();
                this.Hide();
            }
            else
            {
                // If credentials are invalid, show an error message
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        // Method to validate login against the manager table in the database
        private bool ValidateLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM manager WHERE Username = @Username AND Password = @Password";

            try
            {
                DatabaseHelper.Instance.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseHelper.Instance.Connection))
                {
                    // Add parameters to the query to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int result = Convert.ToInt32(cmd.ExecuteScalar()); // Execute query and get the result

                    // If the count is greater than 0, credentials are valid
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while validating login: " + ex.Message);
                return false;
            }
            finally
            {
                DatabaseHelper.Instance.CloseConnection();
            }
        }

        // Back button click event
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the login form
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle text changed event for username
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle text changed event for password
        }
    }
}
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Security_Management_System
{
    public partial class SecurityLoginForm : Form
    {
        private string userType;

        public SecurityLoginForm()
        {
            InitializeComponent();
        }

        public SecurityLoginForm(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            // Call the method to check credentials from MySQL
            if (CheckLoginCredentials(username, password, userType))
            {
                // If credentials are valid, show the appropriate form
                Security security = new Security(username);
                security.FormClosed += (s, args) => this.Show();
                security.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        // This method checks login credentials from the database
        private bool CheckLoginCredentials(string username, string password, string userType)
        {
            bool isValid = false;

            // SQL query to check if the credentials match
            string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";

            try
            {
                DatabaseHelper.Instance.OpenConnection();

                // Create a MySqlCommand to execute the query
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseHelper.Instance.Connection))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Execute the query and get the result
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // If userCount is greater than 0, credentials are valid
                    if (userCount > 0)
                    {
                        isValid = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Display any connection errors
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
            }
            finally
            {
                DatabaseHelper.Instance.CloseConnection();
            }

            return isValid;
        }

        // Close the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Form Load event (optional, not needed for this example)
        private void SecurityLoginForm_Load(object sender, EventArgs e)
        {
            // This could be used to initialize anything when the form loads, if needed.
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
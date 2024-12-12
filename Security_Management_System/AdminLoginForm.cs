using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Security_Management_System
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private string userType;

        public AdminLoginForm(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text.Trim(); // Trim any extra spaces
            string password = passwordTextbox.Text.Trim(); // Trim any extra spaces

            // Validate credentials against database
            if (ValidateAdminCredentials(username, password))
            {
                Admin admin = new Admin();
                admin.FormClosed += (s, args) => this.Show();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        private bool ValidateAdminCredentials(string username, string password)
        {
            // SQL query to check if the credentials match
            string query = "SELECT COUNT(1) FROM admin WHERE Username = @username AND Password = @password";

            try
            {
                DatabaseHelper.Instance.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseHelper.Instance.Connection))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Execute the query and get the result
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Return true if credentials are valid
                    return userCount > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while connecting to the database: " + ex.Message);
                return false;
            }
            finally
            {
                DatabaseHelper.Instance.CloseConnection();
            }
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            // Any load operations if needed
        }
    }
}
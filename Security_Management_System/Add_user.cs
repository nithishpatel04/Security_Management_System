using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Security_Management_System
{
    public partial class Add_user : Form
    {
        public Add_user()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Back button - Close the form
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string username = textBox1.Text.Trim(); // Username
            string password = textBox2.Text.Trim(); // Password
            string email = textBox4.Text.Trim();    // Email
            string phoneNumber = textBox6.Text.Trim(); // Phone Number
            string role = textBox7.Text.Trim().ToLower(); // Role (converted to lowercase)

            // Validate fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            // Check role and insert data into the appropriate table
            if (role == "manager")
            {
                AddToManagerTable(username, password, email, phoneNumber);
            }
            else if (role == "officer")
            {
                AddToUsersTable(username, password, email, phoneNumber);
            }
            else
            {
                MessageBox.Show("Invalid role! Role must be either 'manager' or 'officer'.");
            }
        }

        private void AddToManagerTable(string username, string password, string email, string phoneNumber)
        {
            string connectionString = "Server=localhost;Database=SecurityManagement;Uid=root;Pwd=Pranopasha@7;";
            string query = "INSERT INTO manager (Username, Password, Email, PhoneNumber) VALUES (@Username, @Password, @Email, @PhoneNumber)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Prevent SQL injection
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        
                        // Execute query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Manager added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add manager.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding manager: " + ex.Message);
                }
            }
        }

        private void AddToUsersTable(string username, string password, string email, string phoneNumber)
        {
            string connectionString = "Server=localhost;Database=SecurityManagement;Uid=root;Pwd=Pranopasha@7;";
            string query = "INSERT INTO users (Username, Password, Email, PhoneNumber) VALUES (@Username, @Password, @Email, @PhoneNumber)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Prevent SQL injection
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        // Execute query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Officer added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add officer.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding officer: " + ex.Message);
                }
            }
        }

        private void Add_user_Load(object sender, EventArgs e)
        {

        }
    }
}

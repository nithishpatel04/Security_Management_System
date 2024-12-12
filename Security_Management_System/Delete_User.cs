using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Security_Management_System
{
    public partial class Delete_User : Form
    {
        public Delete_User()
        {
            InitializeComponent();
        }

        // Back button - Close the form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        // Delete button functionality
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim(); // Username entered

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            // Try to delete from the manager table first
            bool managerDeleted = DeleteFromManagerTable(username);
            // Then try to delete from the users table if not found in manager table
            if (!managerDeleted)
            {
                DeleteFromUsersTable(username);
            }
        }

        // Method to delete from the manager table
        private bool DeleteFromManagerTable(string username)
        {
            string connectionString = "Server=localhost;Database=SecurityManagement;Uid=root;Pwd=Pranopasha@7;";
            string query = "DELETE FROM manager WHERE Username = @Username";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Manager deleted successfully.");
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting manager: " + ex.Message);
                }
            }
            return false; // Return false if no manager was deleted
        }

        // Method to delete from the users table
        private void DeleteFromUsersTable(string username)
        {
            string connectionString = "Server=localhost;Database=SecurityManagement;Uid=root;Pwd=Pranopasha@7;";
            string query = "DELETE FROM users WHERE Username = @Username";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Officer deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("User not found in the system.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting officer: " + ex.Message);
                }
            }
        }
    }
}

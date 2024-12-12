using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Ensure you have this namespace for MySQL

namespace Security_Management_System
{
    public partial class Security : Form
    {
        private string username;

        public Security(String username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open the incident form
            IncidentLogForm incidentLogForm = new IncidentLogForm(username);
            incidentLogForm.FormClosed += (s, args) => this.Show();
            incidentLogForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create checkboxes for each day
            CheckBox mondayCheckbox = new CheckBox { Text = "Monday", Location = new Point(20, 100) };
            CheckBox tuesdayCheckbox = new CheckBox { Text = "Tuesday", Location = new Point(20, 130) };
            CheckBox wednesdayCheckbox = new CheckBox { Text = "Wednesday", Location = new Point(20, 160) };
            CheckBox thursdayCheckbox = new CheckBox { Text = "Thursday", Location = new Point(20, 190) };
            CheckBox fridayCheckbox = new CheckBox { Text = "Friday", Location = new Point(20, 220) };
            CheckBox saturdayCheckbox = new CheckBox { Text = "Saturday", Location = new Point(20, 250) };
            CheckBox sundayCheckbox = new CheckBox { Text = "Sunday", Location = new Point(20, 280) };

            // Add checkboxes to the form
            this.Controls.Add(mondayCheckbox);
            this.Controls.Add(tuesdayCheckbox);
            this.Controls.Add(wednesdayCheckbox);
            this.Controls.Add(thursdayCheckbox);
            this.Controls.Add(fridayCheckbox);
            this.Controls.Add(saturdayCheckbox);
            this.Controls.Add(sundayCheckbox);

            // Add a submit button
            Button submitButton = new Button
            {
                Text = "Submit Availability",
                Location = new Point(20, 310)
            };
            submitButton.Click += (s, args) => SubmitAvailability(mondayCheckbox, tuesdayCheckbox, wednesdayCheckbox, thursdayCheckbox, fridayCheckbox, saturdayCheckbox, sundayCheckbox);
            this.Controls.Add(submitButton);
        }

        private void SubmitAvailability(CheckBox monday, CheckBox tuesday, CheckBox wednesday, CheckBox thursday, CheckBox friday, CheckBox saturday, CheckBox sunday)
        {
            try
            {
                // Create a list to store selected days
                var selectedDays = new List<string>();

                if (monday.Checked) selectedDays.Add("Monday");
                if (tuesday.Checked) selectedDays.Add("Tuesday");
                if (wednesday.Checked) selectedDays.Add("Wednesday");
                if (thursday.Checked) selectedDays.Add("Thursday");
                if (friday.Checked) selectedDays.Add("Friday");
                if (saturday.Checked) selectedDays.Add("Saturday");
                if (sunday.Checked) selectedDays.Add("Sunday");

                // Check if any day is selected
                if (selectedDays.Count == 0)
                {
                    MessageBox.Show("Please select at least one day.");
                    return; // Don't proceed with database insertion if no day is selected
                }

                // Save each selected day to the database
                foreach (var day in selectedDays)
                {
                    SaveAvailability(username, day);
                }

                // Close the form after saving availability
                this.Close();

                MessageBox.Show("Availability updated successfully.");
            }
            catch (Exception ex)
            {
                // Handle the exception and display error message
                MessageBox.Show("Error while saving availability: " + ex.Message);
            }
        }

        private void SaveAvailability(string username, string selectedDay)
        {
            string query = "INSERT INTO Availability (Username, Day) VALUES (@Username, @Day)";

            try
            {
                DatabaseHelper.Instance.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseHelper.Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Day", selectedDay);

                    // Execute the query to insert data into the Availability table
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving availability to database: " + ex.Message);
            }
            finally
            {
                DatabaseHelper.Instance.CloseConnection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close the form when clicking the Close button
            this.Close();
        }

        private void Security_Load(object sender, EventArgs e)
        {

        }
    }
}
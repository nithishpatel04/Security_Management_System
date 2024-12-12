using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Security_Management_System
{
    public partial class AssignShifts : Form
    {
        public AssignShifts()
        {
            InitializeComponent();
        }

        private void AssignShifts_Load(object sender, EventArgs e)
        {
            LoadShifts();
        }

        private void LoadShifts()
        {
            string query = "SELECT ShiftID, ShiftName FROM Shifts";

            try
            {
                DatabaseHelper.Instance.OpenConnection();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.Connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboShift.DisplayMember = "ShiftName";
                    comboShift.ValueMember = "ShiftID";
                    comboShift.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading shifts: " + ex.Message);
            }
            finally
            {
                DatabaseHelper.Instance.CloseConnection();
            }
        }

        private void btnAssignShift_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            int shiftID = Convert.ToInt32(comboShift.SelectedValue);

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            AssignShiftToUser(username, shiftID);
        }

        private void AssignShiftToUser(string username, int shiftID)
        {
            string query = "INSERT INTO UserShifts (Username, ShiftID) VALUES (@Username, @ShiftID)";

            try
            {
                DatabaseHelper.Instance.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseHelper.Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@ShiftID", shiftID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Shift successfully assigned to " + username);
                    }
                    else
                    {
                        MessageBox.Show("Error assigning shift.");
                    }
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
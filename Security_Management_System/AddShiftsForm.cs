using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Security_Management_System
{
    public partial class AddShiftsForm : Form
    {
        public AddShiftsForm()
        {
            InitializeComponent();
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            string shiftName = txtShiftName.Text;
            DateTime shiftDate = dtpShiftDate.Value;
            TimeSpan shiftStartTime = dtpStartTime.Value.TimeOfDay;
            TimeSpan shiftEndTime = dtpEndTime.Value.TimeOfDay;

            if (string.IsNullOrEmpty(shiftName))
            {
                MessageBox.Show("Please provide a valid shift name.");
                return;
            }

            if (InsertShift(shiftName, shiftDate, shiftStartTime, shiftEndTime))
            {
                MessageBox.Show("Shift added successfully!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("An error occurred while adding the shift.");
            }
        }

        private bool InsertShift(string shiftName, DateTime shiftDate, TimeSpan shiftStartTime, TimeSpan shiftEndTime)
        {
            bool isSuccess = false;

            string query = "INSERT INTO Shifts (ShiftName, ShiftDate, StartTime, EndTime) VALUES (@ShiftName, @ShiftDate, @StartTime, @EndTime)";

            try
            {
                DatabaseHelper.Instance.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseHelper.Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@ShiftName", shiftName);
                    cmd.Parameters.AddWithValue("@ShiftDate", shiftDate);
                    cmd.Parameters.AddWithValue("@StartTime", shiftStartTime);
                    cmd.Parameters.AddWithValue("@EndTime", shiftEndTime);

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

        private void ClearFields()
        {
            txtShiftName.Clear();
            dtpShiftDate.Value = DateTime.Now;
            dtpStartTime.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now;
        }
    }
}
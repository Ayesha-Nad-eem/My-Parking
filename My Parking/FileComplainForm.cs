using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using My_Parking.Helper;

namespace My_Parking
{
    public partial class FileComplainForm : Form
    {
        public FileComplainForm()
        {
            InitializeComponent();
        }

        private void btn_submitComplain_Click(object sender, EventArgs e)
        {
            int userId = UserSession.UserId;
            string complaintDescription = txt_complainDescription.Text.Trim();

            if (string.IsNullOrEmpty(complaintDescription))
            {
                MessageBox.Show("Please enter a complaint description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save complaint to the database
            bool isSaved = SaveComplaintToDatabase(userId, complaintDescription);

            if (isSaved)
            {
                txt_complainDescription.Text = string.Empty;
                MessageBox.Show("Complaint submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to submit the complaint. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveComplaintToDatabase(int userId, string description)
        {
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Complaints (UserId, Description, Status) VALUES (@UserId, @Description, 'Pending')";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@Description", description);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if the insert was successful
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or display it for debugging
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FileComplainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

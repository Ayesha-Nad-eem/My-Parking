using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Parking
{
    public partial class AddPaymentForm : Form
    {
        public AddPaymentForm()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_userID.Text = "";
            txt_parkingAreaID.Text = "";
            combo_paymentMethod.SelectedItem = "";
            txt_amount.Text = "";
            combo_status.SelectedItem = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Retrieve input values from the form
            int userId = int.Parse(txt_userID.Text); // User ID
            int parkingAreaId = int.Parse(txt_parkingAreaID.Text); // Parking Area ID
            decimal amount = decimal.Parse(txt_amount.Text); // Amount
            string paymentMethod = combo_paymentMethod.SelectedItem.ToString(); // Payment Method
            string status = combo_status.SelectedItem.ToString(); // Payment Status

            // Connection string (update with your database details)
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            // SQL query to check if UserID and ParkingAreaID exist
            string validationQuery = "SELECT COUNT(1) FROM UserAccount WHERE ID = @UserID; " +
                                     "SELECT COUNT(1) FROM ParkingAreas WHERE ID = @ParkingAreaID;";

            // SQL query to insert data into Payments table
            string insertQuery = "INSERT INTO Payments (UserID, ParkingAreaID, Amount, PaymentMethod, Status, Date) " +
                                 "VALUES (@UserID, @ParkingAreaID, @Amount, @PaymentMethod, @Status, GETDATE())";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Validation check
                    using (SqlCommand validateCommand = new SqlCommand(validationQuery, connection))
                    {
                        validateCommand.Parameters.AddWithValue("@UserID", userId);
                        validateCommand.Parameters.AddWithValue("@ParkingAreaID", parkingAreaId);

                        using (SqlDataReader reader = validateCommand.ExecuteReader())
                        {
                            // Check if UserID exists
                            reader.Read();
                            int userExists = reader.GetInt32(0);

                            // Move to the next result set for ParkingAreaID check
                            reader.NextResult();
                            reader.Read();
                            int parkingAreaExists = reader.GetInt32(0);

                            if (userExists == 0)
                            {
                                MessageBox.Show("User ID does not exist. Please enter a valid User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (parkingAreaExists == 0)
                            {
                                MessageBox.Show("Parking Area ID does not exist. Please enter a valid Parking Area ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // Insert payment if validation is successful
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@UserID", userId);
                        insertCommand.Parameters.AddWithValue("@ParkingAreaID", parkingAreaId);
                        insertCommand.Parameters.AddWithValue("@Amount", amount);
                        insertCommand.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        insertCommand.Parameters.AddWithValue("@Status", status);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txt_parkingAreaID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

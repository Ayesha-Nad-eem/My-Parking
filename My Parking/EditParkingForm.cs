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
    public partial class EditParkingForm : Form
    {
        public EditParkingForm()
        {
            InitializeComponent();
        }

        private void btn_saveEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ID.Text) ||
                string.IsNullOrWhiteSpace(txt_latitude.Text) ||
                string.IsNullOrWhiteSpace(txt_longitude.Text) ||
                string.IsNullOrWhiteSpace(txt_locationName.Text) ||
                string.IsNullOrWhiteSpace(txt_slots.Text) ||
                string.IsNullOrWhiteSpace(txt_price.Text))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ParkingAreas SET Latitude = @latitude, Longitude = @longitude, LocationName = @location, Slots = @slot, Price = @price WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters
                command.Parameters.AddWithValue("@ID", txt_ID.Text);
                command.Parameters.AddWithValue("@latitude", txt_latitude.Text);
                command.Parameters.AddWithValue("@longitude", txt_longitude.Text);
                command.Parameters.AddWithValue("@location", txt_locationName.Text);
                command.Parameters.AddWithValue("@slot", txt_slots.Text);
                command.Parameters.AddWithValue("@price", txt_price.Text);

                try
                {
                    connection.Open();

                    // Execute the query and get the number of affected rows
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Parking Area updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No Parking Area found with the provided ID. Please check the ID and try again.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle potential errors (e.g., database issues)
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_latitude.Text = "";
            txt_longitude.Text = "";
            txt_locationName.Text = "";
            txt_slots.Text = "";
            txt_price.Text = "";
        }
    }
}

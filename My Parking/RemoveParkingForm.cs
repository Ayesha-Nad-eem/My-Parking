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
    public partial class RemoveParkingForm : Form
    {
        public RemoveParkingForm()
        {
            InitializeComponent();
        }

        private void RemoveParkingForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ParkingAreas";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewParkings.DataSource = dataTable; // Assuming you have a DataGridView named dataGridViewUsers
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ParkingAreas WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameter for ID
                command.Parameters.AddWithValue("@ID", txt_ID.Text);

                try
                {
                    connection.Open();

                    // Execute the query and check affected rows
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Parking Area Removed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No Parking Area found with the provided ID. Please check and try again.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle potential errors (e.g., database connection issues)
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}

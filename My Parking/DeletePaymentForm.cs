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
    public partial class DeletePaymentForm : Form
    {
        public DeletePaymentForm()
        {
            InitializeComponent();
        }

        private void DeletePaymentForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Payments";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewPayments.DataSource = dataTable; // Assuming you have a DataGridView named dataGridViewUsers
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Payments WHERE ID = @ID";
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
                        MessageBox.Show("Payment deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No Payment found with the provided ID. Please check and try again.");
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

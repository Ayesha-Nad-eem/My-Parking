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
using My_Parking.Helper;

namespace My_Parking
{
    public partial class BookParkingForm : Form
    {
        public BookParkingForm()
        {
            InitializeComponent();
        }

        private void btn_confirmBooking_Click(object sender, EventArgs e)
        {
            int parkingAreaID;
            if (int.TryParse(txt_ID.Text, out parkingAreaID))
            {
                ParkingArea.ParkingAreaId = parkingAreaID;
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Exit the method if the ID is invalid
            }

            // Ensure that MdiParent is of type UserForm
            if (this.MdiParent is UserForm userForm)
            {
                UserPaymentForm upf = new UserPaymentForm(); // Add parameters if needed in the constructor
                userForm.LoadFormInPanel(upf);  // Use the MDI parent's method to load the form
            }
            else
            {
                MessageBox.Show("Invalid MDI Parent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BookParkingForm_Load(object sender, EventArgs e)
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
    }
}

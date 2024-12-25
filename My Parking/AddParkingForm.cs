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
    public partial class AddParkingForm : Form
    {
        public AddParkingForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (/*string.IsNullOrWhiteSpace(txt_ID.Text) ||*/
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
                string query = "INSERT INTO ParkingAreas ( Latitude, Longitude, LocationName, Slots, Price) VALUES ( @lat, @long, @location, @slot, @price)";
                SqlCommand command = new SqlCommand(query, connection);

                //command.Parameters.AddWithValue("@id", txt_ID.Text);
                command.Parameters.AddWithValue("@lat", txt_latitude.Text);
                command.Parameters.AddWithValue("@long", txt_longitude.Text);
                command.Parameters.AddWithValue("@location", txt_locationName.Text);
                command.Parameters.AddWithValue("@slot", txt_slots.Text);
                command.Parameters.AddWithValue("@price", txt_price.Text);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Parking Area added successfully!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_latitude.Text = "";
            txt_longitude.Text = "";
            txt_locationName.Text = "";
            txt_slots.Text = "";
            txt_price.Text = "";
        }

        private void txt_latitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddParkingForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class UserPaymentForm : Form
    {
        public UserPaymentForm()
        {
            InitializeComponent();
            this.parkingAreaId = ParkingArea.ParkingAreaId;  // Parking area ID passed from the booking form
            this.userId = UserSession.UserId;
        }
        private int parkingAreaId;
        private int userId;
        private decimal parkingPrice;
        private void UserPaymentForm_Load(object sender, EventArgs e)
        {
            FetchParkingPrice();
        }
        private void FetchParkingPrice()
        {
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Price FROM ParkingAreas WHERE ID = @parkingAreaId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@parkingAreaId", parkingAreaId);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    parkingPrice = Convert.ToDecimal(result);
                    lbl_amount.Text = $"Amount: ${parkingPrice}";  // Display the amount on the form
                }
                else
                {
                    MessageBox.Show("Error fetching parking price.");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_paymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            // Store the payment details in the database
            StorePaymentDetails();
            UserForm uf = new UserForm();
            uf.Show();
            this.Hide();
            uf.FormClosed += (s, args) => this.Close();
        }
        private void StorePaymentDetails()
        {
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Insert the payment record into the Payments table
                string query = "INSERT INTO Payments (UserID, ParkingAreaID, Amount, PaymentMethod) VALUES (@userId, @parkingAreaId, @amount, @paymentMethod)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@parkingAreaId", parkingAreaId);
                cmd.Parameters.AddWithValue("@paymentMethod", cmb_paymentMethod.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@amount", parkingPrice);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Payment Successful.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Close the payment form and show confirmation
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error processing payment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

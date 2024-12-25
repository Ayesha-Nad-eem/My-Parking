using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace My_Parking
{
    public partial class SignupForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_ph.Text))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connection string (Update with your database details)
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL Insert Command
                    string query = "INSERT INTO UserAccount (UserName, Password, Email, PhoneNumber) VALUES (@UserName, @Password, @Email, @PhoneNumber)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL Injection
                        command.Parameters.AddWithValue("@UserName", txt_username.Text);
                        command.Parameters.AddWithValue("@Password", txt_password.Text); // Consider hashing the password
                        command.Parameters.AddWithValue("@Email", txt_email.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", txt_ph.Text);

                        // Execute the query
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UserForm uf = new UserForm();
                            uf.Show();
                            this.Hide();
                            uf.FormClosed += (s, args) => this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sign up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = checkbox.Checked ? '\0' : '*';
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ph_Click(object sender, EventArgs e)
        {

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            btn_signup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_signup.Width, btn_signup.Height, 30, 30));
            signup_panel.BackColor = Color.FromArgb(150, 128, 128, 128);
        }
    }
}
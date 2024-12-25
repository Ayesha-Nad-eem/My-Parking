using System;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using My_Parking.Helper;

namespace My_Parking
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check Admin Account
                    string queryAdmin = "SELECT COUNT(*) FROM AdminAccount WHERE Name=@username AND Password=@password";
                    using (SqlCommand cmdAdmin = new SqlCommand(queryAdmin, con))
                    {
                        cmdAdmin.Parameters.AddWithValue("@username", txt_username.Text);
                        cmdAdmin.Parameters.AddWithValue("@password", txt_password.Text);
                        int countAdmin = (int)cmdAdmin.ExecuteScalar();

                        if (countAdmin > 0)
                        {
                            // Admin Login Successful
                            WelcomeForm wf = new WelcomeForm();
                            wf.Show();
                            this.Hide();
                            wf.FormClosed += (s, args) => this.Close();
                            return;
                        }
                    }

                    // Check User Account
                    string queryUser = "SELECT Id FROM UserAccount WHERE UserName=@username AND Password=@password";
                    using (SqlCommand cmdUser = new SqlCommand(queryUser, con))
                    {
                        cmdUser.Parameters.AddWithValue("@username", txt_username.Text);
                        cmdUser.Parameters.AddWithValue("@password", txt_password.Text);

                        object result = cmdUser.ExecuteScalar();

                        if (result != null) // If user exists
                        {
                            // Store UserId in UserSession
                            UserSession.UserId = Convert.ToInt32(result);

                            // User Login Successful
                            UserForm uf = new UserForm();
                            uf.Show();
                            this.Hide();
                            uf.FormClosed += (s, args) => this.Close();
                            return;
                        }
                    }

                    // If no valid user is found
                    MessageBox.Show("Error: Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        MessageBox.Show("Connection Successful!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Connection Failed: {ex.Message}");
            //    }
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SignupForm sf = new SignupForm();
            sf.Show();
            this.Hide();
            sf.FormClosed += (s, args) => this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login_panel.BackColor = Color.FromArgb(200, 128, 128, 128);
            btn_login.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_login.Width, btn_login.Height, 30, 30));

        }

        private void lable_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm sf = new SignupForm();
            sf.Show();
            this.Hide();
            sf.FormClosed += (s, args) => this.Close();
        }
    }
}
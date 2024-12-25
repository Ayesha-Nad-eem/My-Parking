using System;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            con.Open();
            string query = "SELECT COUNT(*) FROM UserAccount WHERE UserName=@username AND Password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);
            int countB = (int)cmd.ExecuteScalar();
            string query1 = "SELECT COUNT(*) FROM AdminAccount WHERE Name=@username AND Password=@password";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.Parameters.AddWithValue("@username", txt_username.Text);
            cmd1.Parameters.AddWithValue("@password", txt_password.Text);
            int countA = (int)cmd1.ExecuteScalar();

            con.Close();
            try
            {
                if (txt_username.Text != null && txt_password.Text != null)
                {
                    if (countA > 0)
                    {
                        // MessageBox.Show("Login success", "info", MessageBoxButtons.OK);
                        WelcomeForm wf = new WelcomeForm();
                        wf.Show();
                        this.Hide();
                        wf.FormClosed += (s, args) => this.Close();
                    }
                    else if (countB > 0)
                    {
                        // MessageBox.Show("Login success", "info", MessageBoxButtons.OK);
                        UserForm uf = new UserForm();
                        uf.Show();
                        this.Hide();
                        uf.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password not entered, try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
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
    }
}
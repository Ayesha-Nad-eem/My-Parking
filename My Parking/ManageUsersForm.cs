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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }
        private void ShowPanel(Panel panelToShow)
        {
            // Hide all panels
            panelDefault.Visible = false;
            panelView.Visible = false;
            panelAdd.Visible = false;
            panelEdit.Visible = false;
            panelDelete.Visible = false;

            // Show the selected panel
            panelToShow.Visible = true;
        }
        private void btn_view_Click(object sender, EventArgs e)
        {
            ShowPanel(panelView);
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM UserAccount";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewUser.DataSource = dataTable; // Assuming you have a DataGridView named dataGridViewUsers
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ShowPanel(panelAdd);
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            ShowPanel(panelDefault);
        }

        private void panelAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UserAccount (UserName, Password, Email, PhoneNumber) VALUES (@username, @Password, @Email, @PhoneNumber)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@username", txt_username.Text);
                command.Parameters.AddWithValue("@Password", txt_password.Text);
                command.Parameters.AddWithValue("@Email", txt_email.Text);
                command.Parameters.AddWithValue("@PhoneNumber", txt_ph.Text);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("User added successfully!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
            txt_email.Text = "";
            txt_ph.Text = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ShowPanel(panelEdit);
        }

        private void btn_saveedit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE UserAccount SET UserName = @username, Password = @Password, Email = @Email, PhoneNumber = @PhoneNumber WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters
                command.Parameters.AddWithValue("@ID", txt_IDedit.Text);
                command.Parameters.AddWithValue("@username", txt_nameedit.Text);
                command.Parameters.AddWithValue("@Password", txt_passedit.Text);
                command.Parameters.AddWithValue("@Email", txt_emailedit.Text);
                command.Parameters.AddWithValue("@PhoneNumber", txt_phoneedit.Text);

                try
                {
                    connection.Open();

                    // Execute the query and get the number of affected rows
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No user found with the provided ID. Please check the ID and try again.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle potential errors (e.g., database issues)
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        private void btn_clearedit_Click(object sender, EventArgs e)
        {
            txt_IDedit.Text = "";
            txt_nameedit.Text = "";
            txt_passedit.Text = "";
            txt_emailedit.Text = "";
            txt_phoneedit.Text = "";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            ShowPanel(panelDelete);
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM UserAccount";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewDelete.DataSource = dataTable; // Assuming you have a DataGridView named dataGridViewUsers
            }
        }

        private void panelDelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_confirmdel_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM UserAccount WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameter for ID
                command.Parameters.AddWithValue("@ID", txt_IDdelete.Text);

                try
                {
                    connection.Open();

                    // Execute the query and check affected rows
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No user found with the provided ID. Please check and try again.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle potential errors (e.g., database connection issues)
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            WelcomeForm uf = new WelcomeForm();
            uf.Show();
            this.Hide();
            uf.FormClosed += (s, args) => this.Close();
        }

        private void dataGridViewDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_IDdelete_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using Microsoft.Data.SqlClient;
using My_Parking.Helper;
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
    public partial class AccountSettingsForm : Form
    {
        public AccountSettingsForm()
        {
            InitializeComponent();
        }

        private void AccountSettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                {
                    con.Open();
                    string query = "SELECT UserName, Password, Email, PhoneNumber FROM UserAccount WHERE ID = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", UserSession.UserId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_username.Text = reader["UserName"].ToString();
                                txt_password.Text = reader["Password"].ToString();
                                txt_email.Text = reader["Email"].ToString();
                                txt_phone.Text = reader["PhoneNumber"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_saveEdits_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                {
                    con.Open();
                    string query = "UPDATE UserAccount SET UserName = @UserName, Password = @Password, Email = @Email, PhoneNumber = @Phone WHERE ID = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", UserSession.UserId);
                        cmd.Parameters.AddWithValue("@UserName", txt_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txt_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txt_phone.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating account details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Are you sure you want to delete your account? This action cannot be undone.",
       "Confirm Delete",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning
   );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                    {
                        con.Open();
                        string query = "DELETE FROM UserAccount WHERE ID = @UserId";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@UserId", UserSession.UserId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Your account has been deleted successfully.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Redirect to Login Form
                                this.Close();
                                Form1 loginForm = new Form1();
                                loginForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error: Unable to delete account. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace My_Parking
{
    public partial class UpdateComplainForm : Form
    {
        public UpdateComplainForm()
        {
            InitializeComponent();
        }

        private void UpdateComplainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_ID.Text))
            {
                MessageBox.Show("Complaint ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (combo_status.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse Complaint ID
            int complaintId;
            if (!int.TryParse(txt_ID.Text, out complaintId))
            {
                MessageBox.Show("Complaint ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newStatus = combo_status.SelectedItem.ToString();

            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Check if complaint exists
                    string checkQuery = "SELECT COUNT(*) FROM Complaints WHERE ID = @id";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@id", complaintId);

                        connection.Open();
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("No complaint found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Update the complaint status
                    string updateQuery = "UPDATE Complaints SET Status = @status WHERE ID = @id";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@status", newStatus);
                        updateCommand.Parameters.AddWithValue("@id", complaintId);

                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Complaint status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear input fields after successful update
                            txt_ID.Clear();
                            combo_status.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the complaint status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            combo_status.Text = "";
        }
    }
}

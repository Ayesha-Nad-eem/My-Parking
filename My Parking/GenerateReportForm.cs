using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Microsoft.Data.SqlClient;

namespace My_Parking
{
    public partial class GenerateReportForm : Form
    {
        public GenerateReportForm()
        {
            InitializeComponent();
        }

        private void GenerateReportForm_Load(object sender, EventArgs e)
        {

        }
        private void ExportToExcel(DataTable dt)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                // Add a worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Report");

                // Load data into the worksheet
                worksheet.Cells["A1"].LoadFromDataTable(dt, true);

                // Set file path
                string filePath = "D:\\Reports\\PaymentReport.xlsx";

                // Save the file
                FileInfo file = new FileInfo(filePath);
                package.SaveAs(file);

                MessageBox.Show($"Report saved to {filePath}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;
            string status = combo_status.SelectedItem.ToString();

            // Connection string (update with your database details)
            string connectionString = "Data Source=DESKTOP-DKF72OO\\SQLEXPRESS;Initial Catalog=ParkingManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


            // SQL query to fetch data based on selected filters
            string query = "SELECT p.ID, p.UserID, p.ParkingAreaID, p.Amount, p.PaymentMethod, p.Status, p.Date, " +
                           "u.UserName AS UserName, pa.LocationName AS ParkingAreaName " +
                           "FROM Payments p " +
                           "JOIN UserAccount u ON p.UserID = u.ID " +
                           "JOIN ParkingAreas pa ON p.ParkingAreaID = pa.ID " +
                           "WHERE p.Date BETWEEN @StartDate AND @EndDate " +
                           "AND p.Status = @Status " +
                           "ORDER BY p.Date DESC";

            // Create a DataTable to hold the data
            DataTable reportData = new DataTable();

            // Fetch data from database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    command.Parameters.AddWithValue("@Status", status);

                    // Fill the DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(reportData);
                }
            }

            // Display the data in a DataGridView (or another control)
            dataGridViewReport.DataSource = reportData;

            // Optionally, export to Excel or PDF (for example, using EPPlus for Excel)
            ExportToExcel(reportData);
        }
    }
}

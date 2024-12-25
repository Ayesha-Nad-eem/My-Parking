using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Parking
{
    public partial class ManagePaymentsForm : Form
    {
        public ManagePaymentsForm()
        {
            InitializeComponent();
        }
        private void LoadFormInPanel(Form form)
        {
            // Clear the panel
            panelContainer.Controls.Clear();

            // Set the form as a child and remove borders
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Add the form to the panel and show it
            panelContainer.Controls.Add(form);
            form.Show();
        }
        private void ManagePaymentsForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            ViewPaymentsForm vpf = new ViewPaymentsForm();
            LoadFormInPanel(vpf);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddPaymentForm apf = new AddPaymentForm();
            LoadFormInPanel(apf);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
            wf.FormClosed += (s, args) => this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeletePaymentForm dpf = new DeletePaymentForm();
            LoadFormInPanel(dpf);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdatePaymentForm upf = new UpdatePaymentForm();
            LoadFormInPanel(upf);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            GenerateReportForm grf = new GenerateReportForm();
            LoadFormInPanel(grf);
        }

    }
}

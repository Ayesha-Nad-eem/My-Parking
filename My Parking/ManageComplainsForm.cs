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
    public partial class ManageComplainsForm : Form
    {
        public ManageComplainsForm()
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
        private void ManageComplainsForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_viewComplains_Click(object sender, EventArgs e)
        {
            ViewComplaintsForm veiwComplainsform = new ViewComplaintsForm();
            LoadFormInPanel(veiwComplainsform);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
            wf.FormClosed += (s, args) => this.Close();
        }

        private void btn_updateStatus_Click(object sender, EventArgs e)
        {
            UpdateComplainForm uf = new UpdateComplainForm();
            LoadFormInPanel(uf);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

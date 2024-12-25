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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            AccountSettingsForm asf = new AccountSettingsForm();
            LoadFormInPanel(asf);
        }

        private void btn_complain_Click(object sender, EventArgs e)
        {
            FileComplainForm fcf = new FileComplainForm();
            LoadFormInPanel(fcf);
        }

        private void btn_book_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

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
        private void panelUserForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

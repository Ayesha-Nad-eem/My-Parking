using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace My_Parking
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void webView2Control_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }

        private void btn_showMap_Click(object sender, EventArgs e)
        {

        }

        private void btn_mngusrs_Click(object sender, EventArgs e)
        {
            ManageUsersForm muf = new ManageUsersForm();
            muf.Show();
            this.Hide();
            muf.FormClosed += (s, args) => this.Close();
        }

        private void btn_mngpark_Click(object sender, EventArgs e)
        {
            ManageParkingForm mpf = new ManageParkingForm();
            mpf.Show();
            this.Hide();
            mpf.FormClosed += (s, args) => this.Close();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

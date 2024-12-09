using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Gpio;
using Microsoft.Web.WebView2.WinForms;
using GoogleGeocodingClient;

namespace My_Parking
{
    public partial class ManageParkingForm : Form
    {
        public ManageParkingForm()
        {
            InitializeComponent();
        }



        private async void ManageParkingForm_Load(object sender, EventArgs e)
        {


        }

       

        private void btn_exit_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
            wf.FormClosed += (s, args) => this.Close();
        }
    }
}

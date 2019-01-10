using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApi;
using WebApi.Models;

namespace papir_kamen_i_makaze
{
    public partial class About_Page : Form
    {
        public About_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void About_Page_LoadAsync(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:61421");
            HttpResponseMessage response = client.GetAsync("api/AboutAdmin").Result;
            About_ad[] reports = await response.Content.ReadAsAsync<About_ad[]>();
            foreach (var report in reports)
            {
                fNameLabel.Text = report.F_name;
                lNameLabel.Text = report.L_Name;
                emailLabel.Text = report.Email;
                addressLabel.Text = report.Address;
                skypeLabel.Text = report.Skype;

            }
        }
    }
}

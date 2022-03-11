using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Traffic_analyzer
{
    public partial class ipLocation : Form
    {
        
        public ipLocation()
        {
            
            InitializeComponent();
            this.ipLocationButton.Enabled = false;
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addIPButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            addips obj = new addips();
            obj.Show();
        }
        public void CityStateCountByIp(string IP)
        {
            //var url = "http://freegeoip.net/json/" + IP;
            //var url = "http://freegeoip.net/json/" + IP;
            string url = "http://ipwhois.app/json/"+IP;
            using(WebClient client = new WebClient())
            {
                var json = client.DownloadString(url);
                var result = json.ToString();
                var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                this.label6.Text = values["longitude"];
                this.label4.Text = values["latitude"];
                this.label13.Text = values["type"];
                this.label15.Text = values["city"];
                this.label18.Text = values["region"];
                this.label16.Text = values["country_phone"];
                this.label14.Text = values["country"];
                this.label17.Text = values["timezone_gmt"];
                string locc = "http://www.google.com/maps/place/" + label4.Text + "," + label6.Text;
                

            }   

        }
        private void locateIPButton_Click(object sender, EventArgs e)
        {
            var ip = enterIPTextBox.Text;
            CityStateCountByIp(ip);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Traffic_analyzer
{
    public partial class addips : Form
    {
        public addips()
        {
            InitializeComponent();
            addIPButton.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ipLocationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ipLocation obj = new ipLocation();
            obj.Show();
        }
    }
}

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
    }
}

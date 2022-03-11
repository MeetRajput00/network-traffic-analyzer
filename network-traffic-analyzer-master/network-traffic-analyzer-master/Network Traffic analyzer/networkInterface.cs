using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Core;
using PcapDotNet.Packets;

using SharpPcap.LibPcap;
using SharpPcap;
using PacketDotNet;

namespace Network_Traffic_analyzer
{
    public partial class networkInterface : Form
    {
        List<LibPcapLiveDevice> interfaceList = new List<LibPcapLiveDevice>();
        public networkInterface()
        {
            InitializeComponent();
            LibPcapLiveDeviceList devices = LibPcapLiveDeviceList.Instance;

            foreach (LibPcapLiveDevice device in devices)
            {
                if (!device.Interface.Addresses.Exists(a => a != null && a.Addr != null && a.Addr.ipAddress != null)) continue;
                var devInterface = device.Interface;
                var friendlyName = devInterface.FriendlyName;
                var description = devInterface.Description;

                interfaceList.Add(device);
                networkInterfaceCombo.Items.Add(friendlyName);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (networkInterfaceCombo.SelectedIndex >= 0 && networkInterfaceCombo.SelectedIndex < interfaceList.Count)
            {
                dashboard openMainForm = new dashboard(interfaceList, networkInterfaceCombo.SelectedIndex);
                this.Hide();
                openMainForm.Show();
            }
        }
    }
}

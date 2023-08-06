using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using SharpPcap.LibPcap;
using SharpPcap;
using PacketDotNet;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Network_Traffic_analyzer
{
    public partial class dashboard : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);
        List<LibPcapLiveDevice> interfaceList = new List<LibPcapLiveDevice>();
        int selectedIntIndex;
        LibPcapLiveDevice wifi_device;
        CaptureFileWriterDevice captureFileWriter;
        Dictionary<int, Packet> capturedPackets_list = new Dictionary<int, Packet>();
        HashSet<string> activeIPs,protocolsList;

        int packetNumber = 1;
        string time_str = "", sourceIP = "", destinationIP = "", protocol_type = "";

        bool startCapturingAgain = false;

        Thread sniffing;


        public dashboard(List<LibPcapLiveDevice> interfaces, int selectedIndex)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.dashboardButton.Enabled = false;
            this.interfaceList = interfaces;
            selectedIntIndex = selectedIndex;
            // Extract a device from the list
            wifi_device = interfaceList[selectedIntIndex];
            pauseButton.Enabled = false;
            stopButton.Enabled = false;
            activeIPs = new HashSet<string>();
            protocolsList = new HashSet<string>();
        }
        private void sniffing_Proccess()
        {
            // Open the device for capturing
            int readTimeoutMilliseconds = 1000;
            wifi_device.Open(DeviceModes.Promiscuous, readTimeoutMilliseconds);

            // Start the capturing process
            if (wifi_device.Opened)
            {
                captureFileWriter = new CaptureFileWriterDevice(Environment.CurrentDirectory + "capture.pcap");
                wifi_device.Capture();
            }
        }

        //public void Device_OnPacketArrival(object sender, CaptureEventArgs e)
        //{
        //    // dump to a file
        //    captureFileWriter.Write(e.Packet);


        //    // start extracting properties for the listview 
        //    DateTime time = e.Packet.Timeval.Date;
        //    time_str = (time.Hour + 1) + ":" + time.Minute + ":" + time.Second + ":" + time.Millisecond;


        //    var packet = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

        //    // add to the list
        //    if (!capturedPackets_list.ContainsKey(packetNumber)) 
        //    {
        //        capturedPackets_list.Add(packetNumber, packet);
        //    }


        //    var ipPacket = (IpPacket)packet.Extract(typeof(IpPacket));


        //    if (ipPacket != null)
        //    {
        //        System.Net.IPAddress srcIp = ipPacket.SourceAddress;
        //        System.Net.IPAddress dstIp = ipPacket.DestinationAddress;
        //        protocol_type = ipPacket.Protocol.ToString();
        //        sourceIP = srcIp.ToString();
        //        destinationIP = dstIp.ToString();
                
               



        //        var protocolPacket = ipPacket.PayloadPacket;

        //        ListViewItem item = new ListViewItem(packetNumber.ToString());
        //        item.SubItems.Add(time_str);
        //        item.SubItems.Add(sourceIP);
        //        item.SubItems.Add(destinationIP);
        //        item.SubItems.Add(protocol_type);
        //        try
        //        {
        //            this.Invoke(new MethodInvoker(delegate ()
        //            {
        //                if (!protocolsList.Contains(protocol_type))
        //                {
        //                    packetSentText.Text = Convert.ToString(packetNumber);
        //                    packetReceivedText.Text = Convert.ToString(packetNumber);
        //                }
        //            }));
        //        }
        //        catch (Exception err)
        //        {

        //        }
        //        activeIPs.Add(sourceIP);
        //        activeIPs.Add(destinationIP);
        //        try
        //        {
        //            this.Invoke(new MethodInvoker(delegate ()
        //            {
        //                if (!protocolsList.Contains(protocol_type))
        //                {
        //                    filterCombo.Items.Add(protocol_type);
        //                    protocolsList.Add(protocol_type);
        //                }
        //            }));
        //        }
        //        catch(Exception err)
        //        {

        //        }

        //        try
        //        {
        //            this.Invoke(new MethodInvoker(delegate ()
        //            {
        //                activeIPText.Text = Convert.ToString(activeIPs.Count);
        //            }));
        //        }
        //        catch(Exception err)
        //        {

        //        }

        //        Action action = () => packetTable.Items.Add(item);
        //        try
        //        {
        //            packetTable.Invoke(action);
        //        }
        //        catch(Exception err)
        //        {

        //        }

        //        ++packetNumber;
        //    }
        //}
        private void Dashboard_Click(object sender, EventArgs e)
        {

            pnlNav.Height = dashboardButton.Height;
            pnlNav.Top = dashboardButton.Top;
            pnlNav.Left = dashboardButton.Left;
            dashboardButton.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            pnlNav.Height = addIPButton.Height;
            pnlNav.Top = addIPButton.Top;
            pnlNav.Left = addIPButton.Left;
            addIPButton.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnloc_Click(object sender, EventArgs e)
        {
            pnlNav.Height = IPlocationButton.Height;
            pnlNav.Top = IPlocationButton.Top;
            pnlNav.Left = IPlocationButton.Left;
            addIPButton.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnext_Click(object sender, EventArgs e)
        {
            pnlNav.Height = exitButton.Height;
            pnlNav.Top = exitButton.Top;
            pnlNav.Left = exitButton.Left;
            exitButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Dashboard_leave(object sender, EventArgs e)
        {
            dashboardButton.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnadd_leave(object sender, EventArgs e)
        {
            addIPButton.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnloc_leave(object sender, EventArgs e)
        {
            IPlocationButton.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnext_leave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
            pauseButton.Enabled = false;
            startButton.Enabled = true;
            stopButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
            stopButton.Enabled = false;
            startButton.Enabled = true;
            pauseButton.Enabled = false;
            packetTable.Clear();
            packetTable.Columns.Add("S. No.").Width=100;
            packetTable.Columns.Add("Time taken").Width=140;
            packetTable.Columns.Add("Source IP").Width=180;
            packetTable.Columns.Add("Destination IP").Width=180;
            packetTable.Columns.Add("Protocol").Width=140;
        }

        private void packetTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addIPButton_Click(object sender, EventArgs e)
        {
            addips obj = new addips();
            obj.Show();
        }

        private void IPlocationButton_Click(object sender, EventArgs e)
        {
            ipLocation obj = new ipLocation();
            obj.Show();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void filterButton_Click(object sender, EventArgs e)
        {

        }

        

        private void filterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
            string value = filterCombo.Text.ToLower();
            for (int i = packetTable.Items.Count - 1; -1 < i; i--)
            {
                if
                (packetTable.Items[i].Text.ToLower().StartsWith(value) == false)
                {
                    packetTable.Items[i].Remove();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startCapturingAgain == false) //first time 
            {
                System.IO.File.Delete(Environment.CurrentDirectory + "capture.pcap");
               // wifi_device.OnPacketArrival += new PacketArrivalEventHandler(Device_OnPacketArrival);
                sniffing = new Thread(new ThreadStart(sniffing_Proccess));
                sniffing.Start();
                startButton.Enabled = false;
                pauseButton.Enabled = true;
                stopButton.Enabled = true;
            }
            else if (startCapturingAgain)
            {
                if (MessageBox.Show("Your packets are captured in a file. Starting a new capture will override existing ones.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    // user clicked ok
                    System.IO.File.Delete(Environment.CurrentDirectory + "capture.pcap");
                    packetTable.Items.Clear();
                    capturedPackets_list.Clear();
                    packetNumber = 1;
                    //wifi_device.OnPacketArrival += new PacketArrivalEventHandler(Device_OnPacketArrival);
                    sniffing = new Thread(new ThreadStart(sniffing_Proccess));
                    sniffing.Start();
                    startButton.Enabled = false;
                    pauseButton.Enabled = true;
                    stopButton.Enabled = true;
                }
            }
            startCapturingAgain = true;
        }
    }
}
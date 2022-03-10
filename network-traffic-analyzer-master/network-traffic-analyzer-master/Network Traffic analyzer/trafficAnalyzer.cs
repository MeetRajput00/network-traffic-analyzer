using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpPcap;
namespace Network_Traffic_analyzer
{
    public class trafficAnalyzer
    {
        public void showDevices()
        {
            /*If no device exists, print error */
            var devices = CaptureDeviceList.Instance;
            foreach (var dev in devices)
                Console.WriteLine("{0}\n", dev.ToString());
        }
    }
}

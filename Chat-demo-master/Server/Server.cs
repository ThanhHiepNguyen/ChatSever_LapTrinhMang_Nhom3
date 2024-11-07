using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        private static ConcurrentBag<ClientInfo> clients = new ConcurrentBag<ClientInfo>();
        private TcpListener server;
        private byte[] message;

        public Server()
        {
            InitializeComponent();
        }
        //Lấy ip address từ wifi
        private void ShowWifiIPAddress()
        {
            StringBuilder wifiIP = new StringBuilder();

            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Kiểm tra nếu giao diện là Wi-Fi và đang kết nối
                if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 &&
                    netInterface.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in netInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork) // IPv4
                        {
                            wifiIP.AppendLine(ip.Address.ToString());
                        }
                    }
                }
            }

            if (txt_IPAddress.InvokeRequired)
            {
                txt_IPAddress.Invoke(new Action(() =>
                    txt_IPAddress.Text = wifiIP.ToString()));
            }
            else
            {
                txt_IPAddress.Text = wifiIP.ToString();
            }
        }



    }
}

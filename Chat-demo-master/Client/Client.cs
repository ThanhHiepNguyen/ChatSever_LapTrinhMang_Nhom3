using System;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Security;

namespace Client
{
    public partial class Client : Form
    {
        private TcpClient _client;
        private SslStream _sslStream;

        public Client()
        {
            InitializeComponent();
        }

        //Kiểm tra dữ liệu nhập vào
        private bool CheckInputs(out IPAddress ip, out int port, out string username)
        {
            ip = null;
            port = 0;
            username = string.Empty;

            if (string.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng *_*", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txt_IPAddress.Text) || string.IsNullOrEmpty(txt_Port.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ IP và Port lớn hơn 1000 trở lên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IPAddress.TryParse(txt_IPAddress.Text, out ip))
            {
                MessageBox.Show("Vui lòng nhập đúng địa chỉ IP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txt_Port.Text, out port) || port <= 1000)
            {
                MessageBox.Show("Vui lòng nhập Port có giá trị lớn hơn 1000!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            username = txt_username.Text;
            return true;
        }

        //kết nối với server
        private async Task Connect()
        {
            try
            {
                // Kiểm tra khung nhập dữ liệu
                if (!CheckInputs(out IPAddress ip, out int port, out string username)) return;

                _client = new TcpClient();
                await _client.ConnectAsync(ip, port);

                showStatus("Đã kết nối đến server");

                NetworkStream networkStream = _client.GetStream();

                _sslStream = new SslStream(networkStream, false, ValidateServerCertificate, null);

                try
                {
                    await _sslStream.AuthenticateAsClientAsync(ip.ToString());
                }
                catch (Exception ex)
                {
                    showStatus($"Xác thực thất bại: {ex.Message}");
                    return;
                }

                // Gửi tên người dùng ngay khi kết nối
                byte[] byte_user = Encoding.UTF8.GetBytes(username);
                await _sslStream.WriteAsync(byte_user, 0, byte_user.Length);

                _ = Task.Run(() => ReceiveMessagesAsync(_sslStream));

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Disconnect()
        {
            if (_client != null)
            {
                try
                {
                    _sslStream?.Close();
                    _client.Close();
                }
                catch (Exception ex)
                {
                    ShowMessage($"Lỗi khi ngắt kết nối: {ex.Message}");
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    _client = null;
                    _sslStream = null;
                    showStatus("Đã ngắt kết nối khỏi server");
                }
            }
        }
    }

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using clsCipherAlgorthim;

namespace Client
{
    public partial class frm_Client : Form
    {
        TcpClient client;
        NetworkStream stream;
        public frm_Client()
        {
            InitializeComponent();
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (stream == null)
                {
                    MessageBox.Show("Connect First.");
                    return;
                }

                clsCipherAlgorthim.clsCipherAlgorthims cipherText = new clsCipherAlgorthim.clsCipherAlgorthims();
                byte[] data = Encoding.Unicode.GetBytes(cipherText.Enc_AES(txt_Message.Text));

                stream.Write(data, 0, data.Length);

                txt_Message.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ip = IPAddress.Parse("127.0.0.1");

                IPEndPoint endPoint = new IPEndPoint(ip, 8090);

                client = new TcpClient();

                client.Connect(endPoint);

                stream = client.GetStream();

                MessageBox.Show("Connected Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

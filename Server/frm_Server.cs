using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class frm_Server : Form
    {
        private  TcpListener listener;
        TcpClient client;
        NetworkStream stream;
        public frm_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            try
            {
                if (listener != null)
                {
                    MessageBox.Show("Server is already running.");
                    return;
                }

                Thread t = new Thread(() =>
                {
                    listener = new TcpListener(IPAddress.Any, 8090);
                    listener.Start();

                    client = listener.AcceptTcpClient();

                    stream = client.GetStream();

                    Invoke(new Action(() =>
                    {
                        lst_Message.Items.Add("Client Connected");
                    }));

                    ReceiveMessage();
                });

                t.IsBackground = true;
                t.Start();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReceiveMessage()
        {
            try
            {
                byte[] buffer = new byte[1024];

                while (true)
                {
                    int count = stream.Read(buffer, 0, buffer.Length);

                    if (count == 0)
                        break;

                    string msg = Encoding.Unicode.GetString(buffer, 0, count);
                    clsCipherAlgorthim.clsCipherAlgorthims cipherText = new clsCipherAlgorthim.clsCipherAlgorthims();
                   
                    Invoke(new Action(() =>
                    {
                        lst_Message.Items.Add(cipherText.Dec_AES(msg));
                    }));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.Message);
                }));
            }
        }

        private void frm_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream?.Close();
            client?.Close();
            listener?.Stop();
        }
    }
    }


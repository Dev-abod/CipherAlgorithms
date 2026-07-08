using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CipherAlgorthims
{
    public partial class frm_CipherAlgorthims : Form
    {
        public frm_CipherAlgorthims()
        {
            InitializeComponent();
        }

        private void btn_Qaeser_Click(object sender, EventArgs e)
        {
            QaeserCipher.QaeserCipher qaeserCipher = new QaeserCipher.QaeserCipher();
            qaeserCipher.Show();
        }

        private void btn_AtbashCipher_Click(object sender, EventArgs e)
        {
            AtbashCipher.AtbashCipher atbashCipher = new AtbashCipher.AtbashCipher();
            atbashCipher.Show();
        }

        private void btn_Root13Cipher_Click(object sender, EventArgs e)
        {
            Root13Cipher.Root13Cipher root13Cipher = new Root13Cipher.Root13Cipher();
            root13Cipher.Show();
        }

        private void btn_AffineCipher_Click(object sender, EventArgs e)
        {
            AffineCipher.AffineCipher affineCipher = new AffineCipher.AffineCipher();
            affineCipher.Show();
        }

        private void btn_SimpleVengereCipher_Click(object sender, EventArgs e)
        {
            SimpleVenegerCipher.SimpleVenegerCipher simpleVenegerCipher = new SimpleVenegerCipher.SimpleVenegerCipher();
            simpleVenegerCipher.Show();
        }

        private void btn_AESCipher_Click(object sender, EventArgs e)
        {
            AESCipher.AESCipher aesCipher = new AESCipher.AESCipher();
            aesCipher.Show();
        }

        private void btn_RSACipher_Click(object sender, EventArgs e)
        {
            RSACipher.RSACipher rsaCipher = new RSACipher.RSACipher();
            rsaCipher.Show();
        }

        private void btn_MD5Cipher_Click(object sender, EventArgs e)
        {
            MDFiveCipher.MDFiveCipher md5Cipher = new MDFiveCipher.MDFiveCipher();
            md5Cipher.Show();
        }

        private void btn_HSA256Cipher_Click(object sender, EventArgs e)
        {
            HSACipher.HSACipher hsaCipher = new HSACipher.HSACipher();
            hsaCipher.Show();
        }

        private void btn_Chat_Click(object sender, EventArgs e)
        {
            Client.frm_Client clientForm = new Client.frm_Client();
            clientForm.Show();
            Server.frm_Server serverForm = new Server.frm_Server();
            serverForm.Show();
        }
    }
}

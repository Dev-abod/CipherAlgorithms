using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsCipherAlgorthim;

namespace RSACipher
{
    public partial class RSACipher : Form
    {
        public RSACipher()
        {
            InitializeComponent();
        }
        private clsCipherAlgorthim.clsCipherAlgorthims CipherAlgorthim = new clsCipherAlgorthim.clsCipherAlgorthims();

        private void btn_Encryption_Click(object sender, EventArgs e)
        {
            txt_CipherText.Text = CipherAlgorthim.RSA_Enc(txt_PlainText.Text);
            txt_PlainText.Clear();
        }

        private void btn_Decryption_Click(object sender, EventArgs e)
        {
            txt_PlainText.Text = CipherAlgorthim.RSA_Dec(txt_CipherText.Text);
            txt_CipherText.Clear();
        }
    }
}

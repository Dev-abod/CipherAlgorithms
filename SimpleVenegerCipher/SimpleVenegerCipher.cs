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

namespace SimpleVenegerCipher
{
    public partial class SimpleVenegerCipher : Form
    {
        public SimpleVenegerCipher()
        {
            InitializeComponent();
        }

        private void btn_Encryption_Click(object sender, EventArgs e)
        {
            clsCipherAlgorthim.clsCipherAlgorthims CipherAlgorthim = new clsCipherAlgorthim.clsCipherAlgorthims();
            txt_CipherText.Text = CipherAlgorthim.Enc_SimpleVengereCipher(txt_PlainText.Text, txt_KeyText.Text);
            txt_PlainText.Clear();
        }

        private void btn_Decryption_Click(object sender, EventArgs e)
        {
            clsCipherAlgorthim.clsCipherAlgorthims CipherAlgorthim = new clsCipherAlgorthim.clsCipherAlgorthims();
            txt_PlainText.Text = CipherAlgorthim.Dec_SimpleVengereCipher(txt_CipherText.Text, txt_KeyText.Text);
            txt_CipherText.Clear();
        }
    }
}

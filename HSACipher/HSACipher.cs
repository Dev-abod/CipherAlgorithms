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
namespace HSACipher
{
    public partial class HSACipher : Form
    {
        public HSACipher()
        {
            InitializeComponent();
        }

        private void btn_Encryption_Click(object sender, EventArgs e)
        {
            clsCipherAlgorthim.clsCipherAlgorthims CipherAlgorthim = new clsCipherAlgorthim.clsCipherAlgorthims();
            txt_CipherText.Text = CipherAlgorthim.HSA256_Hash(txt_PlainText.Text);
            txt_PlainText.Clear();
        }

        private void btn_Decryption_Click(object sender, EventArgs e)
        {
            clsCipherAlgorthim.clsCipherAlgorthims CipherAlgorthim = new clsCipherAlgorthim.clsCipherAlgorthims();
            txt_PlainText.Text = CipherAlgorthim.HSA256_Hash(txt_CipherText.Text);
            txt_CipherText.Clear();
        }
    }
}

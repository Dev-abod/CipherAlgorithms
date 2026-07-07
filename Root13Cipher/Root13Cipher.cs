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

namespace Root13Cipher
{
    public partial class Root13Cipher : Form
    {
        public Root13Cipher()
        {
            InitializeComponent();
        }

        private void btn_Encryption_Click(object sender, EventArgs e)
        {
            clsCipherAlgorthim.clsCipherAlgorthims CipherAlgorthim = new clsCipherAlgorthim.clsCipherAlgorthims();
            txt_CipherText.Text = CipherAlgorthim.Root13Cipher(txt_PlainText.Text);
            txt_PlainText.Clear();
        }

        private void btn_Decryption_Click(object sender, EventArgs e)
        {
            clsCipherAlgorthim.clsCipherAlgorthims CipherAlgorthim = new clsCipherAlgorthim.clsCipherAlgorthims();
            txt_PlainText.Text = CipherAlgorthim.Root13Cipher(txt_CipherText.Text);
            txt_CipherText.Clear();
        }
    }
}

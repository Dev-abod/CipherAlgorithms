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

namespace AffineCipher
{
    public partial class AffineCipher : Form
    {
        public AffineCipher()
        {
            InitializeComponent();
        }

        private void btn_Encryption_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_KeyText.Text, out int key))
            {
                MessageBox.Show("الرجاء إدخال قيمة صحيحة للمفتاح.");
                return;
            }

            if (!int.TryParse(txt_MessageText.Text, out int m))
            {
                MessageBox.Show("الرجاء إدخال قيمة صحيحة لـ m.");
                return;
            }

            clsCipherAlgorthim.clsCipherAlgorthims CipherAlgorthim = new clsCipherAlgorthim.clsCipherAlgorthims();
            txt_CipherText.Text = CipherAlgorthim.Enc_Affine(txt_PlainText.Text, key, m);
            txt_PlainText.Clear();
        }


        private void btn_Decryption_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_KeyText.Text, out int key))
            {
                MessageBox.Show("الرجاء إدخال قيمة صحيحة للمفتاح.");
                return;
            }

            if (!int.TryParse(txt_MessageText.Text, out int m))
            {
                MessageBox.Show("الرجاء إدخال قيمة صحيحة لـ m.");
                return;
            }
            clsCipherAlgorthim.clsCipherAlgorthims CipherAlgorthim = new clsCipherAlgorthim.clsCipherAlgorthims();
            txt_PlainText.Text = CipherAlgorthim.Dec_Affine(txt_CipherText.Text, key, m);
            txt_CipherText.Clear();
        }
    }
}

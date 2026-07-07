namespace CipherAlgorthims
{
    partial class frm_CipherAlgorthims
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Qaeser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AtbashCipher = new System.Windows.Forms.Button();
            this.btn_Root13Cipher = new System.Windows.Forms.Button();
            this.btn_SimpleVengereCipher = new System.Windows.Forms.Button();
            this.btn_AffineCipher = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_AESCipher = new System.Windows.Forms.Button();
            this.btn_RSACipher = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_MD5Cipher = new System.Windows.Forms.Button();
            this.btn_HSA256Cipher = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Qaeser
            // 
            this.btn_Qaeser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Qaeser.Location = new System.Drawing.Point(39, 37);
            this.btn_Qaeser.Name = "btn_Qaeser";
            this.btn_Qaeser.Size = new System.Drawing.Size(148, 32);
            this.btn_Qaeser.TabIndex = 0;
            this.btn_Qaeser.Text = "Qaeser Cipher";
            this.btn_Qaeser.UseVisualStyleBackColor = true;
            this.btn_Qaeser.Click += new System.EventHandler(this.btn_Qaeser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AffineCipher);
            this.groupBox1.Controls.Add(this.btn_SimpleVengereCipher);
            this.groupBox1.Controls.Add(this.btn_Root13Cipher);
            this.groupBox1.Controls.Add(this.btn_AtbashCipher);
            this.groupBox1.Controls.Add(this.btn_Qaeser);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classical Cryptography";
            // 
            // btn_AtbashCipher
            // 
            this.btn_AtbashCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_AtbashCipher.Location = new System.Drawing.Point(39, 86);
            this.btn_AtbashCipher.Name = "btn_AtbashCipher";
            this.btn_AtbashCipher.Size = new System.Drawing.Size(148, 32);
            this.btn_AtbashCipher.TabIndex = 1;
            this.btn_AtbashCipher.Text = "Atbash Cipher";
            this.btn_AtbashCipher.UseVisualStyleBackColor = true;
            this.btn_AtbashCipher.Click += new System.EventHandler(this.btn_AtbashCipher_Click);
            // 
            // btn_Root13Cipher
            // 
            this.btn_Root13Cipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Root13Cipher.Location = new System.Drawing.Point(224, 37);
            this.btn_Root13Cipher.Name = "btn_Root13Cipher";
            this.btn_Root13Cipher.Size = new System.Drawing.Size(148, 32);
            this.btn_Root13Cipher.TabIndex = 2;
            this.btn_Root13Cipher.Text = "Root13 Cipher";
            this.btn_Root13Cipher.UseVisualStyleBackColor = true;
            this.btn_Root13Cipher.Click += new System.EventHandler(this.btn_Root13Cipher_Click);
            // 
            // btn_SimpleVengereCipher
            // 
            this.btn_SimpleVengereCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_SimpleVengereCipher.Location = new System.Drawing.Point(405, 65);
            this.btn_SimpleVengereCipher.Name = "btn_SimpleVengereCipher";
            this.btn_SimpleVengereCipher.Size = new System.Drawing.Size(210, 32);
            this.btn_SimpleVengereCipher.TabIndex = 3;
            this.btn_SimpleVengereCipher.Text = "Simple Vengere Cipher";
            this.btn_SimpleVengereCipher.UseVisualStyleBackColor = true;
            this.btn_SimpleVengereCipher.Click += new System.EventHandler(this.btn_SimpleVengereCipher_Click);
            // 
            // btn_AffineCipher
            // 
            this.btn_AffineCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_AffineCipher.Location = new System.Drawing.Point(224, 86);
            this.btn_AffineCipher.Name = "btn_AffineCipher";
            this.btn_AffineCipher.Size = new System.Drawing.Size(148, 32);
            this.btn_AffineCipher.TabIndex = 4;
            this.btn_AffineCipher.Text = "Affine Cipher";
            this.btn_AffineCipher.UseVisualStyleBackColor = true;
            this.btn_AffineCipher.Click += new System.EventHandler(this.btn_AffineCipher_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 168);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modern Cryptography";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_AESCipher);
            this.groupBox3.Location = new System.Drawing.Point(30, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 103);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symmetric Encryption";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_RSACipher);
            this.groupBox4.Location = new System.Drawing.Point(320, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 103);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Asymmetric Encryption)";
            // 
            // btn_AESCipher
            // 
            this.btn_AESCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_AESCipher.Location = new System.Drawing.Point(69, 42);
            this.btn_AESCipher.Name = "btn_AESCipher";
            this.btn_AESCipher.Size = new System.Drawing.Size(148, 32);
            this.btn_AESCipher.TabIndex = 5;
            this.btn_AESCipher.Text = "AES Cipher";
            this.btn_AESCipher.UseVisualStyleBackColor = true;
            this.btn_AESCipher.Click += new System.EventHandler(this.btn_AESCipher_Click);
            // 
            // btn_RSACipher
            // 
            this.btn_RSACipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_RSACipher.Location = new System.Drawing.Point(71, 42);
            this.btn_RSACipher.Name = "btn_RSACipher";
            this.btn_RSACipher.Size = new System.Drawing.Size(148, 32);
            this.btn_RSACipher.TabIndex = 6;
            this.btn_RSACipher.Text = "RSA Cipher";
            this.btn_RSACipher.UseVisualStyleBackColor = true;
            this.btn_RSACipher.Click += new System.EventHandler(this.btn_RSACipher_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_HSA256Cipher);
            this.groupBox5.Controls.Add(this.btn_MD5Cipher);
            this.groupBox5.Location = new System.Drawing.Point(12, 369);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 133);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hash Functions";
            // 
            // btn_MD5Cipher
            // 
            this.btn_MD5Cipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_MD5Cipher.Location = new System.Drawing.Point(30, 35);
            this.btn_MD5Cipher.Name = "btn_MD5Cipher";
            this.btn_MD5Cipher.Size = new System.Drawing.Size(148, 32);
            this.btn_MD5Cipher.TabIndex = 6;
            this.btn_MD5Cipher.Text = "MD5 Cipher";
            this.btn_MD5Cipher.UseVisualStyleBackColor = true;
            this.btn_MD5Cipher.Click += new System.EventHandler(this.btn_MD5Cipher_Click);
            // 
            // btn_HSA256Cipher
            // 
            this.btn_HSA256Cipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_HSA256Cipher.Location = new System.Drawing.Point(30, 79);
            this.btn_HSA256Cipher.Name = "btn_HSA256Cipher";
            this.btn_HSA256Cipher.Size = new System.Drawing.Size(148, 32);
            this.btn_HSA256Cipher.TabIndex = 7;
            this.btn_HSA256Cipher.Text = "HSA256 Cipher";
            this.btn_HSA256Cipher.UseVisualStyleBackColor = true;
            this.btn_HSA256Cipher.Click += new System.EventHandler(this.btn_HSA256Cipher_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(247, 369);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(429, 133);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hash Functions";
            // 
            // frm_CipherAlgorthims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 524);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_CipherAlgorthims";
            this.Text = "Cipher Algorthims";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Qaeser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AtbashCipher;
        private System.Windows.Forms.Button btn_AffineCipher;
        private System.Windows.Forms.Button btn_SimpleVengereCipher;
        private System.Windows.Forms.Button btn_Root13Cipher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_RSACipher;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_AESCipher;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_HSA256Cipher;
        private System.Windows.Forms.Button btn_MD5Cipher;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}


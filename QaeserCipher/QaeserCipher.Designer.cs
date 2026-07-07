namespace QaeserCipher
{
    partial class QaeserCipher
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PlainText = new System.Windows.Forms.TextBox();
            this.txt_CipherText = new System.Windows.Forms.TextBox();
            this.btn_Decryption = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Encryption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PlainText";
            // 
            // txt_PlainText
            // 
            this.txt_PlainText.Location = new System.Drawing.Point(125, 41);
            this.txt_PlainText.Multiline = true;
            this.txt_PlainText.Name = "txt_PlainText";
            this.txt_PlainText.Size = new System.Drawing.Size(243, 30);
            this.txt_PlainText.TabIndex = 1;
            // 
            // txt_CipherText
            // 
            this.txt_CipherText.Location = new System.Drawing.Point(125, 88);
            this.txt_CipherText.Multiline = true;
            this.txt_CipherText.Name = "txt_CipherText";
            this.txt_CipherText.Size = new System.Drawing.Size(243, 30);
            this.txt_CipherText.TabIndex = 3;
            // 
            // btn_Decryption
            // 
            this.btn_Decryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decryption.Location = new System.Drawing.Point(125, 136);
            this.btn_Decryption.Name = "btn_Decryption";
            this.btn_Decryption.Size = new System.Drawing.Size(104, 27);
            this.btn_Decryption.TabIndex = 4;
            this.btn_Decryption.Text = "Decryption";
            this.btn_Decryption.UseVisualStyleBackColor = true;
            this.btn_Decryption.Click += new System.EventHandler(this.btn_Decryption_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "CipherText";
            // 
            // btn_Encryption
            // 
            this.btn_Encryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encryption.Location = new System.Drawing.Point(264, 136);
            this.btn_Encryption.Name = "btn_Encryption";
            this.btn_Encryption.Size = new System.Drawing.Size(104, 27);
            this.btn_Encryption.TabIndex = 6;
            this.btn_Encryption.Text = "Encryption";
            this.btn_Encryption.UseVisualStyleBackColor = true;
            this.btn_Encryption.Click += new System.EventHandler(this.btn_Encryption_Click);
            // 
            // QaeserCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 195);
            this.Controls.Add(this.btn_Encryption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Decryption);
            this.Controls.Add(this.txt_CipherText);
            this.Controls.Add(this.txt_PlainText);
            this.Controls.Add(this.label1);
            this.Name = "QaeserCipher";
            this.Text = "QaeserCipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PlainText;
        private System.Windows.Forms.TextBox txt_CipherText;
        private System.Windows.Forms.Button btn_Decryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Encryption;
    }
}


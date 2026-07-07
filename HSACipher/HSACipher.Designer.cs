namespace HSACipher
{
    partial class HSACipher
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
            this.btn_Encryption = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CipherText = new System.Windows.Forms.TextBox();
            this.txt_PlainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Encryption
            // 
            this.btn_Encryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encryption.Location = new System.Drawing.Point(127, 131);
            this.btn_Encryption.Name = "btn_Encryption";
            this.btn_Encryption.Size = new System.Drawing.Size(243, 27);
            this.btn_Encryption.TabIndex = 12;
            this.btn_Encryption.Text = "Encryption";
            this.btn_Encryption.UseVisualStyleBackColor = true;
            this.btn_Encryption.Click += new System.EventHandler(this.btn_Encryption_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "CipherText";
            // 
            // txt_CipherText
            // 
            this.txt_CipherText.Location = new System.Drawing.Point(127, 83);
            this.txt_CipherText.Multiline = true;
            this.txt_CipherText.Name = "txt_CipherText";
            this.txt_CipherText.Size = new System.Drawing.Size(243, 30);
            this.txt_CipherText.TabIndex = 9;
            // 
            // txt_PlainText
            // 
            this.txt_PlainText.Location = new System.Drawing.Point(127, 36);
            this.txt_PlainText.Multiline = true;
            this.txt_PlainText.Name = "txt_PlainText";
            this.txt_PlainText.Size = new System.Drawing.Size(243, 30);
            this.txt_PlainText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "PlainText";
            // 
            // HSACipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 195);
            this.Controls.Add(this.btn_Encryption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CipherText);
            this.Controls.Add(this.txt_PlainText);
            this.Controls.Add(this.label1);
            this.Name = "HSACipher";
            this.Text = "HSA256 Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Encryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CipherText;
        private System.Windows.Forms.TextBox txt_PlainText;
        private System.Windows.Forms.Label label1;
    }
}


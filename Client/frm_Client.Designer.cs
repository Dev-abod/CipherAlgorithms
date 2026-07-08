namespace Client
{
    partial class frm_Client
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
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(163, 92);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(209, 33);
            this.txt_Message.TabIndex = 3;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(24, 43);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(111, 35);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(24, 90);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(111, 35);
            this.btn_Send.TabIndex = 5;
            this.btn_Send.Text = "Send";
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // frm_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 167);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.btn_Connect);
            this.Name = "frm_Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Send;
    }
}


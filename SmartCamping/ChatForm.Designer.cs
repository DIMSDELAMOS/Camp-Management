namespace SmartCamping
{
    partial class ChatForm
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
            this.ButtonSend = new System.Windows.Forms.Button();
            this.ButtomReturn = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.listChat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonSend
            // 
            this.ButtonSend.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonSend.Location = new System.Drawing.Point(251, 122);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(100, 42);
            this.ButtonSend.TabIndex = 0;
            this.ButtonSend.Text = "Αποστολή";
            this.ButtonSend.UseVisualStyleBackColor = false;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // ButtomReturn
            // 
            this.ButtomReturn.BackColor = System.Drawing.Color.IndianRed;
            this.ButtomReturn.Location = new System.Drawing.Point(666, 197);
            this.ButtomReturn.Name = "ButtomReturn";
            this.ButtomReturn.Size = new System.Drawing.Size(96, 53);
            this.ButtomReturn.TabIndex = 1;
            this.ButtomReturn.Text = "Επιστροφή";
            this.ButtomReturn.UseVisualStyleBackColor = false;
            this.ButtomReturn.Click += new System.EventHandler(this.ButtomReturn_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTitle.Location = new System.Drawing.Point(196, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(237, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Συνομιλία με Υπάλληλο";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(69, 76);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(478, 22);
            this.txtMessage.TabIndex = 3;
            // 
            // listChat
            // 
            this.listChat.FormattingEnabled = true;
            this.listChat.ItemHeight = 16;
            this.listChat.Location = new System.Drawing.Point(69, 197);
            this.listChat.Name = "listChat";
            this.listChat.Size = new System.Drawing.Size(478, 196);
            this.listChat.TabIndex = 4;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listChat);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.ButtomReturn);
            this.Controls.Add(this.ButtonSend);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Button ButtomReturn;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox listChat;
    }
}
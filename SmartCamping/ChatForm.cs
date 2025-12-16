using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCamping
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            string userMessage = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(userMessage)) return;

            listChat.Items.Add("Εσείς: " + userMessage);

            string[] replies = new string[]
            {
        "Θα το φροντίσουμε άμεσα.",
        "Παρακαλώ περιμένετε λίγα λεπτά.",       
        "Ο υπάλληλος ενημερώθηκε."
        
            };

            Random rnd = new Random();
            string response = replies[rnd.Next(replies.Length)];

            listChat.Items.Add("Υπάλληλος: " + response);

            txtMessage.Text = "";
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            listChat.Items.Add("Υπάλληλος: Καλώς ήρθατε στο chat εξυπηρέτησης!");
        }

        private void ButtomReturn_Click(object sender, EventArgs e)
        {
            MainMenuForm lf = new MainMenuForm();
            lf.Show();
            this.Hide();
        }
    }
}

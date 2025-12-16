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
    public partial class MapSelectionForm : Form
    {
        public MapSelectionForm()
        {
            InitializeComponent();
            Label_Feedback.Visible = false;
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            Label_Feedback.Visible = true;
            Label_Feedback.Text = "Σημείο A: Σταθερό έδαφος, καλός φωτισμός";
            Location = "Α";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            Label_Feedback.Visible = true;
            Label_Feedback.Text = "Σημείο B: Μαλακό έδαφος, υγρασία";
            Location = "Β";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            Label_Feedback.Visible = true;
            Label_Feedback.Text = "Σημείο Γ: Ιδανικό για στήσιμο – σταθερό και σκιερό";
            Location = "Γ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PegsForm pf = new PegsForm();
            pf.Show();
            this.Hide();
        }
        public static string Location;

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "➤ Επιλέξτε ένα από τα τρία διαθέσιμα σημεία στον χάρτη για να στήσετε τη σκηνή σας.\n" +
    "✔ Πατήστε το κουμπί με το αντίστοιχο γράμμα (A, B ή Γ) για να δείτε πληροφορίες για κάθε θέση:\n\n" +
    "✅ Αφού επιλέξετε σημείο, πατήστε 'Συνέχεια' για να προχωρήσετε στη ρύθμιση πασάλων.",
    "Βοήθεια - Επιλογή Σημείου Στησίματος",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
        }
    }
}

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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void ButtonSummary_Click(object sender, EventArgs e)
        {
            SummaryForm lf = new SummaryForm();
            lf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TourismForm lf = new TourismForm();
            lf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WeatherMonitorForm lf = new WeatherMonitorForm();
            lf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChatForm lf = new ChatForm();
            lf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderForm lf = new OrderForm();
            lf.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EventsForm lf = new EventsForm();
            lf.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 lf = new Form1();
            lf.Show();
            this.Hide();
        }

        private void ButtonFinished_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το project ολοκληρώθηκε με επιτυχία!\nΕυχαριστούμε που χρησιμοποιήσατε την εφαρμογή Smart Camping!", "Ολοκλήρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "📋 Από εδώ μπορείτε να πλοηγηθείτε στις διάφορες ενότητες της εφαρμογής:\n\n" +
    
    "Επιλέξτε την επιθυμητή λειτουργία για να συνεχίσετε.",
    "Βοήθεια Κεντρικού Μενού",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

        }
    }
}

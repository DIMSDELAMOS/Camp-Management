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
    public partial class PegsForm : Form
    {
        
        private bool validAngle = false;
        private bool validPressure = false;
        public PegsForm()
        {
            InitializeComponent();
           

    }
        public static int Angle;
        public static int Pressure;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Track_Angle_Scroll(object sender, EventArgs e)
        {
            Angle =Track_Angle.Value;
            validAngle = (Angle >= 45 && Angle <= 60);
            if (validAngle)
                Label_AngleFeedback.Text = $"✔ Ιδανική γωνία τοποθέτησης! ({Angle}°)";
            else
                Label_AngleFeedback.Text = $"✘ Η γωνία ίσως προκαλέσει αστάθεια. ({Angle}°)";

            CheckIfReady();
        }

        private void Track_Pressure_Scroll(object sender, EventArgs e)
        {
            Pressure = Track_Pressure.Value;
            validPressure = (Pressure >= 70 && Pressure <= 90);

            if (validPressure)
                Label_PressureFeedback.Text = $"✔ Καλή πίεση για σταθερότητα! ({Pressure}p)";
            else
                Label_PressureFeedback.Text = $"✘ Η πίεση είναι πολύ μικρή ή υπερβολική. ({Pressure}p)";

            CheckIfReady();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            ShadesFormBitmap sf = new ShadesFormBitmap();
            sf.Show();
            this.Hide();
        }
        private void CheckIfReady()
        {
            Button_Next.Visible = validAngle && validPressure;
        }

        private void PegsForm_Load(object sender, EventArgs e)
        {
            Button_Next.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "➤ Ρυθμίστε σωστά τη γωνία και την πίεση για τη σωστή τοποθέτηση των πασάλων.\n\n" +
    "✔ Χρησιμοποιήστε τον επάνω ολισθητή για να ορίσετε τη γωνία (ιδανική μεταξύ 45° και 60°).\n" +
    "✔ Χρησιμοποιήστε τον κάτω ολισθητή για να ρυθμίσετε την πίεση (ιδανική μεταξύ 70p και 90p).\n\n" +
    "✅ Όταν και οι δύο ρυθμίσεις είναι σωστές, εμφανίζεται το κουμπί 'Συνέχεια' για να προχωρήσετε.",
    "Βοήθεια - Ρύθμιση Πασάλων",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);

        }
    }
}

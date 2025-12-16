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
    public partial class EnergyForm : Form
    {
        public EnergyForm()
        {
            InitializeComponent();          
            Check_AC.CheckedChanged += Check_AC_CheckedChanged_1;
            Check_Lights.CheckedChanged += Check_Lights_CheckedChanged_1;
            Check_Devices.CheckedChanged += Check_Devices_CheckedChanged;

        }
       
        private void Check_Devices_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEnergySavingFeedback();
        }
        private void Check_AC_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateEnergySavingFeedback();
        }

        private void Check_Lights_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateEnergySavingFeedback();
        }
        private int batteryLevel ;
        private int consumptionLevel ;
        private int solarOutput ;
        private int initialBatteryLevel;

        private void UpdateEnergySavingFeedback()
        {
            List<string> actions = new List<string>();

            if (Check_AC.Checked) { actions.Add("το air condition");
                Actions += "-Απενεργοποίηση Air Condition\n";
            }
            if (Check_Lights.Checked) { actions.Add("τον φωτισμό");
                Actions += "-Μείωση έντασης φωτισμού\n";
            }
            if (Check_Devices.Checked) { actions.Add("τις συσκευές");
                Actions += "-Απενεργοποίηση μη απαραίτητων συσκευών\n";
            }

            if (actions.Count > 0)
            {
                string list = string.Join(", ", actions);
                Label_Feedback.ForeColor = Color.Green;
                Label_Feedback.Text = $"✅ Εξοικονομείται ενέργεια απενεργοποιώντας {list}.";
            }
            else
            {
                Label_Feedback.ForeColor = Color.DarkRed;
                Label_Feedback.Text = $"⚠ Δεν έχουν επιλεγεί ενέργειες για εξοικονόμηση.";
            }

            
            int consumption = consumptionLevel;
            int battery = initialBatteryLevel;

            
            if (Check_AC.Checked) consumption -= 15;
            if (Check_Lights.Checked) consumption -= 10;
            if (Check_Devices.Checked) consumption -= 8;

            consumption = Math.Max(consumption, 0);
            Label_Consumption.Text = $"Κατανάλωση: {consumption}%";
            FinalConsumption= consumption;
           
            int energyBoost = 0;
            if (Check_AC.Checked) energyBoost += 12;
            if (Check_Lights.Checked) energyBoost += 10;
            if (Check_Devices.Checked) energyBoost += 10;

           
            int newBattery = Math.Min(initialBatteryLevel + energyBoost, 100);
            batteryLevel = newBattery;
            FinalEnergy = newBattery;

            ProgressBar_Energy.Value = newBattery;
            Label_BatteryStatus.Text = $"Στάθμη ενέργειας: {newBattery}%";

            if (newBattery < 50)
            {
                Label_Advice.Text = "⚠ Χαμηλή ενέργεια – απαιτείται εξοικονόμηση.";
                Label_Advice.ForeColor = Color.DarkRed;
                Button_Next.Visible = false;
                Check_Override.Visible = true;

            }
            else
            {
                Label_Advice.Text = "✅ Επαρκής ενέργεια – το σύστημα λειτουργεί κανονικά.";
                Label_Advice.ForeColor = Color.Green;
                Check_Override.Visible = false;
                Check_Override.Checked = false;
                Button_Next.Visible = true;
            }

        }

        private void EnergyForm_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            initialBatteryLevel = rnd.Next(10, 100);
            solarOutput = rnd.Next(50, 100);
            consumptionLevel = rnd.Next(30, 90);
            batteryLevel = initialBatteryLevel;
            ProgressBar_Energy.Value = batteryLevel;
            Label_BatteryStatus.Text = $"Στάθμη ενέργειας: {batteryLevel}%";
            Label_SolarOutput.Text = $"Απόδοση φωτοβολταϊκών: {solarOutput}%";
            Label_Consumption.Text = $"Κατανάλωση: {consumptionLevel}%";
            if (batteryLevel < 50) 
            {
                Label_Advice.Text = "⚠ Χαμηλή ενέργεια - Συνιστάται εξοικονόμηση";
                Label_Advice.ForeColor = Color.DarkRed;
                Check_Override.Visible = true;
            }
            else if (batteryLevel >51) 
            {
                Label_Advice.Text = "✅ Επαρκής ενέργεια – το σύστημα λειτουργεί κανονικά.";
                Label_Advice.ForeColor = Color.Green;
                Button_Next.Visible= true;
            }
        }

        private void Check_Override_CheckedChanged(object sender, EventArgs e)
        {
            Button_Next.Visible = Check_Override.Checked;
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            NavigationForm lf = new NavigationForm();
            lf.Show();
            this.Hide();
            
        }
        public static int FinalEnergy;
        public static int FinalConsumption;
        public static string Actions="";
        private void Label_Advice_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "➤ Παρακολουθήστε και διαχειριστείτε την ενεργειακή κατάσταση της σκηνής.\n\n" +
    "• Στάθμη ενέργειας: Δείχνει την ποσότητα αποθηκευμένης ενέργειας στη μπαταρία.\n" +
    "• Απόδοση φωτοβολταϊκών: Πόση ενέργεια συλλέγεται από τα πάνελ.\n" +
    "• Κατανάλωση: Ενέργεια που καταναλώνεται από τις λειτουργίες της σκηνής.\n\n" +
    "✅ Επιλέξτε ενέργειες εξοικονόμησης:\n" +
    "   - Απενεργοποίηση Air Condition\n" +
    "   - Μείωση έντασης φωτισμού\n" +
    "   - Απενεργοποίηση μη απαραίτητων συσκευών\n\n" +
    "⚠ Αν η ενέργεια παραμένει χαμηλή (<50%), εμφανίζεται προειδοποίηση.\n" +
    "✔ Μπορείτε να συνεχίσετε με 'δική σας ευθύνη', ενεργοποιώντας τη σχετική επιλογή.",
    "Βοήθεια - Διαχείριση Ενέργειας",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);

        }
    }
}

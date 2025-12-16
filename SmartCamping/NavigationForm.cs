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
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();
        }
        private bool isLoading = false;
        private RadioButton radioNone = new RadioButton();


        private void radioShelterA_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading || !radioShelterA.Checked) return; 
            {
                labelDescription.Text = "Καταφύγιο Α – Κοντινό, αλλά το μονοπάτι έχει λασπόνερα και εμπόδια.";
                buttonNext.Visible = true;
                picMap.Image = Properties.Resources.ΚαταφύγιοΑ;
                Shelter = "Καταφύγιο Α";
            }
        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading || !radioShelterB.Checked) return;
            {
                labelDescription.Text = "Καταφύγιο Β – Μακρινό, αλλά πιο ασφαλές και σταθερό μονοπάτι.";
                buttonNext.Visible = true;
                picMap.Image = Properties.Resources.ΚαταφύγιοΒ;
                Shelter = "Καταφύγιο Β";
            }
        }
        private void radioShelterC_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading || !radioShelterC.Checked) return;
            {           
                labelDescription.Text = "Καταφύγιο Γ – Ιδανικό σε καλό καιρό.";
                buttonNext.Visible = true;
                picMap.Image = Properties.Resources.ΚαταφύγιοΓ;
                Shelter = "Καταφύγιο Γ";
            }
        }

        private void NavigationForm_Load(object sender, EventArgs e)
        {
            isLoading = true;
            radioNone.Visible = false;
            Controls.Add(radioNone); // για να "υπάρχει" στη φόρμα

            radioNone.Checked = true;
            labelDescription.Text = "Επιλέξτε ένα καταφύγιο για να δείτε τη διαδρομή.";
            buttonNext.Visible = false;
            picMap.Image = Properties.Resources.DefaultΧαρτης;
            isLoading = false;
            string[] conditions = {
    "☀️ Ηλιόλουστος καιρός – ιδανική μέρα για εύκολες διαδρομές.",
    "🌧️ Ήπια βροχή – καλύτερα να προτιμηθεί πιο ασφαλές μονοπάτι.",
    "⛈️ Καταιγίδα – αποφύγετε εκτεθειμένες διαδρομές και λασπωμένα μονοπάτια."
};

            string[] suggestions = {
    "Προτείνεται: Καταφύγιο Γ – Η διαδρομή είναι ευχάριστη με καλή ορατότητα.",
    "Προτείνεται: Καταφύγιο Β – Πιο σταθερή και ασφαλής διαδρομή.",
    "Προτείνεται: Καταφύγιο Β – Αποφύγετε Καταφύγιο Α λόγω εμποδίων."
};

            Random rnd = new Random();
            int index = rnd.Next(conditions.Length);

            labelWeather.Text = $"Καιρικές συνθήκες: {conditions[index]}";
            labelSuggestion.Text = suggestions[index];
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            MainMenuForm lf = new MainMenuForm();
            lf.Show();
            this.Hide();
        }
        public static string Shelter;

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "➤ Επιλέξτε ένα από τα διαθέσιμα καταφύγια για πλοήγηση:\n\n" +
   
    "📍 Η πρόταση διαδρομής αλλάζει αυτόματα με βάση τις καιρικές συνθήκες.\n\n" +
    "🗺️ Ο χάρτης προσαρμόζεται με την επιλεγμένη επιλογή.\n\n" +
    "➡ Πατήστε 'Συνέχεια' για να προχωρήσετε.",
    "Οδηγίες Πλοήγησης προς Καταφύγιο",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

        }
    }
}

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
    public partial class LightingForm : Form
    {
        public LightingForm()
        {
            InitializeComponent();
        }
        private bool isNight;
        private int brightness = -1;
        private Color selectedColor = Color.Empty;
        private string selectedEffect = "";

        private bool validBrightness = false;
        private bool validColor = false;
        private bool validEffect = false;

        private void LightingForm_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            isNight = rnd.Next(0, 2) == 1;

            if (isNight)
                Label_Conditions.Text = "🌙 Εντοπίστηκαν νυχτερινές συνθήκες. Συνιστάται χαμηλή ένταση.";
            else
                Label_Conditions.Text = "☀ Είναι ημέρα. Ο φωτισμός είναι προαιρετικός.";

            // ComboBox: Προσθήκη επιλογών
            ComboBox_Effect.Items.Clear();
            ComboBox_Effect.Items.AddRange(new string[] { "Σταθερό", "Παλλόμενο", "Αναβοσβήνει" });
            ComboBox_Effect.SelectedIndex = -1;

            // Απόκρυψη κουμπιού "Συνέχεια" στην αρχή
            Button_Continue.Visible = false;
        }
        private void ValidateSelections()
        {
            bool allSet = validBrightness && validColor && validEffect;
            Button_Continue.Visible = allSet;
        }

        private void TrackBar_Brightness_Scroll(object sender, EventArgs e)
        {
            brightness = TrackBar_Brightness.Value;

            if (isNight)
                validBrightness = brightness <= 30;
            else
                validBrightness = true; // επιτρέπεται κάθε τιμή

            Label_BrightnessFeedback.Text = $"Ένταση: {brightness}% " +
                (validBrightness ? "✔" : "✘ (υψηλή για νύχτα)");

            ValidateSelections();
            selectedBrightness = brightness;
        }

        private void Button_ColorSelect_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
                Panel_ColorPreview.BackColor = selectedColor;
                validColor = true;
                ValidateSelections();
                ColorSelected = colorDialog.Color.Name;
            }
        }

        private void ComboBox_Effect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEffect = ComboBox_Effect.SelectedItem?.ToString();
            validEffect = !string.IsNullOrEmpty(selectedEffect);
            ValidateSelections();
            Effect= selectedEffect;
        }

        private void Button_Continue_Click(object sender, EventArgs e)
        {
            EnergyForm lf = new EnergyForm();
            lf.Show();
            this.Hide();
        }
        public static string ColorSelected;
        public static int selectedBrightness;
        public static string Effect;

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "➤ Ρυθμίστε τον φωτισμό της σκηνής σας σύμφωνα με τις συνθήκες (ημέρα/νύχτα).\n\n" +
    "1. Ένταση: Μετακινήστε το ρυθμιστικό για να επιλέξετε την επιθυμητή φωτεινότητα.\n" +
    "2. Χρώμα: Πατήστε «Επιλογή» και διαλέξτε το επιθυμητό χρώμα φωτισμού.\n" +
    "3. Εφέ: Επιλέξτε εφέ φωτισμού (π.χ. Σταθερό, Παλλόμενο, Αναβοσβήνει).\n\n" +
    "✅ Όταν οριστούν όλα, θα ενεργοποιηθεί το κουμπί 'Συνέχεια' για μετάβαση.",
    "Βοήθεια - Ρύθμιση Φωτισμού",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);

        }
    }
}

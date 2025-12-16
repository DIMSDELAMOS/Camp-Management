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
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            Label_Location.Text = $"Θέση Στησίματος: {MapSelectionForm.Location}";
            Label_Pegs.Text = $"Πίεση: {PegsForm.Pressure}% | Γωνία: {PegsForm.Angle}°";

           
            if (ShadesFormBitmap.ShadesCount ==0)
            {
                Label_Shades.Text = "Τοποθετημένα Πανιά: Κανένα";
            }
            else
            {
                Label_Shades.Text = $"Τοποθετημένα Πανιά: {ShadesFormBitmap.Shades}";
            }

            Label_Lighting.Text = $" Φωτισμός: Χρώμα {LightingForm.ColorSelected}, Ένταση: {LightingForm.selectedBrightness}%, Εφέ: {LightingForm.Effect}";

            Label_Energy.Text = $"Ενέργεια: {EnergyForm.FinalEnergy}%, Κατανάλωση: {EnergyForm.FinalConsumption}%, Actions: {EnergyForm.Actions}";
            

            Label_Shelter.Text = $"Καταφύγιο Επιλογής: {NavigationForm.Shelter}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            MainMenuForm lf = new MainMenuForm();
            lf.Show();
            this.Hide();
        }
    }
}

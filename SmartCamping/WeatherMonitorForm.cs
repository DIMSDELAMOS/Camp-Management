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
    public partial class WeatherMonitorForm : Form
    {
        public WeatherMonitorForm()
        {
            InitializeComponent();
        }

        private void WeatherMonitorForm_Load(object sender, EventArgs e)
        {
            labelConditions.Text = "Καιρικές συνθήκες:\n";

            if (ShadesFormBitmap.Weather_WestWind)
                labelConditions.Text += "- Δυτικός άνεμος\n";

            if (ShadesFormBitmap.Weather_EastWind)
                labelConditions.Text += "- Ανατολικός άνεμος\n";

            if (ShadesFormBitmap.Weather_Rain)
                labelConditions.Text += "- Πιθανότητα βροχής\n";

            if (!ShadesFormBitmap.Weather_WestWind && !ShadesFormBitmap.Weather_EastWind && !ShadesFormBitmap.Weather_Rain)
                labelConditions.Text += "- Καμία ιδιαίτερη συνθήκη";

            labelPlacedShades.Text = "Τοποθετημένα πανιά:\n" + ShadesFormBitmap.Shades;
            if (ShadesFormBitmap.FinalScene != null)
                picPreview.Image = ShadesFormBitmap.FinalScene;
            else
                picPreview.Image = Properties.Resources.DefaultΧαρτης; // ή κάτι άλλο

        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            MainMenuForm lf = new MainMenuForm();
            lf.Show();
            this.Hide();
        }
    }
}

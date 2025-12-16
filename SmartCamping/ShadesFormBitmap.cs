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
    public partial class ShadesFormBitmap : Form
    {
        private bool placedWest = false;
        private bool placedEast = false;
        private bool placedRain = false;
        private bool westWind;
        private bool eastWind;
        private bool rain;
        private bool updated;
        Bitmap canvas;
        Graphics g;
        int tentX, tentY, scaledWidth, scaledHeight;
        Image tent, shade1, shade2, shade3;
        public static string Shades ="";
        public static int ShadesCount = 0;
        public static bool Weather_WestWind;
        public static bool Weather_EastWind;
        public static bool Weather_Rain;
        public static Bitmap FinalScene;
        public ShadesFormBitmap()
        {
            InitializeComponent();
          
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void ShadesFormBitmap_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int windOption = rnd.Next(0, 3);
            westWind = windOption == 1;
            eastWind = windOption == 2;
            rain = rnd.Next(0, 2) == 1;

            Label_Weather.Text = "Καιρικές συνθήκες:\n";
            if (westWind) { Label_Weather.Text += "- Δυτικός άνεμος\n"; ShadesCount += 1; }
            if (eastWind) { Label_Weather.Text += "- Ανατολικός άνεμος\n";  ShadesCount += 1; }
            if (rain) { Label_Weather.Text += "- Πιθανότητα βροχής\n"; ShadesCount += 1; }
            if (!westWind && !eastWind && !rain) { Label_Weather.Text += "- Καμία ιδιαίτερη συνθήκη"; ShadesCount = 0; } 
            button1.Visible = false;

            RedrawScene();

            picCanvas.AllowDrop = true;
            Weather_WestWind = westWind;
            Weather_EastWind = eastWind;
            Weather_Rain = rain;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LightingForm lf = new LightingForm(); 
            lf.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "➤ Σύμφωνα με τις τρέχουσες καιρικές συνθήκες (άνεμοι & βροχή), πρέπει να τοποθετήσετε τα κατάλληλα πανιά στη σκηνή.\n\n" +
    "🟫 Σύρετε τα πανιά από την περιοχή γύρω από τη σκηνή και αφήστε τα πάνω της για να τα εφαρμόσετε.\n" +
    "⚠ Μπορείτε να τοποθετήσετε ένα πανί μόνο αν είναι απαραίτητο (σύμφωνα με τον καιρό).\n\n" +
    "✅ Όταν τοποθετηθούν όλα τα απαραίτητα πανιά, θα εμφανιστεί το κουμπί 'Συνέχεια'.",
    "Βοήθεια - Προστατευτικά Πανιά",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);

        }

        private void Label_Shade1_MouseDown(object sender, MouseEventArgs e)
        {
            Label_Shade1.DoDragDrop("west", DragDropEffects.Move);
            this.Label_Shade1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_Shade1_MouseDown);
        }
  
       

        private void Label_Shade2_MouseDown_1(object sender, MouseEventArgs e)
        {
            Label_Shade2.DoDragDrop("east", DragDropEffects.Move);
            this.Label_Shade2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_Shade2_MouseDown_1);
        }

        private void Label_Shade3_MouseDown_1(object sender, MouseEventArgs e)
        {
            Label_Shade3.DoDragDrop("rain", DragDropEffects.Move);
            this.Label_Shade3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_Shade3_MouseDown_1);
        }
    

        private void picCanvas_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Move;
        }
        private void picCanvas_DragDrop(object sender, DragEventArgs e)
        {

            string type = e.Data.GetData(typeof(string)) as string;
            if (type == null) return;

            bool updated = false;

            if (type == "west" && westWind && !placedWest)
            {
                placedWest = true;
                Label_Shade1.Visible = false;
                updated = true;
                Shades += "-Δυτικό πανί\n";
            }
            else if (type == "east" && eastWind && !placedEast)
            {
                placedEast = true;
                Label_Shade2.Visible = false;
                updated = true;
                Shades += "-Ανατολικό πανί\n";
            }
            else if (type == "rain" && rain && !placedRain)
            {
                placedRain = true;
                Label_Shade3.Visible = false;
                updated = true;
                Shades += "-Πανί βροχής\n";
            }
            else
            {
                MessageBox.Show("Δεν επιτρέπεται η τοποθέτηση αυτού του πανιού με βάση τις καιρικές συνθήκες.");
            }

            if (updated)
                RedrawScene();

        }
        private void RedrawScene()
        {
            Bitmap canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            Graphics g = Graphics.FromImage(canvas);

            Image tent = Properties.Resources.Tent;
            Image shade1 = Properties.Resources.Shade1;
            Image shade2 = Properties.Resources.Shade2;
            Image shade3 = Properties.Resources.Shade3;

            int scaledWidth = tent.Width * 2 / 5;
            int scaledHeight = tent.Height * 2 / 5;
            int tentX = (canvas.Width - scaledWidth) / 2;
            int tentY = (canvas.Height - scaledHeight) / 2 - 20;

            // Σχεδίαση σκηνής
            g.DrawImage(tent, tentX, tentY, scaledWidth, scaledHeight);

            // Αρχικές θέσεις για μη τοποθετημένα πανιά
            if (!placedWest)
                g.DrawImage(shade1, 30, 30, 110, 65);

            if (!placedEast)
                g.DrawImage(shade2, canvas.Width - 140, 30, 110, 65);

            if (!placedRain)
                g.DrawImage(shade3, (canvas.Width - 180) / 2, tentY + scaledHeight + 20, 180, 50);

            // Τοποθετημένα πανιά
            if (placedWest)
                g.DrawImage(shade1, tentX - 40, tentY + 20, 110, 75);

            if (placedEast)
                g.DrawImage(shade2, tentX + scaledWidth - 70, tentY + 20, 110, 75);

            if (placedRain)
                g.DrawImage(shade3, tentX + (scaledWidth - 180) / 2, tentY - 50, 180, 50); // πάνω από τη σκηνή

            // Καιρικές συνθήκες
            Label_Weather.Text = "Καιρικές συνθήκες:\n";
            if (westWind) Label_Weather.Text += "- Δυτικός άνεμος\n";
            if (eastWind) Label_Weather.Text += "- Ανατολικός άνεμος\n";
            if (rain) Label_Weather.Text += "- Πιθανότητα βροχής\n";
            if (!westWind && !eastWind && !rain)
                Label_Weather.Text += "- Καμία ιδιαίτερη συνθήκη";
            button1.Visible = (!westWind || placedWest) &&
    (!eastWind || placedEast) &&
    (!rain || placedRain);
           

            picCanvas.Image = canvas;
            FinalScene = (Bitmap)canvas.Clone();
        }

    }
}

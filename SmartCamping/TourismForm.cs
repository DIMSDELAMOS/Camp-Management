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
    public partial class TourismForm : Form
    {
        public TourismForm()
        {
            InitializeComponent();
        }
        
        private RadioButton radioNone = new RadioButton();
        private void TourismForm_Load(object sender, EventArgs e)
        {
           
            radioNone.Visible = false;
            Controls.Add(radioNone); 
            radioNone.Checked = true;
             
        }

        

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            MainMenuForm lf = new MainMenuForm();
            lf.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Ιδανική για χαλάρωση και κολύμπι.";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Διαδρομή μέσα σε δάσος, με πανοραμική θέα.";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Πρόκληση για τους λάτρεις της δράσης.";
        }
    }
}

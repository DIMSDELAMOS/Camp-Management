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
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }



        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            MainMenuForm lf = new MainMenuForm();
            lf.Show();
            this.Hide();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            listEvents.Items.AddRange(new object[]
{
    "🎶 Συναυλία στο αμφιθέατρο (21:00)",
    "🏐 Τουρνουά beach volley (17:00)",
    "🗺️ Οργανωμένη πεζοπορία στο φαράγγι (10:00)",
    "🎬 Προβολή ταινίας στην ύπαιθρο (20:30)"
});
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (listEvents.CheckedItems.Count == 0)
            {
                labelFeedback.Text = "⚠ Δεν επιλέξατε καμία εκδήλωση.";
                labelFeedback.ForeColor = Color.DarkRed;
                return;
            }

            List<string> selected = new List<string>();
            foreach (var item in listEvents.CheckedItems)
                selected.Add(item.ToString());

            labelFeedback.Text = "✅ Δηλώσατε συμμετοχή στις εκδηλώσεις:\n" + string.Join("\n", selected);
            labelFeedback.ForeColor = Color.Green;
        }
    }
}

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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }






        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            MainMenuForm lf = new MainMenuForm();
            lf.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string item = comboItem.SelectedItem?.ToString();
            string time = comboTime.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(item) || string.IsNullOrEmpty(time))
            {
                MessageBox.Show("Παρακαλώ επιλέξτε είδος και ώρα παραγγελίας.");
                return;
            }

            string payment = "";

            if (checkPayNow.Checked)
                payment = "Η πληρωμή έγινε άμεσα.";
            else if (checkAddToAccount.Checked)
                payment = "Η παραγγελία προστέθηκε στον λογαριασμό σας.";
            else
                payment = "Δεν επιλέχθηκε τρόπος πληρωμής.";

            labelStatus.Text = $"✅ Παραγγείλατε: {item} για τις {time}.\n{payment}";
        }

    }
}


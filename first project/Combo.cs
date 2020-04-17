using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project
{
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
            // Adding item to Combobox

            cmbDays.Items.Add("Sunday");
            cmbDays.Items.Add("Monday");
            cmbDays.Items.Add("Tuesday");
            cmbDays.Items.Add("Wensday");
            cmbDays.Items.Add("Thursday");
            cmbDays.Items.Add("Friday");
            cmbDays.Items.Add("Saturday");
            cmbDays.Items.Add("Funday");
            cmbDays.Items.Add("Examday");
        }

        private void frmCombo_Load(object sender, EventArgs e)
        {


        }

        private void BtnMethod1_Click(object sender, EventArgs e)
        {
            //Using Method1

            MessageBox.Show(cmbDays.Text);

        }

        private void BtnMethod2_Click(object sender, EventArgs e)
        {
            //Method2
            var item = this.cmbDays.GetItemText(this.cmbDays.SelectedItem);
            MessageBox.Show(item);
        }

        private void BtnRBI_Click(object sender, EventArgs e)
        {
            cmbDays.Items.RemoveAt(1);
        }

        private void BtnRBN_Click(object sender, EventArgs e)
        {
            cmbDays.Items.Remove("Friday");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnRLI_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count >= 1)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cant remove last item");
            }
        }

        private void BtnR2LI_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count >= 2)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove 2nd last item");
            }

        }
    }
}

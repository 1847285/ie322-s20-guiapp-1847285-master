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
    public partial class RandomCombo : Form
    {

        Random r = new Random();
        public RandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            CmbAFF.ResetText();
            CmbAFF.Items.Clear();
            Random r = new Random();

            for (int i = 0; i < r.Next(1, 51); i++)
            {

                CmbAFF.Items.Add(r.Next(100, 999));
            }
        }
        private void RandomCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        { 
            CmbAFF.ResetText();
            CmbAFF.Items.Clear();
            RadBtnLT500.Checked = false;
            RadBtnGT500.Checked = false;
        }

        private void RadBtnLT500_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CmbAFF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CmbAFF.Text) > 499)
            {
                RadBtnGT500.Checked = true;
            }
            else
            {
                RadBtnLT500.Checked = true;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Generate2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                cmbRandom2.Items.Add(r.Next(10, 99));
            }
            labelAAF.Text = Convert.ToString(cmbRandom2.Items.Count);
        }

        private void cmbRandom2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbRandom2.Text) > 49)
            {
                rdoGreater2.Checked = true;
            }
            else
            {
                rdoLess2.Checked = true;
            }
        }

        private void Reset2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            rdoLess2.Checked = false;
            rdoGreater2.Checked = false;
            label1.Text = Convert.ToString(cmbRandom2.Items.Count);

        }
    }
}

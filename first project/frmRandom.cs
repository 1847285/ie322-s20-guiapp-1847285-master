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
    public partial class frmRandom : Form
    {
        Random y = new Random();
        public frmRandom()
        {
            InitializeComponent();
        }

        private void BtnGenerateRandomColor_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            label1.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            BtnGenerateRandomColor.BackColor = Color.FromArgb(r, g, b);

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void BtnRandomNumber_Click(object sender, EventArgs e)
        {
            BtnRandomNumber.Text = Convert.ToString(y.Next(1, 100));
        }
    }
}

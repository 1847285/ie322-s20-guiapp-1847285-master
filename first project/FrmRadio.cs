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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RdoBtnRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed1.Checked == true)
                rdoRed1.ForeColor = Color.FromArgb(255, 0, 0); // http://www.flounder.com/csharp_color_table.htm
            else
                rdoRed1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoBtnG_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen1.Checked == true)
                rdoGreen1.ForeColor = Color.FromName("green");
            else
                rdoGreen1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoBtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue1.Checked == true)
                rdoBlue1.ForeColor = Color.FromName("blue");
            else
                rdoBlue1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void FrmRadio_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rdoRed1.Checked = false;
            rdoGreen1.Checked = false;
            rdoBlue1.Checked = false;
            rdoYellow1.Checked = false;

            rdoRed1.ForeColor = Color.FromName("black");
            rdoGreen1.ForeColor = Color.FromName("black");
            rdoBlue1.ForeColor = Color.FromName("black");
            rdoYellow1.ForeColor = Color.FromName("black");

            RdoRed2.Checked = false;
            RdoGreen2.Checked = false;
            RdoBlue2.Checked = false;
            RdoYellow2.Checked = false;

            RdoRed2.ForeColor = Color.FromName("black");
            RdoGreen2.ForeColor = Color.FromName("black");
            RdoBlue2.ForeColor = Color.FromName("black");
            RdoYellow2.ForeColor = Color.FromName("black");
        }

        private void rdoYellow1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow1.Checked == true)
                rdoYellow1.ForeColor = Color.FromName("yellow");
            else
                rdoYellow1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            RdoRed2.ForeColor = Color.FromName("red");
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            RdoGreen2.ForeColor = Color.FromName("green");
        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            RdoBlue2.ForeColor = Color.FromName("blue");
        }

        private void RdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            RdoYellow2.ForeColor = Color.FromName("yellow");
        }
    }
}

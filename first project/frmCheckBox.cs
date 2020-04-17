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
    public partial class frmCheckBox : Form
    {
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (chkCoffee.Checked == true)
            {
                msg = chkCoffee.Text;
            }

            if (chkDonut.Checked == true)
            {
                msg = msg + " " + chkDonut.Text;
            }

            if (chkBrownis.Checked == true)
            {
                msg = msg + " " + chkBrownis.Text;
            }

            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " selected ");
            }
            else //length is zero
            {
                MessageBox.Show("Nothing selected");
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
    
}

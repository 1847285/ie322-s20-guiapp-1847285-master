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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUser.Text=="Turki")
            { 
                if (TxtPW.Text =="6220")
                {
                    MessageBox.Show("Login Successful");
                }
                else
                {

                    MessageBox.Show("Invalid Password");
                }
            }
            else
            { MessageBox.Show("Incorrect username"); 
            
            }
            
        }

        private void BtnRad_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            frmCheckBox frm = new frmCheckBox();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void BtnRC_Click(object sender, EventArgs e)
        {
            RandomCombo frm = new RandomCombo();
            frm.ShowDialog();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void BtnPB1_Click(object sender, EventArgs e)
        {
            frmPicture frm = new frmPicture();
            frm.ShowDialog();
        }

        private void BtnPB2_Click(object sender, EventArgs e)
        {
            frmPicture2 frm = new frmPicture2();
            frm.ShowDialog();
        }
    }
}

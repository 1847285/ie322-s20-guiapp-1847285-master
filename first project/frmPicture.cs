using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;            //for strem object
using System.Reflection;   //for assembly

namespace first_project
{
   

    public partial class frmPicture : Form
    {
        Assembly _assembly;
        Stream _imageStream;

        public frmPicture()
        {
            InitializeComponent();

            picTry.SizeMode = PictureBoxSizeMode.StretchImage;
            picTry2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {

                picTry.Image = Image.FromFile("C:\\Users\\HP\\Desktop\\turki.jpg");
            }
            catch
            {
                MessageBox.Show("Image file not found");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmPicture_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("first_project.res.T9.JPG");
        }

        private void BtnImageResource_Click(object sender, EventArgs e)
        {
            try
            {
                picTry2.Image = Image.FromStream(_imageStream);
            }
            catch {
                MessageBox.Show("Error creating image from resource!");
                  }
                

        }

        private void picTry2_Click(object sender, EventArgs e)
        {

        }
    }
}

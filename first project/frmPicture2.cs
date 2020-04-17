using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;             
using System.Reflection;

namespace first_project
{
    public partial class frmPicture2 : Form
    {
        Assembly _assembly;
        Stream _imageStream;

        public frmPicture2()
        {
            InitializeComponent();

            PicTry1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void frmPicture2_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("first_project.res.T9.JPG");

        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {

                PicTry1.Image = Image.FromStream(_imageStream);

            }
            catch
            {
                MessageBox.Show("Error creating image!");
            }

        }
    }
}

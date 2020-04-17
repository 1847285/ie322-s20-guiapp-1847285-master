namespace first_project
{
    partial class frmPicture2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLoadImage = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PicTry1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadImage
            // 
            this.BtnLoadImage.BackColor = System.Drawing.Color.Blue;
            this.BtnLoadImage.Location = new System.Drawing.Point(65, 57);
            this.BtnLoadImage.Name = "BtnLoadImage";
            this.BtnLoadImage.Size = new System.Drawing.Size(79, 49);
            this.BtnLoadImage.TabIndex = 0;
            this.BtnLoadImage.Text = "Load Image";
            this.BtnLoadImage.UseVisualStyleBackColor = false;
            this.BtnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Red;
            this.BtnBack.Location = new System.Drawing.Point(65, 238);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(79, 33);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PicTry1
            // 
            this.PicTry1.Location = new System.Drawing.Point(280, 57);
            this.PicTry1.Name = "PicTry1";
            this.PicTry1.Size = new System.Drawing.Size(270, 254);
            this.PicTry1.TabIndex = 2;
            this.PicTry1.TabStop = false;
            // 
            // frmPicture2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.PicTry1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnLoadImage);
            this.Name = "frmPicture2";
            this.Text = "frmPicture2";
            this.Load += new System.EventHandler(this.frmPicture2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicTry1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadImage;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PicTry1;
    }
}
namespace first_project
{
    partial class frmPicture
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
            this.picTry = new System.Windows.Forms.PictureBox();
            this.picTry2 = new System.Windows.Forms.PictureBox();
            this.BtnLoadImage = new System.Windows.Forms.Button();
            this.BtnImageResource = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(15, 20);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(242, 261);
            this.picTry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTry.TabIndex = 0;
            this.picTry.TabStop = false;
            // 
            // picTry2
            // 
            this.picTry2.Location = new System.Drawing.Point(307, 20);
            this.picTry2.Name = "picTry2";
            this.picTry2.Size = new System.Drawing.Size(231, 261);
            this.picTry2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTry2.TabIndex = 1;
            this.picTry2.TabStop = false;
            this.picTry2.Click += new System.EventHandler(this.picTry2_Click);
            // 
            // BtnLoadImage
            // 
            this.BtnLoadImage.BackColor = System.Drawing.Color.Blue;
            this.BtnLoadImage.Location = new System.Drawing.Point(189, 14);
            this.BtnLoadImage.Name = "BtnLoadImage";
            this.BtnLoadImage.Size = new System.Drawing.Size(102, 37);
            this.BtnLoadImage.TabIndex = 2;
            this.BtnLoadImage.Text = "Image from a File";
            this.BtnLoadImage.UseVisualStyleBackColor = false;
            this.BtnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // BtnImageResource
            // 
            this.BtnImageResource.BackColor = System.Drawing.Color.Blue;
            this.BtnImageResource.Location = new System.Drawing.Point(480, 14);
            this.BtnImageResource.Name = "BtnImageResource";
            this.BtnImageResource.Size = new System.Drawing.Size(105, 37);
            this.BtnImageResource.TabIndex = 3;
            this.BtnImageResource.Text = "Image from a Resource";
            this.BtnImageResource.UseVisualStyleBackColor = false;
            this.BtnImageResource.Click += new System.EventHandler(this.BtnImageResource_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTry2);
            this.groupBox1.Controls.Add(this.picTry);
            this.groupBox1.Location = new System.Drawing.Point(108, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 301);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture Boxes";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Red;
            this.BtnBack.Location = new System.Drawing.Point(672, 319);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(81, 30);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnImageResource);
            this.Controls.Add(this.BtnLoadImage);
            this.Name = "frmPicture";
            this.Text = "frmPicture";
            this.Load += new System.EventHandler(this.frmPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.PictureBox picTry2;
        private System.Windows.Forms.Button BtnLoadImage;
        private System.Windows.Forms.Button BtnImageResource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBack;
    }
}
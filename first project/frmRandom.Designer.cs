namespace first_project
{
    partial class frmRandom
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
            this.BtnGenerateRandomColor = new System.Windows.Forms.Button();
            this.BtnRandomNumber = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGenerateRandomColor
            // 
            this.BtnGenerateRandomColor.Location = new System.Drawing.Point(40, 33);
            this.BtnGenerateRandomColor.Name = "BtnGenerateRandomColor";
            this.BtnGenerateRandomColor.Size = new System.Drawing.Size(185, 53);
            this.BtnGenerateRandomColor.TabIndex = 0;
            this.BtnGenerateRandomColor.Text = "Generate Random Color";
            this.BtnGenerateRandomColor.UseVisualStyleBackColor = true;
            this.BtnGenerateRandomColor.Click += new System.EventHandler(this.BtnGenerateRandomColor_Click);
            // 
            // BtnRandomNumber
            // 
            this.BtnRandomNumber.Location = new System.Drawing.Point(12, 205);
            this.BtnRandomNumber.Name = "BtnRandomNumber";
            this.BtnRandomNumber.Size = new System.Drawing.Size(100, 42);
            this.BtnRandomNumber.TabIndex = 1;
            this.BtnRandomNumber.Text = "Random Nunber";
            this.BtnRandomNumber.UseVisualStyleBackColor = true;
            this.BtnRandomNumber.Click += new System.EventHandler(this.BtnRandomNumber_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Red;
            this.BtnBack.Location = new System.Drawing.Point(194, 287);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(88, 32);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "r-g-b";
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRandomNumber);
            this.Controls.Add(this.BtnGenerateRandomColor);
            this.Name = "frmRandom";
            this.Text = "frmRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerateRandomColor;
        private System.Windows.Forms.Button BtnRandomNumber;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
    }
}
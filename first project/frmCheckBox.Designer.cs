namespace first_project
{
    partial class frmCheckBox
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.chkBrownis = new System.Windows.Forms.CheckBox();
            this.chkDonut = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.Blue;
            this.BtnShow.Location = new System.Drawing.Point(74, 37);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 36);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Red;
            this.BtnBack.Location = new System.Drawing.Point(74, 192);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(82, 39);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(86, 100);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(57, 17);
            this.chkCoffee.TabIndex = 2;
            this.chkCoffee.Text = "Coffee";
            this.chkCoffee.UseVisualStyleBackColor = true;
            // 
            // chkBrownis
            // 
            this.chkBrownis.AutoSize = true;
            this.chkBrownis.Location = new System.Drawing.Point(86, 146);
            this.chkBrownis.Name = "chkBrownis";
            this.chkBrownis.Size = new System.Drawing.Size(63, 17);
            this.chkBrownis.TabIndex = 3;
            this.chkBrownis.Text = "Brownis";
            this.chkBrownis.UseVisualStyleBackColor = true;
            // 
            // chkDonut
            // 
            this.chkDonut.AutoSize = true;
            this.chkDonut.Location = new System.Drawing.Point(86, 123);
            this.chkDonut.Name = "chkDonut";
            this.chkDonut.Size = new System.Drawing.Size(55, 17);
            this.chkDonut.TabIndex = 4;
            this.chkDonut.Text = "Donut";
            this.chkDonut.UseVisualStyleBackColor = true;
            // 
            // frmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.chkDonut);
            this.Controls.Add(this.chkBrownis);
            this.Controls.Add(this.chkCoffee);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnShow);
            this.Name = "frmCheckBox";
            this.Text = "frmCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.CheckBox chkBrownis;
        private System.Windows.Forms.CheckBox chkDonut;
    }
}
namespace first_project
{
    partial class frmCombo
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
            this.BtnMethod1 = new System.Windows.Forms.Button();
            this.BtnMethod2 = new System.Windows.Forms.Button();
            this.BtnRLI = new System.Windows.Forms.Button();
            this.BtnR2LI = new System.Windows.Forms.Button();
            this.BtnRBN = new System.Windows.Forms.Button();
            this.BtnRBI = new System.Windows.Forms.Button();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMethod1
            // 
            this.BtnMethod1.Location = new System.Drawing.Point(44, 45);
            this.BtnMethod1.Name = "BtnMethod1";
            this.BtnMethod1.Size = new System.Drawing.Size(90, 38);
            this.BtnMethod1.TabIndex = 0;
            this.BtnMethod1.Text = "Show selected method1";
            this.BtnMethod1.UseVisualStyleBackColor = true;
            this.BtnMethod1.Click += new System.EventHandler(this.BtnMethod1_Click);
            // 
            // BtnMethod2
            // 
            this.BtnMethod2.Location = new System.Drawing.Point(192, 45);
            this.BtnMethod2.Name = "BtnMethod2";
            this.BtnMethod2.Size = new System.Drawing.Size(90, 38);
            this.BtnMethod2.TabIndex = 1;
            this.BtnMethod2.Text = "Show selected method 2";
            this.BtnMethod2.UseVisualStyleBackColor = true;
            this.BtnMethod2.Click += new System.EventHandler(this.BtnMethod2_Click);
            // 
            // BtnRLI
            // 
            this.BtnRLI.Location = new System.Drawing.Point(314, 118);
            this.BtnRLI.Name = "BtnRLI";
            this.BtnRLI.Size = new System.Drawing.Size(90, 41);
            this.BtnRLI.TabIndex = 2;
            this.BtnRLI.Text = "Remve last item";
            this.BtnRLI.UseVisualStyleBackColor = true;
            this.BtnRLI.Click += new System.EventHandler(this.BtnRLI_Click);
            // 
            // BtnR2LI
            // 
            this.BtnR2LI.Location = new System.Drawing.Point(314, 202);
            this.BtnR2LI.Name = "BtnR2LI";
            this.BtnR2LI.Size = new System.Drawing.Size(93, 43);
            this.BtnR2LI.TabIndex = 3;
            this.BtnR2LI.Text = "Remove 2nd last item";
            this.BtnR2LI.UseVisualStyleBackColor = true;
            this.BtnR2LI.Click += new System.EventHandler(this.BtnR2LI_Click);
            // 
            // BtnRBN
            // 
            this.BtnRBN.Location = new System.Drawing.Point(192, 255);
            this.BtnRBN.Name = "BtnRBN";
            this.BtnRBN.Size = new System.Drawing.Size(86, 37);
            this.BtnRBN.TabIndex = 4;
            this.BtnRBN.Text = "Remve by name";
            this.BtnRBN.UseVisualStyleBackColor = true;
            this.BtnRBN.Click += new System.EventHandler(this.BtnRBN_Click);
            // 
            // BtnRBI
            // 
            this.BtnRBI.Location = new System.Drawing.Point(44, 255);
            this.BtnRBI.Name = "BtnRBI";
            this.BtnRBI.Size = new System.Drawing.Size(90, 37);
            this.BtnRBI.TabIndex = 5;
            this.BtnRBI.Text = "Remove by index";
            this.BtnRBI.UseVisualStyleBackColor = true;
            this.BtnRBI.Click += new System.EventHandler(this.BtnRBI_Click);
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(73, 163);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(121, 21);
            this.cmbDays.TabIndex = 6;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Red;
            this.BtnBack.Location = new System.Drawing.Point(577, 299);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.BtnRBI);
            this.Controls.Add(this.BtnRBN);
            this.Controls.Add(this.BtnR2LI);
            this.Controls.Add(this.BtnRLI);
            this.Controls.Add(this.BtnMethod2);
            this.Controls.Add(this.BtnMethod1);
            this.Name = "frmCombo";
            this.Text = "frmCombo";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMethod1;
        private System.Windows.Forms.Button BtnMethod2;
        private System.Windows.Forms.Button BtnRLI;
        private System.Windows.Forms.Button BtnR2LI;
        private System.Windows.Forms.Button BtnRBN;
        private System.Windows.Forms.Button BtnRBI;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Button BtnBack;
    }
}
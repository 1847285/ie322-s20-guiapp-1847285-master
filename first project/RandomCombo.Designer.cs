namespace first_project
{
    partial class RandomCombo
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.CmbAFF = new System.Windows.Forms.ComboBox();
            this.RadBtnLT500 = new System.Windows.Forms.RadioButton();
            this.RadBtnGT500 = new System.Windows.Forms.RadioButton();
            this.labelAAF = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoGreater2 = new System.Windows.Forms.RadioButton();
            this.rdoLess2 = new System.Windows.Forms.RadioButton();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.Reset2 = new System.Windows.Forms.Button();
            this.Generate2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(177, 74);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(177, 163);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // CmbAFF
            // 
            this.CmbAFF.FormattingEnabled = true;
            this.CmbAFF.Location = new System.Drawing.Point(32, 76);
            this.CmbAFF.Name = "CmbAFF";
            this.CmbAFF.Size = new System.Drawing.Size(121, 21);
            this.CmbAFF.TabIndex = 5;
            this.CmbAFF.SelectedIndexChanged += new System.EventHandler(this.CmbAFF_SelectedIndexChanged);
            // 
            // RadBtnLT500
            // 
            this.RadBtnLT500.AutoSize = true;
            this.RadBtnLT500.Location = new System.Drawing.Point(32, 117);
            this.RadBtnLT500.Name = "RadBtnLT500";
            this.RadBtnLT500.Size = new System.Drawing.Size(96, 17);
            this.RadBtnLT500.TabIndex = 6;
            this.RadBtnLT500.TabStop = true;
            this.RadBtnLT500.Text = "Less Than 500";
            this.RadBtnLT500.UseVisualStyleBackColor = true;
            this.RadBtnLT500.CheckedChanged += new System.EventHandler(this.RadBtnLT500_CheckedChanged);
            // 
            // RadBtnGT500
            // 
            this.RadBtnGT500.AutoSize = true;
            this.RadBtnGT500.Location = new System.Drawing.Point(32, 141);
            this.RadBtnGT500.Name = "RadBtnGT500";
            this.RadBtnGT500.Size = new System.Drawing.Size(103, 17);
            this.RadBtnGT500.TabIndex = 7;
            this.RadBtnGT500.TabStop = true;
            this.RadBtnGT500.Text = "Greater Than 50";
            this.RadBtnGT500.UseVisualStyleBackColor = true;
            // 
            // labelAAF
            // 
            this.labelAAF.AutoSize = true;
            this.labelAAF.Location = new System.Drawing.Point(40, 23);
            this.labelAAF.Name = "labelAAF";
            this.labelAAF.Size = new System.Drawing.Size(78, 13);
            this.labelAAF.TabIndex = 8;
            this.labelAAF.Text = "Quiz03_AAF19";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoGreater2);
            this.groupBox1.Controls.Add(this.rdoLess2);
            this.groupBox1.Controls.Add(this.cmbRandom2);
            this.groupBox1.Controls.Add(this.Reset2);
            this.groupBox1.Controls.Add(this.Generate2);
            this.groupBox1.Location = new System.Drawing.Point(441, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 236);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quiz03_EAF19";
            // 
            // rdoGreater2
            // 
            this.rdoGreater2.AutoSize = true;
            this.rdoGreater2.Location = new System.Drawing.Point(52, 155);
            this.rdoGreater2.Name = "rdoGreater2";
            this.rdoGreater2.Size = new System.Drawing.Size(103, 17);
            this.rdoGreater2.TabIndex = 13;
            this.rdoGreater2.TabStop = true;
            this.rdoGreater2.Text = "Greater Than 50";
            this.rdoGreater2.UseVisualStyleBackColor = true;
            // 
            // rdoLess2
            // 
            this.rdoLess2.AutoSize = true;
            this.rdoLess2.Location = new System.Drawing.Point(52, 131);
            this.rdoLess2.Name = "rdoLess2";
            this.rdoLess2.Size = new System.Drawing.Size(96, 17);
            this.rdoLess2.TabIndex = 12;
            this.rdoLess2.TabStop = true;
            this.rdoLess2.Text = "Less Than 500";
            this.rdoLess2.UseVisualStyleBackColor = true;
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(52, 90);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(121, 21);
            this.cmbRandom2.TabIndex = 11;
            this.cmbRandom2.SelectedIndexChanged += new System.EventHandler(this.cmbRandom2_SelectedIndexChanged);
            // 
            // Reset2
            // 
            this.Reset2.Location = new System.Drawing.Point(197, 177);
            this.Reset2.Name = "Reset2";
            this.Reset2.Size = new System.Drawing.Size(75, 23);
            this.Reset2.TabIndex = 10;
            this.Reset2.Text = "Reset";
            this.Reset2.UseVisualStyleBackColor = true;
            this.Reset2.Click += new System.EventHandler(this.Reset2_Click);
            // 
            // Generate2
            // 
            this.Generate2.Location = new System.Drawing.Point(197, 88);
            this.Generate2.Name = "Generate2";
            this.Generate2.Size = new System.Drawing.Size(75, 23);
            this.Generate2.TabIndex = 9;
            this.Generate2.Text = "Generate";
            this.Generate2.UseVisualStyleBackColor = true;
            this.Generate2.Click += new System.EventHandler(this.Generate2_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Red;
            this.BtnBack.Location = new System.Drawing.Point(53, 265);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // RandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAAF);
            this.Controls.Add(this.RadBtnGT500);
            this.Controls.Add(this.RadBtnLT500);
            this.Controls.Add(this.CmbAFF);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "RandomCombo";
            this.Text = "RandomCombo";
            this.Load += new System.EventHandler(this.RandomCombo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.ComboBox CmbAFF;
        private System.Windows.Forms.RadioButton RadBtnLT500;
        private System.Windows.Forms.RadioButton RadBtnGT500;
        private System.Windows.Forms.Label labelAAF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoGreater2;
        private System.Windows.Forms.RadioButton rdoLess2;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.Button Reset2;
        private System.Windows.Forms.Button Generate2;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
    }
}
namespace hastaneproje
{
    partial class frmhastagirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhastagirisi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.Lnküyeol = new System.Windows.Forms.LinkLabel();
            this.Btngirisyap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(142, 71);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(126, 31);
            this.MskTc.TabIndex = 1;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(142, 113);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(126, 31);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // Lnküyeol
            // 
            this.Lnküyeol.AutoSize = true;
            this.Lnküyeol.Location = new System.Drawing.Point(289, 121);
            this.Lnküyeol.Name = "Lnküyeol";
            this.Lnküyeol.Size = new System.Drawing.Size(65, 23);
            this.Lnküyeol.TabIndex = 4;
            this.Lnküyeol.TabStop = true;
            this.Lnküyeol.Text = "Üye Ol";
            this.Lnküyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnküyeol_LinkClicked);
            // 
            // Btngirisyap
            // 
            this.Btngirisyap.Location = new System.Drawing.Point(142, 160);
            this.Btngirisyap.Name = "Btngirisyap";
            this.Btngirisyap.Size = new System.Drawing.Size(187, 46);
            this.Btngirisyap.TabIndex = 3;
            this.Btngirisyap.Text = "Giriş Yap";
            this.Btngirisyap.UseVisualStyleBackColor = true;
            this.Btngirisyap.Click += new System.EventHandler(this.Btngirisyap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // frmhastagirisi
            // 
            this.AcceptButton = this.Btngirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(409, 218);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btngirisyap);
            this.Controls.Add(this.Lnküyeol);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmhastagirisi";
            this.Text = "Hasta Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.LinkLabel Lnküyeol;
        private System.Windows.Forms.Button Btngirisyap;
        private System.Windows.Forms.Label label3;
    }
}

namespace HastaneYonetimSistemi
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbHastaCinsiyet = new System.Windows.Forms.ComboBox();
            this.TxtHastaAd = new System.Windows.Forms.TextBox();
            this.TxtHastaSoyad = new System.Windows.Forms.TextBox();
            this.MskHastaTc = new System.Windows.Forms.MaskedTextBox();
            this.MskhastaTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtHastaSifre = new System.Windows.Forms.TextBox();
            this.BtnHastaKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(94, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet :";
            // 
            // CmbHastaCinsiyet
            // 
            this.CmbHastaCinsiyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbHastaCinsiyet.FormattingEnabled = true;
            this.CmbHastaCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbHastaCinsiyet.Location = new System.Drawing.Point(198, 246);
            this.CmbHastaCinsiyet.Name = "CmbHastaCinsiyet";
            this.CmbHastaCinsiyet.Size = new System.Drawing.Size(213, 41);
            this.CmbHastaCinsiyet.TabIndex = 6;
            // 
            // TxtHastaAd
            // 
            this.TxtHastaAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtHastaAd.Location = new System.Drawing.Point(198, 16);
            this.TxtHastaAd.Name = "TxtHastaAd";
            this.TxtHastaAd.Size = new System.Drawing.Size(213, 40);
            this.TxtHastaAd.TabIndex = 1;
            // 
            // TxtHastaSoyad
            // 
            this.TxtHastaSoyad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtHastaSoyad.Location = new System.Drawing.Point(198, 62);
            this.TxtHastaSoyad.Name = "TxtHastaSoyad";
            this.TxtHastaSoyad.Size = new System.Drawing.Size(213, 40);
            this.TxtHastaSoyad.TabIndex = 2;
            // 
            // MskHastaTc
            // 
            this.MskHastaTc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MskHastaTc.Location = new System.Drawing.Point(198, 108);
            this.MskHastaTc.Mask = "00000000000";
            this.MskHastaTc.Name = "MskHastaTc";
            this.MskHastaTc.Size = new System.Drawing.Size(213, 40);
            this.MskHastaTc.TabIndex = 3;
            this.MskHastaTc.ValidatingType = typeof(int);
            // 
            // MskhastaTelefon
            // 
            this.MskhastaTelefon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MskhastaTelefon.Location = new System.Drawing.Point(198, 154);
            this.MskhastaTelefon.Mask = "(999) 000-0000";
            this.MskhastaTelefon.Name = "MskhastaTelefon";
            this.MskhastaTelefon.Size = new System.Drawing.Size(213, 40);
            this.MskhastaTelefon.TabIndex = 4;
            // 
            // TxtHastaSifre
            // 
            this.TxtHastaSifre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtHastaSifre.Location = new System.Drawing.Point(198, 200);
            this.TxtHastaSifre.Name = "TxtHastaSifre";
            this.TxtHastaSifre.Size = new System.Drawing.Size(213, 40);
            this.TxtHastaSifre.TabIndex = 5;
            // 
            // BtnHastaKayit
            // 
            this.BtnHastaKayit.BackColor = System.Drawing.Color.Lime;
            this.BtnHastaKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHastaKayit.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHastaKayit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnHastaKayit.Location = new System.Drawing.Point(198, 293);
            this.BtnHastaKayit.Name = "BtnHastaKayit";
            this.BtnHastaKayit.Size = new System.Drawing.Size(209, 54);
            this.BtnHastaKayit.TabIndex = 12;
            this.BtnHastaKayit.Text = "Kayıt Ol";
            this.BtnHastaKayit.UseVisualStyleBackColor = false;
            this.BtnHastaKayit.Click += new System.EventHandler(this.BtnHastaKayit_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnHastaKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(443, 362);
            this.Controls.Add(this.BtnHastaKayit);
            this.Controls.Add(this.TxtHastaSifre);
            this.Controls.Add(this.MskhastaTelefon);
            this.Controls.Add(this.MskHastaTc);
            this.Controls.Add(this.TxtHastaSoyad);
            this.Controls.Add(this.TxtHastaAd);
            this.Controls.Add(this.CmbHastaCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbHastaCinsiyet;
        private System.Windows.Forms.TextBox TxtHastaAd;
        private System.Windows.Forms.TextBox TxtHastaSoyad;
        private System.Windows.Forms.MaskedTextBox MskHastaTc;
        private System.Windows.Forms.MaskedTextBox MskhastaTelefon;
        private System.Windows.Forms.TextBox TxtHastaSifre;
        private System.Windows.Forms.Button BtnHastaKayit;
    }
}
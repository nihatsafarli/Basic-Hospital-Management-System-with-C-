
namespace HastaneYonetimSistemi
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.BtnBilgiGuncelle = new System.Windows.Forms.Button();
            this.TxtHastaSifre = new System.Windows.Forms.TextBox();
            this.MskhastaTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MskHastaTc = new System.Windows.Forms.MaskedTextBox();
            this.TxtHastaSoyad = new System.Windows.Forms.TextBox();
            this.TxtHastaAd = new System.Windows.Forms.TextBox();
            this.CmbHastaCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBilgiGuncelle
            // 
            this.BtnBilgiGuncelle.BackColor = System.Drawing.Color.Lime;
            this.BtnBilgiGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBilgiGuncelle.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBilgiGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBilgiGuncelle.Location = new System.Drawing.Point(203, 289);
            this.BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            this.BtnBilgiGuncelle.Size = new System.Drawing.Size(209, 53);
            this.BtnBilgiGuncelle.TabIndex = 25;
            this.BtnBilgiGuncelle.Text = "Güncelle";
            this.BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.BtnBilgiGuncelle.Click += new System.EventHandler(this.BtnBilgiGuncelle_Click);
            // 
            // TxtHastaSifre
            // 
            this.TxtHastaSifre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtHastaSifre.Location = new System.Drawing.Point(203, 196);
            this.TxtHastaSifre.Name = "TxtHastaSifre";
            this.TxtHastaSifre.Size = new System.Drawing.Size(213, 36);
            this.TxtHastaSifre.TabIndex = 5;
            // 
            // MskhastaTelefon
            // 
            this.MskhastaTelefon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MskhastaTelefon.Location = new System.Drawing.Point(203, 150);
            this.MskhastaTelefon.Mask = "(999) 000-0000";
            this.MskhastaTelefon.Name = "MskhastaTelefon";
            this.MskhastaTelefon.Size = new System.Drawing.Size(213, 36);
            this.MskhastaTelefon.TabIndex = 4;
            // 
            // MskHastaTc
            // 
            this.MskHastaTc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MskHastaTc.Location = new System.Drawing.Point(203, 104);
            this.MskHastaTc.Mask = "00000000000";
            this.MskHastaTc.Name = "MskHastaTc";
            this.MskHastaTc.Size = new System.Drawing.Size(213, 36);
            this.MskHastaTc.TabIndex = 3;
            this.MskHastaTc.ValidatingType = typeof(int);
            // 
            // TxtHastaSoyad
            // 
            this.TxtHastaSoyad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtHastaSoyad.Location = new System.Drawing.Point(203, 58);
            this.TxtHastaSoyad.Name = "TxtHastaSoyad";
            this.TxtHastaSoyad.Size = new System.Drawing.Size(213, 36);
            this.TxtHastaSoyad.TabIndex = 2;
            // 
            // TxtHastaAd
            // 
            this.TxtHastaAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtHastaAd.Location = new System.Drawing.Point(203, 12);
            this.TxtHastaAd.Name = "TxtHastaAd";
            this.TxtHastaAd.Size = new System.Drawing.Size(213, 36);
            this.TxtHastaAd.TabIndex = 1;
            // 
            // CmbHastaCinsiyet
            // 
            this.CmbHastaCinsiyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbHastaCinsiyet.FormattingEnabled = true;
            this.CmbHastaCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbHastaCinsiyet.Location = new System.Drawing.Point(203, 242);
            this.CmbHastaCinsiyet.Name = "CmbHastaCinsiyet";
            this.CmbHastaCinsiyet.Size = new System.Drawing.Size(209, 36);
            this.CmbHastaCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(58, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cinsiyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 35);
            this.label5.TabIndex = 17;
            this.label5.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefon : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad : ";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.BtnBilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 349);
            this.Controls.Add(this.BtnBilgiGuncelle);
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
            this.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Hasta Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBilgiGuncelle;
        private System.Windows.Forms.TextBox TxtHastaSifre;
        private System.Windows.Forms.MaskedTextBox MskhastaTelefon;
        private System.Windows.Forms.MaskedTextBox MskHastaTc;
        private System.Windows.Forms.TextBox TxtHastaSoyad;
        private System.Windows.Forms.TextBox TxtHastaAd;
        private System.Windows.Forms.ComboBox CmbHastaCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
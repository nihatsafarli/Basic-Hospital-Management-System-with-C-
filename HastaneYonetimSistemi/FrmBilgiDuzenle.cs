using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneYonetimSistemi
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskHastaTc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select *From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskHastaTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtHastaAd.Text = dr[1].ToString();
                TxtHastaSoyad.Text = dr[2].ToString();
                MskhastaTelefon.Text = dr[4].ToString();
                TxtHastaSifre.Text = dr[5].ToString();
                CmbHastaCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtHastaAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtHastaSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MskhastaTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", TxtHastaSifre.Text);
            komut2.Parameters.AddWithValue("@p5", CmbHastaCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskHastaTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Başarıyla Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
        }
    }
}

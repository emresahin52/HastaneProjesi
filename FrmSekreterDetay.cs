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

namespace hastaneproje
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public String TCnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            Lbltc.Text = TCnumara;
            //Ad Soyad
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", Lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();

            }
            bgl.baglanti().Close();

            //Barnşları Datagide Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları Listeye Aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd +' '+DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar" ,bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
               
          
            // Branşı comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


            //Doktorları comboboxa Aktarma
            SqlCommand komut3 = new SqlCommand("Select DoktorAd From Tbl_Doktorlar", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }
        






        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();  //insert komutu olduğu için query kullanılıyor.
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");

        }
        //Branşlardan Branşı seçince ona göre Doktor atama.
        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CmbDoktor.Items.Clear();


            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " +dr[1]);
            }
            bgl.baglanti().Close();
             
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",RchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void BtnDokotorPanel_Click(object sender, EventArgs e)
        {
            //Butona tıklayınca dokotor paneline sayfasına gönderme kodu

            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
           

        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            //Butona tıklayınca frmbranş sayfasına gönderme kodu
            FrmBranş frb = new FrmBranş();
            frb.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}

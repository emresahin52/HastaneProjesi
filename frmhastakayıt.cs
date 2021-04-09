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
    public partial class frmhastakayıt : Form
    {
        public frmhastakayıt()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnKayıt_Click(object sender, EventArgs e)
        {
           
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4", MskTel.Text);
            komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p6", CmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close(); 
            MessageBox.Show("Kaydınız Gerçekleştirmiş Şifreniz:"+TxtSifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}

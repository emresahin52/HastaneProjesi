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
    public partial class FrmSekreterGiriş : Form
    {
        public FrmSekreterGiriş()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTc=@p1 and SekreterSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.TCnumara = MskTc.Text;
                frs.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Hatalı TC ya da Şifre");
            }
            bgl.baglanti().Close();

        }
    }
}

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
namespace HASTANE_PROJESI
{
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tc;
        sqlconnection bgl = new sqlconnection();
        private void FrmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskBoxTc.Text = tc;
            SqlCommand komut = new SqlCommand("Select * from Tablo_Hasta where HastaTC=@h1", bgl.baglan());
            komut.Parameters.AddWithValue("@h1", mskBoxTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtBoxAd.Text = dr[1].ToString();
                txtBoxSoyad.Text = dr[2].ToString();
                txtBoxSifre.Text = dr[4].ToString();
                mskBoxTelefon.Text = dr[5].ToString();
                comboBox1.Text = dr[6].ToString();
            }


            bgl.baglan().Close();

        }

        private void mskBoxTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBoxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifreGoster.Checked == true)
            {
                txtBoxSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxSifre.UseSystemPasswordChar = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tablo_Hasta set HastaAdı=@a1, HastaSoyadı=@a2,HastaTelefon=@a3,HastaCinsiyet=@a4,HastaSifre=@a5 where HastaTC=@A6", bgl.baglan());
            komut.Parameters.AddWithValue("@a1", txtBoxAd.Text);
            komut.Parameters.AddWithValue("@a2", txtBoxSoyad.Text);
            komut.Parameters.AddWithValue("@a3", mskBoxTelefon.Text);
            komut.Parameters.AddWithValue("@a4", comboBox1.Text);
            komut.Parameters.AddWithValue("@a5", txtBoxSifre.Text);
            komut.Parameters.AddWithValue("@a6", mskBoxTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Güncellendi");
            this.Hide();
        }
    }
}

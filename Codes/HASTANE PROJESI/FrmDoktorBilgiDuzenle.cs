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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tc;
        sqlconnection bgl = new sqlconnection();
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskBoxTc.Text = tc;
        
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktor where DoktorTC=@h1", bgl.baglan());
            komut.Parameters.AddWithValue("@h1", mskBoxTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtBoxAd.Text = dr[1].ToString();
                txtBoxSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                txtBoxSifre.Text = dr[4].ToString();
                
            }


            bgl.baglan().Close();
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Brans",bgl.baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglan().Close();

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
            SqlCommand komut = new SqlCommand("Update Tbl_Doktor set DoktorAdı=@a1, DoktorSoyadı=@a2,DoktorBransı=@a3,DoktorSifre=@a4 where DoktorTC=@a5", bgl.baglan());
            komut.Parameters.AddWithValue("@a1", txtBoxAd.Text);
            komut.Parameters.AddWithValue("@a2", txtBoxSoyad.Text);
            komut.Parameters.AddWithValue("@a3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@a4", txtBoxSifre.Text);
            komut.Parameters.AddWithValue("@a5", mskBoxTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Güncellendi");
            this.Hide();
            FrmDoktorDetay frm = new FrmDoktorDetay();
            frm.tc = mskBoxTc.Text;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorDetay frm = new FrmDoktorDetay();
            frm.tc = mskBoxTc.Text;
            frm.Show();
            this.Hide();
        }
    }
}

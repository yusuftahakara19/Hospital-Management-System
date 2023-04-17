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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();
        public string tc;
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;
            SqlCommand komut1 = new SqlCommand("Select (HastaAdı + ' ' + HastaSoyadı) as Hasta from Tablo_Hasta where HastaTc=@h1", bgl.baglan());
            komut1.Parameters.AddWithValue("@h1", lblTc.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglan().Close();


            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Brans", bgl.baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglan().Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_randevu where randevuHastaTC='"+lblTc.Text+"'", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle frm = new FrmHastaBilgiDuzenle();
            frm.tc = lblTc.Text;
            frm.Show();

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select (DoktorAdı + ' '+ DoktorSoyadı)  from Tbl_Doktor where DoktorBransı=@d1", bgl.baglan());
            komut3.Parameters.AddWithValue("@d1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0]);
            }
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_randevu where randevuDoktor='"+ (cmbDoktor.Text)+"'and RandevuDurum=0", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
          lblTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            lblSaat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
        
        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevu set randevuDoktor=@a2,randevuBrans=@a3,randevuTarih=@a4,randevuSaat=@a5,RandevuDurum=@a6,RandevuHastaTC=@a7, randevuSikayet=@a8 where randevuID=@a1", bgl.baglan());
            komut.Parameters.AddWithValue("@a1",lblid.Text);
                        komut.Parameters.AddWithValue("@a2",cmbDoktor.Text);
                        komut.Parameters.AddWithValue("@a3",cmbBrans.Text);
                        komut.Parameters.AddWithValue("@a4",lblTarih.Text);
                        komut.Parameters.AddWithValue("@a5",lblSaat.Text);
                        komut.Parameters.AddWithValue("@a6",lblBir.Text);
                        komut.Parameters.AddWithValue("@a7",lblTc.Text);
                        komut.Parameters.AddWithValue("@a8", rtbSikayet.Text);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Randevu Alındı");



        }
    }
}

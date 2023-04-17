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
    public partial class FrmSekreterDoktorPaneli : Form
    {
        public FrmSekreterDoktorPaneli()
        {
            InitializeComponent();
        }

        public void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_doktor", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();
        }
        sqlconnection bgl = new sqlconnection();
        private void FrmSekreterDoktorPaneli_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_doktor", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();

            SqlCommand da1 = new SqlCommand("Select bransad from tbl_brans", bgl.baglan());
            SqlDataReader dr1 = da1.ExecuteReader();
  
            while (dr1.Read())
            {
                cmbBrans.Items.Add(dr1[0]);
            }
            bgl.baglan().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskBoxTc.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtBoxAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBoxSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtBoxSifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_doktor (DoktorAdı,DoktorSoyadı,DoktorTC,DoktorSifre,DoktorBransI) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglan());
            komut.Parameters.AddWithValue("@d1", txtBoxAd.Text);
            komut.Parameters.AddWithValue("@d2", txtBoxSoyad.Text);
            komut.Parameters.AddWithValue("@d3", mskBoxTc.Text);
            komut.Parameters.AddWithValue("@d4", txtBoxSifre.Text);
            komut.Parameters.AddWithValue("@d5", cmbBrans.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_doktor", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Eklendi");



        }

        private void btnAnaMenuDon_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay frm = new FrmSekreterDetay();
            frm.tc = mskBoxTc.Text;
            
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_doktor where doktortc=@a1", bgl.baglan());
            komut.Parameters.AddWithValue("@a1", mskBoxTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();

            listele();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktor set doktoradı=@d1,doktorsoyadı=@d2,doktorsifre=@d4,doktorbransı=@d5 where doktortc=@d3", bgl.baglan());
            komut.Parameters.AddWithValue("@d1", txtBoxAd.Text);
            komut.Parameters.AddWithValue("@d2", txtBoxSoyad.Text);
            komut.Parameters.AddWithValue("@d3", mskBoxTc.Text);
            komut.Parameters.AddWithValue("@d4", txtBoxSifre.Text);
            komut.Parameters.AddWithValue("@d5", cmbBrans.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            listele();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

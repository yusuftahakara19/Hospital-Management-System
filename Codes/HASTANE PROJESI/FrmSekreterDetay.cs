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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        public string tc;
        sqlconnection bgl = new sqlconnection();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;
            SqlCommand komut = new SqlCommand("Select (SekreterAdı+' '+SekreterSoyadı) from Tbl_Sekreter where SekreterTC=@a1", bgl.baglan());
            komut.Parameters.AddWithValue("@a1" , lblTc.Text );
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglan().Close();

            //combobox'a branşların getirilmesi
            SqlCommand komut2 = new SqlCommand("Select bransad from Tbl_brans", bgl.baglan());
          
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglan().Close();


            // Branşların Getirilmesi
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_brans",bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();

            //Doktorların Getirilmesi
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_doktor", bgl.baglan());
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            bgl.baglan().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyuru (DuyuruIcerik) values (@a1)", bgl.baglan());
            komut.Parameters.AddWithValue("@a1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            richTextBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmSekreterBransPaneli frm = new FrmSekreterBransPaneli();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSekreterDoktorPaneli frm = new FrmSekreterDoktorPaneli();
            frm.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSekreterRandevuListesi frm = new FrmSekreterRandevuListesi();
            frm.Show();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select (doktoradı+' '+doktorsoyadı) from tbl_doktor where doktorbransı=@a1", bgl.baglan());
            komut.Parameters.AddWithValue("@a1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_randevu (randevudoktor,randevubrans,randevutarih,randevusaat) values (@r1,@r2,@r3,@r4)", bgl.baglan());
            komut.Parameters.AddWithValue("@r1", cmbDoktor.Text);
            komut.Parameters.AddWithValue("@r2", cmbBrans.Text);
            komut.Parameters.AddWithValue("@r3", mskTarih.Text);
            komut.Parameters.AddWithValue("@r4", mskSaat.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Randevu Oluşturuldu");

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}

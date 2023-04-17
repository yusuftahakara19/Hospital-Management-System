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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlconnection bgl = new sqlconnection();
        public string doktorAdSoyad;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            SqlCommand komut1 = new SqlCommand("Select (DoktorAdı + ' ' + DoktorSoyadı) as Doktor from Tbl_Doktor where DoktorTc=@h1", bgl.baglan());
            komut1.Parameters.AddWithValue("@h1", lblTC.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                doktorAdSoyad = dr[0].ToString();
            }
            bgl.baglan().Close();
            lblAdSoyad.Text = doktorAdSoyad;

            SqlDataAdapter da = new SqlDataAdapter("select RandevuTarih,RandevuSaat,RandevuHastaTC,RandevuSikayet from tbl_randevu where randevudoktor='"+lblAdSoyad.Text+"'And RandevuDurum=1", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;




        }

        private void btnBilgilerimiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frm = new FrmDoktorBilgiDuzenle();
            frm.tc = lblTC.Text;
            frm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyuru frm = new FrmDuyuru();
            frm.Show();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           int secilen = dataGridView1.SelectedCells[0].RowIndex;
richTextBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            

            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}

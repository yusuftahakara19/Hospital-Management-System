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
    public partial class FrmSekreterBransPaneli : Form
    {
        public FrmSekreterBransPaneli()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();

        void textBox_temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void FrmSekreterBransPaneli_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_brans", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_brans (bransad) values(@a1)", bgl.baglan());
            komut.Parameters.AddWithValue("@a1", textBox2.Text);
            komut.ExecuteNonQuery();
          

            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_brans", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();
            textBox_temizle();
            MessageBox.Show("Branş Eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_brans where bransId=@a1", bgl.baglan());
            komut.Parameters.AddWithValue("@a1", textBox1.Text);
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_brans", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();
            textBox_temizle();

            MessageBox.Show("Branş Silindi");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_brans set bransad=@a1 where bransId=@a2", bgl.baglan());
            komut.Parameters.AddWithValue("@a1", textBox2.Text);
            komut.Parameters.AddWithValue("@a2",textBox1.Text);
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_brans", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();
            textBox_temizle();

            MessageBox.Show("Branş Güncellendi");

        }
    }
}

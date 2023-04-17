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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();
        private void button1_Click(object sender, EventArgs e)
        {
  
            SqlCommand komut = new SqlCommand("Select * From Tablo_Hasta where HastaTC = @h1 and HastaSifre = @h2",bgl.baglan());
            komut.Parameters.AddWithValue("@h1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@h2",txtBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay frm = new FrmHastaDetay();
                frm.tc = maskedTextBox1.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı | Şifre", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglan().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaUyeOl frm = new FrmHastaUyeOl();
            frm.Show();

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

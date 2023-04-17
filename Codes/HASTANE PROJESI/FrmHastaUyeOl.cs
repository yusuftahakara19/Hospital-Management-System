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
    public partial class FrmHastaUyeOl : Form
    {
        public FrmHastaUyeOl()
        {
            InitializeComponent();
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


        sqlconnection bgl = new sqlconnection();

        private void button1_Click(object sender, EventArgs e)
        {


          
            SqlCommand komut = new SqlCommand("insert into Tablo_Hasta (HastaAdı,HastaSoyadı,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@h1,@h2,@h3,@h4,@h5,@h6)",bgl.baglan());
            komut.Parameters.AddWithValue("@h1",txtBoxAd.Text);
            komut.Parameters.AddWithValue("@h2",txtBoxSoyad.Text);
            komut.Parameters.AddWithValue("@h3",mskBoxTc.Text);
            komut.Parameters.AddWithValue("@h4",mskBoxTelefon.Text);
            komut.Parameters.AddWithValue("@h5",txtBoxSifre.Text);
           komut.Parameters.AddWithValue("@h6",comboBox1.Text);
           
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Yapıldı\nŞifre : "+txtBoxSifre.Text);
            this.Hide();
           

           
        }
    }
}

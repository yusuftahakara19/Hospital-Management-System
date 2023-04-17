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
    public partial class FrmSekreterRandevuListesi : Form
    {
        public FrmSekreterRandevuListesi()
        {
            InitializeComponent();
        }

        sqlconnection bgl = new sqlconnection();
        private void FrmSekreterRandevuListesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_randevu", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

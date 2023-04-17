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
    public partial class FrmDuyuru : Form
    {
        public FrmDuyuru()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();
        private void FrmDuyuru_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select DuyuruIcerik as Duyuru from tbl_Duyuru", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();
        }
    }
}

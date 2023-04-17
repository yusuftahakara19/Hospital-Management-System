using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HASTANE_PROJESI
{
    class sqlconnection
    {
        public SqlConnection baglan()
        {
            string baglanti = System.IO.File.ReadAllText(@"C:\Database Veri Adresi\Test.txt");
            SqlConnection conn = new SqlConnection(baglanti);
            conn.Open();
            return conn;
        }
    }
}

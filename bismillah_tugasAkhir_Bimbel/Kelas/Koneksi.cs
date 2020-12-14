using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bismillah_tugasAkhir_Bimbel.Kelas
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = NURLIATEGARAPRI; Initial Catalog = bimbelhimalaya; User ID = sa; Password = aprinne; Integrated Security = True";
            return conn;
        }
    }
}

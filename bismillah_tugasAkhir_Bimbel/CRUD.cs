using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace bismillah_tugasAkhir_Bimbel
{
    /// <summary>
    /// Class ini untuk mendefinisikan create, read, update
    /// </summary>

    class CRUD
    {
        /// <summary>
        /// strKoneksi untuk menyambungkan program ke database
        /// </summary>

        string strKoneksi = "Data Source=NURLIATEGARAPRI; Initial Catalog = bimbelhimalaya;User " + "ID =sa; Password=aprinne";


        /// <summary>
        /// method untuk menambahkan data ke database
        /// </summary>
        /// <param name="id"> int untuk id siswa </param>
        /// <param name="namaSiswa"> string untuk nama siswa </param>
        /// <param name="tempat"> string untuk tempat tinggal siswa</param>
        /// <param name="tanggal"> string untuk tanggal saat diinputkan pertama kali data siswa</param>
        /// <param name="alamat"> string untuk alamat siswa</param>
        /// <param name="asal"> string untuk kota asal siswa </param>
        /// <param name="notelpon"> string untuk nomor telpon siswa</param>
        /// <param name="kelas"> string untuk kelas siswa</param>
        /// <param name="hari"> string untuk hari apa saja yang akan dipiloh siswa</param>
        /// <param name="paket"> string untuk paket apa yg akan diambil siswa</param>
        /// <param name="submitbt"> string untuk button update saat kondisi update data, submit saat kondisi menambahkan data </param>


        public void insert(string id, string namaSiswa, string tempat, string tanggal, 
            string alamat, string asal, string notelpon, string kelas, 
            string hari, string paket, string submitbt)
        {
            string str = "";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (submitbt == "Simpan") str = "insert into bimbel (idSiswa, NamaSiswa, tempatLahir, tanggalLahir, alamatSiswa, asalSekolah, noHPSiswa, kelas, hari, paketBimbel)" 
                    + "values(@Id,@Nama,@Tempat,@Tnggal,@Alamat,@Asal,@NoHP,@Kelas,@Hari,@Paket)";
            if (submitbt == "Edit" ) str = "update bimbel set NamaSiswa =@Nama," + 
                    "tempatLahir=@Tempat, tanggalLahir=@Tnggal, alamatSiswa=@Alamat, asalSekolah=@Asal, noHPSiswa=@NoHP, kelas=@Kelas, hari=@Hari, paketBimbel=@Paket where idSiswa=@Id ";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("Id", id));
            cmd.Parameters.Add(new SqlParameter("Nama", namaSiswa));
            cmd.Parameters.Add(new SqlParameter("Tempat", tempat));
            cmd.Parameters.Add(new SqlParameter("Tnggal", tanggal));
            cmd.Parameters.Add(new SqlParameter("Alamat", alamat));
            cmd.Parameters.Add(new SqlParameter("Asal", asal));   
            cmd.Parameters.Add(new SqlParameter("NoHP", notelpon));
            cmd.Parameters.Add(new SqlParameter("Kelas", kelas));
            cmd.Parameters.Add(new SqlParameter("Hari", hari));
            cmd.Parameters.Add(new SqlParameter("Paket", paket));
            cmd.ExecuteNonQuery();

            koneksi.Close();
        }

        /// <summary>
        /// method untuk mengecek dan menambahkan data siswa namun id tidak boleh sama, jika sama maka data tidak akan tersimpan
        /// </summary>
        /// <param name="id"> int untuk id siswa</param>
        /// <returns>menampilkan data siswa yang dicari berdasarkan Id siswa</returns>


        public bool cek(string id)
        {
            bool result = false;
            try
            {
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();

                string str = "select*from bimbel where idSiswa=@dd";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("@dd", id));

                string hasil = "";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    hasil = dr["idSiswa"].ToString();
                }
                dr.Close();
                koneksi.Close();
                if (hasil.Equals(id))
                {
                    result = true;
                }
            }
            catch (Exception)
            {

            }

            return result;
        }

        /// <summary>
        /// methode untuk menghapus data dari database
        /// </summary>
        /// <param name="id">int untuk id siswa</param>


        public void delete(string id)
        {
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            string str = "delete from bimbel where idSiswa = @Id";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("Id", id));
            cmd.ExecuteNonQuery();
            koneksi.Close();
        }

       /// menambahkan data siswa lalu tampilkan hasil di table
       /// <summary>
       /// method untuk menampilkan data siswa
       /// </summary>
       /// <returns> menampilkan data yang sudah ditambahkan ke database di table </returns>

        public DataTable viewdata()
        {
            DataTable datatable;

            string strKoneksi = "Data Source=NURLIATEGARAPRI; Initial Catalog=bimbelhimalaya;User " + "ID=sa;Password=aprinne";
            string query = "SELECT * FROM bimbel";

            SqlDataAdapter adapter = new SqlDataAdapter(query, strKoneksi);
            datatable = new DataTable();
            adapter.Fill(datatable);

            return datatable;
        }

        public string loginValidation(string uname, string passw)
        {
            SqlConnection con = new SqlConnection("Data Source=NURLIATEGARAPRI; Initial Catalog = bimbelhimalaya;User " + "ID =sa; Password=aprinne; Integrated Security = True; Connect Timeout = 10");
            SqlDataAdapter sqa = new SqlDataAdapter("select count(*) from logintBL where Username = '" + uname + "' and Password = '" + passw + "'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return ("Verified");
            }
            else
            {
                return ("Invalid");
            }
        }
        

        
    }
}

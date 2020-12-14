using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bismillah_tugasAkhir_Bimbel
{

    /// <summary>
    /// <list type="table"/>
    /// </summary>

    public partial class pendaftaran : Form
    {
        public pendaftaran()
        {
            InitializeComponent();
            refreshForm();
            view();
        }
        /// <summary>
        /// memanggil class CRUD agar bisa didefinisikan method di form pendaftaran
        /// </summary>
        void view()
        {
            CRUD cek = new CRUD();
            dataGridView1.DataSource = cek.viewdata();
        }


        /// <summary>
        /// method untuk membersihkan form saat selesai menambahkan data
        /// method dobuat private agar tidak bisa diakses oleh class lain
        /// </summary>
        private void refreshForm()
        {
            tbID.Text = "2017014";
            tbNama.Text = "";
            tbTempat.Text = "";
            dtTanggal.Text = "";
            tbAlamat.Text = "";
            tbSekolah.Text = "";
            tbHP.Text = "";
            cmbKelas.Text = "";
            cmbHari.Text = "";
            cmbPaket.Text = "";
            tbID.Enabled = true;
            tbNama.Enabled = false;
            tbTempat.Enabled = false;
            dtTanggal.Enabled = false;
            tbAlamat.Enabled = false;
            tbSekolah.Enabled = false;
            tbHP.Enabled = false;
            cmbHari.Enabled = false;
            cmbKelas.Enabled = false;
            cmbPaket.Enabled = false;
            btSimpan.Name = "Simpan";
            btSimpan.Enabled = false;
            btSimpan.BackColor = Color.Gray;
            btHapus.Enabled = false;
            btHapus.BackColor = Color.Gray;
            btClear.Enabled = false;
            btClear.BackColor = Color.Gray;

        }

        private void pendaftaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bimbelhimalayaDataSet3.bimbel' table. You can move, or remove it, as needed.
            

        }
        /// <summary>
        /// method ini berfungsi untuk menyimpan data yang telah diinputkan
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>

        private void btSimpan_Click(object sender, EventArgs e)
        {
            /// menyimpan data baru 

            string id = tbID.Text;
            string namaSiswa = tbNama.Text;
            string tempat = tbTempat.Text;
            string tanggal = dtTanggal.Text;
            string alamat = tbAlamat.Text;
            string asal = tbSekolah.Text;
            string notelpon = tbHP.Text;
            string kelas = cmbKelas.SelectedItem.ToString();
            string hari = cmbHari.SelectedItem.ToString();
            string paket = cmbPaket.SelectedItem.ToString();
            string submitbt = btSimpan.Name;

            CRUD create = new CRUD();
            create.insert(id, namaSiswa, tempat, tanggal, alamat, asal, notelpon, kelas, hari, paket, submitbt);

            view();
            DialogResult dlg = MessageBox.Show("Silahkan melanjutkan ke form pembayaran", "Informasi", MessageBoxButtons.OK);
            refreshForm();
        }


        /// <summary>
        /// method untuk mengubah kolom Nama menjadi aktif setelah kolom ID terisi
        /// </summary>
        //// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void tbID_TextChanged(object sender, EventArgs e)
        {


            tbNama.Enabled = true;
        }



        /// <summary>
        /// method untuk mengubah kolom Tempat menjadi aktif setelah kolom Nama terisi
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void tbNama_TextChanged(object sender, EventArgs e)
        {
           
            ///memanggil class CRUD untuk memanggil  method simpan
            CRUD crud = new CRUD();

            ///jika ID siswa ada yang sudah terdaftar maka akan muncul notofikasi bahwa ID sebelumnya sudah terdaftar
            if (btSimpan.Name == "Simpan")
            {
                if (tbNama.Text.Length > 0)
                {
                    if (crud.cek(tbID.Text) == true)
                    {
                        refreshForm();
                        DialogResult dlg = MessageBox.Show("Siswa dengan ID ini sudah ada",
                            "Informasi", MessageBoxButtons.OK);
                    }
                    else
                    {
                        tbTempat.Enabled = true;
                    }
                }
            }
        }


        /// <summary>
        /// method untuk mengubah kolom Tanggal menjadi aktif setelah kolom Tempat terisi
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void tbTempat_TextChanged(object sender, EventArgs e)
        {
            dtTanggal.Enabled = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void tbTanggal_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// method untuk mengubah kolom Nomor HP menjadi aktif setelah kolom Asal Sekolah terisi
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void tbSekolah_TextChanged(object sender, EventArgs e)
        {
            tbHP.Enabled = true;
        }


        /// <summary>
        /// method untuk mengubah kolom Sekolah menjadi aktif setelah kolom Alamat terisi
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void tbAlamat_TextChanged(object sender, EventArgs e)
        {
            tbSekolah.Enabled = true;
        }

        /// <summary>
        /// method untuk mengubah kolom Kelas menjadi aktif setelah kolom Nomor HP terisi
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void tbHP_TextChanged(object sender, EventArgs e)
        {
            cmbKelas.Enabled = true;
        }

        /// <summary>
        /// method untuk mengubah kolom Hari menjadi aktif setelah kolom Kelas terisi
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void cmbKelas_TextChanged(object sender, EventArgs e)
        {
            cmbHari.Enabled = true;
        }


        /// <summary>
        /// method untuk mengubah kolom Paket menjadi aktif setelah kolom Hari terisi
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void cmbHari_TextChanged(object sender, EventArgs e)
        {
            cmbPaket.Enabled = true;
        }


        /// <summary>
        /// method untuk mengubah warna tombol Simpan menjadi aktif agar bisa menyimpan data
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void cmbPaket_TextChanged(object sender, EventArgs e)
        {
            btSimpan.Enabled = true;
            btSimpan.BackColor = Color.Transparent;
            btClear.Enabled = true;
            btClear.BackColor = Color.Transparent;
        }

        /// <summary>
        /// method untuk jika nomor ID yang diinputkan lebih dari 11 digit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;

            if (tbID.Text.Length >= 11)
            {
                if (e.KeyChar != (char)8 && e.KeyChar != 13 && e.KeyChar != 32)
                {
                    MessageBox.Show("Tidak boleh lebih dari 11 karakter");
                    e.KeyChar = (char)0;
                }
            }

            if (e.KeyChar == 11)
            {
                tbNama.Select();
            }
        }


        /// <summary>
        /// method untuk jika nomor hp yang diinputkan lebih dari 13 digit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;

            if (tbHP.Text.Length >= 13)
            {
                if (e.KeyChar != (char)8 && e.KeyChar != 13 && e.KeyChar != 32)
                {
                    MessageBox.Show("Tidak boleh lebih dari 13 karakter");
                    e.KeyChar = (char)0;
                }
            }
            if (e.KeyChar == 13)
            {
                cmbKelas.Select();
                
            }
        }


        /// <summary>
        /// method untuk menampilkan data di table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btSimpan.Name.Equals("Simpan")) btSimpan.Name = "Edit";
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string ids = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string nms = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string tpts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string tgls = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            string als = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            string asls = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            string notels = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            string klss = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            string hrs = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            string pkts = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[9].Value);

            tbID.Text = ids;
            tbNama.Text = nms;
            tbTempat.Text = tpts;
            dtTanggal.Text = tgls;
            tbAlamat.Text = als;
            tbSekolah.Text = asls;
            tbHP.Text = notels;
            cmbKelas.Text = klss;
            cmbHari.Text = hrs;
            cmbPaket.Text = pkts;
            tbID.Enabled = false;
            tbTempat.Enabled = true;
            btSimpan.Name = "Edit";
            btSimpan.Enabled = true;
            btHapus.Enabled = true;
            btHapus.BackColor = Color.Transparent;


        }


        /// <summary>
        /// method untuk menutup halaman pendaftaran dan menuju halaman Main Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.Show();
        }

        /// <summary>
        /// method untuk membuat semua kolom kosong 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show(this, "Apakah Anda yakin ingin menghapus data siswa ini?", "Confirm Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                CRUD del = new CRUD();
                del.delete(tbID.Text);
                view();
                refreshForm();
            }
        }

        /// <summary>
        /// method untuk menuju halaman pembayaran
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pembayaran main = new pembayaran();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchbyid(tbSearch.Text.Trim());
        }

        /// <summary>
        /// mencari data siswa berdasarkan id siswa
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        protected void searchbyid(string searchText)
        {

            ///jika kolom tidak terisi
            if (tbSearch.Text == "")
            {
                MessageBox.Show("Tidak ada yang di cari!");

            }
            else
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=NURLIATEGARAPRI;Initial Catalog=bimbelhimalaya;User ID=sa;Password=aprinne;Integrated Security=True"))
                {
                    string sql = "SELECT * FROM bimbel WHERE [NamaSiswa = '" + tbSearch.Text + "']" + "[paketBimbel = '" + tbSearch.Text + "']";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("Nama", tbSearch.Text);
                        cmd.Parameters.AddWithValue("Paket", tbSearch.Text);

                        DataTable dt = new DataTable();
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        ad.Fill(dt);

                        // jika data yang dicari tidak ada
                        if (dt.Rows.Count > 0)
                        { 
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Data yang dicari tidak ada!");
                        }
                    }
                }

            }

        }


        /// <summary>
        /// method ini berfungsi untuk kolom alamat menjadi aktif jika kolom tanggal sudah terisi
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void dtTanggal_ValueChanged(object sender, EventArgs e)
        {
            if (tbTempat.Text.Length >= 1)
            {
                dtTanggal.CustomFormat = "dd/MM/yyyy";
                tbAlamat.Enabled = true;
            }
            else
            {
                tbAlamat.Enabled = false;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

  
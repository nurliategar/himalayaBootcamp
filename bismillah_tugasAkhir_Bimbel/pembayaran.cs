using bismillah_tugasAkhir_Bimbel.Models;
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
    /// class ini untuk menampilkan proses pembayaran dari siswa yang mendaftar baru/mendaftar ulang 
    /// </summary>

    public partial class pembayaran : Form
    {
        /// <summary>
        /// 
        /// </summary>
        static int kelas = 0, hari = 0, paket = 0, jenis = 0;

        Kelas.Koneksi k = new Kelas.Koneksi();
        private SqlCommand cd;
        public pembayaran()
        {
            InitializeComponent();
            timer1.Start();
            auto_nopen();
        }
        
        private List<CartItem> shoppingCart = new List<CartItem>();

        private void pembayaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bimbelhimalayaDataSet8.bayar' table. You can move, or remove it, as needed.
            this.bayarTableAdapter2.Fill(this.bimbelhimalayaDataSet8.bayar);
           
            tbIDPembayaran.Text = "2017014";
            
            
        }

        /// <summary>
        /// method untuk membuat nomor pendaftaran otomatis
        /// </summary>

        void auto_nopen()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection conn = k.GetConn();
            conn.Open();
            cd = new SqlCommand("select noPembayaran from bayar where noPembayaran in (select max(noPembayaran) from bayar) order by noPembayaran desc", conn);
            rd = cd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["noPembayaran"].ToString().Length - 3, 3)) + 1;
                string join = "000" + hitung;
                urut = "HIMA" + join.Substring(join.Length - 3, 3);

            }
            else
            {
                urut = "HIMA001";
            }
            rd.Close();
            tbNopen.Enabled = false;
            tbNopen.Text = urut;
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.label6.Text = time.ToString();
        }


        /// <summary>
        /// method untuk mengubah ID pembayaran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbIDPembayaran_TextChanged(object sender, EventArgs e)
        {
            string constring = @"Data Source = NURLIATEGARAPRI; Initial Catalog = bimbelhimalaya; Integrated Security = True;";
            SqlConnection connection;
            SqlCommand com;
            string sql = "select NamaSiswa , [kelas] , hari , [paketBimbel] from bimbel where idSiswa = '" + tbIDPembayaran.Text + "'";
            connection = new SqlConnection(constring);
            com = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                tbNamaPembayaran.Text = r.GetString(0);
                tbKelasPembayaran.Text = r.GetString(1);
                tbHari.Text = r.GetString(2);
                tbPaketPembayaran.Text = r.GetString(3);
            }
            connection.Close();
        }

        private void dataGridPembayaran_MouseDoubleClick(object sender, MouseEventArgs e)
        { }

        /// <summary>
        /// method untuk menambah data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddPembayaran_Click(object sender, EventArgs e)
        {

           

            string str = "";

            string nopen = tbNopen.Text.ToString();
            string idSiBayar = tbIDPembayaran.Text.ToString();
            string namaS = tbNamaPembayaran.Text.ToString();
            string kls = tbKelasPembayaran.Text.ToString();
            string bKLS = bayarKelas.Text.ToString();
            string hr = tbHari.Text.ToString();
            string bHR = bayarHari.Text.ToString();
            string pkt = tbPaketPembayaran.Text.ToString();
            string bPKT = bayarPaket.Text.ToString();
            string pemba = cmbJenis.SelectedItem.ToString();
            string bPEMBA = bayarJenis.Text.ToString();
            string tol = totalBayar.Text.ToString();

            string strKoneksi = "Data Source = NURLIATEGARAPRI; Initial Catalog = bimbelhimalaya; Integrated Security=True;";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            try
            {
                if (btAddPembayaran.Text.Equals("Buat Transaksi")) str = "insert into bayar values (@NO, @IDS, @NMS, @KLS, @BKLS, @HR, @BHR, @PKT, @BPKT, @PB, @BP, @TOL)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("NO", nopen));
                cmd.Parameters.Add(new SqlParameter("IDS", idSiBayar));
                cmd.Parameters.Add(new SqlParameter("NMS", namaS));
                cmd.Parameters.Add(new SqlParameter("KLS", kls));
                cmd.Parameters.Add(new SqlParameter("BKLS", bKLS));
                cmd.Parameters.Add(new SqlParameter("HR", hr));
                cmd.Parameters.Add(new SqlParameter("BHR", bHR));
                cmd.Parameters.Add(new SqlParameter("PKT", pkt));
                cmd.Parameters.Add(new SqlParameter("BPKT", bPKT));
                cmd.Parameters.Add(new SqlParameter("PB", pemba));
                cmd.Parameters.Add(new SqlParameter("BP", bPEMBA));
                cmd.Parameters.Add(new SqlParameter("TOL", tol));
                cmd.ExecuteNonQuery();

                koneksi.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            
            this.bayarTableAdapter2.Fill(this.bimbelhimalayaDataSet8.bayar);
            dataGridView1.Refresh();
            auto_nopen();
        }


        /// <summary>
        /// method untuk menampilkan data di table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ///method untuk menyimpan data jika data baru, mengubat data jika data lama

            if (btAddPembayaran.Name.Equals("Buat Transaksi")) btAddPembayaran.Name = "Edit";
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string nopen = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string ids = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string nama = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string ksl = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            string biayaKLS = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            string hr = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            string biayaHR = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            string pkt = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            string biayaPaket = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            string pmeba = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            string biayaapmbe = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
            string alll = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[11].Value);

            tbNopen.Text = nopen;
            tbIDPembayaran.Text = ids;
            tbNamaPembayaran.Text = nama;
            tbKelasPembayaran.Text = ksl;
            bayarKelas.Text = biayaKLS;
            tbHari.Text = hr;
            bayarHari.Text = biayaHR;
            tbPaketPembayaran.Text = pkt;
            bayarPaket.Text = biayaPaket;
            cmbJenis.Text = pmeba;
            bayarJenis.Text = biayaapmbe;
            totalBayar.Text = alll;
        }

        /// <summary>
        /// method untuk menambah semua jumlah harga yang telat diinputkan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bayarJenis_TextChanged(object sender, EventArgs e)
        {
            
                if (Int32.TryParse(bayarKelas.Text, out kelas) && Int32.TryParse(bayarPaket.Text, out paket) && Int32.TryParse(bayarHari.Text, out hari) && Int32.TryParse(bayarJenis.Text, out jenis))
                {
                    totalBayar.Text =(kelas+ paket + hari + jenis).ToString();

                }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// method untuk tampilan dokumen yang akan di print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Properties.Resources.qq;
            int yPos = 295;
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            e.Graphics.DrawString("Tanggal :  " + DateTime.Now.ToShortDateString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString("Nama Siswa : " + tbNamaPembayaran.Text.Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 190));
            e.Graphics.DrawString("Kelas : " + tbKelasPembayaran.Text.Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 215));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------", 
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 235));
            e.Graphics.DrawString("No Pembayaran", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 255));
            e.Graphics.DrawString("ID Siswa", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(200, 255));
            e.Graphics.DrawString("Jenis Pembayaran", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(350, 255));
            e.Graphics.DrawString("Total Bayar", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(600, 255));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 270));
            e.Graphics.DrawString(tbNopen.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
            e.Graphics.DrawString(tbIDPembayaran.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(200, yPos));
            e.Graphics.DrawString(cmbJenis.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(350, yPos));
            e.Graphics.DrawString(totalBayar.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(600, yPos));

        }

        /// <summary>
        /// method untuk print preview sebelum di print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }


        /// <summary>
        /// method untuk print dokument
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}

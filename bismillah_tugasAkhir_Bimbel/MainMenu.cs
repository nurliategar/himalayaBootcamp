using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bismillah_tugasAkhir_Bimbel
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// method ini berfungsi untuk pindah halaman dari halaman MainMenu ke halaman pendaftaran
        /// method ini bersifat private karena tidak boleh diakses oleh class lain
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>

        private void btDaftarSiswa_Click(object sender, EventArgs e)
        {
            this.Hide();
            pendaftaran main = new pendaftaran();
            main.Show();
        }


        /// <summary>
        /// method ini berfungsi untuk pindah halaman dari halaman MainMenu ke halaman pembayaran
        /// method ini bersifat private karena tidak boleh diakses oleh class lain
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void btBayarPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            pembayaran main = new pembayaran();
            main.Show();
        }
    }
}

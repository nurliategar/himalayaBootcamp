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
    public partial class Form1 : Form
    {
        string namauser;
        public Form1()
        {
            InitializeComponent();

        }

        internal double loginBT_Click(string v)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// method ini berfungsi untuk validasi sekligus sebagai navigasi pindah ke halaman MainMenu.
        /// Validasi digunakan untuk mencocokkan apakah username dan password sudah sesuai dengan data yang ada di database
        /// Navigasi digunakan untuk pindah halaman ke halaman MainMenu
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>

        public void loginBT_Click(object sender, EventArgs e)
        {
            string uname = tbUsername.Text;
            string pw = tbPassword.Text;
            CRUD p = new CRUD();
            string login = p.loginValidation(uname, pw);
            if (login == "Verified") 
            {
                MainMenu menuu = new MainMenu();
                namauser = tbUsername.Text;
                menuu.Show();
                this.Hide();
            }
            
            else
            {
                MessageBox.Show("Username atau Password Anda Salah.\n" + 
                    "\nPastikan Username dan Password yang anda masukkan benar!", "Login Error!" + login, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbUsername.Clear();
                tbPassword.Clear();
            }
        }
    


        /// <summary>
        /// method ini berfungsi untuk menutup aplikasi
        /// </summary>
        /// <param name="sender">Objek yang berfungsi untuk mengirim data</param>
        /// <param name="e">event yang berfungsi untuk mewakili data yang dikirim</param>
        private void closeBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

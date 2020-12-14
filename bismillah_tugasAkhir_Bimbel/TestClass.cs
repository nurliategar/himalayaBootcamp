using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace bismillah_tugasAkhir_Bimbel
{
    [TestFixture]
    class TestClass
    {
        /// <summary>
        /// Test Case untuk mengecek data di database
        /// </summary>
        [TestCase]
        public void viewdata()
        {
            CRUD tess = new CRUD();
            Assert.AreEqual(true, tess.cek("20170140001"));
        }

        /// <summary>
        /// Test Case 1.1 : Mengecek fungsi login jika dimasukkan username dan password yang benar 
        /// </summary>
        [TestCase]
        public void validasi()
        {
            CRUD tess = new CRUD();
            Assert.AreEqual("Verified", tess.loginValidation("himalaya1", "bimbel1"));
        }

        /// <summary>
        /// Test Case 1.3 : Mengecek fungsi login jika dimasukkan password yang salah 
        /// </summary>
        [TestCase]
        public void validasi2()
        {
            CRUD tess = new CRUD();
            Assert.AreEqual("Invalid", tess.loginValidation("himalaya1", "bimbel2"));
        }

        /// <summary>
        /// Test Case 1.4 : Mengecek fungsi loin jika dimasukkan username yang salah 
        /// </summary>
        [TestCase]
        public void validasi3()
        {
            CRUD tess = new CRUD();
            Assert.AreEqual("Invalid", tess.loginValidation("himalaya", "bimbel1"));
        }

        /// <summary>
        /// Test Case 1.2 : Mengecek fungsi loin jika dimasukkan password kosong 
        /// </summary>
        [TestCase]
        public void validasi4()
        {
            CRUD tess = new CRUD();
            Assert.AreEqual("Invalid", tess.loginValidation("himalaya", ""));
        }

        /// <summary>
        /// Test Case 1.5 : Mengecek fungsi loin jika dimasukkan username kosong 
        /// </summary>
        [TestCase]
        public void validasi5()
        {
            CRUD tess = new CRUD();
            Assert.AreEqual("Invalid", tess.loginValidation("", "bimbel1"));
        }

    }
}

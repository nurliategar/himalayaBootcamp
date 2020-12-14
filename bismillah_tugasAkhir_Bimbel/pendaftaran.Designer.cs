namespace bismillah_tugasAkhir_Bimbel
{
    partial class pendaftaran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pendaftaran));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbSekolah = new System.Windows.Forms.TextBox();
            this.tbTempat = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.cmbHari = new System.Windows.Forms.ComboBox();
            this.cmbPaket = new System.Windows.Forms.ComboBox();
            this.cmbKelas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bimbelhimalayaDataSet3 = new bismillah_tugasAkhir_Bimbel.bimbelhimalayaDataSet3();
            this.bimbelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimbelTableAdapter = new bismillah_tugasAkhir_Bimbel.bimbelhimalayaDataSet3TableAdapters.bimbelTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btHapus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bimbelhimalayaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ordinary", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 61);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Siswa BIMBEL HIMALAYA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Siswa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alamat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(789, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Asal Sekolah :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tempat Lahir :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(787, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Kelas :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(789, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "No HP :";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(340, 107);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(279, 34);
            this.tbID.TabIndex = 15;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            this.tbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbID_KeyPress);
            // 
            // tbHP
            // 
            this.tbHP.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHP.Location = new System.Drawing.Point(948, 156);
            this.tbHP.Multiline = true;
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(279, 34);
            this.tbHP.TabIndex = 17;
            this.tbHP.TextChanged += new System.EventHandler(this.tbHP_TextChanged);
            this.tbHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHP_KeyPress);
            // 
            // tbAlamat
            // 
            this.tbAlamat.Font = new System.Drawing.Font("Nexa Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlamat.Location = new System.Drawing.Point(340, 301);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(279, 103);
            this.tbAlamat.TabIndex = 18;
            this.tbAlamat.TextChanged += new System.EventHandler(this.tbAlamat_TextChanged);
            // 
            // tbSekolah
            // 
            this.tbSekolah.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSekolah.Location = new System.Drawing.Point(948, 108);
            this.tbSekolah.Multiline = true;
            this.tbSekolah.Name = "tbSekolah";
            this.tbSekolah.Size = new System.Drawing.Size(279, 35);
            this.tbSekolah.TabIndex = 19;
            this.tbSekolah.TextChanged += new System.EventHandler(this.tbSekolah_TextChanged);
            // 
            // tbTempat
            // 
            this.tbTempat.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTempat.Location = new System.Drawing.Point(340, 204);
            this.tbTempat.Multiline = true;
            this.tbTempat.Name = "tbTempat";
            this.tbTempat.Size = new System.Drawing.Size(279, 34);
            this.tbTempat.TabIndex = 20;
            this.tbTempat.TextChanged += new System.EventHandler(this.tbTempat_TextChanged);
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(340, 154);
            this.tbNama.Multiline = true;
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(279, 34);
            this.tbNama.TabIndex = 21;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // btSimpan
            // 
            this.btSimpan.BackColor = System.Drawing.Color.Transparent;
            this.btSimpan.Font = new System.Drawing.Font("Nexa Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimpan.Image = ((System.Drawing.Image)(resources.GetObject("btSimpan.Image")));
            this.btSimpan.Location = new System.Drawing.Point(1305, 66);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(113, 110);
            this.btSimpan.TabIndex = 22;
            this.btSimpan.Text = "Simpan / Edit";
            this.btSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSimpan.UseVisualStyleBackColor = false;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // cmbHari
            // 
            this.cmbHari.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHari.FormattingEnabled = true;
            this.cmbHari.Items.AddRange(new object[] {
            "Senin, Rabu, Jumat",
            "Senin, Selasa, Rabu",
            "Selasa, Kamis, Sabtu",
            "Kamis, Jumat, Sabtu"});
            this.cmbHari.Location = new System.Drawing.Point(948, 247);
            this.cmbHari.Name = "cmbHari";
            this.cmbHari.Size = new System.Drawing.Size(279, 33);
            this.cmbHari.TabIndex = 23;
            this.cmbHari.TextChanged += new System.EventHandler(this.cmbHari_TextChanged);
            // 
            // cmbPaket
            // 
            this.cmbPaket.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaket.FormattingEnabled = true;
            this.cmbPaket.Items.AddRange(new object[] {
            "A (Matematika, Bahasa Indonesia, Bahasa Inggris)",
            "B (Fisika, Kimia, Biology)",
            "C (Semua Pelajaran)"});
            this.cmbPaket.Location = new System.Drawing.Point(948, 297);
            this.cmbPaket.Name = "cmbPaket";
            this.cmbPaket.Size = new System.Drawing.Size(279, 33);
            this.cmbPaket.TabIndex = 24;
            this.cmbPaket.TextChanged += new System.EventHandler(this.cmbPaket_TextChanged);
            // 
            // cmbKelas
            // 
            this.cmbKelas.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKelas.FormattingEnabled = true;
            this.cmbKelas.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbKelas.Location = new System.Drawing.Point(948, 200);
            this.cmbKelas.Name = "cmbKelas";
            this.cmbKelas.Size = new System.Drawing.Size(279, 33);
            this.cmbKelas.TabIndex = 25;
            this.cmbKelas.TextChanged += new System.EventHandler(this.cmbKelas_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(789, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Paket :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(789, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Hari :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(153, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Tanggal Lahir :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // bimbelhimalayaDataSet3
            // 
            this.bimbelhimalayaDataSet3.DataSetName = "bimbelhimalayaDataSet3";
            this.bimbelhimalayaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bimbelBindingSource
            // 
            this.bimbelBindingSource.DataMember = "bimbel";
            this.bimbelBindingSource.DataSource = this.bimbelhimalayaDataSet3;
            // 
            // bimbelTableAdapter
            // 
            this.bimbelTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 436);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1533, 379);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btHapus
            // 
            this.btHapus.BackColor = System.Drawing.Color.Transparent;
            this.btHapus.Font = new System.Drawing.Font("Nexa Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHapus.Image = ((System.Drawing.Image)(resources.GetObject("btHapus.Image")));
            this.btHapus.Location = new System.Drawing.Point(1305, 182);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(113, 109);
            this.btHapus.TabIndex = 31;
            this.btHapus.Text = "Hapus";
            this.btHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btHapus.UseVisualStyleBackColor = false;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Nama Siswa :";
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.Transparent;
            this.btClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClear.BackgroundImage")));
            this.btClear.Font = new System.Drawing.Font("Nexa Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Image = ((System.Drawing.Image)(resources.GetObject("btClear.Image")));
            this.btClear.Location = new System.Drawing.Point(1447, 66);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(113, 110);
            this.btClear.TabIndex = 33;
            this.btClear.Text = "Clear";
            this.btClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClose.BackgroundImage")));
            this.btClose.Font = new System.Drawing.Font("Nexa Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.Location = new System.Drawing.Point(1447, 182);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(113, 107);
            this.btClose.TabIndex = 34;
            this.btClose.Text = "Tutup";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1305, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 54);
            this.button1.TabIndex = 35;
            this.button1.Text = "Form Pembayaran";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1464, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 35);
            this.button2.TabIndex = 36;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(957, 375);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(501, 33);
            this.tbSearch.TabIndex = 37;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(749, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "Cari Nama Siswa :";
            // 
            // dtTanggal
            // 
            this.dtTanggal.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTanggal.Location = new System.Drawing.Point(340, 251);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(279, 32);
            this.dtTanggal.TabIndex = 39;
            this.dtTanggal.ValueChanged += new System.EventHandler(this.dtTanggal_ValueChanged);
            // 
            // pendaftaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 843);
            this.Controls.Add(this.dtTanggal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbKelas);
            this.Controls.Add(this.cmbPaket);
            this.Controls.Add(this.cmbHari);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbTempat);
            this.Controls.Add(this.tbSekolah);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbHP);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "pendaftaran";
            this.Text = "pendaftaran";
            this.Load += new System.EventHandler(this.pendaftaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bimbelhimalayaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbHP;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbSekolah;
        private System.Windows.Forms.TextBox tbTempat;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.ComboBox cmbHari;
        private System.Windows.Forms.ComboBox cmbPaket;
        private System.Windows.Forms.ComboBox cmbKelas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private bimbelhimalayaDataSet3 bimbelhimalayaDataSet3;
        private System.Windows.Forms.BindingSource bimbelBindingSource;
        private bimbelhimalayaDataSet3TableAdapters.bimbelTableAdapter bimbelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtTanggal;
    }
}
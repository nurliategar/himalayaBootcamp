namespace bismillah_tugasAkhir_Bimbel
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btDaftarSiswa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btBayarPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDaftarSiswa
            // 
            this.btDaftarSiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDaftarSiswa.Font = new System.Drawing.Font("Nexa Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDaftarSiswa.Image = ((System.Drawing.Image)(resources.GetObject("btDaftarSiswa.Image")));
            this.btDaftarSiswa.Location = new System.Drawing.Point(447, 161);
            this.btDaftarSiswa.Name = "btDaftarSiswa";
            this.btDaftarSiswa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btDaftarSiswa.Size = new System.Drawing.Size(289, 201);
            this.btDaftarSiswa.TabIndex = 4;
            this.btDaftarSiswa.Text = "PENDAFTARAN SISWA";
            this.btDaftarSiswa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDaftarSiswa.UseVisualStyleBackColor = true;
            this.btDaftarSiswa.Click += new System.EventHandler(this.btDaftarSiswa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ordinary", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(350, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 61);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bimbingan Belajar Himalaya";
            // 
            // btBayarPage
            // 
            this.btBayarPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBayarPage.Font = new System.Drawing.Font("Nexa Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBayarPage.Image = ((System.Drawing.Image)(resources.GetObject("btBayarPage.Image")));
            this.btBayarPage.Location = new System.Drawing.Point(801, 161);
            this.btBayarPage.Name = "btBayarPage";
            this.btBayarPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btBayarPage.Size = new System.Drawing.Size(289, 201);
            this.btBayarPage.TabIndex = 6;
            this.btBayarPage.Text = "PEMBAYARAN SISWA";
            this.btBayarPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBayarPage.UseVisualStyleBackColor = true;
            this.btBayarPage.Click += new System.EventHandler(this.btBayarPage_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1412, 699);
            this.Controls.Add(this.btBayarPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDaftarSiswa);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDaftarSiswa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBayarPage;
    }
}
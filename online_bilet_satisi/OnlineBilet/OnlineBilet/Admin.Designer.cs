namespace OnlineBilet
{
    partial class Admin
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfirmaadi = new System.Windows.Forms.TextBox();
            this.txtyetkiliAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyetkiliSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYetkiliTC = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnIstek = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSeferSayisi = new System.Windows.Forms.TextBox();
            this.txtYolcuSayisi = new System.Windows.Forms.TextBox();
            this.txtUcakSayisi = new System.Windows.Forms.TextBox();
            this.txtBagajAgiriligi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEkle.Location = new System.Drawing.Point(289, 351);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnGuncelle.Location = new System.Drawing.Point(289, 264);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSil.Location = new System.Drawing.Point(418, 264);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Firma Adı";
            // 
            // txtfirmaadi
            // 
            this.txtfirmaadi.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtfirmaadi.Location = new System.Drawing.Point(123, 19);
            this.txtfirmaadi.Name = "txtfirmaadi";
            this.txtfirmaadi.Size = new System.Drawing.Size(100, 20);
            this.txtfirmaadi.TabIndex = 3;
            // 
            // txtyetkiliAd
            // 
            this.txtyetkiliAd.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtyetkiliAd.Location = new System.Drawing.Point(123, 82);
            this.txtyetkiliAd.Name = "txtyetkiliAd";
            this.txtyetkiliAd.Size = new System.Drawing.Size(100, 20);
            this.txtyetkiliAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yetkili Adı";
            // 
            // txtyetkiliSoyad
            // 
            this.txtyetkiliSoyad.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtyetkiliSoyad.Location = new System.Drawing.Point(123, 120);
            this.txtyetkiliSoyad.Name = "txtyetkiliSoyad";
            this.txtyetkiliSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtyetkiliSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yetkili Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numara";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "TC NO";
            // 
            // txtYetkiliTC
            // 
            this.txtYetkiliTC.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtYetkiliTC.Location = new System.Drawing.Point(123, 49);
            this.txtYetkiliTC.MaxLength = 11;
            this.txtYetkiliTC.Name = "txtYetkiliTC";
            this.txtYetkiliTC.Size = new System.Drawing.Size(100, 20);
            this.txtYetkiliTC.TabIndex = 3;
            // 
            // txtNumara
            // 
            this.txtNumara.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtNumara.Location = new System.Drawing.Point(123, 163);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 190);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnTemizle.Location = new System.Drawing.Point(289, 308);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnIstek
            // 
            this.btnIstek.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnIstek.Location = new System.Drawing.Point(418, 323);
            this.btnIstek.Name = "btnIstek";
            this.btnIstek.Size = new System.Drawing.Size(69, 51);
            this.btnIstek.TabIndex = 5;
            this.btnIstek.Text = "Firma İstekleri";
            this.btnIstek.UseVisualStyleBackColor = false;
            this.btnIstek.Click += new System.EventHandler(this.btnIstek_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sefer Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Uçak Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Max Yolcu Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bagaj Ağırlığı";
            // 
            // txtSeferSayisi
            // 
            this.txtSeferSayisi.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtSeferSayisi.Location = new System.Drawing.Point(123, 196);
            this.txtSeferSayisi.Name = "txtSeferSayisi";
            this.txtSeferSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSeferSayisi.TabIndex = 3;
            // 
            // txtYolcuSayisi
            // 
            this.txtYolcuSayisi.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtYolcuSayisi.Location = new System.Drawing.Point(141, 248);
            this.txtYolcuSayisi.Name = "txtYolcuSayisi";
            this.txtYolcuSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtYolcuSayisi.TabIndex = 3;
            // 
            // txtUcakSayisi
            // 
            this.txtUcakSayisi.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtUcakSayisi.Location = new System.Drawing.Point(141, 223);
            this.txtUcakSayisi.Name = "txtUcakSayisi";
            this.txtUcakSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtUcakSayisi.TabIndex = 3;
            // 
            // txtBagajAgiriligi
            // 
            this.txtBagajAgiriligi.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtBagajAgiriligi.Location = new System.Drawing.Point(120, 285);
            this.txtBagajAgiriligi.Name = "txtBagajAgiriligi";
            this.txtBagajAgiriligi.Size = new System.Drawing.Size(100, 20);
            this.txtBagajAgiriligi.TabIndex = 3;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1100, 436);
            this.Controls.Add(this.btnIstek);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtyetkiliSoyad);
            this.Controls.Add(this.txtUcakSayisi);
            this.Controls.Add(this.txtBagajAgiriligi);
            this.Controls.Add(this.txtYolcuSayisi);
            this.Controls.Add(this.txtSeferSayisi);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtyetkiliAd);
            this.Controls.Add(this.txtYetkiliTC);
            this.Controls.Add(this.txtfirmaadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfirmaadi;
        private System.Windows.Forms.TextBox txtyetkiliAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyetkiliSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYetkiliTC;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnIstek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSeferSayisi;
        private System.Windows.Forms.TextBox txtYolcuSayisi;
        private System.Windows.Forms.TextBox txtUcakSayisi;
        private System.Windows.Forms.TextBox txtBagajAgiriligi;
    }
}
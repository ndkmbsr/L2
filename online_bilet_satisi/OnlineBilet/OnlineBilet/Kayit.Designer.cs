namespace OnlineBilet
{
    partial class Kayit
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
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.rdbtnErkek = new System.Windows.Forms.RadioButton();
            this.rdbtnKadin = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker3.Location = new System.Drawing.Point(496, 118);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker3.TabIndex = 93;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(366, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 16);
            this.label17.TabIndex = 92;
            this.label17.Text = "Doğum Tarihi";
            // 
            // rdbtnErkek
            // 
            this.rdbtnErkek.AutoSize = true;
            this.rdbtnErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnErkek.Location = new System.Drawing.Point(586, 89);
            this.rdbtnErkek.Name = "rdbtnErkek";
            this.rdbtnErkek.Size = new System.Drawing.Size(66, 20);
            this.rdbtnErkek.TabIndex = 90;
            this.rdbtnErkek.TabStop = true;
            this.rdbtnErkek.Text = "Erkek";
            this.rdbtnErkek.UseVisualStyleBackColor = true;
            this.rdbtnErkek.CheckedChanged += new System.EventHandler(this.rdbtnErkek_CheckedChanged);
            // 
            // rdbtnKadin
            // 
            this.rdbtnKadin.AutoSize = true;
            this.rdbtnKadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnKadin.Location = new System.Drawing.Point(496, 89);
            this.rdbtnKadin.Name = "rdbtnKadin";
            this.rdbtnKadin.Size = new System.Drawing.Size(65, 20);
            this.rdbtnKadin.TabIndex = 91;
            this.rdbtnKadin.TabStop = true;
            this.rdbtnKadin.Text = "Kadın";
            this.rdbtnKadin.UseVisualStyleBackColor = true;
            this.rdbtnKadin.CheckedChanged += new System.EventHandler(this.rdbtnKadin_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(404, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 89;
            this.label15.Text = "Cinsiyet";
            // 
            // cmbSaat
            // 
            this.cmbSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(496, 167);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(121, 24);
            this.cmbSaat.TabIndex = 88;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(427, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 16);
            this.label18.TabIndex = 87;
            this.label18.Text = "Saat";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtSoyad.Location = new System.Drawing.Point(227, 146);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 86;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtAd.Location = new System.Drawing.Point(227, 114);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 85;
            // 
            // txtTc
            // 
            this.txtTc.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtTc.Location = new System.Drawing.Point(227, 83);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 84;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(123, 148);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 20);
            this.label20.TabIndex = 83;
            this.label20.Text = "Soyad";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(123, 112);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 20);
            this.label21.TabIndex = 82;
            this.label21.Text = "Ad";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(123, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 20);
            this.label22.TabIndex = 81;
            this.label22.Text = "TcKimlik";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnKaydet.Location = new System.Drawing.Point(251, 205);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 43);
            this.btnKaydet.TabIndex = 94;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(766, 217);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(75, 61);
            this.btnAnaSayfa.TabIndex = 95;
            this.btnAnaSayfa.Text = "AnaSayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1028, 324);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.rdbtnErkek);
            this.Controls.Add(this.rdbtnKadin);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Name = "Kayit";
            this.Text = "Kayit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kayit_FormClosing);
            this.Load += new System.EventHandler(this.Kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rdbtnErkek;
        private System.Windows.Forms.RadioButton rdbtnKadin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}
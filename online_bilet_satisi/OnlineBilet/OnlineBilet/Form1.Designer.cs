namespace OnlineBilet
{
    partial class Form1
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
            this.lblnereye = new System.Windows.Forms.Label();
            this.nereye = new System.Windows.Forms.ComboBox();
            this.nereden = new System.Windows.Forms.ComboBox();
            this.spKalkisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlineBiletDataSet = new OnlineBilet.OnlineBiletDataSet();
            this.rdbtnGidisDonus = new System.Windows.Forms.RadioButton();
            this.rdbtnTekYon = new System.Windows.Forms.RadioButton();
            this.sp_KalkisTableAdapter = new OnlineBilet.OnlineBiletDataSetTableAdapters.Sp_KalkisTableAdapter();
            this.onlineBiletDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlineBiletDataSet1 = new OnlineBilet.OnlineBiletDataSet1();
            this.sPVarisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sP_VarisTableAdapter = new OnlineBilet.OnlineBiletDataSet1TableAdapters.SP_VarisTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnuye = new System.Windows.Forms.Button();
            this.btngiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtYon = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.havaAlanlari = new OnlineBilet.HavaAlanlari();
            this.spHavaAlanlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_HavaAlanlariTableAdapter = new OnlineBilet.HavaAlanlariTableAdapters.Sp_HavaAlanlariTableAdapter();
            this.spHavaAlanlariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nereden21 = new OnlineBilet.nereden2();
            this.sp_HavaAlanlariTableAdapter1 = new OnlineBilet.nereden2TableAdapters.Sp_HavaAlanlariTableAdapter();
            this.havaalaniyeni = new OnlineBilet.Havaalaniyeni();
            this.spHavaAlanlariBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sp_HavaAlanlariTableAdapter2 = new OnlineBilet.HavaalaniyeniTableAdapters.Sp_HavaAlanlariTableAdapter();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sPVarisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spKalkisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBiletDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBiletDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBiletDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVarisBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.havaAlanlari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHavaAlanlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHavaAlanlariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nereden21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havaalaniyeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHavaAlanlariBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVarisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnereye
            // 
            this.lblnereye.AutoSize = true;
            this.lblnereye.Location = new System.Drawing.Point(448, 97);
            this.lblnereye.Name = "lblnereye";
            this.lblnereye.Size = new System.Drawing.Size(47, 13);
            this.lblnereye.TabIndex = 7;
            this.lblnereye.Text = "Nereye";
            // 
            // nereye
            // 
            this.nereye.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.nereye.FormattingEnabled = true;
            this.nereye.Location = new System.Drawing.Point(418, 139);
            this.nereye.Name = "nereye";
            this.nereye.Size = new System.Drawing.Size(140, 21);
            this.nereye.TabIndex = 5;
            this.nereye.SelectedIndexChanged += new System.EventHandler(this.nereye_SelectedIndexChanged);
            // 
            // nereden
            // 
            this.nereden.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.nereden.FormattingEnabled = true;
            this.nereden.Location = new System.Drawing.Point(201, 139);
            this.nereden.Name = "nereden";
            this.nereden.Size = new System.Drawing.Size(140, 21);
            this.nereden.TabIndex = 6;
            this.nereden.SelectedIndexChanged += new System.EventHandler(this.nereden_SelectedIndexChanged);
            // 
            // spKalkisBindingSource
            // 
            this.spKalkisBindingSource.DataMember = "Sp_Kalkis";
            this.spKalkisBindingSource.DataSource = this.onlineBiletDataSet;
            // 
            // onlineBiletDataSet
            // 
            this.onlineBiletDataSet.DataSetName = "OnlineBiletDataSet";
            this.onlineBiletDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdbtnGidisDonus
            // 
            this.rdbtnGidisDonus.AutoSize = true;
            this.rdbtnGidisDonus.Location = new System.Drawing.Point(138, 19);
            this.rdbtnGidisDonus.Name = "rdbtnGidisDonus";
            this.rdbtnGidisDonus.Size = new System.Drawing.Size(93, 17);
            this.rdbtnGidisDonus.TabIndex = 3;
            this.rdbtnGidisDonus.TabStop = true;
            this.rdbtnGidisDonus.Text = "Gidiş-Dönüş";
            this.rdbtnGidisDonus.UseVisualStyleBackColor = true;
            this.rdbtnGidisDonus.CheckedChanged += new System.EventHandler(this.rdbtnGidisDonus_CheckedChanged);
            this.rdbtnGidisDonus.Click += new System.EventHandler(this.rdbtnGidisDonus_Click);
            // 
            // rdbtnTekYon
            // 
            this.rdbtnTekYon.AutoSize = true;
            this.rdbtnTekYon.Location = new System.Drawing.Point(0, 19);
            this.rdbtnTekYon.Name = "rdbtnTekYon";
            this.rdbtnTekYon.Size = new System.Drawing.Size(73, 17);
            this.rdbtnTekYon.TabIndex = 4;
            this.rdbtnTekYon.TabStop = true;
            this.rdbtnTekYon.Text = "Tek-Yön";
            this.rdbtnTekYon.UseVisualStyleBackColor = true;
            this.rdbtnTekYon.CheckedChanged += new System.EventHandler(this.rdbtnTekYon_CheckedChanged);
            this.rdbtnTekYon.Click += new System.EventHandler(this.rdbtnTekYon_Click);
            // 
            // sp_KalkisTableAdapter
            // 
            this.sp_KalkisTableAdapter.ClearBeforeFill = true;
            // 
            // onlineBiletDataSetBindingSource
            // 
            this.onlineBiletDataSetBindingSource.DataSource = this.onlineBiletDataSet;
            this.onlineBiletDataSetBindingSource.Position = 0;
            // 
            // onlineBiletDataSet1
            // 
            this.onlineBiletDataSet1.DataSetName = "OnlineBiletDataSet1";
            this.onlineBiletDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPVarisBindingSource1
            // 
            this.sPVarisBindingSource1.DataMember = "SP_Varis";
            this.sPVarisBindingSource1.DataSource = this.onlineBiletDataSet1;
            // 
            // sP_VarisTableAdapter
            // 
            this.sP_VarisTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Üye Girişi";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(160, 40);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(116, 20);
            this.txtKullaniciAdi.TabIndex = 9;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(160, 84);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(116, 20);
            this.txtSifre.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnuye);
            this.panel1.Controls.Add(this.btngiris);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Location = new System.Drawing.Point(726, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 214);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OnlineBilet.Properties.Resources.images__2_;
            this.pictureBox1.Location = new System.Drawing.Point(283, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 101);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnuye
            // 
            this.btnuye.BackgroundImage = global::OnlineBilet.Properties.Resources.CheckMark;
            this.btnuye.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuye.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnuye.Location = new System.Drawing.Point(77, 136);
            this.btnuye.Name = "btnuye";
            this.btnuye.Size = new System.Drawing.Size(79, 75);
            this.btnuye.TabIndex = 14;
            this.btnuye.Text = "Üye Ol";
            this.btnuye.UseVisualStyleBackColor = true;
            this.btnuye.Click += new System.EventHandler(this.btnuye_Click);
            // 
            // btngiris
            // 
            this.btngiris.BackgroundImage = global::OnlineBilet.Properties.Resources.CheckMark;
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngiris.Location = new System.Drawing.Point(225, 137);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(77, 74);
            this.btngiris.TabIndex = 13;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Şifre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(521, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "13-24";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(450, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "65+";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "0-2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "2-12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "12+";
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox7.Location = new System.Drawing.Point(521, 217);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(47, 21);
            this.comboBox7.TabIndex = 50;
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox6.Location = new System.Drawing.Point(448, 217);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(49, 21);
            this.comboBox6.TabIndex = 49;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox5.Location = new System.Drawing.Point(362, 217);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(49, 21);
            this.comboBox5.TabIndex = 48;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            ""});
            this.comboBox4.Location = new System.Drawing.Point(279, 217);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(48, 21);
            this.comboBox4.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Öğrenci";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "60 Yaş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Bebek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Çocuk";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox3.Location = new System.Drawing.Point(203, 217);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(47, 21);
            this.comboBox3.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(199, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Yetişkin";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(768, 340);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker2.TabIndex = 73;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(764, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 72;
            this.label14.Text = "Dönüş Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.PaleGoldenrod;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(768, 283);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 71;
            this.dateTimePicker1.Value = new System.DateTime(2014, 1, 23, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(764, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "Gidiş Tarihi";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(241, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Nereden";
            // 
            // txtYon
            // 
            this.txtYon.Location = new System.Drawing.Point(768, 339);
            this.txtYon.Name = "txtYon";
            this.txtYon.Size = new System.Drawing.Size(182, 20);
            this.txtYon.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.Controls.Add(this.rdbtnTekYon);
            this.groupBox1.Controls.Add(this.rdbtnGidisDonus);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 60);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            // 
            // havaAlanlari
            // 
            this.havaAlanlari.DataSetName = "HavaAlanlari";
            this.havaAlanlari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spHavaAlanlariBindingSource
            // 
            this.spHavaAlanlariBindingSource.DataMember = "Sp_HavaAlanlari";
            this.spHavaAlanlariBindingSource.DataSource = this.havaAlanlari;
            // 
            // sp_HavaAlanlariTableAdapter
            // 
            this.sp_HavaAlanlariTableAdapter.ClearBeforeFill = true;
            // 
            // spHavaAlanlariBindingSource1
            // 
            this.spHavaAlanlariBindingSource1.DataMember = "Sp_HavaAlanlari";
            this.spHavaAlanlariBindingSource1.DataSource = this.nereden21;
            // 
            // nereden21
            // 
            this.nereden21.DataSetName = "nereden2";
            this.nereden21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_HavaAlanlariTableAdapter1
            // 
            this.sp_HavaAlanlariTableAdapter1.ClearBeforeFill = true;
            // 
            // havaalaniyeni
            // 
            this.havaalaniyeni.DataSetName = "Havaalaniyeni";
            this.havaalaniyeni.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spHavaAlanlariBindingSource2
            // 
            this.spHavaAlanlariBindingSource2.DataMember = "Sp_HavaAlanlari";
            this.spHavaAlanlariBindingSource2.DataSource = this.havaalaniyeni;
            // 
            // sp_HavaAlanlariTableAdapter2
            // 
            this.sp_HavaAlanlariTableAdapter2.ClearBeforeFill = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnKaydet.BackgroundImage = global::OnlineBilet.Properties.Resources.ad763ea3_f295_4f05_9069_ea1460388bd9;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.ImageIndex = 2;
            this.btnKaydet.Location = new System.Drawing.Point(407, 323);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 103);
            this.btnKaydet.TabIndex = 75;
            this.btnKaydet.Text = "ARA";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button4.BackgroundImage = global::OnlineBilet.Properties.Resources.s_130920889666;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImageIndex = 1;
            this.button4.Location = new System.Drawing.Point(163, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 103);
            this.button4.TabIndex = 74;
            this.button4.Text = "Koltuklar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sPVarisBindingSource
            // 
            this.sPVarisBindingSource.DataMember = "SP_Varis";
            // 
            // Form1
            // 
            this.AcceptButton = this.btngiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1133, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtYon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblnereye);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.nereye);
            this.Controls.Add(this.nereden);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spKalkisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBiletDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBiletDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBiletDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVarisBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.havaAlanlari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHavaAlanlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHavaAlanlariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nereden21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havaalaniyeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHavaAlanlariBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVarisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnereye;
        private OnlineBiletDataSet onlineBiletDataSet;
        private System.Windows.Forms.BindingSource spKalkisBindingSource;
        private OnlineBiletDataSetTableAdapters.Sp_KalkisTableAdapter sp_KalkisTableAdapter;
        private System.Windows.Forms.BindingSource onlineBiletDataSetBindingSource;
        private System.Windows.Forms.BindingSource sPVarisBindingSource;
        private OnlineBiletDataSet1 onlineBiletDataSet1;
        private System.Windows.Forms.BindingSource sPVarisBindingSource1;
        private OnlineBiletDataSet1TableAdapters.SP_VarisTableAdapter sP_VarisTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox comboBox7;
        public System.Windows.Forms.ComboBox comboBox6;
        public System.Windows.Forms.ComboBox comboBox5;
        public System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtYon;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox nereden;
        public System.Windows.Forms.RadioButton rdbtnGidisDonus;
        public System.Windows.Forms.RadioButton rdbtnTekYon;
        public System.Windows.Forms.ComboBox nereye;
        private HavaAlanlari havaAlanlari;
        private System.Windows.Forms.BindingSource spHavaAlanlariBindingSource;
        private HavaAlanlariTableAdapters.Sp_HavaAlanlariTableAdapter sp_HavaAlanlariTableAdapter;
        private nereden2 nereden21;
        private System.Windows.Forms.BindingSource spHavaAlanlariBindingSource1;
        private nereden2TableAdapters.Sp_HavaAlanlariTableAdapter sp_HavaAlanlariTableAdapter1;
        private Havaalaniyeni havaalaniyeni;
        private System.Windows.Forms.BindingSource spHavaAlanlariBindingSource2;
        private HavaalaniyeniTableAdapters.Sp_HavaAlanlariTableAdapter sp_HavaAlanlariTableAdapter2;
        private System.Windows.Forms.Button btnuye;
        private System.Windows.Forms.PictureBox pictureBox1;

   
    }
}


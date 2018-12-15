/////////////Uyelik formu//////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace YemekSepeti2
{
    public partial class Uyelik : Form
    {
        string kullaniciTipi = " ";
        public Uyelik()
        {
            InitializeComponent();
            groupBox1.Visible = false;//firma seçildiğinde açılacak
            groupBox2.Visible = false;// müşteri seçildiğinde açılacak
            ilDoldur();
           
        }
        class ilSinif
        {
            public int id;
            public string adi;

            public override string ToString()
            {
                return string.Format("{0}", adi);
            }
        }
        class ilceSinif
        {
            public int id;
            public string adi;

            public override string ToString()
            {
                return string.Format("{0}", adi);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, parola, parolaTekrar, eMail;
            
            kullaniciAdi = txtKullanıcıAdı.Text;
            parola = txtParola.Text;
            parolaTekrar = txtParolaTekrar.Text;
            eMail = txtEMail.Text;
            
           
            if (kullaniciTipi == "M" || kullaniciTipi == "F")
            {
                if (parola != parolaTekrar)
                {
                    MessageBox.Show("Girilen parola değerleri birbirini tutmamaktadır.");

                }
                else
                {
                    string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
                    OleDbConnection baglan = new OleDbConnection(kaynak);
                    string ekle = "insert into Kullanici" + "(KullaniciAdi, Sifre,KullaniciTipi) values " + "('" + kullaniciAdi + "','" + parola.Trim() + "','" + kullaniciTipi + "')";
                    OleDbDataAdapter adapFirma = new OleDbDataAdapter(ekle, baglan);
                    DataSet dsFirma = new DataSet();
                    adapFirma.Fill(dsFirma);


                    if (kullaniciTipi == "F")
                        groupBox1.Visible = true;
                    if (kullaniciTipi == "M")
                        groupBox2.Visible = true;
                }
            }
            else
                MessageBox.Show("Lutfen Firma mı Musterimi oldugunuzu belirtiniz!!!!");
        }

        private void Uyelik_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            string firmaAdi, hizmetBolgesi, yetkiliAdiSoyadi, yetkiliCep, mail, hizmetbil;
            firmaAdi = txtFirmaAdi.Text;
            hizmetBolgesi = comboBoxHizmetbol.SelectedItem.ToString();
            yetkiliAdiSoyadi = txtYetkiliAdSoyad.Text;
            yetkiliCep = txtCeptel.Text;
            mail = txtMailAdresi.Text;
            hizmetbil = txtHizmetBilgileri.Text;           
            string ekle = "insert into Firma " + "(FirmaAdi,HizmetBolgesi,HizmetBilgileri,MailAdresi,YetkiliKisiAdSoyad,YetkiliKisiCep) values" + " ('" + firmaAdi + "','" + hizmetBolgesi + "','" + hizmetbil + "','" + mail + "','" + yetkiliAdiSoyadi + "','" + yetkiliCep + "')";
            OleDbDataAdapter adap = new OleDbDataAdapter(ekle, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            MessageBox.Show("Kaydedildi..");
        }

        private void btneklemusteri_Click(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            string ad, soyad, telefon, il, ilce, adres;
            ad = txtad.Text;
            soyad = txtsoyad.Text;
            telefon = txtTelNo.Text;
            il = comboİl.SelectedItem.ToString();
            ilce = comboİlce.SelectedItem.ToString();
            adres = richtxtAdres.Text;
            string ekle = "insert into Musteri " + "(Ad,Soyad,TelefonNo,il,ilce,Adres) values" + " ('" + ad + "','" + soyad + "','" + telefon + "','" + il + "','" + ilce + "','" + adres + "')";
            OleDbDataAdapter adap = new OleDbDataAdapter(ekle, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            MessageBox.Show("Kullanıcı Başarı ile Eklendi", "Başarılı");
        }
        private void ilDoldur()
        {
            
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            string goster = "Select PlakaNo,ilAdi  From il order by PlakaNo";
            OleDbDataAdapter adap = new OleDbDataAdapter(goster, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            ilSinif il;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                il = new ilSinif();
                il.id = Convert.ToInt32(ds.Tables[0].Rows[i]["PlakaNo"]);
                il.adi = ds.Tables[0].Rows[i]["ilAdi"].ToString();
                comboİl.Items.Add(il);

            }
        }

        private void comboİl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilSinif il;
            il = (ilSinif)comboİl.SelectedItem;
            comboİlce.Items.Clear();
            comboİlce.SelectedText = "";
            ilceDoldur(il.id);
        }
        private void ilceDoldur(int il_id)
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            string goster = "Select ilPlaka,ilceAdi  From ilce where ilPlaka= " + il_id + "";
            OleDbDataAdapter adap = new OleDbDataAdapter(goster, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            ilceSinif ilce;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ilce = new ilceSinif();
                ilce.id = Convert.ToInt32(ds.Tables[0].Rows[i]["ilPlaka"]);
                ilce.adi = ds.Tables[0].Rows[i]["ilceAdi"].ToString();
                comboİlce.Items.Add(ilce);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nesne = new Form1();
            nesne.Show();
            this.Hide();

        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 nesne = new Form1();
            nesne.Show();
            this.Hide();
        }

        private void Uyelik_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();//açılırken ekranın ortasında olamsı için
        }

        private void radiobtnMusteri_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnMusteri.Checked == true)
            {
                kullaniciTipi = "M";
                radiobtnFirma.Enabled = false;
            }
           
           
        }

        private void radiobtnFirma_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radiobtnFirma.Checked == true)
            {
                kullaniciTipi = "F";
                radiobtnMusteri.Enabled = false;
            }
        }
    }
}

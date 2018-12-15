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
    public partial class Yonetici : Form
    {
        string mail;// iki tane tabpage kullanılacağı için glabal tanımlanmıştır
        public Yonetici()
        {
            InitializeComponent();
            ilDoldur();
            FirmaDoldur();
        }
        private void FirmaDoldur()
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            OleDbCommand komut = new OleDbCommand();
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            komut.Connection = baglanti; // komut'un bağlantı yapacağı connection belirtilir
            komut.CommandText = "SELECT * FROM Firma"; // veritabanı sorgunuzz
            OleDbDataAdapter adp = new OleDbDataAdapter(); //Yeni komutu baglantiyla çalıştıracak adapter
            adp.SelectCommand = komut; //Komut adaptere Select sorgusu olarak tanımlanır
            DataSet ds = new DataSet(); //Verileri tutacağımız bir dataset oluşturulur
            adp.Fill(ds, "Firma"); //Datasetin için tablodan gelen satırlarla doldurulur.
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {


                comboBoxfirmaguncelle.Items.Add(ds.Tables[0].Rows[i]["FirmaAdi"].ToString()); //comboboxiçerisine belirtilen kolondaki veriler eklenir
            }


        }

        private void Yonetici_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            string goster = "Select FirmaAdi From Firma order by FirmaAdi";
            OleDbDataAdapter adap = new OleDbDataAdapter(goster, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            Firmaa f;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                f = new Firmaa();

                f.ad = ds.Tables[0].Rows[i]["FirmaAdi"].ToString();
                comboSilinecekFirma.Items.Add(f);
            }
        }
        

        private void btnFirmaListele_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            baglan.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Firma WHERE FirmaAdi='" + comboSilinecekFirma.SelectedItem.ToString() + "'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            baglan.Dispose();

            comboSilinecekFirma.Items.Clear();
            comboSilinecekFirma.Text = "";
            OleDbCommand komut = new OleDbCommand();
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            komut.Connection = baglanti; // komut'un bağlantı yapacağı connection belirtilir
            komut.CommandText = "SELECT * FROM Firma"; // veritabanı sorgunuzz
            OleDbDataAdapter adp = new OleDbDataAdapter(); //Yeni komutu baglantiyla çalıştıracak adapter
            adp.SelectCommand = komut; //Komut adaptere Select sorgusu olarak tanımlanır
            DataSet ds = new DataSet(); //Verileri tutacağımız bir dataset oluşturulur
            adp.Fill(ds, "Firma"); //Datasetin için tablodan gelen satırlarla doldurulur.
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
            

                comboSilinecekFirma.Items.Add(ds.Tables[0].Rows[i]["FirmaAdi"].ToString()); //comboboxiçerisine belirtilen kolondaki veriler eklenir
            }

            MessageBox.Show("Seçtiğiniz Firma silindi.");
        }

        private void btncikisSilme_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            string firmaAdi, hizmetBolgesi, yetkiliAdiSoyadi, yetkiliCep, mail, hizmetbil,hizmetIlce;
            firmaAdi = txtFirmaAdi.Text;
            hizmetBolgesi = comboBoxHizmetbol.SelectedItem.ToString();
            yetkiliAdiSoyadi = txtYetkiliAdSoyad.Text;
            yetkiliCep = txtCeptel.Text;
            mail = txtMailAdresi.Text;
            hizmetbil = txtHizmetBilgileri.Text;
            hizmetIlce = comboFirmaekleİlce.SelectedItem.ToString();
            string ekle = "insert into Firma " + "(FirmaAdi,HizmetBolgesi,HizmetBilgileri,MailAdresi,YetkiliKisiAdSoyad,YetkiliKisiCep,HizmetBolgesiİlce) values" + " ('" + firmaAdi + "','" + hizmetBolgesi + "','" + hizmetbil + "','" + mail + "','" + yetkiliAdiSoyadi + "','" + yetkiliCep + "','" + hizmetIlce+"')";
            OleDbDataAdapter adap = new OleDbDataAdapter(ekle, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            MessageBox.Show("Kaydedildi..");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);         

            string firmaAdi, hizmetBolgesi, yetkiliAdiSoyadi, yetkiliCep, hizmetbil;
            firmaAdi = txtGFirmaAdi.Text;
            hizmetBolgesi = txtGHizmetBolgesi.Text;
            yetkiliAdiSoyadi = txtGadSoyad.Text;
            yetkiliCep = txtGCepTel.Text;
            mail = txtGmailAdresi.Text;
            hizmetbil = txtGHizmetBilgileri.Text;
            string guncelle = "Update Firma Set " + "FirmaAdi ='" + firmaAdi + "'" +
                ",HizmetBolgesi ='" + hizmetBolgesi + "'" +
                ",HizmetBilgileri='" + hizmetbil + "'" +
                ",MailAdresi='" + mail + "'" +
                ",YetkiliKisiAdSoyad='" + yetkiliAdiSoyadi + "'" +
                ",YetkiliKisiCep ='" + yetkiliCep + "'" +

                " Where FirmaAdi = '" + comboBoxfirmaguncelle.SelectedItem.ToString() + "'";
            OleDbDataAdapter adap1 = new OleDbDataAdapter(guncelle, baglan);
            DataSet ds1 = new DataSet();
            adap1.Fill(ds1);
            MessageBox.Show("Güncellemeniz yapıldı");

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            
            string kullaniciAdi, parola, parolaTekrar, eMail;
            kullaniciAdi = txtKullanıcıAdı.Text;
            parola = txtParola.Text;
            parolaTekrar = txtParolaTekrar.Text;
            eMail = mail;
            if (parola != parolaTekrar)
            {
                MessageBox.Show("Girilen parola değerleri birbirini tutmamaktadır.");

            }
            else
            {
                string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
                OleDbConnection baglan = new OleDbConnection(kaynak);
                string ekle = "insert into Kullanici" + "(KullaniciAdi, Sifre,KullaniciTipi) values " + "('" + kullaniciAdi + "','" + parola.Trim() + "'," + "'F'" + ")";
                OleDbDataAdapter adapFirma = new OleDbDataAdapter(ekle, baglan);
                DataSet dsFirma = new DataSet();
                adapFirma.Fill(dsFirma);
                MessageBox.Show("Kullanıcı Başarı ile Eklendi", "Başarılı");


            }

        }
        class Firmaa
        {

            public string ad;

            public override string ToString()
            {
                return string.Format("{0}", ad);
            }
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
                comboBoxHizmetbol.Items.Add(il);
            }

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

        private void comboBoxHizmetbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFirmaekleİlce.Items.Clear();//ildeğiştirildiğinde eski ilin ilçelerinin kalmaması için
            ilSinif il;
            il = (ilSinif)comboBoxHizmetbol.SelectedItem;       
            
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
                comboFirmaekleİlce.Items.Add(ilce);
            }
        }

        private void tabFirmaGuncelle_Click(object sender, EventArgs e)
        {
            FirmaDoldur();
        }   

        
    }
}

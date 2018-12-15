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
    public partial class Firma : Form
    {
        string gelenFirma;
        string UrunAdi, UrunFiyati;
        public Firma(string firmaAdi)
        {
           InitializeComponent();
           gelenFirma= firmaAdi ;
           txtFirmaAd.Text = gelenFirma;//tabpage ler arası geçişlerde isimin gitmesi için
        
           
            
        }
        private void UrunleriGetir()
        {
            
            OleDbCommand komut = new OleDbCommand();
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBaseYemek.accdb;Persist Security Info=True");
            komut.Connection = baglanti; // komut'un bağlantı yapacağı connection belirtilir
            komut.CommandText = " SELECT UrunAdi ,UrunFiyati FROM Firma INNER JOIN Urun ON Firma.FirmaAdi = Urun.UrunFirmasi " +
            "Where Urun.UrunFirmasi='" + gelenFirma + "'";
            OleDbDataAdapter adp = new OleDbDataAdapter(); //Yeni komutu baglantiyla çalıştıracak adapter
            adp.SelectCommand = komut; 
            DataSet ds = new DataSet(); //Verileri tutacağımız bir dataset oluşturulur
            adp.Fill(ds); //Datasetin için tablodan gelen satırlarla doldurulur.

            dataGridView3.DataSource = ds.Tables[0];
            
        }       
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            string urunAdi, urunFiyati, urunFirmasi;
            urunAdi=txtUrunAdiekle.Text;
            urunFiyati=txtUrunFiyatiEkle.Text;
            urunFirmasi=gelenFirma;
            
            string ekle = "insert into Urun " + "(UrunAdi,UrunFiyati,UrunFirmasi) values" + " ('" + urunAdi + "','" + urunFiyati + "','" + urunFirmasi + "')";
            OleDbDataAdapter adap = new OleDbDataAdapter(ekle, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            MessageBox.Show("Başarıyla Eklendi");
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);           
            baglan.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Urun WHERE UrunAdi='" + comboBox1.SelectedItem.ToString() + "'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            baglan.Dispose();
            comboBox1.SelectedItem = null;
            comboBox1.Items.Clear();
            OleDbCommand komut = new OleDbCommand();
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            komut.Connection = baglanti; // komut'un bağlantı yapacağı connection belirtilir
            komut.CommandText = "SELECT * FROM Urun"; // veritabanı sorgunuzz
            OleDbDataAdapter adp = new OleDbDataAdapter(); //Yeni komutu baglantiyla çalıştıracak adapter
            adp.SelectCommand = komut; //Komut adaptere Select sorgusu olarak tanımlanır
            DataSet ds = new DataSet(); //Verileri tutacağımız bir dataset oluşturulur
            adp.Fill(ds, "Urun"); //Datasetin için tablodan gelen satırlarla doldurulur.
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                comboBox1.Items.Add(ds.Tables[0].Rows[i]["UrunAdi"].ToString()); //listboxiçerisine belirtilen kolondaki veriler eklenir
            }

            MessageBox.Show("Seçtiğiniz ürün   silindi.");
            
        }       
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {//comboboxın içinin dolu gelmesi için
            comboBox1.Items.Clear();
            OleDbCommand komut = new OleDbCommand();
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBaseYemek.accdb;Persist Security Info=True");
            komut.Connection = baglanti; // komut'un bağlantı yapacağı connection belirtilir
            komut.CommandText = "SELECT Urun.UrunAdi FROM Firma INNER JOIN Urun ON Firma.FirmaAdi = Urun.UrunFirmasi where Firma.FirmaAdi='"+gelenFirma+"'"; // veritabanı sorgunuzz WHERE UrunAdi='" + comboBox1.SelectedItem.ToString() + "'"
            OleDbDataAdapter adp = new OleDbDataAdapter(); //Yeni komutu baglantiyla çalıştıracak adapter
            adp.SelectCommand = komut; //Komut adaptere Select sorgusu olarak tanımlanır
            DataSet ds = new DataSet(); //Verileri tutacağımız bir dataset oluşturulur
            adp.Fill(ds, "Urun"); //Datasetin için tablodan gelen satırlarla doldurulur.
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                comboBox1.Items.Add(ds.Tables[0].Rows[i]["UrunAdi"].ToString()); //comboboxiçerisine belirtilen kolondaki veriler eklenir
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand();
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBaseYemek.accdb;Persist Security Info=True");
            komut.Connection = baglanti; // komut'un bağlantı yapacağı connection belirtilir
            
            komut.CommandText = "SELECT Kullanici.KullaniciAdi, Urun.UrunAdi, Urun.UrunFiyati, Siparis_Listesi.Tarih, Urun.UrunFirmasi FROM (Urun INNER JOIN Siparis_Listesi ON Urun.ID = Siparis_Listesi.UrunID) INNER JOIN Kullanici ON Siparis_Listesi.KullanıcıID = Kullanici.ID  Where Urun.UrunFirmasi= '"+ gelenFirma +"'  Order by Siparis_Listesi.Tarih ";
            OleDbDataAdapter adp = new OleDbDataAdapter(); //Yeni komutu baglantiyla çalıştıracak adapter
            adp.SelectCommand = komut; //Komut adaptere Select sorgusu olarak tanımlanır
            DataSet ds = new DataSet(); //Verileri tutacağımız bir dataset oluşturulur
            adp.Fill(ds); //Datasetin için tablodan gelen satırlarla doldurulur.

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnUrunGoster_Click(object sender, EventArgs e)
        {
            string secilenFirma;
            secilenFirma = gelenFirma;
            OleDbCommand komut = new OleDbCommand();
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBaseYemek.accdb;Persist Security Info=True");
            komut.Connection = baglanti; // komut'un bağlantı yapacağı connection belirtilir
            komut.CommandText = " SELECT UrunAdi ,UrunFiyati FROM Urun " +
            "Where UrunFirmasi='" + secilenFirma + "'";
            OleDbDataAdapter adp = new OleDbDataAdapter(); //Yeni komutu baglantiyla çalıştıracak adapter
            adp.SelectCommand = komut; //Komut adaptere Select sorgusu olarak tanımlanır
            DataSet ds = new DataSet(); //Verileri tutacağımız bir dataset oluşturulur
            adp.Fill(ds); //Datasetin için tablodan gelen satırlarla doldurulur.

            dataGridView2.DataSource = ds.Tables[0];

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            UrunAdi = txaUrunAdi.Text;
            UrunFiyati = txtUrunFiyati.Text;


            string guncelle = "Update Urun Set   UrunAdi ='" + UrunAdi + "'" +

                ",UrunFiyati ='" + UrunFiyati + "'" +

                " Where UrunFirmasi = '" + gelenFirma + "'";
            OleDbDataAdapter adap1 = new OleDbDataAdapter(guncelle, baglan);
            DataSet ds1 = new DataSet();
            adap1.Fill(ds1);
            MessageBox.Show("Güncellemeniz yapıldı");
            UrunleriGetir();       

        }
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.RowCount > 0 && dataGridView3.SelectedRows.Count > 0)
            {
                txaUrunAdi.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                txtUrunFiyati.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void Firma_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();//açılırken ekranın ortasında olamsı için
        }

        private void tabUrunGuncelle_Click(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        
    }
}

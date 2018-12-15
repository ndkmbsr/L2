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
    public partial class Musterii : Form
    {
        int kullaniciID;//veri tabanındaki sipariş listesi için
        int urunID;//veri tabanındaki sipariş listesi için
        double toplamTutar = 0;
        string SiparisVeren, urunAdi,aranacakUrun;
        public Musterii(string kullaniciAdi)
        {
            InitializeComponent();
            ilDoldur();
            firmaDoldur();
            SiparisVeren = kullaniciAdi;
            kullaniciIDBul();
            errorProvider1.SetError(label6, "Lütfen firma ismiyle arama yaptıktan sonra sepete ekleyiniz");
         
            
        }
        private void kullaniciIDBul()
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            string goster = "Select * From Kullanici where KullaniciAdi='" + SiparisVeren + "'";
            OleDbDataAdapter adap = new OleDbDataAdapter(goster, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            
            kullaniciID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);          

        }
        private void urunIDBul()
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            string goster = "Select * From Urun where UrunAdi='" + urunAdi + "'";
            OleDbDataAdapter adap = new OleDbDataAdapter(goster, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);            
            urunID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
        }
        private void firmaDoldur()
        {
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
                comboBoxMusteri.Items.Add(f);
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
                comboİlSeciniz.Items.Add(il);

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
        private void btnSiparisVermek_Click(object sender, EventArgs e)
        {
            DateTime dt;
            dt = dateTimePicker1.Value.Date;
         
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);

            string ekle = "insert into Siparis_Listesi " + "(KullanıcıID,UrunID,Tarih) values" + " (" + kullaniciID + "," + urunID + ",'" + dt + "')";
            OleDbDataAdapter adap = new OleDbDataAdapter(ekle, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            MessageBox.Show("Siparişiniz işleme alındı.Bizi seçtiğiniz için teşekkür ederiz.");          

        }

        private void button1_Click(object sender, EventArgs e)//urun arama butonu
        {
            aranacakUrun = txtArananUrun.Text;
            string il, ilce;
            il = comboİlSeciniz.SelectedItem.ToString();
            ilce = comboİlceSeciniz.SelectedItem.ToString();            
            OleDbCommand komut = new OleDbCommand();
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBaseYemek.accdb;Persist Security Info=True");
            komut.Connection = baglanti;
            komut.CommandText = " SELECT Urun.UrunAdi, Urun.UrunFiyati, Urun.UrunFirmasi" + " FROM Urun INNER JOIN ((il INNER JOIN ilce ON il.PlakaNo = ilce.ilPlaka) INNER JOIN Firma ON il.ilAdi = Firma.HizmetBolgesi) ON Urun.UrunFirmasi = Firma.FirmaAdi " +
            "Where Urun.UrunAdi='" + aranacakUrun + "' And il.ilAdi='"+il+"' And ilce.ilceAdi='" + ilce + "'";
            OleDbDataAdapter adp = new OleDbDataAdapter(); 
            adp.SelectCommand = komut;
            DataSet ds = new DataSet(); //Verileri tutacağımız bir dataset oluşturulur
            adp.Fill(ds,"Firma"); //Datasetin için tablodan gelen satırlarla doldurulur.
            
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnFirmaninÜrünleri_Click(object sender, EventArgs e)
        {
            string secilenFirma;
            secilenFirma = comboBoxMusteri.SelectedItem.ToString();
            OleDbCommand komut = new OleDbCommand();
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBaseYemek.accdb;Persist Security Info=True");
            komut.Connection = baglanti; // komut'un bağlantı yapacağı connection belirtilir
            komut.CommandText = " SELECT UrunAdi ,UrunFiyati FROM Firma INNER JOIN Urun ON Firma.FirmaAdi = Urun.UrunFirmasi " +
            "Where Urun.UrunFirmasi='" + secilenFirma + "'";
            OleDbDataAdapter adp = new OleDbDataAdapter();
            adp.SelectCommand = komut; 
            DataSet ds = new DataSet(); //Verileri tutacağımız bir dataset oluşturulur
            adp.Fill(ds, "Urun"); //Datasetin için tablodan gelen satırlarla doldurulur.

            dataGridView1.DataSource = ds.Tables[0];
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

        private void comboİlSeciniz_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilSinif il;
            il = (ilSinif)comboİlSeciniz.SelectedItem;
            comboİlceSeciniz.Items.Clear();
            comboİlceSeciniz.SelectedText = "";
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
                comboİlceSeciniz.Items.Add(ilce);
            }
        }  

        private void button2_Click(object sender, EventArgs e)//sepete ekle butonu
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            panel1.Enabled = true;
            string UrunFiyati, FirmaAdi;
            urunAdi = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            UrunFiyati = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            FirmaAdi = comboBoxMusteri.SelectedItem.ToString();

            string ekle = "insert into Sepet " + "(UrunAdi,UrunFiyati,FirmaAdi,KullaniciAdi) values" + " ('" + urunAdi + "','" + UrunFiyati + "','" + FirmaAdi + "','" + SiparisVeren + "')";
            OleDbDataAdapter adap = new OleDbDataAdapter(ekle, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            listboxSepetim.Items.Add(urunAdi);
            toplamTutar += Convert.ToDouble(UrunFiyati);
            txttoplamTutar.Text = toplamTutar.ToString()+"TL";
            MessageBox.Show("Sepetinize eklendi");
            urunIDBul();   

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)//urun arama butonunun gridviewi
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Musterii_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();//açılırken ekranın ortasında olamsı için
        }       
    }
}
        
       
    


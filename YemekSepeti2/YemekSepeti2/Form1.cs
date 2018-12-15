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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0; data Source =DataBaseYemek.accdb";
            OleDbConnection baglan = new OleDbConnection(kaynak);
            string goster = "Select * From Kullanici where KullaniciAdi='" + txtKullanici.Text + "'" + " And " + " Sifre ='"+txtSifre.Text +"'" ;
            OleDbDataAdapter adap = new OleDbDataAdapter(goster, baglan);
            DataSet ds = new DataSet();
            adap.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0) // Kullanıcı adı ve şifre mevcut giriş başarılı
            {
                lblHata.Visible = false;
                MessageBox.Show("Sisteme Giriş Başarılı");
                
                if (ds.Tables[0].Rows[0]["KullaniciTipi"].ToString() == "A")  //admin  
                {
                    MessageBox.Show("Yonetici hoşgeldiniz");
                    Yonetici admin = new Yonetici();
                    admin.ShowDialog();
                }
                else if (ds.Tables[0].Rows[0]["KullaniciTipi"].ToString() == "M")    // Müşteri
                {
                    MessageBox.Show("Kullanici "+ ds.Tables[0].Rows[0][1].ToString() + " hoşgeldiniz");
                    Musterii firmaMenu = new Musterii(txtKullanici.Text);
                    firmaMenu.ShowDialog();
                }
                else if (ds.Tables[0].Rows[0]["KullaniciTipi"].ToString() == "F")    // Firma
                {
                    MessageBox.Show("Firma " + ds.Tables[0].Rows[0][1].ToString() + " hoşgeldiniz");
                    Firma firmaMenu = new Firma((ds.Tables[0].Rows[0]["KullaniciAdi"].ToString()));
                    firmaMenu.ShowDialog();
                }
            }
            else
            { // giriş başarısız.
                lblHata.Text = "Kullanıcı Adı veya Şifre Hatalı!";
                lblHata.ForeColor = Color.Red;
                lblHata.Visible = true;
            }
            
        
        }

        private void btnYeniUye_Click(object sender, EventArgs e)
        {
            Uyelik nesne = new Uyelik();
            nesne.Show();
            this.Hide();
        }

        private void bntCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();//formun ekranın ortasında açılması için.
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Data.SqlTypes;


namespace OnlineBilet
{
    public partial class Form1 : Form
   {
          public Admin frmAdmin;
          public Koltuk frmkoltuk;
          public Ara frmAra;
          public Kayit frmKayit;
          public Uye frmUye;
          //public Firma1 frm1;
          //public Firma2 frm2;
        string connectionString = "Data Source=NIDOŞŞŞ;Initial Catalog=OnlineBilet;User ID=sa;Password=as";
        public string SecilenYon = "";
      
        public DateTime donusTarihi=DateTime.Now;
        public DateTime gidisTarihi=DateTime.Now;
        public string Nereden="";
        public string Nereye="";
        //string yetiskin = "";
        //string cocuk = "";
        //string bebek = "";
      


        public Form1()
        {
            
            InitializeComponent();
           
            frmAdmin = new Admin();            
            frmkoltuk = new Koltuk();
            frmKayit = new Kayit();
            //frm1 = new Firma1();
            //frm2 = new Firma2();
            HavaAlaniDoldur(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'havaalaniyeni.Sp_HavaAlanlari' table. You can move, or remove it, as needed.
            this.sp_HavaAlanlariTableAdapter2.Fill(this.havaalaniyeni.Sp_HavaAlanlari);
           
            // TODO: This line of code loads data into the 'havaAlanlari.Sp_HavaAlanlari' table. You can move, or remove it, as needed.
          // this.sp_HavaAlanlariTableAdapter.Fill(this.havaAlanlari.Sp_HavaAlanlari);           
            txtYon.Visible = true;       
           
            comboBox3.SelectedIndex = 0;
        }

    
        private void HavaAlaniDoldur()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Sp_HavaAlanlari";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            reader = cmd.ExecuteReader();
            ComboboxItem item;
            while (reader.Read())
            {
                item = new ComboboxItem();

                item.Text = reader["YerAdi"].ToString();
                item.Value = Convert.ToInt32(reader["YerID"]);
                nereden.Items.Add(item);
                nereye.Items.Add(item);
            }
            nereden.SelectedIndex = 0;
            nereye.SelectedIndex = 0;
            sqlConnection.Close();
        }

       
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void nereye_SelectedIndexChanged(object sender, EventArgs e)
        {


            Nereye = nereye.SelectedText;
        }
        private void btngiris_Click(object sender, EventArgs e)
        {
            string sonuc = "Başarısız ";
            string KullaniciTipi = " ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Sp_Login";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (txtKullaniciAdi.Text == reader["KullaniciAdi"].ToString() && txtSifre.Text == reader["Sifre"].ToString())
                {
                    sonuc = "Başarılı";
                    KullaniciTipi = reader["KullaniciTipi"].ToString();
                   
                    break;
                }


            }
            MessageBox.Show(sonuc);
            if (KullaniciTipi == "A")
            {
                frmAdmin.Show();
                this.Hide();
            }
            if (KullaniciTipi=="F1")
            {
                //frm1.Show();
                this.Hide();      
            }
            if (KullaniciTipi == "F2")
            {
                //frm2.Show();
                this.Hide();
            }

            sqlConnection.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            
           
                frmAra = new Ara();
                frmKayit = new Kayit();
                MessageBox.Show(gidisTarihi.ToString());
                frmAra.gTarih = gidisTarihi;
                frmAra.dTarih = donusTarihi;
                frmKayit.Nereden = Nereden;
                frmKayit.Nereye = Nereye;
                frmKayit.SecilenYon = SecilenYon;
                frmKayit.dTarihi = donusTarihi;
                frmAra.Show();
                this.Hide();
           
              
        } 
        private void button4_Click(object sender, EventArgs e)
        {
            frmkoltuk.Show();
            this.Hide();
        }

        private void rdbtnTekYon_CheckedChanged(object sender, EventArgs e)
        {
            txtYon.Visible = true;
            txtYon.Text = "Tek Yön";
            dateTimePicker2.Visible = false;
            txtYon.Enabled = false;
            SecilenYon = rdbtnTekYon.Text;
            donusTarihi = Convert.ToDateTime(null);
            
        }

        private void rdbtnTekYon_Click(object sender, EventArgs e)
        {

            SecilenYon = "TekYon";

        }

        private void rdbtnGidisDonus_CheckedChanged(object sender, EventArgs e)
        {
            txtYon.Visible = false;

            dateTimePicker2.Visible = true;
            SecilenYon = rdbtnGidisDonus.Text;


        }

        

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           donusTarihi = (dateTimePicker2.Value);
           //frmAra.dTarih = donusTarihi;

        
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            gidisTarihi = (dateTimePicker1.Value);
            dateTimePicker2.MinDate = gidisTarihi;
           // frmAra.gTarih = gidisTarihi;
           
                     
           
        }       
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void nereden_SelectedIndexChanged(object sender, EventArgs e)
        {

            Nereden = nereden.SelectedText;
           
        }

        private void rdbtnGidisDonus_Click(object sender, EventArgs e)
        {
            SecilenYon = "Gidis-Donus";
        }

        private void btnuye_Click(object sender, EventArgs e)
        {
            frmUye = new Uye();
            frmUye.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
    }
}
   
    
       
    


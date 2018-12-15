using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace OnlineBilet
{
    public partial class Kayit : Form
    {
        Form1 frm;
        string connectionString = "Data Source=NIDOŞŞŞ;Initial Catalog=OnlineBilet;User ID=sa;Password=as";
        public string SecilenYon = ""; 
        string cinsiyet = "";
        int kalkisYolcu = 0;
        int KalkisID = 0;
        int ID = 0;
        string TC = "";
        int VarisID = 0;
        int varisYolcu = 0; 
        public string firmaAdi= "";
        public DateTime gTarih1;
        public DateTime dTarihi;
        public string Nereden = "";
        public string Nereye = ""; 
        public Kayit()
        {
            InitializeComponent();
            
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            frm = new Form1();
            dateTimePicker3.MaxDate = DateTime.Now;
          
           
          
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {


            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTc.Text != "" && cinsiyet != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO YolcuBilgileri(YolcuAdi,YolcuSoyadi,TC,Cinsiyet,DogumTarihi) VALUES(@paramAd,@paramSoyad,@paramTcNo,@paramCinsiyet, @paramDogumTarih)";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@paramAd", SqlDbType.VarChar, 50).Value = txtAd.Text;
                    cmd.Parameters.Add("@paramSoyad", SqlDbType.VarChar, 50).Value = txtSoyad.Text;
                    cmd.Parameters.Add("@paramTcNo", SqlDbType.VarChar, 50).Value = txtTc.Text;
                    cmd.Parameters.Add("@paramCinsiyet", SqlDbType.VarChar, 50).Value = cinsiyet;
                    cmd.Parameters.Add("@paramDogumTarih", SqlDbType.Date).Value = dateTimePicker3.Text;

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                }

                //////////////////////////////////////////YolcuID, KalkısID,VarisID leri Getirmek//////////////////////////
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand cmd1 = new SqlCommand();
                SqlDataReader reader;

                cmd1.CommandText = "SP_YolcuIDGetir";
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Connection = sqlConnection;

                sqlConnection.Open();

                reader = cmd1.ExecuteReader();

                while (reader.Read())
                {

                    TC = reader["TC"].ToString();


                    if (TC == txtTc.Text)
                    {
                        ID = Convert.ToInt32(reader["YolcuID"]);
                    }
                }

                sqlConnection.Close();

            }
            ///////////////////////ARA İşlem
            if (firmaAdi == "THY")
            {

                if (txtAd.Text != "" && txtSoyad.Text != "" && txtTc.Text != "" && cinsiyet != "")
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql = "INSERT INTO Firma1THY(YolcuAdi,YolcuSoyadi,TC,Cinsiyet,DogumTarihi) VALUES(@paramAd,@paramSoyad,@paramTcNo,@paramCinsiyet, @paramDogumTarih)";
                        SqlCommand cmd = new SqlCommand(sql, connection);
                        cmd.Parameters.Add("@paramAd", SqlDbType.VarChar, 50).Value = txtAd.Text;
                        cmd.Parameters.Add("@paramSoyad", SqlDbType.VarChar, 50).Value = txtSoyad.Text;
                        cmd.Parameters.Add("@paramTcNo", SqlDbType.VarChar, 50).Value = txtTc.Text;
                        cmd.Parameters.Add("@paramCinsiyet", SqlDbType.VarChar, 50).Value = cinsiyet;
                        cmd.Parameters.Add("@paramDogumTarih", SqlDbType.Date).Value = dateTimePicker3.Text;

                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                    }
                }

                if (firmaAdi == "PEGASUS")
                {

                    if (txtAd.Text != "" && txtSoyad.Text != "" && txtTc.Text != "" && cinsiyet != "")
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string sql = "INSERT INTO Firma2PEGASUS(YolcuAdi,YolcuSoyadi,TC,Cinsiyet,DogumTarihi) VALUES(@paramAd,@paramSoyad,@paramTcNo,@paramCinsiyet, @paramDogumTarih)";
                            SqlCommand cmd = new SqlCommand(sql, connection);
                            cmd.Parameters.Add("@paramAd", SqlDbType.VarChar, 50).Value = txtAd.Text;
                            cmd.Parameters.Add("@paramSoyad", SqlDbType.VarChar, 50).Value = txtSoyad.Text;
                            cmd.Parameters.Add("@paramTcNo", SqlDbType.VarChar, 50).Value = txtTc.Text;
                            cmd.Parameters.Add("@paramCinsiyet", SqlDbType.VarChar, 50).Value = cinsiyet;
                            cmd.Parameters.Add("@paramDogumTarih", SqlDbType.Date).Value = dateTimePicker3.Text;

                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();

                        }
                    }



                    //////////////////////////////////////////YolcuID, KalkısID,VarisID leri Getirmek//////////////////////////
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    SqlCommand cmd1 = new SqlCommand();
                    SqlDataReader reader;

                    cmd1.CommandText = "SP_YolcuIDGetir";
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Connection = sqlConnection;

                    sqlConnection.Open();

                    reader = cmd1.ExecuteReader();

                    while (reader.Read())
                    {

                        TC = reader["TC"].ToString();


                        if (TC == txtTc.Text)
                        {
                            ID = Convert.ToInt32(reader["YolcuID"]);
                        }
                    }

                    sqlConnection.Close();

                }

            }

            //////////////////
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO KalkisDurumu(KalkisYeriAdi,KalkisTarihi,DonusTarihi,YolcuID) VALUES(@paramnereden,@paramGTarih,@paramDTarih,@paramYolcuID)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@paramnereden", SqlDbType.VarChar, 100).Value = Nereden;
                cmd.Parameters.Add("@paramGTarih", SqlDbType.Date).Value = gTarih1;
                cmd.Parameters.Add("@paramDTarih", SqlDbType.Date).Value = frm.donusTarihi;
                cmd.Parameters.Add("@paramYolcuID", SqlDbType.Int).Value = ID;


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO VarisDurumu(VarisYeriAdi,YolcuID) VALUES(@paramnereye,@paramYolcuID)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@paramnereye", SqlDbType.VarChar, 100).Value = Nereye;

                cmd.Parameters.Add("@paramYolcuID", SqlDbType.Int).Value = ID;


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            ///////////////////////////////KalkısID//////////////////
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand cmd2 = new SqlCommand();
            SqlDataReader reader2;

            cmd2.CommandText = "SP_KalkisIDGetir";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {

                kalkisYolcu = Convert.ToInt32(reader2["YolcuID"]);


                if (kalkisYolcu == ID)
                {
                    KalkisID = Convert.ToInt32(reader2["KalkisID"]);
                }
            }

            sqlConnection1.Close();
            /////////////////////////////////////VarısID//////////////////////////
            cmd2.CommandText = "SP_VarisIDGetir";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                varisYolcu = Convert.ToInt32(reader2["YolcuID"]);

                if (varisYolcu == ID)
                {
                    VarisID = Convert.ToInt32(reader2["VarisID"]);
                }
            }

            sqlConnection1.Close();

            //////////////////////////////////////IDLER GETİRİLDİ//////////////////
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Hareket(Yon,YolcuID,KalkisID,VarisID) VALUES(@paramYon,@paramYolcuID,@paramKalkisID,@paramVarisID)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@paramYon", SqlDbType.VarChar, 100).Value = SecilenYon;
                cmd.Parameters.Add("@paramYolcuID", SqlDbType.Int).Value = ID;
                cmd.Parameters.Add("@paramKalkisID", SqlDbType.Int).Value = KalkisID;
                cmd.Parameters.Add("@paramVarisID", SqlDbType.Int).Value = VarisID;



                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }

            MessageBox.Show("Ekleme İşlemi tamamlandı!!!");
        }

       


        private void rdbtnKadin_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = rdbtnKadin.Text; 
        }

        private void rdbtnErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = rdbtnErkek.Text;   
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Kayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();
        }
        
    }
}
        
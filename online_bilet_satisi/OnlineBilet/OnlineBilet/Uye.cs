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
    public partial class Uye : Form
    {
        public Form1 frm1;
        string TC;
        int ID = 0;
        string connectionString = "Data Source=NIDOŞŞŞ;Initial Catalog=OnlineBilet;User ID=sa;Password=as";
        public Uye()
        {
            InitializeComponent();
            frm1 = new Form1();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtUyeyetkiliAd.Text != "" && txtUyeyetkiliSoyad.Text != "" && txtUyeYetkiliTC.Text != "" && txtUyefirmaadi.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO UyelikBilgileri(UyeTC,UyeAdi,UyeSoyadi,UyeNumara) VALUES(@paramUTC,@paramUAd,@paramUSoyad,@paramUNo)";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@paramUTC", SqlDbType.VarChar, 50).Value = txtUyeYetkiliTC.Text;
                    cmd.Parameters.Add("@paramUAd", SqlDbType.VarChar, 50).Value = txtUyeyetkiliAd.Text;
                    cmd.Parameters.Add("@paramUSoyad", SqlDbType.VarChar, 50).Value = txtUyeyetkiliSoyad.Text;
                    cmd.Parameters.Add("@paramUNo", SqlDbType.VarChar,50).Value = txtUyeNumara.Text;
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                   
                }
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand cmd1 = new SqlCommand();
                SqlDataReader reader;

                cmd1.CommandText = "SP_UyeIDGetir";
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Connection = sqlConnection;

                sqlConnection.Open();

                reader = cmd1.ExecuteReader();

                while (reader.Read())
                {

                   TC = reader["UyeTC"].ToString();


                    if ( TC== txtUyeYetkiliTC.Text )
                    {
                        ID = Convert.ToInt32(reader["UyeID"]);
                    }
                }

                sqlConnection.Close();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO UcakBilgileri(FirmaAdi,SeferSayisi,UcakSayisi,MaxYolcuSayisi,BagajAgirligi,UyeID) VALUES(@paramFA,@paramSefer,@paramUcakSayisi,@paramYolcu,@paramBagaj,@paramUYEID)";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@paramFA", SqlDbType.VarChar, 50).Value = txtUyefirmaadi.Text;
                    cmd.Parameters.Add("@paramSefer", SqlDbType.VarChar, 50).Value = txtSefer.Text;
                    cmd.Parameters.Add("@paramUcakSayisi", SqlDbType.VarChar, 50).Value = txtUcakSayisi.Text;
                    cmd.Parameters.Add("@paramYolcu", SqlDbType.Int).Value = txtYolcuSayisi.Text;
                    cmd.Parameters.Add("@paramBagaj", SqlDbType.VarChar, 50).Value = txtBagaj.Text;
                    cmd.Parameters.Add("@paramUYEID", SqlDbType.Int).Value = ID;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                }

            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz !!!");
            }
            MessageBox.Show("Admine Bilgileriniz Gönderilmiştir");

        }

        private void Uye_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

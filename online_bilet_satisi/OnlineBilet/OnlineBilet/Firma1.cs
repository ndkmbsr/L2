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
    public partial class Firma1 : Form
    {
        string connectionString = "Data Source=NIDOŞŞŞ;Initial Catalog=OnlineBilet;User ID=sa;Password=as";
        public string firmaAdi = "";
        string yolcuAdi = "";
        string yolcuSoyadi = "";
        string TC = "";
        string cinsiyet = "";
        DateTime dogumTarihi;
        public Firma1()
        {
            InitializeComponent();
            textleriDoldur();
        }

        private void Firma1_Load(object sender, EventArgs e)
        {
           
        }
        private void textleriDoldur()             
        {

            txtFirmaAdi1.Text = firmaAdi;
          
            //SqlDataReader reader;
          //  cmd.CommandText = "SP_FirmaBilgileriGetir";
            //cmd   CommandType.StoredProcedure;
        
         


            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "select * from [dbo].[AdmininGörevleri]";
               cmd = new SqlCommand(sql, connection);
                cmd.Connection = sqlConnection;
              
                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                DataTable dt = new DataTable();
                
               


                dt.Columns.Add(new DataColumn("UyeID", typeof(int)));
                dt.Columns.Add(new DataColumn("UyeTC", typeof(string)));
                dt.Columns.Add(new DataColumn("UyeAdi", typeof(string)));
                dt.Columns.Add(new DataColumn("UyeSoyadi", typeof(string)));
                dt.Columns.Add(new DataColumn("UyeNumara", typeof(string)));
                dt.Columns.Add(new DataColumn("FirmaAdi", typeof(string)));
                dt.Columns.Add(new DataColumn("SeferSayisi", typeof(string)));
                dt.Columns.Add(new DataColumn("UcakSayisi", typeof(string)));
                dt.Columns.Add(new DataColumn("MaxYolcuSayisi", typeof(int)));
                dt.Columns.Add(new DataColumn("BagajAgirligi", typeof(string)));


                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {


                    txtTc1.Text = dataSet.Tables[0].Rows[i]["UyeTC"].ToString();

                    txtYetkiliAdi1.Text = dataSet.Tables[0].Rows[i]["UyeAdi"].ToString();

                    txtYetkilisoyadi1.Text = dataSet.Tables[0].Rows[i]["UyeSoyadi"].ToString();
                    txtNumara1.Text = dataSet.Tables[0].Rows[i]["UyeNumara"].ToString();
                    txtSeferSayisi1.Text = dataSet.Tables[0].Rows[i]["SeferSayisi"].ToString();
                    txtUcakSayisi1.Text = dataSet.Tables[0].Rows[i]["UcakSayisi"].ToString();
                    txtMaxYolcuSayisi1.Text = dataSet.Tables[0].Rows[i]["MaxYolcuSayisi"].ToString();
                    txtBagajAgirligi1.Text = dataSet.Tables[0].Rows[i]["BagajAgirligi"].ToString();
                 
                }
            


                sqlConnection.Close();
            
            }
        }
    }
}

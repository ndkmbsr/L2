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
    public partial class Admin : Form
    {
        string connectionString = "Data Source=NIDOŞŞŞ;Initial Catalog=OnlineBilet;User ID=sa;Password=as";
        public Admin()
        {
            InitializeComponent();
            GridDoldur();
                   
        }       
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtyetkiliAd.Text!= "" && txtyetkiliSoyad.Text!= "" && txtYetkiliTC.Text != "" && txtfirmaadi.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO AdmininGörevleri(FirmaAdi,YetkiliAdi,YetkiliSoyadi,Numara,YetkiliTC,SeferSayisi,UcakSayisi,MaxYolcuSayisi,BagajAgirligi) VALUES(@paramFAd,@paramYAd,@paramYSoyad,@paramNo,@paramTC,@paramSeferSayisi,@paramUcakSayisi,@paramMaxYolcuSayisi,@paramBagajAgirligi)";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@paramFAd", SqlDbType.VarChar, 50).Value = txtfirmaadi.Text;
                    cmd.Parameters.Add("@paramYAd", SqlDbType.VarChar, 50).Value = txtyetkiliAd.Text;
                    cmd.Parameters.Add("@paramYSoyad", SqlDbType.VarChar, 50).Value =txtyetkiliSoyad.Text;
                    cmd.Parameters.Add("@paramNo", SqlDbType.VarChar, 11).Value = txtNumara.Text;
                    cmd.Parameters.Add("@paramTC", SqlDbType.VarChar ,11).Value = txtYetkiliTC.Text;
                    cmd.Parameters.Add("@paramSeferSayisi", SqlDbType.VarChar, 50).Value = txtSeferSayisi.Text;
                    cmd.Parameters.Add("@paramUcakSayisi", SqlDbType.VarChar, 50).Value = txtUcakSayisi.Text;
                    cmd.Parameters.Add("@paramMaxYolcuSayisi", SqlDbType.Int).Value = Convert.ToInt32(txtYolcuSayisi.Text);
                    cmd.Parameters.Add("@paramBagajAgirligi", SqlDbType.VarChar, 50).Value = txtBagajAgiriligi.Text;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    GridDoldur();
                }
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz !!!");
            }
        }
        private void GridDoldur()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;
            cmd.CommandText = "SP_FirmaBilgileriGetir";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add(new DataColumn("FirmaID", typeof(int)));
            dt.Columns.Add(new DataColumn("FirmaAdi", typeof(string)));                      
            dt.Columns.Add(new DataColumn("UyeTC", typeof(string)));
            dt.Columns.Add(new DataColumn("UyeAdi", typeof(string)));
            dt.Columns.Add(new DataColumn("UyeSoyadi", typeof(string)));
            dt.Columns.Add(new DataColumn("UyeNumara", typeof(string)));         
            dt.Columns.Add(new DataColumn("SeferSayisi", typeof(string)));
            dt.Columns.Add(new DataColumn("UcakSayisi", typeof(string)));
            dt.Columns.Add(new DataColumn("MaxYolcuSayisi", typeof(int)));
            dt.Columns.Add(new DataColumn("BagajAgirligi", typeof(string)));
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = dataSet.Tables[0].Rows[i]["FirmaID"].ToString();
                dr[1] = dataSet.Tables[0].Rows[i]["FirmaAdi"].ToString();
                dr[2] = dataSet.Tables[0].Rows[i]["YetkiliTC"].ToString();
                dr[3] = dataSet.Tables[0].Rows[i]["YetkiliAdi"].ToString();
                dr[4] = dataSet.Tables[0].Rows[i]["YetkiliSoyadi"].ToString();
                dr[5] = dataSet.Tables[0].Rows[i]["Numara"].ToString();
                dr[6] = dataSet.Tables[0].Rows[i]["SeferSayisi"].ToString();
                dr[7] = dataSet.Tables[0].Rows[i]["UcakSayisi"].ToString();
                dr[8] = dataSet.Tables[0].Rows[i]["MaxYolcuSayisi"].ToString();
                dr[9] = dataSet.Tables[0].Rows[i]["BagajAgirligi"].ToString(); 
                dt.Rows.Add(dr);
            }
            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            sqlConnection.Close();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                txtfirmaadi.Text = dataGridView1.SelectedRows[0].Cells["FirmaAdi"].Value.ToString();
                txtYetkiliTC.Text = dataGridView1.SelectedRows[0].Cells["UyeTC"].Value.ToString();
                txtyetkiliAd.Text= dataGridView1.SelectedRows[0].Cells["UyeAdi"].Value.ToString();
                txtyetkiliSoyad.Text= dataGridView1.SelectedRows[0].Cells["UyeSoyadi"].Value.ToString();
                txtNumara.Text = dataGridView1.SelectedRows[0].Cells["UyeNumara"].Value.ToString();
                txtSeferSayisi.Text = dataGridView1.SelectedRows[0].Cells["SeferSayisi"].Value.ToString();
                txtUcakSayisi.Text = dataGridView1.SelectedRows[0].Cells["UcakSayisi"].Value.ToString();
                txtYolcuSayisi.Text = dataGridView1.SelectedRows[0].Cells["MaxYolcuSayisi"].Value.ToString();
                txtBagajAgiriligi.Text = dataGridView1.SelectedRows[0].Cells["BagajAgirligi"].Value.ToString();
            }


        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtYetkiliTC.Text = "";
            txtyetkiliSoyad.Text = "";
            txtyetkiliAd.Text = "";
            txtNumara.Text = "";
            txtfirmaadi.Text = "";
            txtBagajAgiriligi.Text = "";
            txtSeferSayisi.Text = "";
            txtUcakSayisi.Text = "";
            txtYolcuSayisi.Text = "";
            
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            int FirmaID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            cmd.CommandText = "SP_FirmaGuncelle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = FirmaID;
            cmd.Parameters.Add("@FirmaAdi", SqlDbType.VarChar, 50).Value = txtfirmaadi.Text;
            cmd.Parameters.Add("@YetkiliAdi", SqlDbType.VarChar, 50).Value = txtyetkiliAd.Text;
            cmd.Parameters.Add("@YetkiliSoyadi", SqlDbType.VarChar, 50).Value = txtyetkiliSoyad.Text;
            cmd.Parameters.Add("@Numara", SqlDbType.VarChar, 50).Value = txtNumara.Text;
            cmd.Parameters.Add("@YetkiliTC", SqlDbType.VarChar, 50).Value = txtYetkiliTC.Text;
            cmd.Parameters.Add("@SeferSayisi", SqlDbType.VarChar, 50).Value = txtSeferSayisi.Text;
            cmd.Parameters.Add("@UcakSayisi", SqlDbType.VarChar, 50).Value = txtUcakSayisi.Text;
            cmd.Parameters.Add("@MaxYolcuSayisi", SqlDbType.Int).Value = Convert.ToInt32(txtYolcuSayisi.Text);
            cmd.Parameters.Add("@BagajAgirligi", SqlDbType.VarChar, 50).Value = txtBagajAgiriligi.Text;   
            sqlConnection.Open();
            reader = cmd.ExecuteReader();                      
            GridDoldur();
            sqlConnection.Close();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            int FirmaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);           
                    cmd.CommandText = "SP_FirmaSil";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = sqlConnection;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value =FirmaId;                   
                    sqlConnection.Open();
                    reader = cmd.ExecuteReader();
                    GridDoldur();
                    sqlConnection.Close();
                    txtYetkiliTC.Text = "";
                    txtyetkiliSoyad.Text = "";
                    txtyetkiliAd.Text = "";
                    txtNumara.Text = "";
                    txtfirmaadi.Text = "";
                    txtSeferSayisi.Text = "";
                    txtUcakSayisi.Text = "";
                    txtYolcuSayisi.Text = "";
                    txtBagajAgiriligi.Text = "";
                                     
        }
        private void btnIstek_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "SP_SanalTabloGetir";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            reader = cmd.ExecuteReader();     
            Grid1Doldur();            
        }
        private void Grid1Doldur()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
           // SqlDataReader reader;
            cmd.CommandText = "SP_SanalTabloGetir";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dt = new DataTable();
            DataRow dr;           
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
                dr = dt.NewRow();
                dr[0] = dataSet.Tables[0].Rows[i]["UyeID"].ToString();
                dr[1] = dataSet.Tables[0].Rows[i]["UyeTC"].ToString();
                dr[2] = dataSet.Tables[0].Rows[i]["UyeAdi"].ToString();
                dr[3] = dataSet.Tables[0].Rows[i]["UyeSoyadi"].ToString();
                dr[4] = dataSet.Tables[0].Rows[i]["UyeNumara"].ToString();
                dr[5] = dataSet.Tables[0].Rows[i]["FirmaAdi"].ToString();
                dr[6] = dataSet.Tables[0].Rows[i]["SeferSayisi"].ToString();
                dr[7] = dataSet.Tables[0].Rows[i]["UcakSayisi"].ToString();
                dr[8] = dataSet.Tables[0].Rows[i]["MaxYolcuSayisi"].ToString();
                dr[9] = dataSet.Tables[0].Rows[i]["BagajAgirligi"].ToString();
                dt.Rows.Add(dr);
            }
            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            sqlConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
   }

 }


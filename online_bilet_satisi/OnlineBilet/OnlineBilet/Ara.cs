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
    public partial class Ara : Form
    {
        string connectionString = "Data Source=NIDOŞŞŞ;Initial Catalog=OnlineBilet;User ID=sa;Password=as";
        public Kayit frmkayit;
        public DateTime gTarih;
        public DateTime dTarih;
        string firmaAdi="";
       
        public Ara()
        {
            InitializeComponent();           
            frmkayit = new Kayit();
         
        }

        private void Ara_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void GridDoldur()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Sp_FirmaButun";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            MessageBox.Show(gTarih.ToString()+"nida");
            cmd.Parameters.AddWithValue("@gidistarihi", gTarih);
            sqlConnection.Open();                          
                           
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    DataTable dt = new DataTable();
                    DataRow dr;
                    dt.Columns.Add(new DataColumn("FirmaAdi", typeof(string)));
                    dt.Columns.Add(new DataColumn("KalkisSaati", typeof(string)));
                    dt.Columns.Add(new DataColumn("VarisSaati", typeof(string)));
                    dt.Columns.Add(new DataColumn("UcusKodu", typeof(string)));
                    dt.Columns.Add(new DataColumn("GidisTarihi", typeof(DateTime)));
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                     
                        dr = dt.NewRow();
                        dr[0] = dataSet.Tables[0].Rows[i]["FirmaAdi"].ToString();
                        dr[1] = dataSet.Tables[0].Rows[i]["KalkisSaati"].ToString();
                        dr[2] = dataSet.Tables[0].Rows[i]["VarisSaati"].ToString();
                        dr[3] = dataSet.Tables[0].Rows[i]["UcusKodu"].ToString();
                        dr[4] = dataSet.Tables[0].Rows[i]["GidisTarihi"].ToString();
                        dt.Rows.Add(dr);
                    }
                    DataView dv = new DataView(dt);
                    dataGridView1.DataSource = dv;
                   
           
            sqlConnection.Close();
            
           // MessageBox.Show(gTarih.ToString());
           
           

        }
        private void GridDoldur1()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Sp_FirmaButunDonus";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            cmd.Parameters.AddWithValue("@donustarihi", dTarih);
            sqlConnection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add(new DataColumn("FirmaAdi", typeof(string)));
            dt.Columns.Add(new DataColumn("KalkisSaati", typeof(string)));
            dt.Columns.Add(new DataColumn("VarisSaati", typeof(string)));
            dt.Columns.Add(new DataColumn("UcusKodu", typeof(string)));
            dt.Columns.Add(new DataColumn("DonusTarihi", typeof(DateTime)));
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = dataSet.Tables[0].Rows[i]["FirmaAdi"].ToString();
                dr[1] = dataSet.Tables[0].Rows[i]["KalkisSaati"].ToString();
                dr[2] = dataSet.Tables[0].Rows[i]["VarisSaati"].ToString();
                dr[3] = dataSet.Tables[0].Rows[i]["UcusKodu"].ToString();
                dr[4] = dataSet.Tables[0].Rows[i]["DonusTarihi"].ToString();
                dt.Rows.Add(dr);
            }
            DataView dv = new DataView(dt);
            dataGridView2.DataSource = dv;

            sqlConnection.Close();

            MessageBox.Show(gTarih.ToString());


        }


        private void btnIleri_Click(object sender, EventArgs e)
        {
            firmaAdi = dataGridView1.SelectedRows[0].Cells["FirmaAdi"].Value.ToString();
            frmkayit.firmaAdi = firmaAdi;
            frmkayit.gTarih1 = gTarih;
            frmkayit.dTarihi = dTarih;
           
            frmkayit.Show();
            this.Hide();


        }
      
        private void Ara_Load(object sender, EventArgs e)
        {

            MessageBox.Show(gTarih.ToString());
            GridDoldur();
           GridDoldur1();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

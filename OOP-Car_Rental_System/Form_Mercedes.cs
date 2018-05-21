using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace OOP_Car_Rental_System
{
    public partial class Mercedes : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public Mercedes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Car_Rental"].ConnectionString;
            com.CommandText = "Select * from Car where Car_name=Mercedes ";
            com.Connection = con;
            con.Open();
            dr = com.ExecuteReader();
            Mercedes_DGV.Columns.Clear();
            Mercedes_DGV.Rows.Clear();
            Mercedes_DGV.Columns.Add("Color", "Color");
            Mercedes_DGV.Columns.Add("model","model");
            Mercedes_DGV.Columns.Add("Car_name", "Car_name");
            Mercedes_DGV.Columns.Add("Price", "Price");
           int i=0;
            while(dr.Read()){
                Mercedes_DGV.Rows.Add();
                Mercedes_DGV.Rows[i].Cells[0].Value=dr["Color"];
                Mercedes_DGV.Rows[i].Cells[1].Value = dr["model"];
                Mercedes_DGV.Rows[i].Cells[2].Value = dr["Car_name"];
                Mercedes_DGV.Rows[i].Cells[3].Value = dr["Price"];
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace OOP_Car_Rental_System
{
    public partial class MINI : Form
    {
        SqlConnection con=new SqlConnection();
        SqlCommand com=new SqlCommand();
        SqlDataReader dr;
        public MINI()
        {
            InitializeComponent();
        }

        private void MINI_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                     con.ConnectionString = ConfigurationManager.ConnectionStrings["Car_Rental"].ConnectionString;
            com.CommandText = "Select * from Car where Car_name=MINICOPPER ";
            com.Connection = con;
            con.Open();
            dr = com.ExecuteReader();
            MINI_DGV.Columns.Clear();
            MINI_DGV.Rows.Clear();
            MINI_DGV.Columns.Add("Color", "Color");
            MINI_DGV.Columns.Add("model", "model");
            MINI_DGV.Columns.Add("Car_name", "Car_name");
            MINI_DGV.Columns.Add("Price", "Price");
           int i=0;
            while(dr.Read()){
                MINI_DGV.Rows.Add();
                MINI_DGV.Rows[i].Cells[0].Value=dr["Color"];
                MINI_DGV.Rows[i].Cells[1].Value = dr["model"];
                MINI_DGV.Rows[i].Cells[2].Value = dr["Car_name"];
                MINI_DGV.Rows[i].Cells[3].Value = dr["Price"];
            }

        }
       
    }
   
}


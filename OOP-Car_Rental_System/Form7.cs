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
using Microsoft.Reporting.WinForms;

namespace OOP_Car_Rental_System
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private DataTable populate(DataTable dt)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            SqlDataAdapter ab = new SqlDataAdapter("SELECT COUNT(*) AS Customers FROM Customer", con);
            SqlDataAdapter ac = new SqlDataAdapter("Select COUNT(*) AS Cars FROM Cars", con);
            SqlDataAdapter ad = new SqlDataAdapter("Select COUNT(*) AS Bookings FROM Booking", con);

            ab.Fill(dt);
            ac.Fill(dt);
            ad.Fill(dt);
            return dt;

        }
        private void Form7_Load(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            dtt = populate(dtt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rprt = new ReportDataSource("DataSet1", dtt);
            reportViewer1.LocalReport.DataSources.Add(rprt);
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

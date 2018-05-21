using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace OOP_Car_Rental_System
{
    public partial class Form11 : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public Form11()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 x = new Form6();
            x.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            receipt x = new receipt();
            x.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            com.Connection = con;
            com.CommandText = "select Name from Cars";
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Name"]);
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            
            com.Connection = con;
            com.CommandText = "select * from Cars where Name=@C_N ";
            com.Parameters.Add("@C_N", SqlDbType.NVarChar).Value = comboBox1.SelectedItem;
            con.Open();
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                label7.Text = dr["Colour"].ToString();
                label8.Text = dr["MA"].ToString();
                label3.Text = dr["Price"].ToString();

            }
            com.Parameters.Clear();
            con.Close();
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

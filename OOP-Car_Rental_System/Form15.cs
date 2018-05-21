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

namespace OOP_Car_Rental_System
{
    public partial class Form15 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public Form15()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 x = new Form5();
            x.Show();
            this.Hide();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            Booking book = new Booking();
            book.Veiw_all_booking();


            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            com.Connection = con;
            com.CommandText = "select Name from Cars";
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Name"]);
            }
            con.Close();


            SqlConnection conn = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            com.Connection = conn;
            com.CommandText = "select NationalID from Customer";
            conn.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["NationalID"]);
                comboBox3.Items.Add(dr["NationalID"]);
                comboBox4.Items.Add(dr["NationalID"]);

            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Booking book = new Booking();
            book.Delete_Booking(comboBox3.SelectedItem.ToString());
            book.Veiw_all_booking();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Booking book = new Booking();
            book.Edit_Booking(comboBox1.SelectedItem.ToString(),comboBox2.SelectedItem.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Booking book = new Booking();
            book.Get_info_of_Booking(comboBox4.SelectedItem.ToString());
        }
    }
}

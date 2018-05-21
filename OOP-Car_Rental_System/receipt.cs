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
    public partial class receipt : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public receipt()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 x = new Form6();
            this.Hide();
            x.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            dataGridView1.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            dataGridView1.Visible = true;
            Booking book = new Booking();
            book.setID(textBox1.Text.ToString());
            book.setPayment(label4.Text.ToString());

            book.Add_new_Booking(book.getID(), comboBox1.SelectedItem.ToString(), book.getPayment());
            dataGridView1.DataSource = book.Show_Receipt(book.getID());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");

            com.Connection = con;
            com.CommandText = "select Price from Cars where Name=@C_N ";
            com.Parameters.Add("@C_N", SqlDbType.NVarChar).Value = comboBox1.SelectedItem;
            con.Open();
            dr = com.ExecuteReader();
            label4.Visible = true;
            while (dr.Read())
            {

                label4.Text = dr["Price"].ToString();

            }
            com.Parameters.Clear();
            con.Close();
        }
    }
}

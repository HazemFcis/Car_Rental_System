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
using System.Data;

namespace OOP_Car_Rental_System
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FindCustomer = textBox1.Text.ToString();
            Customer custm = new Customer();

            DataTable Table = custm.FindCustomer(FindCustomer);
            dataGridView1.DataSource = Table;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Customer custm = new Customer();
            DataTable Table = custm.View_All_Customers();
            dataGridView1.DataSource = Table;
            // a5le el grid ytl3 3leha el table

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string deletedCustomer = textBox2.Text.ToString();
            Customer custm = new Customer();
           custm.DeleteCustomer(deletedCustomer);
            
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 x = new Form5();
            this.Hide();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer custm = new Customer();
            DataTable Table = custm.View_All_Customers();
            dataGridView1.DataSource = Table;
        }
    }
}

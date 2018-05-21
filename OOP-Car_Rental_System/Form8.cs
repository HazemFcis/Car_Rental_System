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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 x = new Form6();
            x.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox5.Text.ToString();
            string y = textBox3.Text.ToString();
            string z = textBox4.Text.ToString();
            Customer custm = new Customer();
            custm.UpdateAccount(x, z, y);
            
        }
    }
}

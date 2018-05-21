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
    public partial class form_ford : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public form_ford()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Honda x = new Honda();
            x.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 x = new Form6();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 x = new Form11();
            x.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Mercedes x = new Mercedes();
            x.Show();
            this.Hide();
            //
        }

        private void Ford_Click(object sender, EventArgs e)
        {
            ford x = new ford();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MINI x = new MINI();
            x.Show();
            this.Hide();
        }
    }
}

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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 x = new Form5();
            this.Hide();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox5.Text.ToString(); //username
            string z = textBox4.Text.ToString(); //pass
            Admin admn = new Admin();
            admn.UpdateAccount(x, z);
        }
    }
}

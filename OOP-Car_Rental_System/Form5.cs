using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using OOP_Car_Rental_System.Properties;

namespace OOP_Car_Rental_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Close3b;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            this.Hide();
            adm.LogOut();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 x = new Form10();
            this.Hide();
            x.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 x = new Form9();
            this.Hide();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 x = new Form12();
            this.Hide();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 x = new Form7();
            x.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form15 x = new Form15();
            x.Show();
            this.Hide();
        }
    }
}

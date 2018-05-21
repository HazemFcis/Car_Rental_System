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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 x = new Form5();
            this.Hide();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string car = textBox1.Text.ToString();
            Car c = new Car();

            DataTable Table = c.View_Details(car);
            dataGridView1.DataSource = Table;

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            string deletedCar = textBox2.Text.ToString();
            Car c = new Car();
            c.Delete_Car(deletedCar);
            c.Veiw_all_Cars();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 x = new Form13();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car c = new Car();

            DataTable Table = c.Veiw_all_Cars();
            dataGridView1.DataSource = Table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form14 x = new Form14();
            x.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            
            Car c = new Car();

            DataTable Table = c.Veiw_all_Cars();
            dataGridView1.DataSource = Table;
        }
    }
}

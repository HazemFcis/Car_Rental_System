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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string price = textBox4.Text.ToString();
           string color = textBox3.Text.ToString();
           string ma = comboBox1.SelectedItem.ToString();
           string name = textBox2.Text.ToString();
           Car c = new Car();
           c.Edit_Car(price, color, ma, name);

        }
    }
}

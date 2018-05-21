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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car Car = new Car();
           
            Car.setName(textBox2.Text.ToString());
            Car.setPrice ( textBox4.Text.ToString() );
            Car.setColour ( textBox3.Text.ToString() );
            Car.setMorA(comboBox1.SelectedItem.ToString());

            string name = Car.getName();
            string price = Car.getPrice();
            string color = Car.getColour();
            string mora = Car.getMorA();

            Car.Add_new_Car(name , price , color,mora);
        }

      
    }
}

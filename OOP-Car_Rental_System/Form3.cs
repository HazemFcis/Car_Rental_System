using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace OOP_Car_Rental_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
              Form4.show("Please, Enter a valid UserName and Password", "OK", "Cancel");
            }

            else
            {

                if (radioButton1.Checked)
                {
                    if(radioButton2.Checked)
                     {

                         Customer Custom = new Customer();
                         Custom.setName( textBox1.Text.ToString() );
                         Custom.setPass ( textBox2.Text.ToString() );
                         Custom.setAddress   ( textBox3.Text.ToString() );
                         Custom.setMobile ( textBox4.Text.ToString() );
                         Custom.setNationalID ( textBox5.Text.ToString() );

                         Custom.Add_Account(Custom.getName() ,Custom.getPass() ,Custom.getAddress() ,Custom.getMobile() ,Custom.getNationalID());

                         Form6 x = new Form6();
                         this.Hide();
                         x.Show();
                     }

                else if (radioButton3.Checked)
                    {
                       
                        Admin adm = new Admin();
                        adm.setName ( textBox1.Text.ToString() );
                        adm.setPass(textBox2.Text.ToString());

                        adm.Add_Account(adm.getName(), adm.getPass());
                        Form5 x = new Form5();
                        this.Hide();
                        x.Show();
                     }

                 
                }
                else
                {
                    Form4.show("You have to accepte terms of use", "OK", "Cancel");
                }
            }
        }

       
   
       
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
            }

            if(radioButton3.Checked==false)
            {

                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
            }
        }
    }
}

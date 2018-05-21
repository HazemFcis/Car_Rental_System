using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Media;
using System.Threading;

namespace OOP_Car_Rental_System
{
    public partial class Form1 : Form
    {
        private SoundPlayer Sound;
         public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '•';
            
            Sound = new SoundPlayer("car.wav");
        }

         public void Loading()
         {
             Application.Run(new Form2());
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sound.Play();
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                Form4.show("Please, Enter a UserName or Password", "OK", "Cancel");
            }

            else
            {
                button2.BackColor = Color.Yellow;
            
                
                if(radioButton1.Checked)
                {
                    Admin adm = new Admin();
                    adm.setName(  textBox1.Text.ToString());
                    adm.setPass(textBox2.Text.ToString());
                    
                    adm.LogIn(adm.getName() , adm.getPass() );
                    this.Hide();
                    Form5 x = new Form5();
                    x.Show();

                }

                else if (radioButton2.Checked)
                {
                    Customer cstm = new Customer();
                    cstm.setName ( textBox1.Text.ToString() ) ;
                    cstm.setPass ( textBox2.Text.ToString() );
                    
                    cstm.LogIn(cstm.getName() , cstm.getPass() );
                    this.Hide();
                    Form6 x = new Form6();
                    x.Show();

                }
                else
                {
                    Form4.show("Please, Check if you are a Customer or User !!", "OK", "Cancel");

                }
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Khaki;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.YellowGreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FaceBook x = new FaceBook();
            x.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Twitter x = new Twitter();
            x.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Google_ x = new Google_();
            x.Show();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Khaki;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.YellowGreen;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.OliveDrab;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 x = new Form3();
            x.Show();
        }

    }
}

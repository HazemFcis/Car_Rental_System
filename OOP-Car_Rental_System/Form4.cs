using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Car_Rental_System
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }
        static Form4 MsgBox;
        static DialogResult result = DialogResult.No;
        public static DialogResult show(string text, string btnOK, string btnCancel)
        {
            MsgBox = new Form4();
            MsgBox.label1.Text = text;
            MsgBox.button1.Text = btnOK;
            MsgBox.button2.Text = btnCancel;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }



        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Khaki;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.YellowGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Khaki;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.YellowGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.OliveDrab;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.OliveDrab;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            button1.BackColor = Color.OliveDrab;
            result = DialogResult.Yes;
            MsgBox.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            button2.BackColor = Color.OliveDrab;
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Khaki;
        }

        private void button2_MouseEnter_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.Khaki;
        }

        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.YellowGreen;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.YellowGreen;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            button1.BackColor = Color.OliveDrab;
            result = DialogResult.Yes;
            MsgBox.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            button2.BackColor = Color.OliveDrab;
        }



        
    }
}

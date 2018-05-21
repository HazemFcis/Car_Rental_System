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
    abstract class user
    {
        private string Name;
        private string Password;
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public string getName()
        {
            return Name;
        }
        public void setPass(string Password)
        {
            this.Password = Password;
        }
        public string getPass()
        {
            return Password;
        }
        public virtual void LogIn(string username , string pass)
        {
            Form4.show("LOG IN IS BLOCKED", "OK", "Cancel");
        }
        public void Loading()
        {
            Application.Run(new Form2());
        }
        public virtual void LogOut()
        {
            Form1 x = new Form1();
            x.Show();
        }
    }
   }

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

    class Admin : user
    {
        public override void LogIn(string username, string pass)
        {

            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Admin where [Name]='" + username + "' and [Password]='" + pass + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Thread t = new Thread(new ThreadStart(Loading));
                t.Start();
                Thread.Sleep(5000); // Melly Seconed
                t.Abort();


            }

        }
        public void Add_Account(string username, string pass)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();



            string addstring = @"insert into Admin (Name,Password) values(@name,@password)";
            SqlCommand cmd = new SqlCommand(addstring, con);
            cmd.CommandType = CommandType.Text;

            SqlParameter name = new SqlParameter("@name", username);
            SqlParameter password = new SqlParameter("@password", pass);

            cmd.Parameters.Add(name);
            cmd.Parameters.Add(password);
            cmd.ExecuteNonQuery();
            con.Close();
            Form4.show("You have created a new account.", "OK", "Cancel");


        }
        public void UpdateAccount(string name, string pass)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Admin set Password = '" + pass + "' where Name='" + name + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            Form4.show("Customer's Info. was UPDATED Successfully", "OK", "Cancel");
        }
   
    }

   }
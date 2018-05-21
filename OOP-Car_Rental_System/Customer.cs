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
    class Customer : user
    {
        private string Address;
        private string Mobile;
        private string NationalID;

        public void setAddress(string Address)
        {
            this.Address = Address;
        }
        public string getAddress()
        {
            return Address;
        }

        public void setMobile(string Mobile)
        {
            this.Mobile = Mobile;
        }
        public string getMobile()
        {
            return Mobile;
        }

        public void setNationalID(string NationalID)
        {
            this.NationalID = NationalID;
        }
        public string getNationalID()
        {
            return NationalID;
        }
        public override void LogIn(string username, string pass)

        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Customer where [Name]='" + username + "' and [Password]='" + pass + "'", con);
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
        public void Add_Account(string username, string pass, string addres, string mob, string id)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();


            string addstring = @"insert into Customer (Name,Password ,Address , Mobile , NationalID) values(@name,@password,@addrs, @mob,@id)";
            SqlCommand cmd = new SqlCommand(addstring, con);
            cmd.CommandType = CommandType.Text;

            SqlParameter name = new SqlParameter("@name", username);
            SqlParameter password = new SqlParameter("@password", pass);
            SqlParameter addrs = new SqlParameter("@addrs", addres);
            SqlParameter mobile = new SqlParameter("@mob", mob);
            SqlParameter ID = new SqlParameter("@id", id);

            cmd.Parameters.Add(name);
            cmd.Parameters.Add(password);
            cmd.Parameters.Add(addrs);
            cmd.Parameters.Add(mobile);
            cmd.Parameters.Add(ID);
            cmd.ExecuteNonQuery();
            con.Close();
            Form4.show("You have created a new account.", "OK", "Cancel");


        }
        public  void UpdateAccount(string name , string pho , string addrs)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Customer set Mobile = '" + pho + "' , Address = '" + addrs + "' where Name='" + name + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            Form4.show("Customer's Info. was UPDATED Successfully", "OK", "Cancel");

        }
        public DataTable View_All_Customers()
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            string DATE = "SELECT *FROM Customer";

            SqlCommand cmd = new SqlCommand(DATE, con);
            cmd.CommandType = CommandType.Text;


            SqlDataReader rdr = cmd.ExecuteReader(); //Call Execute reader to get query results 
            DataTable tb = new DataTable(); // create table
            tb.Columns.Add("Name"); // a3ml el colmns
            tb.Columns.Add("Address");
            tb.Columns.Add("Mobile");
            tb.Columns.Add("NationalID");
            DataRow row;  // a3ml row 

            while (rdr.Read())
            {
                row = tb.NewRow();
                row["Name"] = rdr["Name"]; // an2el el data
                row["Address"] = rdr["Address"];
                row["Mobile"] = rdr["Mobile"];
                row["NationalID"] = rdr["NationalID"];

                tb.Rows.Add(row); // a7ot el row gowa el table
            }


            rdr.Close();// close reader
            con.Close();// close connection
            return tb;
        }
        public void DeleteCustomer(string name)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            String DeleteString = @"delete from Customer where Name=@name";
            SqlCommand cmd = new SqlCommand(DeleteString, con);
            cmd.CommandType = CommandType.Text;
            SqlParameter parameter = new SqlParameter("@name", SqlDbType.Char);
            cmd.Parameters.Add(parameter).Value = name;
            cmd.ExecuteNonQuery();
            con.Close();
            Form4.show("Customer's Account Was DELETED Successfully.", "OK", "Cancel");

        }
        public DataTable FindCustomer(string name)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();

            string X = @"SELECT Name , Address , Mobile , NationalID FROM Customer WHERE Name= @name";
            string x = name;
            SqlCommand cmd = new SqlCommand(X, con);
            cmd.CommandType = CommandType.Text;
            SqlParameter value = new SqlParameter("@name", SqlDbType.Char);
            cmd.Parameters.Add(value).Value = x;


            SqlDataReader rdr = cmd.ExecuteReader(); //Call Execute reader to get query results 
            DataTable tb = new DataTable(); // create table
            tb.Columns.Add("Name"); // a3ml el colmns
            tb.Columns.Add("Address");
            tb.Columns.Add("Mobile");
            tb.Columns.Add("NationalID");

            DataRow row;  // a3ml row 

            while (rdr.Read())
            {
                row = tb.NewRow();
                row["Name"] = rdr["Name"]; // an2el el data
                row["Address"] = rdr["Address"];
                row["Mobile"] = rdr["Mobile"];
                row["NationalID"] = rdr["NationalID"];
                tb.Rows.Add(row); // a7ot el row gowa el table
            }

            rdr.Close();// close reader
            con.Close();// close connection
            return tb; // a5le el grid ytl3 3leha el table

        }
        
    }
}
   

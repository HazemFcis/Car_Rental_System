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

namespace OOP_Car_Rental_System
{
    class Car
    {
        private string Name;
        private string Colour;
        private string Price;
        private string MorA;
        
        public void setName(string Name)
        {
            this.Name= Name;
        }
        public string getName()
        {
            return Name;
        }

        public void setColour(string Colour)
        {
            this.Colour = Colour;
        }
        public string getColour()
        {
            return Colour;
        }

        public void setPrice(string Price)
        {
            this.Price = Price;
        }
        public string getPrice()
        {
            return Price;
        }

        public void setMorA(string MorA)
        {
            this.MorA = MorA;
        }
        public string getMorA()
        {
            return MorA;
        }

        public DataTable  View_Details(string car)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();

            string X = @"SELECT Name , Price , Colour , MA FROM Cars WHERE Name= @name";
            string x = car;
            SqlCommand cmd = new SqlCommand(X, con);
            cmd.CommandType = CommandType.Text;
            SqlParameter value = new SqlParameter("@name", SqlDbType.Char);
            cmd.Parameters.Add(value).Value = x;


            SqlDataReader rdr = cmd.ExecuteReader(); //Call Execute reader to get query results 
            DataTable tb = new DataTable(); // create table
            tb.Columns.Add("Name"); // a3ml el colmns
            tb.Columns.Add("Price");
            tb.Columns.Add("Colour");
            tb.Columns.Add("MA");

            DataRow row;  // a3ml row 

            while (rdr.Read())
            {
                row = tb.NewRow();
                row["Name"] = rdr["Name"]; // an2el el data
                row["Price"] = rdr["Price"];
                row["Colour"] = rdr["Colour"];
                row["MA"] = rdr["MA"];
                tb.Rows.Add(row); // a7ot el row gowa el table
            }

            rdr.Close();// close reader
            con.Close();// close connection
            return tb; // a5le el grid ytl3 3leha el table
        }
        public void Delete_Car(string name)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            String DeleteString = @"delete from Cars where Name=@name";
            SqlCommand cmd = new SqlCommand(DeleteString, con);
            cmd.CommandType = CommandType.Text;
            SqlParameter parameter = new SqlParameter("@name", SqlDbType.Char);
            cmd.Parameters.Add(parameter).Value = name;
            cmd.ExecuteNonQuery();
            con.Close();
            Form4.show("Car's Info. Was DELETED Successfully.", "OK", "Cancel");
        }
        public void Add_new_Car(string Name , string Price , string Colour , string MA)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
                con.Open();

                string addstring = @"insert into Cars (Name,Price,Colour,MA) values(@name,@price,@color, @mora)";
                SqlCommand cmd = new SqlCommand(addstring, con);
                cmd.CommandType = CommandType.Text;

                SqlParameter name = new SqlParameter("@name", Name);
                SqlParameter price = new SqlParameter("@price", Price);
                SqlParameter colour = new SqlParameter("@color", Colour);
                SqlParameter mora = new SqlParameter("@mora", MA);

                cmd.Parameters.Add(name);
                cmd.Parameters.Add(price);
                cmd.Parameters.Add(colour);
                cmd.Parameters.Add(mora);
                cmd.ExecuteNonQuery();
                con.Close();
                Form4.show("Car was Added Successfully.", "OK", "Cancel");
            }
            catch (Exception)
            {
                Form4.show("This car is already Exist", "OK", "Cancel");
            }
        }
        public void Edit_Car(string price , string color , string ma , string name )
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Cars set Price = '" + price + "' , Colour = '" + color + "', MA = '" + ma + "' where Name='" + name + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            Form4.show("Car's Info. was UPDATED Successfully", "OK", "Cancel");
        }
        public DataTable Veiw_all_Cars()
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            string DATE = "SELECT *FROM Cars";

            SqlCommand cmd = new SqlCommand(DATE, con);
            cmd.CommandType = CommandType.Text;


            SqlDataReader rdr = cmd.ExecuteReader(); //Call Execute reader to get query results 
            DataTable tb = new DataTable(); // create table
            tb.Columns.Add("Name"); // a3ml el colmns
            tb.Columns.Add("Price");
            tb.Columns.Add("Colour");
            tb.Columns.Add("MA");
            DataRow row;  // a3ml row 

            while (rdr.Read())
            {
                row = tb.NewRow();
                row["Name"] = rdr["Name"]; // an2el el data
                row["Price"] = rdr["Price"];
                row["Colour"] = rdr["Colour"];
                row["MA"] = rdr["MA"];

                tb.Rows.Add(row); // a7ot el row gowa el table
            }


            rdr.Close();// close reader
            con.Close();// close connection
            return tb;
        }
       
    }
}

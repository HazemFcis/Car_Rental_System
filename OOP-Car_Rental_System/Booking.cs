using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OOP_Car_Rental_System
{
    class Booking
    {
        private string Booking_ID;
        private string Payment;
        public void setPayment(string payment)
        {
            this.Payment=payment;
        }
        public string getPayment()
        {
            return Payment;
        }
         public void setID(string Booking_ID)
        {
            this.Booking_ID=Booking_ID;
        }
        public string getID()
        {
            return Booking_ID;
        }
        public void Add_new_Booking(string id , string SelectedCar , string Price)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();

            string addstring = @"insert into Booking (Car,Price,Customer_ID) values(@name,@price,@id)";
            SqlCommand cmd = new SqlCommand(addstring, con);
            cmd.CommandType = CommandType.Text;

            SqlParameter name = new SqlParameter("@name", SelectedCar);
            SqlParameter price = new SqlParameter("@price", Price);
            SqlParameter ID = new SqlParameter("@id", id);

            cmd.Parameters.Add(name);
            cmd.Parameters.Add(price);
            cmd.Parameters.Add(ID);
            cmd.ExecuteNonQuery();
            con.Close();
            Form4.show("You Have Booked a Car", "OK", "Cancel");
        }
        public void Edit_Booking(string car , string id)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Booking set Car = '" + car + "' where Customer_ID='" + id + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            Form4.show("Booking's Info. was UPDATED Successfully", "OK", "Cancel");
        }
        public DataTable Get_info_of_Booking(string id)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();

            string X = @"SELECT Car , Price , Customer_ID FROM Booking WHERE Name= @name";
            string x = id;
            SqlCommand cmd = new SqlCommand(X, con);
            cmd.CommandType = CommandType.Text;
            SqlParameter value = new SqlParameter("@name", SqlDbType.Char);
            cmd.Parameters.Add(value).Value = x;


            SqlDataReader rdr = cmd.ExecuteReader(); //Call Execute reader to get query results 
            DataTable tb = new DataTable(); // create table
            tb.Columns.Add("Car"); // a3ml el colmns
            tb.Columns.Add("Price");
            tb.Columns.Add("Customer_ID");

            DataRow row;  // a3ml row 

            while (rdr.Read())
            {
                row = tb.NewRow();
                row["Car"] = rdr["Car"]; // an2el el data
                row["Price"] = rdr["Price"];
                row["Customer_ID"] = rdr["Customer_ID"];
                tb.Rows.Add(row); // a7ot el row gowa el table
            }

            rdr.Close();// close reader
            con.Close();// close connection
            return tb; // a5le el grid ytl3 3leha el table
        }
        public DataTable Veiw_all_booking()
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            string DATE = "SELECT * FROM Booking";

            SqlCommand cmd = new SqlCommand(DATE, con);
            cmd.CommandType = CommandType.Text;


            SqlDataReader rdr = cmd.ExecuteReader(); //Call Execute reader to get query results 
            DataTable tb = new DataTable(); // create table
            tb.Columns.Add("Car"); // a3ml el colmns
            tb.Columns.Add("Price");
            tb.Columns.Add("Customer_ID");
            DataRow row;  // a3ml row 

            while (rdr.Read())
            {
                row = tb.NewRow();
                row["Name"] = rdr["Name"]; // an2el el data
                row["Price"] = rdr["Price"];
                row["Customer_ID"] = rdr["Customer_ID"];

                tb.Rows.Add(row); // a7ot el row gowa el table
            }


            rdr.Close();// close reader
            con.Close();// close connection
            return tb;
        }
        public void Delete_Booking(string deletedBooking)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            String DeleteString = @"delete from Booking where Name=@name";
            SqlCommand cmd = new SqlCommand(DeleteString, con);
            cmd.CommandType = CommandType.Text;
            SqlParameter parameter = new SqlParameter("@name", SqlDbType.Char);
            cmd.Parameters.Add(parameter).Value = deletedBooking;
            cmd.ExecuteNonQuery();
            con.Close();
            Form4.show("Booking's Info. Was DELETED Successfully.", "OK", "Cancel");
        }
        public DataTable Show_Receipt(string id)
        {
            SqlConnection con = new SqlConnection("Data Source=Sara\\SQLEXPRESS;Initial Catalog=CAR;Integrated Security=True");
            con.Open();
            string DATE = "SELECT * FROM Booking WHERE Customer_ID= @name";
            string x = id;
            SqlCommand cmd = new SqlCommand(DATE, con);
            cmd.CommandType = CommandType.Text;
            SqlParameter value = new SqlParameter("@name", SqlDbType.Char);
            cmd.Parameters.Add(value).Value = x;


            SqlDataReader rdr = cmd.ExecuteReader(); //Call Execute reader to get query results 
            DataTable tb = new DataTable(); // create table
            tb.Columns.Add("Customer_ID");
            tb.Columns.Add("Car"); // a3ml el colmns
            tb.Columns.Add("Price");

            DataRow row;  // a3ml row 

            while (rdr.Read())
            {
                row = tb.NewRow();
                row["Customer_ID"] = rdr["Customer_ID"];
                row["Car"] = rdr["Car"]; // an2el el data
                row["Price"] = rdr["Price"];
                tb.Rows.Add(row); // a7ot el row gowa el table
            }

            rdr.Close();// close reader
            con.Close();// close connection
            return tb; // a5le el grid ytl3 3leha el table
        }
    
    }
}

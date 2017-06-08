using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace dwa_s10166858 {
    public class Staff {

        public int staffId { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public DateTime dob { get; set; }
        public string nationality { get; set; }
        public string eMail { get; set; }
        public double salary { get; set; }
        public bool isFullTime { get; set; }
        public int branchNo { get; set; }

        public int add() {
            //Read connection string "DWABookConnectionString" from web.config file.
            string strConn = ConfigurationManager.ConnectionStrings["DWABookConnectionString"].ToString();

            //Instatitate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            //Instantiate a SqlCommand object, supply it with SQL statement INSERT
            //and the connection object for connecting to the database.
            SqlCommand cmd = new SqlCommand
                ("INSERT INTO Staff (Name, Gender, DOB, Salary, EmailAddr, Nationality, Status)" +
                "VALUES(@name , @gender, @dob, @salary," +
                "@email, @country, @status)", conn);

            //Define the parameters used in SQL statement, value for each parameter 
            //is retrieved from perspective class' property.
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@email", eMail);
            cmd.Parameters.AddWithValue("@country", nationality);
            cmd.Parameters.AddWithValue("@status", isFullTime);

            //A connection to database must be opened before any operations made.
            conn.Open();

            //ExecuteNonQuery is used for INSERT, UPDATE, DELETE SQL statement.
            cmd.ExecuteNonQuery();

            //A connection should be closed after operations.
            conn.Close();

            //Return 0 when no error occurs.
            return 0;
        }
    }
}
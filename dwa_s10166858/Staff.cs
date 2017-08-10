using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        public int getDetails() {
            //Read connection string "DWABookConnectionString" from web.config file.
            string strConn = ConfigurationManager.ConnectionStrings["DWABookConnectionString"].ToString();

            //Create a SqlConnection object with the Connection String read
            SqlConnection conn = new SqlConnection(strConn);

            //Create a SqlCommand object, with a SELECT SQL statemenet to retrieve all
            //attributes of a staff, and a connection object to open the database.
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE StaffID = @selectedStaffID", conn);

            //Define parameter used in SQL, get its valuye from class property staffId
            cmd.Parameters.AddWithValue("@selectedSaffID", staffId);

            //Create a DataAdapter object, pass SqlCommand object as parameter
            SqlDataAdapter daStaff = new SqlDataAdapter(cmd);

            //Create a DataSet object result
            DataSet result = new DataSet();

            //Open a databse connection.
            conn.Open();

            //Use DataAdapter to fetch data to a table "StaffDetails" in DataSet

            //Close database connection
            conn.Close();

            if (result.Tables["StaffDetails"].Rows.Count > 0) {
                //Assign values from DataSet to class properties of Staff
                //DBNull() detects null value retrieved from the database for a
                //particular attribute

                //name
                if (!DBNull.Value.Equals(result.Tables["StaffDetails"].Rows[0]["Name"]))
                    name = Convert.ToString(result.Tables["StaffDetails"].Rows[0]["Name"]);

                //gender
                if (!DBNull.Value.Equals(result.Tables["StaffDetails"].Rows[0]["Gender"]))
                    gender = Convert.ToString(result.Tables["StaffDetails"].Rows[0]["Gender"]);

                //dob
                if (!DBNull.Value.Equals(result.Tables["StaffDetails"].Rows[0]["DOB"]))
                    dob = Convert.ToDateTime(result.Tables["StaffDetails"].Rows[0]["DOB"]);

                //salary
                if (!DBNull.Value.Equals(result.Tables["StaffDetails"].Rows[0]["Salary"]))
                    salary = Convert.ToDouble(result.Tables["StaffDetails"].Rows[0]["Salary"]);

                //nationality
                if (!DBNull.Value.Equals(result.Tables["StaffDetails"].Rows[0]["Nationality"]))
                    nationality = Convert.ToString(result.Tables["StaffDetails"].Rows[0]["Nationality"]);

                //is full time
                if (!DBNull.Value.Equals(result.Tables["StaffDetails"].Rows[0]["Status"])) {
                    if (Convert.ToInt32(result.Tables["StaffDetails"].Rows[0]["Status"]) == 1) {
                        isFullTime = true;
                    } else {
                        isFullTime = false;
                    }
                }

                //branchNo
                if (!DBNull.Value.Equals(result.Tables["StaffDetails"].Rows[0]["BranchNo"]))
                    branchNo = Convert.ToInt32(result.Tables["StaffDetails"].Rows[0]["BranchNo"]);
            }

            return -2;
        }

        public int update() {
            //Read connection string from web.config file.
            String strConn = ConfigurationManager.ConnectionStrings["DWABookConnectionString"].ToString();

            //Create a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            //Create a SqlCommand object, with a SQL statement UPDATE to update the
            //attributes of a staff, and a connection object to open the database.
            SqlCommand cmd = new SqlCommand("UPDATE Staff SET Name=@name, Gender=@gender, Salary=@salary, " +
                "DOB=@dob, EmailAddr=@email, Nationality=@naionality, Status=@status, BranchNo=@branchNo " +
                "WHERE StaffID=@selectedStaffID", conn);

            //Define the parameters used in SQL statement, value for each parameter
            //are retrieved from class propertes of Staffg
            cmd.Parameters.AddWithValue("@selectedStaffID", staffId);
        }

    }
}
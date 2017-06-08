using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace dwa_s10166858 {
    public class Branch {
        //Properties
        public int branchNo { get; set; }
        public string address { get; set; }
        public string telNo { get; set; }
        public DateTime dateStarted { get; set; }

        public int getBranchStaff(ref DataSet result) {
            //Read connection string "DWABookConnectionString" from web.config file.
            string strConn = ConfigurationManager.ConnectionStrings["DWABookConnectionString"].ToString();
            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            //Instantiate a SqlCommand object, supply it with a SELECT SQL
            //Statement which retrieves all attributes of a staff record.
            SqlCommand cmd = new SqlCommand
                ("SELECT * FROM Staff WHERE BranchNo = @selectedBranchNo", conn);

            //Define the parameter used in SQL statement, value for the
            //Parameter is retrieved from the branchNo proeprty of the Branch class.
            cmd.Parameters.AddWithValue("@selectedBranchNo", branchNo);

            //Instantiate a DataAdapter object, pass the SqlCommand
            //object created as parameter.
            //Fix the question marks
            SqlDataAdapter daStaff = new SqlDataAdapter(cmd);

            //Open a database connection
            conn.Open();

            //Use DataAdapter to fetch data to a table "StaffDetails" in DataSet.
            daStaff.Fill(result, "StaffDetails");

            //Close database connection
            conn.Close();

            //Return 0 when no error occurs
            return 0;

        }
    }
}
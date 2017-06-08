using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_s10166858 {
    public partial class ViewBranch : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Page_Init(object sender, EventArgs e) {
            displayBranchList();
        }

        protected void gvBranch_SelectedIndexChanged(object sender, EventArgs e) {
            //Get the SelectedDataKey form GridView, which is he branchNo
            //and do the necessary data conversion.
            int selectedBranchNo = Convert.ToInt32(gvBranch.SelectedDataKey[0]);

            //Create a Branch object.
            Branch objBranch = new Branch();

            //Create a DataSet object to contain the staff list of a branch.
            DataSet dataSet = new DataSet();

            //Call the getDetails method of Saff class to retreive staff details
            //from database.
            objBranch.branchNo = selectedBranchNo;

            int errorCode = objBranch.getBranchStaff(ref dataSet);

            if (errorCode == 0) {
                gvStaff.DataSource = dataSet.Tables["StaffDetails"];
                gvStaff.DataBind();
            }
        }
        
        private void displayBranchList() {
            //Read connection string "DWABookConnectionString" from web.config file.
            String strConn = ConfigurationManager.ConnectionStrings["DWABookConnectionString"].ToString();

            //Instantiate a SqlConnection object with the Connection string read.
            SqlConnection conn = new SqlConnection(strConn);

            //Instantiate a SqlCommand Object, supply it wih the SQL statement
            //(SELECT, INSERT, UPDATE or DELETE) that is to be operated against the
            //database, and the connection object used for connecting to the database.
            SqlCommand cmd = new SqlCommand("SELECT * FROM Branch", conn);

            //Declare and instantiate DataAdapter object
            SqlDataAdapter daBranch = new SqlDataAdapter(cmd);

            //Create a DataSet object to contain the records retrieved from database
            DataSet dataSet = new DataSet();

            conn.Open();

            //Use DataAdapter to fetch data to a table
            //named as "BranchDetails" in DataSet.
            daBranch.Fill(dataSet, "BranchDetails");

            conn.Close();

            //Specify FridView to get data from table "BranchDetails"
            //in DataSet "result"
            gvBranch.DataSource = dataSet.Tables["BranchDetails"];

            //Display the list of data into GridView
            gvBranch.DataBind();
        }
    }
}
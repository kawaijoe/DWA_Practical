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
    public partial class ViewStaff : System.Web.UI.Page {

        protected void Page_Init(object sender, EventArgs e) {
            displayStaffList();
        }

        protected void Page_Load(object sender, EventArgs e) {

        }

        private void displayStaffList() {
            //Read connection string "DWABookConnectionString" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings["DWABookConnectionSTring"].ToString();

            //Instantiate a Sqlconnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            //Instantiate a SqlCommand object, supply it with the SQL statement
            //SELECT  that operates against the database, and the connection object
            //used for connecting to the database.
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff ORDER BY StaffID", conn);

            //Instantiate a DataAdapter object and pass the SqlCommand object
            //Created as parameter.
            SqlDataAdapter daStaff = new SqlDataAdapter(cmd);

            //Create a DataSet object to contain the records retrieved from database
            DataSet result = new DataSet();

            //A connection must be opened before any operation made.
            conn.Open();

            //Use DataAdapter to fetch data to a table "StaffDetails" in DataSet.
            //Dataset "result" will store the result of the SELECT operation.
            daStaff.Fill(result, "StaffDetails");

            //A connection should always be closed, whether error occurs or not.
            conn.Close();

            //Specify GridView to get data from table "StaffDetails"
            //In DataSet "result"
            gvStaff.DataSource = result.Tables["StaffDetails"];

            //Display the list of data in GridView
            gvStaff.DataBind();

            //Count the number of rows
            if (result.Tables["StaffDetails"].Rows.Count > 0) {
                lblMessage.Text = result.Tables["StaffDetails"].Rows.Count.ToString();
            } else {
                lblMessage.Text = "No staff record.";
            }
        }

        protected void gvStaff_PageIndexChanging(object sender, GridViewPageEventArgs e) {
            //Set the page index to the page clicked by user.
            gvStaff.PageIndex = e.NewPageIndex;
            //Display records on the new page.
            displayStaffList();
        }
    }
}
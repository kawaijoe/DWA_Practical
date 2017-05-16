using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_s1234567
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e) {
            // Read inputs from textboces
            String loginID = txtLoginID.Text.ToLower(); //Textbox: txtLoginID
            String password = txtPassword.Text; //Textbox: txtPassword

            // Read selection of radio buttons
            String userType = "";
            if (rdoStaff.Checked) {
                userType = "Staff";
            } else if (rdoCustomer.Checked) {
                userType = "Customer";
            }

            if ((loginID == "abc@npbook.com" &&
                password == "pass1234" &&
                userType == "Staff") || true) {

                Session["LoginID"] = loginID;
                Session["LoggedInTime"] = DateTime.Now.ToString();
                // redirect user to Main.aspx page
                Response.Redirect("Main.aspx");
            } else {
                // Display error message
                lblMessage.Text = "Invalid Login Credentials!";
            }

        }

    }
}
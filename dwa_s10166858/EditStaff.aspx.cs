using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_s10166858 {
    public partial class EditStaff : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                ddlNationality.Items.Add("Singapore");
                ddlNationality.Items.Add("Malaysia");
                ddlNationality.Items.Add("Indonesia");
                ddlNationality.Items.Add("China");

                ddlBranch.Items.Add("1");
                ddlBranch.Items.Add("2");
                ddlBranch.Items.Add("3");

                if (Request.QueryString["staffid"] != null) {
                    //Create a new Staff Object
                    Staff objStaff = new Staff();
                    //Read Staff ID from query string
                    objStaff.staffId = Convert.ToInt32(Request.QueryString["staffid"]);

                    //Load staff information to various controls
                    int errorCode = objStaff.getDetails();

                    if (errorCode == 0) {
                        //Assign property values from the Staff object to various controls
                        txtName.Text = objStaff.name;
                        txtDOB.Text = objStaff.dob.ToShortDateString();

                        if (objStaff.gender == "M")
                            radMale.Checked = true;
                        else
                            radFemale.Checked = true;

                        //Format currency value: 2 decimal places, punctuated at thousand
                        txtSalary.Text = objStaff.salary.ToString("##,##0.00");

                        txtEmail.Text = objStaff.eMail;
                        ddlNationality.SelectedValue = objStaff.nationality;
                        chkFullTime.Checked = objStaff.isFullTime;

                        //Select Branch Number in DropDownList
                        ddlBranch.SelectedValue = objStaff.branchNo.ToString();
                    } else if (errorCode == -2) {
                        lblMessage.Text = "Unable to retrieve staff details for ID " + objStaff.staffId.ToString();
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e) {
            Page.Validate();
            if (Page.IsValid) {

                // display the values
                Response.Redirect("ConfirmAddStaff.aspx?");
            }
        }

        
    }
}
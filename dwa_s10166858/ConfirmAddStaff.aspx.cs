using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_s10166858 {
    public partial class ConfirmAddStaff : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            lblName.Text = Request.QueryString["name"];
            lblGender.Text = Request.QueryString["gender"];
            lblDOB.Text = Request.QueryString["dob"];
            lblSalary.Text = Request.QueryString["salary"];
            lblEmail.Text = Request.QueryString["email"];
            lblNationality.Text = Request.QueryString["nationality"];
            lblIsFullTimeStaff.Text = Request.QueryString["fulltime"];
        }

        protected void BtnSubmit_Click(object sender, EventArgs e) {
            if (Page.IsValid) {
                //Create a new object from the staff class
                Staff objStaff = new Staff();

                //Pass data to the properties of the staff object,
                //do all necessary data type conversion if need to.
                objStaff.name = lblName.Text;

                if (lblGender.Text == "Male")
                    objStaff.gender = "M";
                else
                    objStaff.gender = "F";
                objStaff.dob = Convert.ToDateTime(lblDOB.Text);
                objStaff.salary = Convert.ToDouble(lblSalary.Text);
                objStaff.eMail = lblEmail.Text;
                objStaff.nationality = lblNationality.Text;

                if (lblIsFullTimeStaff.Text == "yes")
                    objStaff.isFullTime = true;
                else
                    objStaff.isFullTime = false;

                //Call the add method to insert the staff record to database
                int errorCode = objStaff.add();

                //If record has been inserted successfully if returned code is 0
                if (errorCode == 0)
                    lblMessage.Text = " New staff is added successfully";

            }
        }
    }
}
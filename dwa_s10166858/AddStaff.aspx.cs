using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_s10166858 {
    public partial class AddStaff : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                ddlNationality.Items.Add("Singapore");
                ddlNationality.Items.Add("Malaysia");
                ddlNationality.Items.Add("Indonesia");
                ddlNationality.Items.Add("China");
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e) {
            Page.Validate();
            if (Page.IsValid) {
                string strValues;

                // retrieve the inputs
                strValues = "name=" + Server.UrlEncode(txtName.Text);

                if (radMale.Checked == true)
                    strValues += "&gender=Male";
                else
                    strValues += "&gender=Female";

                strValues += "&dob=" + Server.UrlEncode(txtDOB.Text);
                strValues += "&salary=" + Server.UrlEncode(txtSalary.Text);
                strValues += "&email=" + Server.UrlEncode(txtEmail.Text);
                strValues += "&nationality=" + Server.UrlEncode(ddlNationality.SelectedValue);

                if (chkFullTime.Checked == true)
                    strValues += "&fulltime=yes";
                else
                    strValues += "&fulltime=no";

                // display the values
                Response.Redirect("ConfirmAddStaff.aspx?" + strValues);
            }
        }
    }
}
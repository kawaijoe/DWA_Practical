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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_s10166858 {
    public partial class StaffTemplate:System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            Utility.RequireLogin();

            lblLoginID.Text = (string) Session["LoginID"];
            lblLoginTime.Text = DateTime.Now.ToString();

            lblCurrentUsers.Text = Application["CurrentUsers"].ToString();
        }
    }
}
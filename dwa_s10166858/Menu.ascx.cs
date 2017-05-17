using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_s10166858 {
    public partial class Menu:System.Web.UI.UserControl {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnLogOut_Click(object sender, EventArgs e) {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}
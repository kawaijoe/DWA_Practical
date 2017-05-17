using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dwa_s10166858 {
    public class Utility {

        public static void RequireLogin() {
            if (HttpContext.Current.Session["LoginID"] == null) {
                HttpContext.Current.Response.Redirect("Login.aspx");
            }
        }
    }
}
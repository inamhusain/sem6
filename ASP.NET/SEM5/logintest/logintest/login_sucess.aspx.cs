using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace logintest
{
    public partial class login_sucess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void onclick(object sender, EventArgs e)
        {
            Response.Redirect("forgotpass.aspx");
        }
    }
}
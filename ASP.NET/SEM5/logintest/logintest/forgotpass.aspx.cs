using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace logintest
{
    public partial class forgotpass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnchngpass_Click(object sender, EventArgs e)
        {
            Session["uid"] = txtu_id.Text;
            Session["upass"] = txtU_password.Text;
            Response.Redirect("main.aspx");
        }

    }
}
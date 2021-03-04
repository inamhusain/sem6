using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace logintest
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblid.Text= Session["uid"].ToString();
            lblpassword.Text = Session["upass"].ToString();
        }

        protected void onclick(object sender, EventArgs e)
        {
            string a = lblid.Text;
            string p = lblpassword.Text;
            if (a == txtid.Text)
            {
                if (p == txtpass.Text)
                {
                    Response.Redirect("login_sucess.aspx");
                }
                else
                {
                    txtpass.Text = "Wrong PASSWORD";
                }
                
            }
            else 
            {
                txtid.Text = "Wrong USER-ID";
                
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical3
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Value1"] = TextBox1.Text;
            Session["Value2"] = TextBox2.Text;
            Session["Value3"] = TextBox3.Text;
            Response.Redirect("page2.aspx");
        }
    }
}
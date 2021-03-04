using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical3
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["Value1"].ToString();
            Label2.Text = Session["Value2"].ToString();
            Label3.Text = Session["Value3"].ToString();
        }
    }
}
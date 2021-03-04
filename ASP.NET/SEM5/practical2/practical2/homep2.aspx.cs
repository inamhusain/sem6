using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical2
{
    public partial class homep2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("hello");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hello";
        }
    }
}
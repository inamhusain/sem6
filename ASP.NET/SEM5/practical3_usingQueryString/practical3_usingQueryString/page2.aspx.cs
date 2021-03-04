using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical3_usingQueryString
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string firstname = Request.QueryString["firstname"];
            string lastname = Request.QueryString["lastname"];
            string rollno = Request.QueryString["rollno"];


            lblname.Text = "welcome to " + firstname + " " + lastname;
            lblrollno.Text = "Your RollNo is..." + rollno;
        }
    }
}
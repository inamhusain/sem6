﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical3_usingQueryString
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2.aspx?firstname=" + txtFirstname.Text + "&lastname=" + txtlastname.Text +"&rollno="+txtRollno.Text);
        }
    }
}
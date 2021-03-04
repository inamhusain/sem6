using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical4
{
     
    //class car 
    //{ 
           
           
    //}

    public partial class page1 : System.Web.UI.Page
    {

        private string model = "BMW";
        protected void Page_Load(object sender, EventArgs e)
        {

           Response.Write(model);

        }


    }
}
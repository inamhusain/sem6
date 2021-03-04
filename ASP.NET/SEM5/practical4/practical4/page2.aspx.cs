using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical4
{
    public class c2 
    {
        public static void main(String[] a)
        {
         
        }
    } 

    public partial class page2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
          //  Response.Write(Request.QueryString["txt1"] + "<br/>");
           // Response.Write(Request.QueryString["txt2"]);



            Response.Write("hello" + "<br/>");
            Response.Write("line2");

            //car obj = new car();
            //obj.model = "BMW";
            //Response.Write(obj.model);
        }

        
    }
}
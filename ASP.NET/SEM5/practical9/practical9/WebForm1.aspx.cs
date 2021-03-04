using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int odd = 0, even = 0, i=1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    even = even + i;
                }
                else
                {
                    odd = odd + i;
                }
                i++;
            }
            Response.Write("Using While Loop <br>");
            Response.Write("Sum of even no = " + even + "<br>");
            Response.Write("Sum of odd no = " + odd + "<br>");

            //int odd1 = 0, even1 = 0, a = 1;
            //for (a = 1; a <= 100; a++)
            //{
            //    if (a % 2 == 0)
            //    {
            //        even1 = even1 + a;
            //    }
            //    else
            //    {
            //        odd1 = odd1 + a;
            //    }
            //}
            //Response.Write("<br>Using For loop <br>");
            //Response.Write("Sum of even no = " + even1 + "<br>");           
            //Response.Write("Sum of odd no = " + odd1 + "<br>");
            
        }
    }
}
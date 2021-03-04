using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical12
{ 


    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = DropDownList1.SelectedItem.Value;
            int no = Int16.Parse(a);
            if (no == 1)
            {
                Image1.ImageUrl = "~/Images/img1.jpg";
            }
            else if (no == 2)
            {
                Image1.ImageUrl = "~/Images/img2.jpg";
            }
            else
            {
                Image1.ImageUrl = "~/Images/img3.jpg";
            }
        }
    }
}
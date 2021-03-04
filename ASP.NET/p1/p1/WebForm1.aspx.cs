using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void csmval(object source, ServerValidateEventArgs args)
        {
            //if (args.Value.Length < 5)
            //{
            //    args.IsValid = false;
            //}
            //else
            //{
            //    args.IsValid = true;
            //}

            String str = txtname.Text;
            int index = str.IndexOf('@');
            int index1 = str.IndexOf('.');

            if (index < 0)
            {
                Label1.Text = "@ sign is missing";
            }
            else if (index1 < 0)
            {
                Label1.Text = ". sign is missing";
            }
            else
            {
                Label1.Text = "hello";
            }
        }
    }
}
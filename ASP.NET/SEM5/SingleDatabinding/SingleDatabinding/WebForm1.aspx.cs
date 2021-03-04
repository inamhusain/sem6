using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SingleDatabinding
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string Name, City;
        protected void Page_Load(object sender, EventArgs e)
        {
            Name = "Inamhusain";
            City = "Ilol";
            //this.DataBind();
        }
    }
}
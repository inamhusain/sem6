using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assiment_ROllNo16
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert(object sender, EventArgs e)
        {
            SqlDataSource1.Insert();
        }

        protected void Update(object sender, EventArgs e)
        {
            SqlDataSource1.Update();
        }

        protected void Delete(object sender, EventArgs e)
        {
            SqlDataSource1.Delete();
        }
    }
}
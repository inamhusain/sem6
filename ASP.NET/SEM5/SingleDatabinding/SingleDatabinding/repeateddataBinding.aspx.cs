using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SingleDatabinding
{
    public partial class repeateddataBinding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                List<string> lstobj = new List<string>();
                lstobj.Add("Apple");
                lstobj.Add("Banana");
                lstobj.Add("Mango");

                ListBox1.DataSource = lstobj;
                DropDownList1.DataSource = lstobj;
                CheckBoxList1.DataSource = lstobj;
                RadioButtonList1.DataSource = lstobj;
                this.DataBind();
            }

        }
    }
}
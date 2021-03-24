using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task1_richcontrols_validations
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void selectDate(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate >= DateTime.Today)
            {

                txtdateError.Text = "Please Enter Valid Date";
                txtdate.Text = null;
            }
            else
            {
                txtdateError.Text = null;
                txtdate.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            }
        }

        protected void btnPersonalNext_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnQulificationPrv_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnQulificationNext_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        
    }
}
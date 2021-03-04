using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical_10_and_11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click_add(object sender, EventArgs e)
        {

            DropDownList1.Items.Add(TextBox.Text);
            ListBox1.Items.Add(TextBox.Text);
            TextBox.Text = null;
        }

        protected void Button1_Click_remove(object sender, EventArgs e)
        {
            DropDownList1.Items.Remove(DropDownList1.Text);
            ListBox1.Items.Remove(ListBox1.Text);       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ListBox1.Items.Add(DropDownList1.SelectedItem.Value);
        }
    }
}
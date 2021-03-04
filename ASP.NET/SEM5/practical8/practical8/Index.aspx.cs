using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical8
{
    public partial class Index : System.Web.UI.Page
    {

        public delegate int MyDelegate(int a,int b);
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyDelegate objmul = new MyDelegate(mul);
            MyDelegate objdiv = new MyDelegate(div);

            int no1 = int.Parse(TextBox1.Text);  //
            int no2 = int.Parse(TextBox2.Text); 
             
            Response.Write("<br/>");
            Response.Write("Multiplication: " + mul( no1, no2) );
            Response.Write("<br/>");
            Response.Write("Division: " + div( no1, no2)) ;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
    }
}
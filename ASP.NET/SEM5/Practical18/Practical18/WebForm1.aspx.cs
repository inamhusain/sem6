using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Practical18
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void clearAll()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\Practical18\Practical18\App_Data\Database1.mdf;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("select * from LoginTable Where UserName='"+txtUserName.Text+"' AND Password='"+txtPassword.Text+"'", con);

                SqlDataReader sdr;
                con.Open();
                sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    //Response.Write("Login SuccessFul");
                    Response.Write("<script>alert('Login Successful'); </script>");
                    //Response.Write("<marquee>Login Successful</marquee>");
                }
                else
                {
                    //Response.Write("UserName or Password not match");
                    Response.Write("<script>alert('UserName and Password Not match');</script>");
                    clearAll();
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                //throw;
            }
        }
    }
}
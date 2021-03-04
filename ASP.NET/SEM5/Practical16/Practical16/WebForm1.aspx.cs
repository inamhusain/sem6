using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Display(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\Practical16\Practical16\App_Data\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select * from StudentData", conn);
                SqlDataReader sdr;
                conn.Open();
                sdr = cmd.ExecuteReader();
                Response.Write("<table border=1>");
                Response.Write("<tr>");
                Response.Write("<th>");
                Response.Write("Roll No");
                Response.Write("</th>");
                Response.Write("<th>");
                Response.Write("Name");
                Response.Write("</th>");
                Response.Write("<th>");
                Response.Write("City");
                Response.Write("</th>");
                Response.Write("</tr>");

                while (sdr.Read())
                {
                    Response.Write("<tr>");
                    Response.Write("<td>");
                    Response.Write(sdr["RollNo"].ToString());
                    Response.Write("</td>");
                    Response.Write("<td>");
                    Response.Write(sdr["Name"].ToString());
                    Response.Write("</td>");
                    Response.Write("<td>");
                    Response.Write(sdr["city"].ToString());
                    Response.Write("</td>");
                    Response.Write("</tr>");
                }
                Response.Write("</table>");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}
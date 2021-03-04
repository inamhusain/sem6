using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical15
{
    public partial class WebForm1 : System.Web.UI.Page
    {

      
        //protected void Button_Insert(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical15\practical15\App_Data\Database1.mdf;Integrated Security=True");
             
        //        SqlCommand cmd = new SqlCommand("insert into StudentData (RollNo,Name,City) Values (" + txtRollNo.Text + " , ' " + txttName.Text + " ' , ' " + txtCity.Text + " ')", con);
               
        //        con.Open();
        //        Response.Write(cmd.ExecuteNonQuery() + "Row Inserted");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //        //throw;
        //    }
            
        //}

        //protected void Button_Update(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical15\practical15\App_Data\Database1.mdf;Integrated Security=True");
        //        SqlCommand cmd = new SqlCommand("update StudentData set Name='" + txttName.Text + "' ,City='" + txtCity.Text + "' where RollNo = " + txtRollNo.Text + " ", con);
        //        con.Open();
        //        Response.Write(cmd.ExecuteNonQuery() + "Row Updated");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //        //throw;
        //    }
        //}

        protected void Button_Delete(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical15\practical15\App_Data\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Delete from StudentData where RollNo =" + txtRollNo.Text + " ", con);
                con.Open();
                Response.Write(cmd.ExecuteNonQuery() + "Row Deleted");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                //throw;
            }
           
        }

        protected void Button_Search(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical15\practical15\App_Data\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select * from StudentData where Name like '%"+ txttName.Text+"%' ", con);
                //SqlCommand cmd = new SqlCommand("Select * from StudentData where RollNo="+txtRollNo.Text+" ", con);



                SqlDataReader sdr;

                con.Open();
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
                Response.Write("</th> </tr>");
                //Response.Write("</tr>");

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
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }


        
    }
}
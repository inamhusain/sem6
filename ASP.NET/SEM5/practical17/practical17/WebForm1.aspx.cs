using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical17
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void clearAll()
        {
            txtEmpNo.Text = "";
            txtEmpName.Text = "";
            txtAddress.Text = "";
            TxtEmpSalary.Text = "";
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
                try
                {
                    string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical17\practical17\App_Data\Database1.mdf;Integrated Security=True";
                
                    string query = "insert into EmpData (EmpNo,EmpName,Address,Salary) Values (" + txtEmpNo.Text + ", '" + txtEmpName.Text + "','" + txtAddress.Text + "'," + TxtEmpSalary.Text + ")";
                
                    SqlDataAdapter ad = new SqlDataAdapter(query, constring);
                
                    DataSet ds = new DataSet();
                
                    ad.Fill(ds, "EmpData");
                
                    Response.Write("Row Inserted");

                    clearAll();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                    //throw;
                }
            
        }

        

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
                try
                {
                    string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical17\practical17\App_Data\Database1.mdf;Integrated Security=True";
                string query = "update EmpData set EmpName='"+txtEmpName.Text+"', Address='"+txtAddress.Text+"',Salary="+TxtEmpSalary.Text+" where EmpNo="+txtEmpNo.Text+" ";
                SqlDataAdapter ad = new SqlDataAdapter(query, constring);
                DataSet ds = new DataSet();
                ad.Fill(ds, "EmpData");
                Response.Write(ds.GetXml() + "Row Updated");

                clearAll();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                    //throw;
                }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
                try
                {
                string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical17\practical17\App_Data\Database1.mdf;Integrated Security=True";
                
                string query = "delete from EmpData where Empno=" + txtEmpNo.Text + " ";

                SqlDataAdapter ad = new SqlDataAdapter(query, constring);

                DataSet ds = new DataSet();

                ad.Fill(ds, "EmpData");

                Response.Write(ds.GetXml() + "Row Deleted");

                clearAll();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                    // throw;
                }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

                try
                {
                        //SqlConnection con = new SqlConnection( @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical17\practical17\App_Data\Database1.mdf;Integrated Security=True");
                string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical17\practical17\App_Data\Database1.mdf;Integrated Security=True";
            
                string query="select * from EmpData where EmpNo="+txtEmpNo.Text+" ";
                //SqlCommand cmd = new SqlCommand(query, cons);
                SqlDataAdapter ad = new SqlDataAdapter(query, constring);
                DataSet ds = new DataSet();
                ad.Fill(ds);

                /*Response.Write("<table border=1 align=center>");
                    Response.Write("<tr>");
                        Response.Write("<th>");
                        Response.Write("Emp No");
                        Response.Write("</th>");
                        Response.Write("<th>");
                        Response.Write("Emp Name");
                        Response.Write("</th>");
                        Response.Write("<th>");
                        Response.Write("Address");
                        Response.Write("</th>");
                        Response.Write("<th>");
                        Response.Write("Salary");
                        Response.Write("</th>");
                    Response.Write("</tr>");
                    */
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++) 
                    {

                      //  Response.Write("<tr>");
                        // Response.Write("<td>");
                        Response.Write("Id :" + ds.Tables[0].Rows[i]["EmpNo"].ToString());
                        //  Response.Write("</td>");
                        // Response.Write("<td>");
                        Response.Write("<br>Name :" + ds.Tables[0].Rows[i]["EmpName"].ToString());
                        // Response.Write("</td>");
                        // Response.Write("<td>");
                        Response.Write("<br>Address :" + ds.Tables[0].Rows[i]["Address"].ToString());
                        // Response.Write("</td>");
                        // Response.Write("<td>");
                        Response.Write("<br>Salary :" + ds.Tables[0].Rows[i]["Salary"].ToString() + "<hr><hr>");
                        // Response.Write("</td>");
                        //Response.Write("</tr>");
                    
                    }

                    //Response.Write("</table>");
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                    //throw;
                }


        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection( @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical17\practical17\App_Data\Database1.mdf;Integrated Security=True");
                string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical17\practical17\App_Data\Database1.mdf;Integrated Security=True";
               
                
                
                string query = "select * from EmpData";

                //SqlCommand cmd = new SqlCommand(query, cons);
                SqlDataAdapter ad = new SqlDataAdapter(query, constring);
                DataSet ds = new DataSet();
                ad.Fill(ds);

                /*Response.Write("<table border=1 align=center>");
                    Response.Write("<tr>");
                        Response.Write("<th>");
                        Response.Write("Emp No");
                        Response.Write("</th>");
                        Response.Write("<th>");
                        Response.Write("Emp Name");
                        Response.Write("</th>");
                        Response.Write("<th>");
                        Response.Write("Address");
                        Response.Write("</th>");
                        Response.Write("<th>");
                        Response.Write("Salary");
                        Response.Write("</th>");
                    Response.Write("</tr>");
                    */
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    //  Response.Write("<tr>");
                    // Response.Write("<td>");
                    Response.Write("Id :" + ds.Tables[0].Rows[i]["EmpNo"].ToString());
                    //  Response.Write("</td>");
                    // Response.Write("<td>");
                    Response.Write("&nbsp&nbsp&nbsp | &nbsp&nbsp&nbspName :" + ds.Tables[0].Rows[i]["EmpName"].ToString());
                    // Response.Write("</td>");
                    // Response.Write("<td>");
                    Response.Write("&nbsp&nbsp&nbsp | &nbsp&nbsp&nbspAddress :" + ds.Tables[0].Rows[i]["Address"].ToString());
                    // Response.Write("</td>");
                    // Response.Write("<td>");
                    Response.Write("&nbsp&nbsp&nbsp | &nbsp&nbsp&nbspSalary :" + ds.Tables[0].Rows[i]["Salary"].ToString() + "<hr><hr>");
                    // Response.Write("</td>");
                    //Response.Write("</tr>");

                }

                //Response.Write("</table>");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                //throw;
            }
        }
    }
}




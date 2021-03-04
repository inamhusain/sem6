using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical14
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical14\practical14\App_Data\simple.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into tblStudent (Rollno,Name,City) Values (" +txtRollNo.Text+  ",'" + txtName.Text + "','" + txtCity.Text + "')", conn);
                conn.Open();
                Response.Write(cmd.ExecuteNonQuery() + " Row Inserted");
                conn.Close();
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
   SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\practical14\practical14\App_Data\simple.mdf;Integrated Security=True");
     SqlCommand cmd = new SqlCommand("update tblStudent set Name='" + txtName.Text + "',City='" + txtCity.Text + "' where RollNo="+txtRollNo.Text+" ", conn);
                conn.Open();
                Response.Write(cmd.ExecuteNonQuery() + " Row Updated");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                //throw;
            }
        }
    }
}
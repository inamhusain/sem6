using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assiment_ROllNo16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
       string con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\Assiment_ROllNo16\Assiment_ROllNo16\App_Data\Database1.mdf;Integrated Security=True";
       private void ClearAll()
       {
           txtID.Text = "";
           txtName.Text = "";
           DropDownList1.SelectedIndex = 0;
           RadioButtonList1.ClearSelection();
           CheckBoxList1.ClearSelection();
       }
        protected void Button1_insert(object sender, EventArgs e)
        {
            
            try
            {
                Collection<string> items = new Collection<string>();
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                        if (CheckBoxList1.Items[i].Selected)
                    {
                        //arr[i]=CheckBoxList1.Items[i].Text.ToString()+", ";
                        items.Add(CheckBoxList1.Items[i].Text);
                    }
                    
                }
               
                 string query = "insert into CustomerMaster (CustomerId, Name, City, Gender, Hobbies) values (" + txtID.Text + ", '" + txtName.Text + "','" + DropDownList1.SelectedItem.Text + "','" + RadioButtonList1.SelectedItem.Text + "','" + String.Join(",", items.ToArray()) + "')";
                 SqlDataAdapter ad = new SqlDataAdapter(query, con);
                 DataSet ds = new DataSet();
                 ad.Fill(ds);
                 Response.Write("<script>alert('Row Inserted');</script>");
                 ClearAll();

                
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                //throw;
            }
        }

        protected void Button2_update(object sender, EventArgs e)
        {
            try
            {
                Collection<string> items = new Collection<string>();
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        items.Add(CheckBoxList1.Items[i].Text);
                    }

                }
                string query = "update CustomerMaster set Name='" + txtName.Text + "', City='" + DropDownList1.SelectedItem.Text + "', Gender='" + RadioButtonList1.SelectedItem.Text + "', Hobbies='" + String.Join(",", items.ToArray()) + "' where  CustomerId=" + txtID.Text + " ";
                SqlDataAdapter ad = new SqlDataAdapter(query,con);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                Response.Write("<script>alert('Row Updated');</script>");
                ClearAll();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                //throw;
            }
        }

        protected void Button3_Delete(object sender, EventArgs e)
        {
            try
            {
                string query = "Delete from CustomerMaster where CustomerId=" + txtID.Text + "  ";
                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                Response.Write("<script>alert('Row Deleted');</script>");
                ClearAll();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                throw;
            }
        }

        protected void Button4_Display(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from CustomerMaster ";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            Response.Write("<table border=1 align=center>");

            Response.Write("<tr> <th>");
            Response.Write("Customer Id");
            Response.Write("</th> <th>");
            Response.Write("Customer Name");
            Response.Write("</th> <th>");
            Response.Write("City");                    
            Response.Write("</th> <th>");
            Response.Write("Gender");
            Response.Write("</th> <th>");
            Response.Write("Hobbies");
            Response.Write("</th> </tr>");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Response.Write("<tr> <td>");
                Response.Write(ds.Tables[0].Rows[i]["CustomerId"].ToString());
                Response.Write("</td> <td>");
                Response.Write(ds.Tables[0].Rows[i]["Name"].ToString());
                Response.Write("</td> <td>");
                Response.Write(ds.Tables[0].Rows[i]["City"].ToString());
                Response.Write("</td> <td>");
                Response.Write(ds.Tables[0].Rows[i]["Gender"].ToString());
                Response.Write("</td> <td>");
                Response.Write(ds.Tables[0].Rows[i]["Hobbies"].ToString());
                Response.Write("</td> </tr>");
            }
            Response.Write("</table>");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                //throw;
            }
        }

        protected void Button5_Search(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from CustomerMaster where Name like '%" + txtName.Text + "%' ";
                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                ad.Fill(ds);

                Response.Write("<table border=1 align=center>");

                Response.Write("<tr> <th>");
                Response.Write("Customer Id");
                Response.Write("</th> <th>");
                Response.Write("Customer Name");
                Response.Write("</th> <th>");
                Response.Write("City");
                Response.Write("</th> <th>");
                Response.Write("Gender");
                Response.Write("</th> <th>");
                Response.Write("Hobbies");
                Response.Write("</th> </tr>");

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Response.Write("<tr> <td>");
                    Response.Write(ds.Tables[0].Rows[i]["CustomerId"].ToString());
                    Response.Write("</td> <td>");
                    Response.Write(ds.Tables[0].Rows[i]["Name"].ToString());
                    Response.Write("</td> <td>");
                    Response.Write(ds.Tables[0].Rows[i]["City"].ToString());
                    Response.Write("</td> <td>");
                    Response.Write(ds.Tables[0].Rows[i]["Gender"].ToString());
                    Response.Write("</td> <td>");
                    Response.Write(ds.Tables[0].Rows[i]["Hobbies"].ToString());
                    Response.Write("</td> </tr>");
                }
                Response.Write("</table>");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                //throw;
            }
        }

        

        
    }
}
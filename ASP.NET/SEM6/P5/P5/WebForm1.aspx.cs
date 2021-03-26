using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        static int counthr = 00;
        static int countmin = 59;
        static int countsec = 50;
        protected void ontick(object sender, EventArgs e)
        {
            countsec++;
            if (countsec > 59)
            {
                countmin++;
                countsec = 00;
            }
            else if (countmin > 59)
            {
                counthr++;
                countmin = 00;
            }
            lblhr.Text = counthr.ToString();
            lblmin.Text = countmin.ToString();
            lblsec.Text = countsec.ToString();
        }
        protected void btnStart_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        }

        protected void btnStop_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
                   
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            countsec = 00;
            countmin = 00;
            counthr = 00;
            lblhr.Text = counthr.ToString();
            lblmin.Text = countmin.ToString();
            lblsec.Text = countsec.ToString();
        }
    }
}
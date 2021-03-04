using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {

        }







        Double sal, pf, it, pfamount, itamount, gsal, hra, madicalAllows, eductionAllows, totalEarnings, deductions, nsal;

        private void button1_Click(object sender, EventArgs e)
        {
            sal = double.Parse(txtSal.Text);

            if (chkPf.Checked == true)
            {
                pfamount = sal * 10 / 100;
            }

            if (chkIt.Checked == true)
            {
                itamount = sal * 5 / 100;
            }

            txtPf.Text = pfamount.ToString();
            txtIt.Text = itamount.ToString();

        
            txtBSal.Text = sal.ToString();

            hra = sal * 10 / 100;
            txthra.Text = hra.ToString();

            madicalAllows = sal * 15 / 100;
            txtMA.Text = madicalAllows.ToString();

            eductionAllows = sal * 10 / 100;
            txtEA.Text = eductionAllows.ToString();

            totalEarnings = sal + hra + madicalAllows + eductionAllows;
            txtTEarnings.Text = totalEarnings.ToString();

            deductions = pfamount + itamount;
            txtDedu.Text = deductions.ToString();

            nsal = totalEarnings - deductions;
            txtNSal.Text = nsal.ToString();

      
        }

        private void txtNSal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSal.Text = "";
            txtBSal.Text = "";
            txthra.Text = "";
            txtMA.Text = "";
            txtEA.Text = "";
            txtTEarnings.Text = "";
            txtPf.Text = "";
            txtIt.Text = "";
            txtDedu.Text = "";
            txtNSal.Text = "";

         }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }



}

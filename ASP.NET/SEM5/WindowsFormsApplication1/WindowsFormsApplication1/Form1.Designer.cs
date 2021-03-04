namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEA = new System.Windows.Forms.TextBox();
            this.txtMA = new System.Windows.Forms.TextBox();
            this.txtTEarnings = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPf = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txthra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBSal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIt = new System.Windows.Forms.CheckBox();
            this.chkPf = new System.Windows.Forms.CheckBox();
            this.txtNSal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDedu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALARY CALCULATATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMP NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "EMP SALARY";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(153, 187);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(229, 22);
            this.txtSal.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtDedu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtEA);
            this.groupBox1.Controls.Add(this.txtMA);
            this.groupBox1.Controls.Add(this.txtTEarnings);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtIt);
            this.groupBox1.Controls.Add(this.txtNSal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtPf);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txthra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBSal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkIt);
            this.groupBox1.Controls.Add(this.chkPf);
            this.groupBox1.Location = new System.Drawing.Point(41, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 494);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CALCULATION";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEA
            // 
            this.txtEA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEA.Location = new System.Drawing.Point(259, 231);
            this.txtEA.Name = "txtEA";
            this.txtEA.Size = new System.Drawing.Size(167, 15);
            this.txtEA.TabIndex = 27;
            this.txtEA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMA
            // 
            this.txtMA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMA.Location = new System.Drawing.Point(256, 290);
            this.txtMA.Name = "txtMA";
            this.txtMA.Size = new System.Drawing.Size(167, 15);
            this.txtMA.TabIndex = 26;
            this.txtMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTEarnings
            // 
            this.txtTEarnings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTEarnings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTEarnings.Location = new System.Drawing.Point(259, 338);
            this.txtTEarnings.Name = "txtTEarnings";
            this.txtTEarnings.Size = new System.Drawing.Size(167, 15);
            this.txtTEarnings.TabIndex = 25;
            this.txtTEarnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(819, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "AMOUNTS";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 338);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 17);
            this.label17.TabIndex = 22;
            this.label17.Text = "TOTAL EARNINGS";
            // 
            // txtIt
            // 
            this.txtIt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIt.Location = new System.Drawing.Point(716, 186);
            this.txtIt.Name = "txtIt";
            this.txtIt.Size = new System.Drawing.Size(180, 15);
            this.txtIt.TabIndex = 7;
            this.txtIt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "INCOME TAX AMOUNT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "MEDICAL ALLOWANCE";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtPf
            // 
            this.txtPf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPf.Location = new System.Drawing.Point(716, 138);
            this.txtPf.Name = "txtPf";
            this.txtPf.Size = new System.Drawing.Size(180, 15);
            this.txtPf.TabIndex = 4;
            this.txtPf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "EDUCTION ALLOWANCE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "PF AMOUNT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(487, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "DEDUCTIONS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(469, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "AMOUNTS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "EARNINGS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 61);
            this.button1.TabIndex = 14;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txthra
            // 
            this.txthra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txthra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txthra.Location = new System.Drawing.Point(259, 188);
            this.txthra.Name = "txthra";
            this.txthra.Size = new System.Drawing.Size(167, 15);
            this.txthra.TabIndex = 11;
            this.txthra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txthra.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "HRA";
            // 
            // txtBSal
            // 
            this.txtBSal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBSal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBSal.Location = new System.Drawing.Point(259, 140);
            this.txtBSal.Name = "txtBSal";
            this.txtBSal.Size = new System.Drawing.Size(167, 15);
            this.txtBSal.TabIndex = 9;
            this.txtBSal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBSal.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "BASIC SALARY";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chkIt
            // 
            this.chkIt.AutoSize = true;
            this.chkIt.Location = new System.Drawing.Point(151, 55);
            this.chkIt.Name = "chkIt";
            this.chkIt.Size = new System.Drawing.Size(118, 21);
            this.chkIt.TabIndex = 1;
            this.chkIt.Text = " INCOME TAX";
            this.chkIt.UseVisualStyleBackColor = true;
            this.chkIt.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkPf
            // 
            this.chkPf.AutoSize = true;
            this.chkPf.Location = new System.Drawing.Point(40, 55);
            this.chkPf.Name = "chkPf";
            this.chkPf.Size = new System.Drawing.Size(47, 21);
            this.chkPf.TabIndex = 0;
            this.chkPf.Text = "PF";
            this.chkPf.UseVisualStyleBackColor = true;
            // 
            // txtNSal
            // 
            this.txtNSal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNSal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSal.Location = new System.Drawing.Point(739, 338);
            this.txtNSal.Name = "txtNSal";
            this.txtNSal.Size = new System.Drawing.Size(157, 17);
            this.txtNSal.TabIndex = 13;
            this.txtNSal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNSal.TextChanged += new System.EventHandler(this.txtNSal_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(491, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "NET SALARY";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtDedu
            // 
            this.txtDedu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDedu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDedu.Location = new System.Drawing.Point(739, 259);
            this.txtDedu.Name = "txtDedu";
            this.txtDedu.Size = new System.Drawing.Size(162, 15);
            this.txtDedu.TabIndex = 29;
            this.txtDedu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "TOTAL DEDUCTION";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(490, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 61);
            this.button2.TabIndex = 30;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(655, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 61);
            this.button3.TabIndex = 31;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(757, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(392, 61);
            this.button4.TabIndex = 32;
            this.button4.Text = "INFORMATION About @Application";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 794);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLOYEE SALARY";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIt;
        private System.Windows.Forms.CheckBox chkPf;
        private System.Windows.Forms.TextBox txtPf;
        private System.Windows.Forms.TextBox txtIt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBSal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNSal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txthra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEA;
        private System.Windows.Forms.TextBox txtMA;
        private System.Windows.Forms.TextBox txtTEarnings;
        private System.Windows.Forms.TextBox txtDedu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


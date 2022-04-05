using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentMarks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, s4,total;
            double per;
            s1 = Convert.ToInt32(txt1.Text);
            s2 = Convert.ToInt32(txt2.Text);
            s3 = Convert.ToInt32(txt3.Text);
            s4 = Convert.ToInt32(txt4.Text);
            total = s1 + s2 + s3 + s4;
            txttotal.Text = total.ToString();
            per = (total * 100 / 400);
            label8.Text = per.ToString();
            if (per >= 50 && per < 60)
            {
                label9.Text = ("Second class");
            }
            if (per >= 61 && per < 80)
            {
                label9.Text = ("First class");
            }
            if (per >= 81 && per < 1000)
            {
                label9.Text = ("Best class");
            }
        }
        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

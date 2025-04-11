using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai20_BaiThiThu
{
    public partial class giaiphuongtrinhbac2 : Form
    {
        public giaiphuongtrinhbac2()
        {
            InitializeComponent();
        }

        private void giaiphuongtrinhbac2_Load(object sender, EventArgs e)
        {
            lblkq.Text = "ax" + ("\u00B2") + " + bx + c = 0";
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;
            }
            
        }

        private void btnkq_Click(object sender, EventArgs e)
        {
            double a, b, c, dt, x1, x2;
            a = Convert.ToDouble(txtso1.Text);
            b = Convert.ToDouble(txtso2.Text);
            c = Convert.ToDouble(txtso3.Text);
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        lblkq.Text = "Phuong trinh vo nghiem";
                    }
                    else
                    {
                        lblkq.Text = "Phuong trinh co vo so nghiem";
                    }
                }
                else
                {
                    x1 = x2 = -c / b;
                    lblkq.Text = "Phuong trinh vo nghiem";
                }
            }
            else
            {
                dt = b * b - 4 * a * c;
                lblkq.Text = ("delta :"+dt+"\n").ToString();
                
                if (dt < 0)
                {
                    lblkq.Text += "Phuong trinh vo nghiem " ;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(dt)) / (2 * a);
                    x2 = (-b - Math.Sqrt(dt)) / (2 * a);
                    lblkq.Text += " Phuong trinh co 2 nghiem phan biet";
                    lblkq.Text += "\nx1 = " + x1;
                    lblkq.Text += "\nx2 = " + x2;

                }
            }
        }

                private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtso1.Text = "" + tb1.Value;
        }

        private void tb2_Scroll(object sender, EventArgs e)
        {
            txtso2.Text = "" + tb2.Value;
        }

        private void tb3_Scroll(object sender, EventArgs e)
        {
            txtso3.Text = "" + tb3.Value;
        }
    }
}

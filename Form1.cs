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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void lbtt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích", "thông tin");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            giaiphuongtrinhbac2 gpt = new giaiphuongtrinhbac2();
            gpt.MdiParent = this;
            gpt.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            DinhDang dinhdang = new DinhDang();
            dinhdang.MdiParent = this;
            dinhdang.Show();
        }

        private void gptb2StripMenuItem5_Click(object sender, EventArgs e)
        {
            giaiphuongtrinhbac2 gpt = new giaiphuongtrinhbac2();
            gpt.MdiParent = this;
            gpt.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            dangkymonhoc dk = new dangkymonhoc();
            dk.MdiParent = this;
            dk.Show();
        }
    }
}

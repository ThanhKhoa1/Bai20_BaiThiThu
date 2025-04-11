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
    public partial class DinhDang : Form
    {
        public DinhDang()
        {
            InitializeComponent();
        }

        private void DinhDang_Load(object sender, EventArgs e)
        {
            txtTen.Focus();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtkq.Text = txtTen.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtkq.ForeColor = Color.Red;
            txtTen.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtkq.ForeColor = Color.Green;
            txtTen.ForeColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtkq.ForeColor = Color.Blue;
            txtTen.ForeColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtkq.ForeColor = Color.Black;
            txtTen.ForeColor = Color.Black;
        }

        private void rdDam_CheckedChanged(object sender, EventArgs e)
        {
            txtkq.Font = new Font(txtkq.Font.Name, txtkq.Font.Size,
            txtkq.Font.Style ^ FontStyle.Bold);
        }

        private void rdNg_CheckedChanged(object sender, EventArgs e)
        {
            txtkq.Font = new Font(txtkq.Font.Name, txtkq.Font.Size,
            txtkq.Font.Style ^ FontStyle.Italic);
        }

        private void rdgc_CheckedChanged(object sender, EventArgs e)
        {
            txtkq.Font = new Font(txtkq.Font.Name, txtkq.Font.Size,
            txtkq.Font.Style ^ FontStyle.Underline);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtkq.Font = new Font(txtkq.Font.Name, txtkq.Font.Size,
            txtkq.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtkq.Font = new Font(txtkq.Font.Name, txtkq.Font.Size,
            txtkq.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            txtkq.Font = new Font(txtkq.Font.Name, txtkq.Font.Size,
            txtkq.Font.Style ^ FontStyle.Underline);
        }
    }
}

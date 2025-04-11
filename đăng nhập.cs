using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai20_BaiThiThu
{
    public partial class đăng_nhập : Form
    {
        public đăng_nhập()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "admin" && txtpass.Text == "admin")
            {
                Form1 dangnhap = new Form1();
                this.Hide();
                dangnhap.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("sai tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void đăng_nhập_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btndangnhap;
            this.CancelButton = btnthoat;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class dangkymonhoc : Form
    {
        public dangkymonhoc()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "54222420062" + txtmssv.Text;
            thongtin += "Hồ Thanh Khoa" + txtten.Text;
        }
    }
}

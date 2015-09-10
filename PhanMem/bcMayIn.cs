using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanMem
{
    public partial class bcMayIn : Form
    {
        public bcMayIn()
        {
            InitializeComponent();
        }

        private void bt_bcLuongN1_Click(object sender, EventArgs e)
        {
            var baocao = new bcLuongN1();
            baocao.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void bt_bcLuongN2_Click(object sender, EventArgs e)
        {
            var baocao = new bcLuongN2();
            baocao.ShowDialog();
        }

        private void bt_bcLuongN3_Click(object sender, EventArgs e)
        {
            var baocao = new bcLuongN3();
            baocao.ShowDialog();
        }

        private void bt_bcKhachhang_Click(object sender, EventArgs e)
        {

        }
    }
}

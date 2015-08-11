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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void bt_qlCongNhan_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var ql = new qlCongNhan();
            ql.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNhapCat_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var ql = new qlCongCat();
            ql.Show();
        }

        private void btKhoVai_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var ql = new qlKhoVai();
            ql.Show();
        }

        private void btViecPhu_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var ql = new qlViecPhu();
            ql.Show();
        }

        private void btCongPhu_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var ql = new qlCongPhu();
            ql.Show();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var bc = new BcCongCat();
            bc.Show();
        }

        private void btBcTongHop_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var bc = new BcTongHopCat();
            bc.Show();
        }

        private void btLuong_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var bc = new BcLuongCat();
            bc.Show();
        }
    }
}

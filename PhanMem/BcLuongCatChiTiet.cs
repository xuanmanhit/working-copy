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
    public partial class BcLuongCatChiTiet : Form
    {
        DataAccess DA = new DataAccess();        

        public BcLuongCatChiTiet()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadGrid()
        {
            DataTable dt = DA.ThongtinLuongCatChiTiet();
            label4.Text = "Chi tiết lương công nhân: " + dt.Rows[0][0] + " - từ " + dt.Rows[0][1] + " đến " + dt.Rows[0][2];
            gvLuongChiTiet.AutoGenerateColumns = false;
            gvLuongChiTiet.DataSource = DA.LuongCatChiTiet();
        }

        private void BcLuongCatChiTiet_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}

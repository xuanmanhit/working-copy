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
    public partial class qlKhachHang : Form
    {
        DataAccess DA = new DataAccess();

        public qlKhachHang()
        {
            InitializeComponent();
        }

        private void qlKhachHang_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttKhachHang("", this);
            thongtin.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void gvViecMayIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvKhachhang.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttKhachHang(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvKhachhang.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_KhachHang(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        public void LoadGrid()
        {
            int rownum = DA.List_KhachHang().Rows.Count;
            label4.Text = "Danh sách Khách hàng: " + rownum;
            gvKhachhang.AutoGenerateColumns = false;
            gvKhachhang.DataSource = DA.List_KhachHang();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_KhachHang().Rows.Count;
            label4.Text = "Danh sách Khách hàng: " + rownum;
            gvKhachhang.AutoGenerateColumns = false;
            gvKhachhang.DataSource = DA.List_KhachHang();
            gvKhachhang.Rows[rowindex].Selected = true;
            gvKhachhang.FirstDisplayedScrollingRowIndex = rowindex;
        }
    }
}

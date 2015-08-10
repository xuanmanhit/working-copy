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
    public partial class qlCongNhan : Form
    {
        DataAccess DA = new DataAccess();

        public qlCongNhan()
        {
            InitializeComponent();

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        public void LoadGrid()
        {
            int rownum = DA.List_CongNhan().Rows.Count;
            label4.Text = "Danh sách Công Nhân: " + rownum;
            gvCongNhan.AutoGenerateColumns = false;
            gvCongNhan.DataSource = DA.List_CongNhan();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_CongNhan().Rows.Count;
            label4.Text = "Danh sách Công Nhân: " + rownum;
            gvCongNhan.AutoGenerateColumns = false;
            gvCongNhan.DataSource = DA.List_CongNhan();
            gvCongNhan.Rows[rowindex].Selected = true;
            gvCongNhan.FirstDisplayedScrollingRowIndex = rowindex;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttCongNhan("", this);
            thongtin.ShowDialog();
        }

        private void gvCongNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvCongNhan.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttCongNhan(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvCongNhan.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Công Nhân này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_CongNhan(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        private void qlCongNhan_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}

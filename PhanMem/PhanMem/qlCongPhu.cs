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
    public partial class qlCongPhu : Form
    {
        DataAccess DA = new DataAccess();

        public qlCongPhu()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttCongPhu("", this);
            thongtin.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void gvCongPhu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvCongPhu.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttCongPhu(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvCongPhu.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Công Phụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_CongCatPhu(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        public void LoadGrid()
        {
            int rownum = DA.List_CongCatPhu().Rows.Count;
            label4.Text = "Danh sách Công Phụ: " + rownum;
            gvCongPhu.AutoGenerateColumns = false;
            gvCongPhu.DataSource = DA.List_CongCatPhu();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_CongCatPhu().Rows.Count;
            label4.Text = "Danh sách Công Phụ: " + rownum;
            gvCongPhu.AutoGenerateColumns = false;
            gvCongPhu.DataSource = DA.List_CongCatPhu();
            gvCongPhu.Rows[rowindex].Selected = true;
            gvCongPhu.FirstDisplayedScrollingRowIndex = rowindex;
        }

        private void qlCongPhu_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}

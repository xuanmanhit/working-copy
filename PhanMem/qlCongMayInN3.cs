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
    public partial class qlCongMayInN3 : Form
    {
        DataAccess DA = new DataAccess();

        public qlCongMayInN3()
        {
            InitializeComponent();
        }

        private void qlCongMayInN3_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttCongMayInN3("", this);
            thongtin.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void gvCongN3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvCongPhu.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttCongMayInN3(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvCongPhu.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Công Phụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_CongN3(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        public void LoadGrid()
        {
            int rownum = DA.List_CongN3().Rows.Count;
            label4.Text = "Danh sách Công Phụ: " + rownum;
            gvCongPhu.AutoGenerateColumns = false;
            gvCongPhu.DataSource = DA.List_CongN3();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_CongN3().Rows.Count;
            label4.Text = "Danh sách Công Phụ: " + rownum;
            gvCongPhu.AutoGenerateColumns = false;
            gvCongPhu.DataSource = DA.List_CongN3();
            gvCongPhu.Rows[rowindex].Selected = true;
            gvCongPhu.FirstDisplayedScrollingRowIndex = rowindex;
        }
    }
}

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
    public partial class qlCongMayInN1 : Form
    {
        DataAccess DA = new DataAccess();

        public qlCongMayInN1()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttCongMayInN1("", this);
            thongtin.ShowDialog();
        }

        private void qlCongMayInN1_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void gvCongN1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvCongN1.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttCongMayInN1(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvCongN1.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Công này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_CongN1(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        public void LoadGrid()
        {
            int rownum = DA.List_CongN1().Rows.Count;
            label4.Text = "Danh sách Công Nhóm 1: " + rownum;
            gvCongN1.AutoGenerateColumns = false;
            gvCongN1.DataSource = DA.List_CongN1();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_CongN1().Rows.Count;
            label4.Text = "Danh sách Công Nhóm 1: " + rownum;
            gvCongN1.AutoGenerateColumns = false;
            gvCongN1.DataSource = DA.List_CongN1();
            gvCongN1.Rows[rowindex].Selected = true;
            gvCongN1.FirstDisplayedScrollingRowIndex = rowindex;
        }
    }
}

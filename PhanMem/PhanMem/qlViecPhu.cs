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
    public partial class qlViecPhu : Form
    {
        DataAccess DA = new DataAccess();

        public qlViecPhu()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttViecPhu("", this);
            thongtin.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        public void LoadGrid()
        {
            int rownum = DA.List_ViecPhu().Rows.Count;
            label4.Text = "Danh sách Việc Phụ: " + rownum;
            gvViecPhu.AutoGenerateColumns = false;
            gvViecPhu.DataSource = DA.List_ViecPhu();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_ViecPhu().Rows.Count;
            label4.Text = "Danh sách Việc Phụ: " + rownum;
            gvViecPhu.AutoGenerateColumns = false;
            gvViecPhu.DataSource = DA.List_ViecPhu();
            gvViecPhu.Rows[rowindex].Selected = true;
            gvViecPhu.FirstDisplayedScrollingRowIndex = rowindex;
        }

        private void gvViecPhu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvViecPhu.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttViecPhu(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvViecPhu.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Việc Phụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_ViecPhu(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        private void qlViecPhu_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}

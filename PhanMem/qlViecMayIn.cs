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
    public partial class qlViecMayIn : Form
    {
        DataAccess DA = new DataAccess();

        public qlViecMayIn()
        {
            InitializeComponent();
        }

        private void qlViecMayIn_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttViecMayIn("", this);
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
                string _id_rowindex = gvViecMayIn.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttViecMayIn(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvViecMayIn.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Công việc này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_ViecMayIn(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        public void LoadGrid()
        {
            int rownum = DA.List_ViecMayIn().Rows.Count;
            label4.Text = "Danh sách Công việc May - In: " + rownum;
            gvViecMayIn.AutoGenerateColumns = false;
            gvViecMayIn.DataSource = DA.List_ViecMayIn();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_ViecMayIn().Rows.Count;
            label4.Text = "Danh sách Công việc May - In: " + rownum;
            gvViecMayIn.AutoGenerateColumns = false;
            gvViecMayIn.DataSource = DA.List_ViecMayIn();
            gvViecMayIn.Rows[rowindex].Selected = true;
            gvViecMayIn.FirstDisplayedScrollingRowIndex = rowindex;
        }
    }
}

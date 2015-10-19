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
    public partial class qlCongIn : Form
    {
        DataAccess DA = new DataAccess();

        public qlCongIn()
        {
            InitializeComponent();
        }

        private void qlCongMayInN2_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttCongIn("", this);
            thongtin.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void gvCongN2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvCongN2.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttCongIn(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvCongN2.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Công này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_CongIn(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        public void LoadGrid()
        {
            int rownum = DA.List_CongIn().Rows.Count;
            label4.Text = "Danh sách Công In: " + rownum;
            gvCongN2.AutoGenerateColumns = false;
            gvCongN2.DataSource = DA.List_CongIn();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_CongIn().Rows.Count;
            label4.Text = "Danh sách Công In: " + rownum;
            gvCongN2.AutoGenerateColumns = false;
            gvCongN2.DataSource = DA.List_CongIn();
            gvCongN2.Rows[rowindex].Selected = true;
            gvCongN2.FirstDisplayedScrollingRowIndex = rowindex;
        }
    }
}

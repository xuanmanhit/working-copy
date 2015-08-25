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
    public partial class qlThoMayIn : Form
    {
        DataAccess DA = new DataAccess();

        public qlThoMayIn()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttThoMayIn("", this);
            thongtin.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void qlThoMayIn_Load(object sender, EventArgs e)
        {            
            LoadGrid();
        }

        private void gvThoMayIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvThoMayIn.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttThoMayIn(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvThoMayIn.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Thợ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_ThoMayIn(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        public void LoadGrid()
        {
            int rownum = DA.List_ThoMayIn().Rows.Count;
            label4.Text = "Danh sách Thợ May - In: " + rownum;
            gvThoMayIn.AutoGenerateColumns = false;
            gvThoMayIn.DataSource = DA.List_ThoMayIn();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_ThoMayIn().Rows.Count;
            label4.Text = "Danh sách Thợ May - In: " + rownum;
            gvThoMayIn.AutoGenerateColumns = false;
            gvThoMayIn.DataSource = DA.List_ThoMayIn();
            gvThoMayIn.Rows[rowindex].Selected = true;
            gvThoMayIn.FirstDisplayedScrollingRowIndex = rowindex;
        }
    }
}

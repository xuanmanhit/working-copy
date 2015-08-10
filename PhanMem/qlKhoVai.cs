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
    public partial class qlKhoVai : Form
    {
        DataAccess DA = new DataAccess();

        public qlKhoVai()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttKhoVai("", this);
            thongtin.ShowDialog();
        }

        public void LoadGrid()
        {
            int rownum = DA.List_KhoVai().Rows.Count;
            label4.Text = "Danh sách Khổ Vải: " + rownum;
            gvKhoVai.AutoGenerateColumns = false;
            gvKhoVai.DataSource = DA.List_KhoVai();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_KhoVai().Rows.Count;
            label4.Text = "Danh sách Khổ Vải: " + rownum;
            gvKhoVai.AutoGenerateColumns = false;
            gvKhoVai.DataSource = DA.List_KhoVai();
            gvKhoVai.Rows[rowindex].Selected = true;
            gvKhoVai.FirstDisplayedScrollingRowIndex = rowindex;
        }

        private void qlKhoVai_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void gvKhoVai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvKhoVai.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttKhoVai(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvKhoVai.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Khổ Vải này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_KhoVai(new string[] { _id });
                    LoadGrid();
                }
            }
        }
    }
}

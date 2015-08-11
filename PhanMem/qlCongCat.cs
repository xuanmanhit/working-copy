﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanMem
{
    public partial class qlCongCat : Form
    {
        DataAccess DA = new DataAccess();

        public qlCongCat()
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
            var thongtin = new ttCongCat("", this);
            thongtin.ShowDialog();
        }

        public void LoadGrid()
        {
            int rownum = DA.List_CongCat().Rows.Count;
            label4.Text = "Danh sách Công Cắt: " + rownum;
            gvCongCat.AutoGenerateColumns = false;
            gvCongCat.DataSource = DA.List_CongCat();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_CongCat().Rows.Count;
            label4.Text = "Danh sách Công Cắt: " + rownum;
            gvCongCat.AutoGenerateColumns = false;
            gvCongCat.DataSource = DA.List_CongCat();
            gvCongCat.Rows[rowindex].Selected = true;
            gvCongCat.FirstDisplayedScrollingRowIndex = rowindex;
        }

        private void gvCongCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvCongCat.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttCongCat(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvCongCat.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Công Cắt này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_CongCat(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        private void qlCongCat_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
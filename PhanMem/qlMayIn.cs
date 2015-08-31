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
    public partial class qlMayIn : Form
    {
        DataAccess DA = new DataAccess();

        public qlMayIn()
        {
            InitializeComponent();
        }

        private void qlMayIn_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttMayIn("", this);
            thongtin.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void gvMayIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvMayIn.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttMayIn(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvMayIn.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Máy in này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_MayIn(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        public void LoadGrid()
        {
            int rownum = DA.List_MayIn().Rows.Count;
            label4.Text = "Danh sách Máy in: " + rownum;
            gvMayIn.AutoGenerateColumns = false;
            gvMayIn.DataSource = DA.List_MayIn();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_MayIn().Rows.Count;
            label4.Text = "Danh sách Máy in: " + rownum;
            gvMayIn.AutoGenerateColumns = false;
            gvMayIn.DataSource = DA.List_MayIn();
            gvMayIn.Rows[rowindex].Selected = true;
            gvMayIn.FirstDisplayedScrollingRowIndex = rowindex;
        }
    }
}
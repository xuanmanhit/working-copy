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
    public partial class ttViecPhu : Form
    {
        DataAccess DA = new DataAccess();
        qlViecPhu ql;
        static string idViecPhu = string.Empty;
        static string rowindex = string.Empty;

        public ttViecPhu(string _id_rowindex, qlViecPhu _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idViecPhu = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_ViecPhu(new string[] { idViecPhu });
                txtTenViec.Text = dt.Rows[0][1].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Cập nhật")
            {
                if (string.IsNullOrEmpty(txtTenViec.Text))
                    MessageBox.Show("Tên Việc không được để trống!");
                else
                {

                    DA.Edit_ViecPhu(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtTenViec.Text))
                    MessageBox.Show("Tên Việc không được để trống!");
                else
                {
                    DA.Add_ViecPhu(GetParam());
                    ql.LoadGrid();
                    this.Close();
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDefault()
        {
            txtTenViec.Text = string.Empty;
        }

        private string[] GetParam()
        {
            string[] param = new string[2];
            param[0] = txtTenViec.Text.Trim();
            param[1] = idViecPhu;
            return param;
        }
    }
}

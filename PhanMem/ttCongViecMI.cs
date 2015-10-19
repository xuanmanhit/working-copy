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
    public partial class ttCongViecMI : Form
    {
        DataAccess DA = new DataAccess();
        qlCongViecMI ql;
        static string idViec = string.Empty;
        static string rowindex = string.Empty;

        public ttCongViecMI(string _id_rowindex, qlCongViecMI _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idViec = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_ViecMayIn(new string[] { idViec });
                txtCongviec.Text = dt.Rows[0][1].ToString();
                txtDongia.Text = dt.Rows[0][2].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Cập nhật")
            {
                int icheck;
                if (string.IsNullOrEmpty(txtCongviec.Text))
                    MessageBox.Show("Tên công việc không được để trống!");
                else if (!string.IsNullOrEmpty(txtDongia.Text) && (!int.TryParse(txtDongia.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Đơn giá phải là số nguyên!");
                else
                {

                    DA.Edit_ViecMayIn(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                int icheck;
                if (string.IsNullOrEmpty(txtCongviec.Text))
                    MessageBox.Show("Tên công việc không được để trống!");
                else if (!string.IsNullOrEmpty(txtDongia.Text) && (!int.TryParse(txtDongia.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Đơn giá phải là số nguyên!");
                else
                {
                    DA.Add_ViecMayIn(GetParam());
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
            txtCongviec.Text = string.Empty;
            txtDongia.Text = string.Empty;
        }

        private string[] GetParam()
        {
            string[] param = new string[3];
            param[0] = txtCongviec.Text.Trim();
            param[1] = string.IsNullOrEmpty(txtDongia.Text) ? "0" : txtDongia.Text.Trim();
            param[2] = idViec;
            return param;
        }
    }
}

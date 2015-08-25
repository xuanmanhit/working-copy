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
    public partial class ttKhachHang : Form
    {
        DataAccess DA = new DataAccess();
        qlKhachHang ql;
        static string idKh = string.Empty;
        static string rowindex = string.Empty;

        public ttKhachHang(string _id_rowindex, qlKhachHang _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idKh = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_KhachHangn(new string[] { idKh });
                txtHoTen.Text = dt.Rows[0][1].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Cập nhật")
            {
                if (string.IsNullOrEmpty(txtHoTen.Text))
                    MessageBox.Show("Họ Tên không được để trống!");
                else
                {

                    DA.Edit_KhachHang(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtHoTen.Text))
                    MessageBox.Show("Họ Tên không được để trống!");
                else
                {
                    DA.Add_KhachHang(GetParam());
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
            txtHoTen.Text = string.Empty;
        }

        private string[] GetParam()
        {
            string[] param = new string[2];
            param[0] = txtHoTen.Text.Trim();
            param[1] = idKh;
            return param;
        }
    }
}

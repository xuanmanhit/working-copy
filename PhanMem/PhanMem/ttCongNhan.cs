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
    public partial class ttCongNhan : Form
    {
        DataAccess DA = new DataAccess();
        qlCongNhan ql;
        static string idCongnhan = string.Empty;
        static string rowindex = string.Empty;

        public ttCongNhan(string _id_rowindex, qlCongNhan _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idCongnhan = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_CongNhan(new string[]{idCongnhan});
                txtHoTen.Text = dt.Rows[0][1].ToString();
                cbCongViec.SelectedValue = dt.Rows[0][2].ToString();
                cbLoaiHinh.SelectedValue = dt.Rows[0][3].ToString();
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
                    
                    DA.Edit_CongNhan(GetParam());
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
                    DA.Add_CongNhan(GetParam());
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
            cbCongViec.DataSource = DA.List_CongViec();
            cbCongViec.DisplayMember = "Value";
            cbCongViec.ValueMember = "Value";
            cbLoaiHinh.DataSource = DA.List_NhanVien();
            cbLoaiHinh.DisplayMember = "Value";
            cbLoaiHinh.ValueMember = "Value";
        }

        private string[] GetParam()
        {
            string[] param = new string[4];
            param[0] = txtHoTen.Text.Trim();
            param[1] = cbCongViec.SelectedValue.ToString();
            param[2] = cbLoaiHinh.SelectedValue.ToString();
            param[3] = idCongnhan;
            return param;
        }
    }
}

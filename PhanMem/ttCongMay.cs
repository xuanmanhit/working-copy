using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanMem
{
    public partial class ttCongMay : Form
    {
        DataAccess DA = new DataAccess();
        qlCongMay ql;
        static string idN1 = string.Empty;
        static string rowindex = string.Empty;

        public ttCongMay(string _id_rowindex, qlCongMay _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idN1 = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_CongMay(new string[] { idN1 });
                dtpNgayCong.Value = DateTime.ParseExact(dt.Rows[0][1].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture); ;
                cbCongviec.SelectedValue = dt.Rows[0][2].ToString();
                txtSanpham.Text = dt.Rows[0][3].ToString();
                cbKhoVai.SelectedValue = dt.Rows[0][4].ToString();
                cbTho1.SelectedValue = dt.Rows[0][5].ToString();
                txtGio1.Text = dt.Rows[0][6].ToString();
                cbTho2.SelectedValue = dt.Rows[0][7].ToString();
                txtGio2.Text = dt.Rows[0][8].ToString();
                txtGia2.Text = dt.Rows[0][9].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Cập nhật")
            {
                int icheck;
                if (!string.IsNullOrEmpty(txtSanpham.Text) && (!int.TryParse(txtSanpham.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số lượng SP phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio1.Text) && (!int.TryParse(txtGio1.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ chính phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio2.Text) && (!int.TryParse(txtGio2.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ phụ phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGia2.Text) && (!int.TryParse(txtGia2.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá công thợ phụ phải là số nguyên!");
                else
                {
                    DA.Edit_CongMay(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                int icheck;
                if (!string.IsNullOrEmpty(txtSanpham.Text) && (!int.TryParse(txtSanpham.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số lượng SP phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio1.Text) && (!int.TryParse(txtGio1.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ chính phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio2.Text) && (!int.TryParse(txtGio2.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ phụ phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGia2.Text) && (!int.TryParse(txtGia2.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá công thợ phụ phải là số nguyên!");
                else
                {
                    DA.Add_CongMay(GetParam());
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
            dtpNgayCong.Format = DateTimePickerFormat.Custom;
            dtpNgayCong.CustomFormat = "dd/MM/yyyy";
            cbCongviec.DataSource = DA.List_CongviecMayIn();
            cbCongviec.ValueMember = "ID";
            cbCongviec.DisplayMember = "TenCongViec";
            txtSanpham.Text = string.Empty;
            cbKhoVai.DataSource = DA.List_KhoVaiMayIn();
            cbKhoVai.ValueMember = "ID";
            cbKhoVai.DisplayMember = "KhoVai";
            cbTho1.DataSource = DA.List_Tho();
            cbTho1.ValueMember = "ID";
            cbTho1.DisplayMember = "HoTen";
            txtGio1.Text = string.Empty;
            cbTho2.DataSource = DA.List_Tho();
            cbTho2.ValueMember = "ID";
            cbTho2.DisplayMember = "HoTen";
            txtGio2.Text = string.Empty;
            txtGia2.Text = string.Empty;
        }

        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2}";
            return string.Format(dateTimeFormat, datetime.Year, CheckString(datetime.Month), CheckString(datetime.Day));
        }

        private string CheckString(int number)
        {
            return number < 10 ? "0" + number.ToString() : number.ToString();
        }

        private string[] GetParam()
        {
            string[] param = new string[11];
            param[0] = DateTimeSQLite(dtpNgayCong.Value);
            param[1] = cbCongviec.SelectedValue.ToString();
            param[2] = string.IsNullOrEmpty(txtSanpham.Text) ? "0" : txtSanpham.Text.Trim();
            param[3] = cbKhoVai.SelectedValue.ToString();
            param[4] = cbTho1.SelectedValue.ToString();
            param[5] = string.IsNullOrEmpty(txtGio1.Text) ? "0" : txtGio1.Text.Trim();
            param[6] = cbTho2.SelectedValue.ToString();
            param[7] = string.IsNullOrEmpty(txtGio2.Text) ? "0" : txtGio2.Text.Trim();
            param[8] = string.IsNullOrEmpty(txtGia2.Text) ? "0" : txtGia2.Text.Trim();
            param[9] = idN1;
            return param;
        }        
    }
}

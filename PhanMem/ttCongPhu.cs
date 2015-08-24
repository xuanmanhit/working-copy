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
    public partial class ttCongPhu : Form
    {
        DataAccess DA = new DataAccess();
        qlCongPhu ql;
        static string idCongPhu = string.Empty;
        static string rowindex = string.Empty;

        public ttCongPhu(string _id_rowindex, qlCongPhu _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idCongPhu = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_CongCatPhu(new string[] { idCongPhu });
                dtpNgayCong.Value = DateTime.ParseExact(dt.Rows[0][1].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture); ;
                cbCongNhan.SelectedValue = dt.Rows[0][2].ToString();
                cbTenViec.SelectedValue = dt.Rows[0][3].ToString();
                txtGioCong.Text = dt.Rows[0][4].ToString();
                txtGiaCong.Text = dt.Rows[0][5].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Cập nhật")
            {
                int icheck;                
                if (!string.IsNullOrEmpty(txtGioCong.Text) && (!int.TryParse(txtGioCong.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ Công phải là số nguyên dương!");
                else if (!string.IsNullOrEmpty(txtGiaCong.Text) && (!int.TryParse(txtGiaCong.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá Công phải là số nguyên dương!");
                else
                {
                    DA.Edit_CongCatPhu(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                int icheck;
                if (!string.IsNullOrEmpty(txtGioCong.Text) && (!int.TryParse(txtGioCong.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ Công phải là số nguyên dương!");
                else if (!string.IsNullOrEmpty(txtGiaCong.Text) && (!int.TryParse(txtGiaCong.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá Công phải là số nguyên dương!");
                else
                {
                    DA.Add_CongCatPhu(GetParam());
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

            cbCongNhan.DataSource = DA.List_CongNhanCat();
            cbCongNhan.ValueMember = "ID";
            cbCongNhan.DisplayMember = "HoTen";

            cbTenViec.DataSource = DA.List_ViecPhu();
            cbTenViec.ValueMember = "ID";
            cbTenViec.DisplayMember = "TenViec";

            txtGioCong.Text = string.Empty;
            txtGiaCong.Text = string.Empty;
        }

        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2}";
            return string.Format(dateTimeFormat, datetime.Year, CheckString(datetime.Month), CheckString(datetime.Day));
        }

        private string[] GetParam()
        {
            string[] param = new string[11];
            param[0] = DateTimeSQLite(dtpNgayCong.Value);
            param[1] = cbCongNhan.SelectedValue.ToString();
            param[2] = cbTenViec.SelectedValue.ToString();
            param[3] = string.IsNullOrEmpty(txtGioCong.Text) ? "0" : txtGioCong.Text.Trim();
            param[4] = string.IsNullOrEmpty(txtGiaCong.Text) ? "0" : txtGiaCong.Text.Trim();
            param[5] = idCongPhu;
            return param;
        }

        private string CheckString(int number)
        {
            return number < 10 ? "0" + number.ToString() : number.ToString();
        }
    }
}

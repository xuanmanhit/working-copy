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
    public partial class ttCongMayInN1 : Form
    {
        DataAccess DA = new DataAccess();
        qlCongMayInN1 ql;
        static string idN1 = string.Empty;
        static string rowindex = string.Empty;

        public ttCongMayInN1(string _id_rowindex, qlCongMayInN1 _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idN1 = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_CongN1(new string[] { idN1 });
                dtpNgayCong.Value = DateTime.ParseExact(dt.Rows[0][1].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture); ;
                cbTho.SelectedValue = dt.Rows[0][2].ToString();
                cbCongviec.SelectedValue = dt.Rows[0][3].ToString();
                cbKhoVai.SelectedValue = dt.Rows[0][4].ToString();
                cbKhg.SelectedValue = dt.Rows[0][5].ToString();
                txtSoluong.Text = dt.Rows[0][6].ToString();
                txtGhichu.Text = dt.Rows[0][7].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Cập nhật")
            {
                int icheck;
                if (!string.IsNullOrEmpty(txtSoluong.Text) && (!int.TryParse(txtSoluong.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số lượng SP phải là số nguyên!");
                else
                {
                    DA.Edit_CongN1(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                int icheck;
                if (!string.IsNullOrEmpty(txtSoluong.Text) && (!int.TryParse(txtSoluong.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số lượng SP phải là số nguyên!");
                else
                {
                    DA.Add_CongN1(GetParam());
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

            cbTho.DataSource = DA.List_Tho();
            cbTho.ValueMember = "ID";
            cbTho.DisplayMember = "HoTen";

            cbCongviec.DataSource = DA.List_CongviecMayIn();
            cbCongviec.ValueMember = "ID";
            cbCongviec.DisplayMember = "TenCongViec";

            cbKhoVai.DataSource = DA.List_KhoVaiMayIn();
            cbKhoVai.ValueMember = "ID";
            cbKhoVai.DisplayMember = "KhoVai";

            cbKhg.DataSource = DA.List_KhgMayIn();
            cbKhg.ValueMember = "ID";
            cbKhg.DisplayMember = "HoTen";

            txtSoluong.Text = string.Empty;
            txtGhichu.Text = string.Empty;
        }

        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2}";
            return string.Format(dateTimeFormat, datetime.Year, CheckString(datetime.Month), CheckString(datetime.Day));
        }

        private string[] GetParam()
        {
            string[] param = new string[8];
            param[0] = DateTimeSQLite(dtpNgayCong.Value);
            param[1] = cbTho.SelectedValue.ToString();
            param[2] = cbCongviec.SelectedValue.ToString();
            param[3] = cbKhoVai.SelectedValue.ToString();
            param[4] = cbKhg.SelectedValue.ToString();
            param[5] = string.IsNullOrEmpty(txtSoluong.Text) ? "0" : txtSoluong.Text.Trim();
            param[6] = txtGhichu.Text.Trim();            
            param[7] = idN1;
            return param;
        }

        private string CheckString(int number)
        {
            return number < 10 ? "0" + number.ToString() : number.ToString();
        }
    }
}

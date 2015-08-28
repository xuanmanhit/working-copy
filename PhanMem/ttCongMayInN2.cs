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
    public partial class ttCongMayInN2 : Form
    {
        DataAccess DA = new DataAccess();
        qlCongMayInN2 ql;
        static string idN2 = string.Empty;
        static string rowindex = string.Empty;

        public ttCongMayInN2(string _id_rowindex, qlCongMayInN2 _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idN2 = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_CongN2(new string[] { idN2 });
                dtpNgayCong.Value = DateTime.ParseExact(dt.Rows[0][1].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                cbThochinh.SelectedValue = dt.Rows[0][2].ToString();
                cbThophu.SelectedValue = dt.Rows[0][3].ToString();
                dtpNhanIn.Value = DateTime.ParseExact(dt.Rows[0][4].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                dtpIn.Value = DateTime.ParseExact(dt.Rows[0][5].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                dtpInxong.Value = DateTime.ParseExact(dt.Rows[0][6].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                cbKhoVai.SelectedValue = dt.Rows[0][7].ToString();
                cbCongviec.SelectedValue = dt.Rows[0][8].ToString();
                cbThocat.SelectedValue = dt.Rows[0][9].ToString();
                txtSoSp.Text = dt.Rows[0][10].ToString();
                txtInHu.Text = dt.Rows[0][11].ToString();
                cbThoinHu.SelectedValue = dt.Rows[0][12].ToString();
                txtInPhe.Text = dt.Rows[0][13].ToString();
                cbThoInPhe.SelectedValue = dt.Rows[0][14].ToString();
                txtInVayMuc.Text = dt.Rows[0][15].ToString();
                cbThoInVayMuc.SelectedValue = dt.Rows[0][16].ToString();
                txtInLoi.Text = dt.Rows[0][17].ToString();
                cbThoInLoi.SelectedValue = dt.Rows[0][18].ToString();
                txtGhichu.Text = dt.Rows[0][19].ToString();
                cbSoMayIn.SelectedValue = dt.Rows[0][20].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Cập nhật")
            {
                int icheck;
                if (!string.IsNullOrEmpty(txtSoSp.Text) && (!int.TryParse(txtSoSp.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số lượng SP phải là số nguyên!");
                else
                {
                    DA.Edit_CongN2(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                int icheck;
                if (!string.IsNullOrEmpty(txtSoSp.Text) && (!int.TryParse(txtSoSp.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số lượng SP phải là số nguyên!");
                else
                {
                    DA.Add_CongN2(GetParam());
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
            
            cbThochinh.DataSource = DA.List_Tho();
            cbThochinh.ValueMember = "ID";
            cbThochinh.DisplayMember = "HoTen";
            cbThophu.DataSource = DA.List_Tho();
            cbThophu.ValueMember = "ID";
            cbThophu.DisplayMember = "HoTen";

            dtpNhanIn.Format = DateTimePickerFormat.Custom;
            dtpNhanIn.CustomFormat = "HH:mm";
            dtpIn.Format = DateTimePickerFormat.Custom;
            dtpIn.CustomFormat = "HH:mm";
            dtpInxong.Format = DateTimePickerFormat.Custom;
            dtpInxong.CustomFormat = "HH:mm";

            cbKhoVai.DataSource = DA.List_KhoVaiMayIn();
            cbKhoVai.ValueMember = "ID";
            cbKhoVai.DisplayMember = "KhoVai";

            cbCongviec.DataSource = DA.List_CongviecMayIn();
            cbCongviec.ValueMember = "ID";
            cbCongviec.DisplayMember = "TenCongViec";

            cbThocat.DataSource = DA.List_CongNhanCat();
            cbThocat.ValueMember = "ID";
            cbThocat.DisplayMember = "HoTen";

            txtSoSp.Text = string.Empty;
            txtGhichu.Text = string.Empty;
        }

        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2}";
            return string.Format(dateTimeFormat, datetime.Year, CheckString(datetime.Month), CheckString(datetime.Day));
        }

        private string[] GetParam()
        {
            string[] param = new string[21];
            param[0] = DateTimeSQLite(dtpNgayCong.Value);
            param[1] = cbSoMayIn.SelectedValue.ToString();
            param[2] = cbThochinh.SelectedValue.ToString();
            param[3] = cbThophu.SelectedValue.ToString();
            param[4] = DateTimeSQLite(dtpNhanIn.Value);
            param[5] = DateTimeSQLite(dtpIn.Value);
            param[6] = DateTimeSQLite(dtpInxong.Value);
            param[7] = cbKhoVai.SelectedValue.ToString();
            param[8] = cbCongviec.SelectedValue.ToString();
            param[9] = cbThocat.SelectedValue.ToString();
            param[10] = txtSoSp.Text.Trim();
            param[11] = txtInHu.Text.Trim();
            param[12] = cbThoinHu.SelectedValue.ToString();
            param[13] = txtInPhe.Text.Trim();
            param[14] = cbThoInPhe.SelectedValue.ToString();
            param[15] = txtInVayMuc.Text.Trim();
            param[16] = cbThoInVayMuc.SelectedValue.ToString();
            param[17] = txtInLoi.Text.Trim();
            param[18] = cbThoInLoi.SelectedValue.ToString();
            param[19] = txtGhichu.Text.Trim();            
            param[20] = idN2;
            return param;
        }

        private string CheckString(int number)
        {
            return number < 10 ? "0" + number.ToString() : number.ToString();
        }
    }
}

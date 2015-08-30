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
                dtpNhanIn.Value = DateTime.ParseExact(dt.Rows[0][4].ToString(), "HH:mm", CultureInfo.InvariantCulture);
                dtpIn.Value = DateTime.ParseExact(dt.Rows[0][5].ToString(), "HH:mm", CultureInfo.InvariantCulture);
                dtpInxong.Value = DateTime.ParseExact(dt.Rows[0][6].ToString(), "HH:mm", CultureInfo.InvariantCulture);
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
                    MessageBox.Show("Số lượng phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInHu.Text) && (!int.TryParse(txtInHu.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in hư phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInPhe.Text) && (!int.TryParse(txtInPhe.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in phế phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInVayMuc.Text) && (!int.TryParse(txtInVayMuc.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in vấy mực phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInLoi.Text) && (!int.TryParse(txtInLoi.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in lỗi phải là số nguyên!");
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
                    MessageBox.Show("Số lượng phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInHu.Text) && (!int.TryParse(txtInHu.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in hư phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInPhe.Text) && (!int.TryParse(txtInPhe.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in phế phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInVayMuc.Text) && (!int.TryParse(txtInVayMuc.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in vấy mực phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInLoi.Text) && (!int.TryParse(txtInLoi.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in lỗi phải là số nguyên!");
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

            cbSoMayIn.DataSource = DA.List_DsMayIn();
            cbSoMayIn.ValueMember = "ID";
            cbSoMayIn.DisplayMember = "MayIn";

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

            txtInHu.Text = string.Empty;
            cbThoinHu.DataSource = DA.List_Tho();
            cbThoinHu.ValueMember = "ID";
            cbThoinHu.DisplayMember = "HoTen";

            txtInPhe.Text = string.Empty;
            cbThoInPhe.DataSource = DA.List_Tho();
            cbThoInPhe.ValueMember = "ID";
            cbThoInPhe.DisplayMember = "HoTen";

            txtInVayMuc.Text = string.Empty;
            cbThoInVayMuc.DataSource = DA.List_Tho();
            cbThoInVayMuc.ValueMember = "ID";
            cbThoInVayMuc.DisplayMember = "HoTen";

            txtInLoi.Text = string.Empty;
            cbThoInLoi.DataSource = DA.List_Tho();
            cbThoInLoi.ValueMember = "ID";
            cbThoInLoi.DisplayMember = "HoTen";

            txtGhichu.Text = string.Empty;
        }

        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2}";
            return string.Format(dateTimeFormat, datetime.Year, CheckString(datetime.Month), CheckString(datetime.Day));
        }

        private string timeSQLite(DateTime datetime)
        {
            string timeFormat = "{0}:{1}";
            return string.Format(timeFormat, CheckString(datetime.Hour), CheckString(datetime.Minute));
        }

        private string[] GetParam()
        {
            string[] param = new string[21];
            param[0] = DateTimeSQLite(dtpNgayCong.Value);
            param[1] = cbSoMayIn.SelectedValue.ToString();
            param[2] = cbThochinh.SelectedValue.ToString();
            param[3] = cbThophu.SelectedValue.ToString();
            param[4] = timeSQLite(dtpNhanIn.Value);
            param[5] = timeSQLite(dtpIn.Value);
            param[6] = timeSQLite(dtpInxong.Value);
            param[7] = cbKhoVai.SelectedValue.ToString();
            param[8] = cbCongviec.SelectedValue.ToString();
            param[9] = cbThocat.SelectedValue.ToString();
            param[10] = string.IsNullOrEmpty(txtSoSp.Text) ? "0" : txtSoSp.Text.Trim();
            param[11] = string.IsNullOrEmpty(txtInHu.Text) ? "0" : txtInHu.Text.Trim();
            param[12] = string.IsNullOrEmpty(txtInHu.Text) || txtInHu.Text == "0" ? "0" : cbThoinHu.SelectedValue.ToString();
            param[13] = string.IsNullOrEmpty(txtInPhe.Text) ? "0" : txtInPhe.Text.Trim();
            param[14] = string.IsNullOrEmpty(txtInPhe.Text) || txtInPhe.Text == "0" ? "0" : cbThoInPhe.SelectedValue.ToString();
            param[15] = string.IsNullOrEmpty(txtInVayMuc.Text) ? "0" : txtInVayMuc.Text.Trim();
            param[16] = string.IsNullOrEmpty(txtInVayMuc.Text) || txtInVayMuc.Text == "0" ? "0" : cbThoInVayMuc.SelectedValue.ToString();
            param[17] = string.IsNullOrEmpty(txtInLoi.Text) ? "0" : txtInLoi.Text.Trim();
            param[18] = string.IsNullOrEmpty(txtInLoi.Text) || txtInLoi.Text == "0" ? "0" : cbThoInLoi.SelectedValue.ToString();
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

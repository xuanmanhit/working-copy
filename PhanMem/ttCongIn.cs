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
    public partial class ttCongIn : Form
    {
        DataAccess DA = new DataAccess();
        qlCongIn ql;
        static string idN2 = string.Empty;
        static string rowindex = string.Empty;

        public ttCongIn(string _id_rowindex, qlCongIn _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idN2 = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_CongIn(new string[] { idN2 });
                dtpNgayCong.Value = DateTime.ParseExact(dt.Rows[0][1].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                cbCongviec.SelectedValue = dt.Rows[0][2].ToString();
                txtSoSp.Text = dt.Rows[0][3].ToString();
                cbKhoVai.SelectedValue = dt.Rows[0][4].ToString();
                cbTho1.SelectedValue = dt.Rows[0][5].ToString();
                txtGio1.Text = dt.Rows[0][6].ToString();
                txtGia1.Text = dt.Rows[0][7].ToString();
                cbTho2.SelectedValue = dt.Rows[0][8].ToString();
                txtGio2.Text = dt.Rows[0][9].ToString();
                txtGia2.Text = dt.Rows[0][10].ToString();
                cbTho3.SelectedValue = dt.Rows[0][11].ToString();
                txtGio3.Text = dt.Rows[0][12].ToString();
                txtGia3.Text = dt.Rows[0][13].ToString();
                cbTho4.SelectedValue = dt.Rows[0][14].ToString();
                txtGio4.Text = dt.Rows[0][15].ToString();
                txtGia4.Text = dt.Rows[0][16].ToString();
                txtInHu.Text = dt.Rows[0][17].ToString();
                cbThoinHu.SelectedValue = dt.Rows[0][18].ToString();
                txtInPhe.Text = dt.Rows[0][19].ToString();
                cbThoInPhe.SelectedValue = dt.Rows[0][20].ToString();
                txtInVayMuc.Text = dt.Rows[0][21].ToString();
                cbThoInVayMuc.SelectedValue = dt.Rows[0][22].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Cập nhật")
            {
                int icheck;
                if (!string.IsNullOrEmpty(txtSoSp.Text) && (!int.TryParse(txtSoSp.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số lượng phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio1.Text) && (!int.TryParse(txtGio1.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ 1 phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGia1.Text) && (!int.TryParse(txtGia1.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá công thợ 1 là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio2.Text) && (!int.TryParse(txtGio2.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ 2 phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGia2.Text) && (!int.TryParse(txtGia2.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá công thợ 2 là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio3.Text) && (!int.TryParse(txtGio3.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ 3 phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGia3.Text) && (!int.TryParse(txtGia3.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá công thợ 3 là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio4.Text) && (!int.TryParse(txtGio4.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ 4 phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGia4.Text) && (!int.TryParse(txtGia4.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá công thợ 4 là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInHu.Text) && (!int.TryParse(txtInHu.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in hư phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInPhe.Text) && (!int.TryParse(txtInPhe.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in phế phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInVayMuc.Text) && (!int.TryParse(txtInVayMuc.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in vấy mực phải là số nguyên!");
                else
                {
                    DA.Edit_CongIn(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                int icheck;
                if (!string.IsNullOrEmpty(txtSoSp.Text) && (!int.TryParse(txtSoSp.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số lượng phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio1.Text) && (!int.TryParse(txtGio1.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ 1 phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGia1.Text) && (!int.TryParse(txtGia1.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá công thợ 1 là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio2.Text) && (!int.TryParse(txtGio2.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ 2 phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGia2.Text) && (!int.TryParse(txtGia2.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá công thợ 2 là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio3.Text) && (!int.TryParse(txtGio3.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ 3 phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGia3.Text) && (!int.TryParse(txtGia3.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá công thợ 3 là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGio4.Text) && (!int.TryParse(txtGio4.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giờ công thợ 4 phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtGia4.Text) && (!int.TryParse(txtGia4.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Giá công thợ 4 là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInHu.Text) && (!int.TryParse(txtInHu.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in hư phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInPhe.Text) && (!int.TryParse(txtInPhe.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in phế phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtInVayMuc.Text) && (!int.TryParse(txtInVayMuc.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Số in vấy mực phải là số nguyên!");
                else
                {
                    DA.Add_CongIn(GetParam());
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

            txtSoSp.Text = string.Empty;

            cbKhoVai.DataSource = DA.List_KhoVaiMayIn();
            cbKhoVai.ValueMember = "ID";
            cbKhoVai.DisplayMember = "KhoVai";

            cbTho1.DataSource = DA.List_Tho();
            cbTho1.ValueMember = "ID";
            cbTho1.DisplayMember = "HoTen";
            txtGio1.Text = string.Empty;
            txtGia1.Text = string.Empty;

            cbTho2.DataSource = DA.List_Tho();
            cbTho2.ValueMember = "ID";
            cbTho2.DisplayMember = "HoTen";
            txtGio2.Text = string.Empty;
            txtGia2.Text = string.Empty;

            cbTho3.DataSource = DA.List_Tho();
            cbTho3.ValueMember = "ID";
            cbTho3.DisplayMember = "HoTen";
            txtGio3.Text = string.Empty;
            txtGia3.Text = string.Empty;

            cbTho4.DataSource = DA.List_Tho();
            cbTho4.ValueMember = "ID";
            cbTho4.DisplayMember = "HoTen";
            txtGio4.Text = string.Empty;
            txtGia4.Text = string.Empty;

            txtInHu.Text = string.Empty;
            cbThoinHu.DataSource = DA.List_Tho();
            cbThoinHu.ValueMember = "ID";
            cbThoinHu.DisplayMember = "HoTen";
            cbThoinHu.SelectedValue = 0;

            txtInPhe.Text = string.Empty;
            cbThoInPhe.DataSource = DA.List_Tho();
            cbThoInPhe.ValueMember = "ID";
            cbThoInPhe.DisplayMember = "HoTen";
            cbThoInPhe.SelectedValue = 0;

            txtInVayMuc.Text = string.Empty;
            cbThoInVayMuc.DataSource = DA.List_Tho();
            cbThoInVayMuc.ValueMember = "ID";
            cbThoInVayMuc.DisplayMember = "HoTen";
            cbThoInVayMuc.SelectedValue = 0;
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
            string[] param = new string[24];
            param[0] = DateTimeSQLite(dtpNgayCong.Value);
            param[1] = cbCongviec.SelectedValue.ToString();
            param[2] = string.IsNullOrEmpty(txtSoSp.Text) ? "0" : txtSoSp.Text.Trim();
            param[3] = cbKhoVai.SelectedValue.ToString();
            param[4] = cbTho1.SelectedValue.ToString();
            param[5] = string.IsNullOrEmpty(txtGio1.Text) ? "0" : txtGio1.Text.Trim();
            param[6] = string.IsNullOrEmpty(txtGia1.Text) ? "0" : txtGia1.Text.Trim();
            param[7] = cbTho2.SelectedValue.ToString();
            param[8] = string.IsNullOrEmpty(txtGio2.Text) ? "0" : txtGio2.Text.Trim();
            param[9] = string.IsNullOrEmpty(txtGia2.Text) ? "0" : txtGia2.Text.Trim();
            param[10] = cbTho3.SelectedValue.ToString();
            param[11] = string.IsNullOrEmpty(txtGio3.Text) ? "0" : txtGio3.Text.Trim();
            param[12] = string.IsNullOrEmpty(txtGia3.Text) ? "0" : txtGia3.Text.Trim();
            param[13] = cbTho4.SelectedValue.ToString();
            param[14] = string.IsNullOrEmpty(txtGio4.Text) ? "0" : txtGio4.Text.Trim();
            param[15] = string.IsNullOrEmpty(txtGia4.Text) ? "0" : txtGia4.Text.Trim();
            param[16] = string.IsNullOrEmpty(txtInHu.Text) ? "0" : txtInHu.Text.Trim();
            param[17] = string.IsNullOrEmpty(txtInHu.Text) || txtInHu.Text == "0" ? "0" : cbThoinHu.SelectedValue.ToString();
            param[18] = string.IsNullOrEmpty(txtInPhe.Text) ? "0" : txtInPhe.Text.Trim();
            param[19] = string.IsNullOrEmpty(txtInPhe.Text) || txtInPhe.Text == "0" ? "0" : cbThoInPhe.SelectedValue.ToString();
            param[20] = string.IsNullOrEmpty(txtInVayMuc.Text) ? "0" : txtInVayMuc.Text.Trim();
            param[21] = string.IsNullOrEmpty(txtInVayMuc.Text) || txtInVayMuc.Text == "0" ? "0" : cbThoInVayMuc.SelectedValue.ToString();
            param[22] = idN2;
            return param;
        }
    }
}

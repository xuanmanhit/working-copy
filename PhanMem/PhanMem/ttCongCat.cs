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
    public partial class ttCongCat : Form
    {
        DataAccess DA = new DataAccess();
        qlCongCat ql;
        static string idCongCat = string.Empty;
        static string rowindex = string.Empty;

        public ttCongCat(string _id_rowindex, qlCongCat _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idCongCat = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_CongCat(new string[] { idCongCat });
                dtpNgayCong.Value = DateTime.ParseExact(dt.Rows[0][1].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture); ;
                cbCongNhan.SelectedValue = dt.Rows[0][2].ToString();
                cbKhoVai.SelectedValue = dt.Rows[0][3].ToString();
                txtKgCat.Text = dt.Rows[0][4].ToString();

                cbPheTH1.SelectedValue = dt.Rows[0][5].ToString();
                txtPheTH1.Text = dt.Rows[0][6].ToString();
                cbPheTH2.SelectedValue = dt.Rows[0][7].ToString();
                txtPheTH2.Text = dt.Rows[0][8].ToString();

                cbPheSuot1.SelectedValue = dt.Rows[0][9].ToString();
                txtPheSuot1.Text = dt.Rows[0][10].ToString();
                cbPheSuot2.SelectedValue = dt.Rows[0][11].ToString();
                txtPheSuot2.Text = dt.Rows[0][12].ToString();

                cbPheDC1.SelectedValue = dt.Rows[0][13].ToString();
                txtPheDC1.Text = dt.Rows[0][14].ToString();
                cbPheDC2.SelectedValue = dt.Rows[0][15].ToString();
                txtPheDC2.Text = dt.Rows[0][16].ToString();

                txtSoSP.Text = dt.Rows[0][17].ToString();
                txtPhutSP.Text = dt.Rows[0][18].ToString();
                txtCongNhat.Text = dt.Rows[0][19].ToString();
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Cập nhật")
            {
                double dcheck;
                int icheck;
                if (!string.IsNullOrEmpty(txtKgCat.Text) && (!double.TryParse(txtKgCat.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Số Kg Cắt phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheTH1.Text) && (!double.TryParse(txtPheTH1.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế TH phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheSuot1.Text) && (!double.TryParse(txtPheSuot1.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế Suốt phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheDC1.Text) && (!double.TryParse(txtPheDC1.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế ĐC phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheTH2.Text) && (!double.TryParse(txtPheTH2.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế TH phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheSuot2.Text) && (!double.TryParse(txtPheSuot2.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế Suốt phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheDC2.Text) && (!double.TryParse(txtPheDC2.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế ĐC phải là số nguyên!");
                else if (!int.TryParse(txtSoSP.Text.Trim(), out icheck) || icheck <= 0)
                    MessageBox.Show("Số lượng SP phải là số nguyên và lớn hơn 0!");
                else if (!string.IsNullOrEmpty(txtPhutSP.Text) && (!int.TryParse(txtPhutSP.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Phút SP phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtCongNhat.Text) && (!int.TryParse(txtCongNhat.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Phút Công Nhật phải là số nguyên!");
                else
                {
                    DA.Edit_CongCat(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                double dcheck;
                int icheck;
                if (!string.IsNullOrEmpty(txtKgCat.Text) && (!double.TryParse(txtKgCat.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Số Kg Cắt phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheTH1.Text) && (!double.TryParse(txtPheTH1.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế TH phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheSuot1.Text) && (!double.TryParse(txtPheSuot1.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế Suốt phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheDC1.Text) && (!double.TryParse(txtPheDC1.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế ĐC phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheTH2.Text) && (!double.TryParse(txtPheTH2.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế TH phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheSuot2.Text) && (!double.TryParse(txtPheSuot2.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế Suốt phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtPheDC2.Text) && (!double.TryParse(txtPheDC2.Text.Trim(), out dcheck) || dcheck < 0))
                    MessageBox.Show("Phế ĐC phải là số nguyên!");
                else if (!int.TryParse(txtSoSP.Text.Trim(), out icheck) || icheck <= 0)
                    MessageBox.Show("Số lượng SP phải là số nguyên và lớn hơn 0!");
                else if (!string.IsNullOrEmpty(txtPhutSP.Text) && (!int.TryParse(txtPhutSP.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Phút SP phải là số nguyên!");
                else if (!string.IsNullOrEmpty(txtCongNhat.Text) && (!int.TryParse(txtCongNhat.Text.Trim(), out icheck) || icheck < 0))
                    MessageBox.Show("Phút Công Nhật phải là số nguyên!");
                else
                {
                    DA.Add_CongCat(GetParam());
                    ql.LoadGrid();
                    this.Close();
                }
            }
        }

        private void SetDefault()
        {
            dtpNgayCong.Format = DateTimePickerFormat.Custom;
            dtpNgayCong.CustomFormat = "dd/MM/yyyy";

            cbCongNhan.DataSource = DA.List_CongNhanCat();
            cbCongNhan.ValueMember = "ID";
            cbCongNhan.DisplayMember = "HoTen";

            cbKhoVai.DataSource = DA.List_KhoVaiCat();
            cbKhoVai.ValueMember = "ID";
            cbKhoVai.DisplayMember = "KhoVai";

            txtKgCat.Text = string.Empty;

            cbPheTH1.DataSource = DA.List_CongNhanTheoViec("Dệt");
            cbPheTH1.ValueMember = "ID";
            cbPheTH1.DisplayMember = "HoTen";
            cbPheTH1.SelectedValue = 0;
            txtPheTH1.Text = string.Empty;

            cbPheTH2.DataSource = DA.List_CongNhanTheoViec("Dệt");
            cbPheTH2.ValueMember = "ID";
            cbPheTH2.DisplayMember = "HoTen";
            cbPheTH2.SelectedValue = 0;
            txtPheTH2.Text = string.Empty;

            cbPheSuot1.DataSource = DA.List_CongNhanTheoViec("Dệt");
            cbPheSuot1.ValueMember = "ID";
            cbPheSuot1.DisplayMember = "HoTen";
            cbPheSuot1.SelectedValue = 0;
            txtPheSuot1.Text = string.Empty;

            cbPheSuot2.DataSource = DA.List_CongNhanTheoViec("Dệt");
            cbPheSuot2.ValueMember = "ID";
            cbPheSuot2.DisplayMember = "HoTen";
            cbPheSuot2.SelectedValue = 0;
            txtPheSuot2.Text = string.Empty;

            cbPheDC1.DataSource = DA.List_CongNhanTheoViec("Dệt");
            cbPheDC1.ValueMember = "ID";
            cbPheDC1.DisplayMember = "HoTen";
            cbPheDC1.SelectedValue = 0;
            txtPheDC1.Text = string.Empty;

            cbPheDC2.DataSource = DA.List_CongNhanTheoViec("Dệt");
            cbPheDC2.ValueMember = "ID";
            cbPheDC2.DisplayMember = "HoTen";
            cbPheDC2.SelectedValue = 0;
            txtPheDC2.Text = string.Empty;

            txtSoSP.Text = string.Empty;
            txtPhutSP.Text = string.Empty;
            txtCongNhat.Text = string.Empty;
        }

        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2}";
            return string.Format(dateTimeFormat, datetime.Year, CheckString(datetime.Month), CheckString(datetime.Day));
        }

        private string[] GetParam()
        {
            string[] param = new string[20];
            param[0] = DateTimeSQLite(dtpNgayCong.Value);
            param[1] = cbCongNhan.SelectedValue.ToString();
            param[2] = cbKhoVai.SelectedValue.ToString();
            param[3] = txtKgCat.Text.Trim();
            param[4] = string.IsNullOrEmpty(txtPheTH1.Text) || txtPheTH1.Text == "0" ? "0" : cbPheTH1.SelectedValue.ToString();
            param[5] = string.IsNullOrEmpty(txtPheTH1.Text) ? "0" : txtPheTH1.Text.Trim();
            param[6] = string.IsNullOrEmpty(txtPheTH2.Text) || txtPheTH2.Text == "0" ? "0" : cbPheTH2.SelectedValue.ToString();
            param[7] = string.IsNullOrEmpty(txtPheTH2.Text) ? "0" : txtPheTH2.Text.Trim();
            param[8] = string.IsNullOrEmpty(txtPheSuot1.Text) || txtPheSuot1.Text == "0" ? "0" : cbPheSuot1.SelectedValue.ToString();
            param[9] = string.IsNullOrEmpty(txtPheSuot1.Text) ? "0" : txtPheSuot1.Text.Trim();
            param[10] = string.IsNullOrEmpty(txtPheSuot2.Text) || txtPheSuot2.Text == "0" ? "0" : cbPheSuot2.SelectedValue.ToString();
            param[11] = string.IsNullOrEmpty(txtPheSuot2.Text) ? "0" : txtPheSuot2.Text.Trim();
            param[12] = string.IsNullOrEmpty(txtPheDC1.Text) || txtPheDC1.Text == "0" ? "0" : cbPheDC1.SelectedValue.ToString();
            param[13] = string.IsNullOrEmpty(txtPheDC1.Text) ? "0" : txtPheDC1.Text.Trim();
            param[14] = string.IsNullOrEmpty(txtPheDC2.Text) || txtPheDC2.Text == "0" ? "0" : cbPheDC2.SelectedValue.ToString();
            param[15] = string.IsNullOrEmpty(txtPheDC2.Text) ? "0" : txtPheDC2.Text.Trim();
            param[16] = txtSoSP.Text.Trim();
            param[17] = string.IsNullOrEmpty(txtPhutSP.Text) ? "0" : txtPhutSP.Text.Trim();
            param[18] = string.IsNullOrEmpty(txtCongNhat.Text) ? "0" : txtCongNhat.Text.Trim();
            param[19] = idCongCat;
            return param;
        }

        private string CheckString(int number)
        {
            return number < 10 ? "0" + number.ToString() : number.ToString();
        }
    }
}

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
    public partial class ttKhoVai : Form
    {
        DataAccess DA = new DataAccess();
        qlKhoVai ql;
        static string idKhovai = string.Empty;
        static string rowindex = string.Empty;

        public ttKhoVai(string _id_rowindex, qlKhoVai _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idKhovai = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_KhoVai(new string[] { idKhovai });
                txtKhoVai.Text = dt.Rows[0][1].ToString();
                txtGiaDet.Text = dt.Rows[0][2].ToString();
                txtGiaCat.Text = dt.Rows[0][3].ToString();
                if (dt.Rows[0][4].ToString() != "0")
                {
                    cKhoVaiChinh.Checked = true;
                    cbKhoVaiChinh.SelectedValue = dt.Rows[0][4].ToString();
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int check;
            if (btThem.Text == "Cập nhật")
            {
                if (string.IsNullOrEmpty(txtKhoVai.Text))
                    MessageBox.Show("Vui lòng nhập tên Khổ Vải!");
                else if (!Int32.TryParse(txtGiaDet.Text.Trim(), out check) || check < 0)
                    MessageBox.Show("Đơn giá Dệt chỉ nhập số nguyên dương!");
                else if (!Int32.TryParse(txtGiaCat.Text.Trim(), out check) || check < 0)
                    MessageBox.Show("Đơn giá Cắt chỉ nhập số nguyên dương!");
                else
                {
                    DA.Edit_KhoVai(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtKhoVai.Text))
                    MessageBox.Show("Vui lòng nhập tên Khổ Vải!");
                else if (!string.IsNullOrEmpty(txtGiaDet.Text) && (!Int32.TryParse(txtGiaDet.Text.Trim(), out check) || check < 0))
                    MessageBox.Show("Đơn giá Dệt chỉ nhập số nguyên dương!");
                else if (!string.IsNullOrEmpty(txtGiaCat.Text) && (!Int32.TryParse(txtGiaCat.Text.Trim(), out check) || check < 0))
                    MessageBox.Show("Đơn giá Cắt chỉ nhập số nguyên dương!");
                else
                {
                    DA.Add_KhoVai(GetParam());
                    ql.LoadGrid();
                    this.Close();
                }
            }
        }

        private void SetDefault()
        {
            txtKhoVai.Text = string.Empty;
            txtGiaDet.Text = string.Empty;
            txtGiaCat.Text = string.Empty;
            cKhoVaiChinh.Checked = false;
            cbKhoVaiChinh.DataSource = DA.List_KhoVaiChinh();
            cbKhoVaiChinh.DisplayMember = "KhoVai";
            cbKhoVaiChinh.ValueMember = "ID";
        }

        private string[] GetParam()
        {
            string[] param = new string[5];
            param[0] = txtKhoVai.Text.Trim();
            param[1] = string.IsNullOrEmpty(txtGiaDet.Text) ? "0" : txtGiaDet.Text.Trim();
            param[2] = string.IsNullOrEmpty(txtGiaCat.Text) ? "0" : txtGiaCat.Text.Trim();
            param[3] = cKhoVaiChinh.Checked ? cbKhoVaiChinh.SelectedValue.ToString() : "0";
            param[4] = idKhovai;
            return param;
        }
    }
}

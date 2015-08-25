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
    public partial class ttThoMayIn : Form
    {
        DataAccess DA = new DataAccess();
        qlThoMayIn ql;
        static string idTho = string.Empty;
        static string rowindex = string.Empty;

        public ttThoMayIn(string _id_rowindex, qlThoMayIn _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idTho = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_ThoMayIn(new string[] { idTho });
                txtHoTen.Text = dt.Rows[0][1].ToString();
                txtSoTho.Text = dt.Rows[0][2].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Cập nhật")
            {
                int icheck;
                if (string.IsNullOrEmpty(txtHoTen.Text))
                    MessageBox.Show("Họ Tên không được để trống!");
                else if (!string.IsNullOrEmpty(txtSoTho.Text) && (!int.TryParse(txtSoTho.Text.Trim(), out icheck) || icheck <= 0))
                    MessageBox.Show("Số thợ phải là số nguyên và lớn hơn 0!");
                else
                {

                    DA.Edit_ThoMayIn(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                int icheck;
                if (string.IsNullOrEmpty(txtHoTen.Text))
                    MessageBox.Show("Họ Tên không được để trống!");
                else if (!string.IsNullOrEmpty(txtSoTho.Text) && (!int.TryParse(txtSoTho.Text.Trim(), out icheck) || icheck <= 0))
                    MessageBox.Show("Số thợ phải là số nguyên và lớn hơn 0!");
                else
                {
                    DA.Add_ThoMayIn(GetParam());
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
            txtSoTho.Text = string.Empty;
        }

        private string[] GetParam()
        {
            string[] param = new string[3];
            param[0] = txtHoTen.Text.Trim();
            param[1] = string.IsNullOrEmpty(txtSoTho.Text) ? "1" : txtSoTho.Text.Trim();
            param[2] = idTho;
            return param;
        }
    }
}

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
    public partial class ttMayIn : Form
    {
        DataAccess DA = new DataAccess();
        qlMayIn ql;
        static string idmayin = string.Empty;
        static string rowindex = string.Empty;

        public ttMayIn(string _id_rowindex, qlMayIn _ql)
        {
            InitializeComponent();
            SetDefault();
            ql = _ql;
            if (!string.IsNullOrEmpty(_id_rowindex))
            {
                idmayin = _id_rowindex.Split('_').GetValue(0).ToString();
                rowindex = _id_rowindex.Split('_').GetValue(1).ToString();
                btThem.Text = "Cập nhật";
                DataTable dt = DA.Load_MayIn(new string[] { idmayin });
                txtMayIn.Text = dt.Rows[0][1].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Cập nhật")
            {
                if (string.IsNullOrEmpty(txtMayIn.Text))
                    MessageBox.Show("Tên máy in không được để trống!");
                else
                {

                    DA.Edit_MayIn(GetParam());
                    ql.LoadGridAndSelect(Convert.ToInt32(rowindex));
                    this.Close();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtMayIn.Text))
                    MessageBox.Show("Tên máy in không được để trống!");
                else
                {
                    DA.Add_MayIn(GetParam());
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
            txtMayIn.Text = string.Empty;
        }

        private string[] GetParam()
        {
            string[] param = new string[2];
            param[0] = txtMayIn.Text.Trim();
            param[1] = idmayin;
            return param;
        }
    }
}

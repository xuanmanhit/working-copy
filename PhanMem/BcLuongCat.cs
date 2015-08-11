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
    public partial class BcLuongCat : Form
    {
        DataAccess DA = new DataAccess();

        public BcLuongCat()
        {
            InitializeComponent();
            SetDefault();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void BcLuongCat_Load(object sender, EventArgs e)
        {
            DA.Edit_ThamSo(GetParam());
            LoadGrid();
        }

        public void LoadGrid()
        {
            gvLuong.AutoGenerateColumns = false;
            gvLuong.DataSource = DA.DsLuongCat();
        }

        private void SetDefault()
        {
            dtpTuNgay.Value = DateTime.Today;
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";

            dtpDenNgay.Value = DateTime.Today;
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
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

        private void btXem_Click(object sender, EventArgs e)
        {
            DA.Edit_ThamSo(GetParam());
            LoadGrid();
        }

        private void btExport_Click(object sender, EventArgs e)
        {

        }

        private string[] GetParam()
        {
            string[] param = new string[3];
            param[0] = DateTimeSQLite(dtpTuNgay.Value);
            param[1] = DateTimeSQLite(dtpDenNgay.Value);
            param[2] = "1";
            return param;
        }

        private void gvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

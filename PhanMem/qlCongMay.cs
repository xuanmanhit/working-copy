using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanMem
{
    public partial class qlCongMay : Form
    {
        DataAccess DA = new DataAccess();

        public qlCongMay()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttCongMay("", this);
            thongtin.ShowDialog();
        }

        private void qlCongMayInN1_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void gvCongN1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvCongN1.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttCongMay(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvCongN1.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Công này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_CongMay(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        public void LoadGrid()
        {
            int rownum = DA.List_CongMay().Rows.Count;
            label4.Text = "Danh sách Công May: " + rownum;
            gvCongN1.AutoGenerateColumns = false;
            gvCongN1.DataSource = DA.List_CongMay();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_CongMay().Rows.Count;
            label4.Text = "Danh sách Công May: " + rownum;
            gvCongN1.AutoGenerateColumns = false;
            gvCongN1.DataSource = DA.List_CongMay();
            gvCongN1.Rows[rowindex].Selected = true;
            gvCongN1.FirstDisplayedScrollingRowIndex = rowindex;
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            int numResult = 0;
            try
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                    DataTable dt = new DataTable();
                    dt = WorksheetToDataTable(worksheet);
                    //0:NgayCong, 2:Tho1, 3:Tho2, 9:CongViec, 10:KhoVai, 11:KhoVaiChinh, 12:KH, 13:SanPham, 14:GiaSP,
                    //15:PhutSP1, 16:GiaSP1, 17:PhutSP2, 18:GiaSP2
                    //19:PheThuong, 20:InHu, 21:VayMuc, 22:Ghichu

                    //0:NgayCong, 1:Tho1, 2:Tho2, 3:CongViec, 4:KhoVaiChinh, 5:SanPham, 6:GiaSP,
                    //7:PhutSP1, 8:GiaSP1, 9:PhutSP2, 10:GiaSP2, 11:Ghichu

                    foreach (DataRow row in dt.Rows)
                    {
                        if (!string.IsNullOrEmpty(row[4].ToString()))
                        {
                            string[] param = new string[13];
                            param[0] = DateTimeSQLite(Convert.ToDateTime(row[0]));
                            param[1] = DA.Find_ViecMayIn(row[3].ToString().Trim());
                            param[2] = string.IsNullOrEmpty(row[5].ToString().Trim()) ? "0" : row[5].ToString().Trim();
                            param[3] = string.IsNullOrEmpty(row[6].ToString().Trim()) ? "0" : row[6].ToString().Trim();
                            param[4] = DA.Find_KhoVai(row[4].ToString().Trim());
                            param[5] = DA.Find_ThoMayIn(row[1].ToString().Trim());
                            param[6] = string.IsNullOrEmpty(row[7].ToString().Trim()) ? "0" : row[7].ToString().Trim();
                            param[7] = string.IsNullOrEmpty(row[8].ToString().Trim()) ? "0" : row[8].ToString().Trim();
                            param[8] = string.IsNullOrEmpty(row[2].ToString().Trim()) ? "0" : DA.Find_ThoMayIn(row[2].ToString().Trim());
                            param[9] = string.IsNullOrEmpty(row[9].ToString().Trim()) ? "0" : row[9].ToString().Trim();
                            param[10] = string.IsNullOrEmpty(row[10].ToString().Trim()) ? "0" : row[10].ToString().Trim();
                            param[11] = row[11].ToString().Trim();
                            DA.Add_CongMay(param);
                            numResult++;
                        }
                    }
                }
                LoadGrid();
                MessageBox.Show("Hệ thống đã nhập dữ liệu từ file vào thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình nhập dữ liệu ở dòng thứ " + numResult + 1 + "!\n" + ex.ToString());
            }
        }

        private DataTable WorksheetToDataTable(ExcelWorksheet oSheet)
        {
            int totalRows = oSheet.Dimension.End.Row;
            int totalCols = oSheet.Dimension.End.Column;
            DataTable dt = new DataTable(oSheet.Name);
            DataRow dr = null;
            for (int i = 1; i <= totalRows; i++)
            {
                if (i > 1) dr = dt.Rows.Add();
                for (int j = 1; j <= totalCols; j++)
                {
                    if (i == 1)
                        dt.Columns.Add(oSheet.Cells[i, j].Value.ToString());
                    else
                        dr[j - 1] = oSheet.Cells[i, j].Value == null ? "" : oSheet.Cells[i, j].Value.ToString();
                }
            }
            return dt;
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
    }
}

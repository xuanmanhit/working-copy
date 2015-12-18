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
    public partial class qlCongIn : Form
    {
        DataAccess DA = new DataAccess();

        public qlCongIn()
        {
            InitializeComponent();
        }

        private void qlCongMayInN2_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttCongIn("", this);
            thongtin.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void gvCongN2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvCongN2.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttCongIn(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvCongN2.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Công này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_CongIn(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        public void LoadGrid()
        {
            int rownum = DA.List_CongIn().Rows.Count;
            label4.Text = "Danh sách Công In: " + rownum;
            gvCongN2.AutoGenerateColumns = false;
            gvCongN2.DataSource = DA.List_CongIn();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_CongIn().Rows.Count;
            label4.Text = "Danh sách Công In: " + rownum;
            gvCongN2.AutoGenerateColumns = false;
            gvCongN2.DataSource = DA.List_CongIn();
            gvCongN2.Rows[rowindex].Selected = true;
            gvCongN2.FirstDisplayedScrollingRowIndex = rowindex;
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
                    //0:NgayCong, 2:Tho1, 3:Tho2, 4:Tho3, 5:Tho4, 8:CongViec, 9:KhoVai, 10:KhoVaiChinh, 11:KH, 12:SanPham,
                    //13:GioTho1, 14:GiaTho1, 15:GioTho2, 16:GiaTho2, 17:GioTho3, 18:GiaTho3, 19:GioTho4, 20:GiaTho4,
                    //21:ThoPheThuong, 22:PheThuong, 23:ThoInHu, 24:InHu, 25:ThoVayMuc, 26:VayMuc, 27:Ghichu

                    //0:NgayCong, 1:Tho1, 2:Tho2, 3:Tho3, 4:Tho4, 5:CongViec, 6:KhoVaiChinh, 7:SanPham,
                    //8:GioTho1, 9:GiaTho1, 10:GioTho2, 11:GiaTho2, 12:GioTho3, 13:GiaTho3, 14:GioTho4, 15:GiaTho4,
                    //16:ThoInHu, 17:InHu, 18:ThoPheThuong, 19:PheThuong, 20:ThoVayMuc, 21:VayMuc, 22:Ghichu

                    foreach (DataRow row in dt.Rows)
                    {
                        //if (!string.IsNullOrEmpty(row[6].ToString()))
                        //{
                            string[] param = new string[24];
                            param[0] = DateTimeSQLite(Convert.ToDateTime(row[0]));
                            param[1] = DA.Find_ViecMayIn(row[5].ToString().Trim());
                            param[2] = string.IsNullOrEmpty(row[7].ToString().Trim()) ? "0" : row[7].ToString().Trim();
                            param[3] = string.IsNullOrEmpty(row[6].ToString().Trim()) ? "0" : DA.Find_KhoVai(row[6].ToString().Trim());
                            param[4] = DA.Find_ThoMayIn(row[1].ToString().Trim());
                            param[5] = string.IsNullOrEmpty(row[8].ToString().Trim()) ? "0" : row[8].ToString().Trim();
                            param[6] = string.IsNullOrEmpty(row[9].ToString().Trim()) ? "0" : row[9].ToString().Trim();
                            param[7] = string.IsNullOrEmpty(row[2].ToString().Trim()) ? "0" : DA.Find_ThoMayIn(row[2].ToString().Trim());
                            param[8] = string.IsNullOrEmpty(row[10].ToString().Trim()) ? "0" : row[10].ToString().Trim();
                            param[9] = string.IsNullOrEmpty(row[11].ToString().Trim()) ? "0" : row[11].ToString().Trim();
                            param[10] = string.IsNullOrEmpty(row[3].ToString().Trim()) ? "0" : DA.Find_ThoMayIn(row[3].ToString().Trim());
                            param[11] = string.IsNullOrEmpty(row[12].ToString().Trim()) ? "0" : row[12].ToString().Trim();
                            param[12] = string.IsNullOrEmpty(row[13].ToString().Trim()) ? "0" : row[13].ToString().Trim();
                            param[13] = string.IsNullOrEmpty(row[4].ToString().Trim()) ? "0" : DA.Find_ThoMayIn(row[4].ToString().Trim());
                            param[14] = string.IsNullOrEmpty(row[14].ToString().Trim()) ? "0" : row[14].ToString().Trim();
                            param[15] = string.IsNullOrEmpty(row[15].ToString().Trim()) ? "0" : row[15].ToString().Trim();
                            param[16] = string.IsNullOrEmpty(row[17].ToString().Trim()) ? "0" : row[17].ToString().Trim();
                            param[17] = string.IsNullOrEmpty(row[16].ToString().Trim()) ? "0" : DA.Find_ThoMayIn(row[16].ToString().Trim());
                            param[18] = string.IsNullOrEmpty(row[19].ToString().Trim()) ? "0" : row[19].ToString().Trim();
                            param[19] = string.IsNullOrEmpty(row[18].ToString().Trim()) ? "0" : DA.Find_ThoMayIn(row[18].ToString().Trim());
                            param[20] = string.IsNullOrEmpty(row[21].ToString().Trim()) ? "0" : row[21].ToString().Trim();
                            param[21] = string.IsNullOrEmpty(row[20].ToString().Trim()) ? "0" : DA.Find_ThoMayIn(row[20].ToString().Trim());
                            param[22] = row[22].ToString();
                            DA.Add_CongIn(param);
                            numResult++;
                        //}
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

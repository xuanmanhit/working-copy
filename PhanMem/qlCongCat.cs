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
    public partial class qlCongCat : Form
    {
        DataAccess DA = new DataAccess();

        public qlCongCat()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            var main = new FormMain();
            main.Show();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var thongtin = new ttCongCat("", this);
            thongtin.ShowDialog();
        }

        public void LoadGrid()
        {
            int rownum = DA.List_CongCat().Rows.Count;
            label4.Text = "Danh sách Công Cắt: " + rownum;
            gvCongCat.AutoGenerateColumns = false;
            gvCongCat.DataSource = DA.List_CongCat();
        }

        public void LoadGridAndSelect(int rowindex)
        {
            int rownum = DA.List_CongCat().Rows.Count;
            label4.Text = "Danh sách Công Cắt: " + rownum;
            gvCongCat.AutoGenerateColumns = false;
            gvCongCat.DataSource = DA.List_CongCat();
            gvCongCat.Rows[rowindex].Selected = true;
            gvCongCat.FirstDisplayedScrollingRowIndex = rowindex;
        }

        private void gvCongCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sửa
            if (e.ColumnIndex == 0)
            {
                string _id_rowindex = gvCongCat.Rows[e.RowIndex].Cells[2].Value.ToString();
                _id_rowindex += "_" + e.RowIndex;
                var thongtin = new ttCongCat(_id_rowindex, this);
                thongtin.ShowDialog();
            }

            // Xóa
            if (e.ColumnIndex == 1)
            {
                string _id = gvCongCat.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Công Cắt này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DA.Del_CongCat(new string[] { _id });
                    LoadGrid();
                }
            }
        }

        private void qlCongCat_Load(object sender, EventArgs e)
        {
            LoadGrid();
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
                    //0:NgayCong,1:CongNhan,2:CongViec,3:KhoVai,4:KhoVaiChinh,5:SoKgCat,6:NgayDet,7:SoluongSP,8:PhutSP,9:PhutCongNhat,
                    //10:ThoPheThuong1,11:PheThuong1,12:ThoPheThuong2,13:PheThuong2,
                    //14:ThoPheSuot,15:PheSuot,16:ThoPheDauCay,17:PheDauCay,

                    //0:NgayCong,1:CongNhan,2:KhoVai,3:SoKgCat,4:SoluongSP,5:PhutSP,6:PhutCongNhat,
                    //7:CN_PT_1, 8:PT_1, 9:CN_PT_2, 10:PT_2, 11:CN_PS, 12:PS, 13:CN_PDC, 14:PDC,
                                        
                    foreach (DataRow row in dt.Rows)
                    {
                        if (!string.IsNullOrEmpty(row[2].ToString()))
                        {
                            string[] param = new string[20];
                            param[0] = DateTimeSQLite(Convert.ToDateTime(row[0]));
                            param[1] = DA.Find_CongNhan(row[1].ToString().Trim());
                            param[2] = DA.Find_KhoVai(row[2].ToString().Trim());
                            param[3] = string.IsNullOrEmpty(row[3].ToString().Trim()) ? "0" : row[3].ToString().Trim();
                            param[4] = string.IsNullOrEmpty(row[7].ToString().Trim()) ? "0" : DA.Find_CongNhan2(row[7].ToString().Trim());
                            param[5] = string.IsNullOrEmpty(row[8].ToString().Trim()) ? "0" : row[8].ToString().Trim();
                            param[6] = string.IsNullOrEmpty(row[9].ToString().Trim()) ? "0" : DA.Find_CongNhan2(row[9].ToString().Trim());
                            param[7] = string.IsNullOrEmpty(row[10].ToString().Trim()) ? "0" : row[10].ToString().Trim();
                            param[8] = string.IsNullOrEmpty(row[11].ToString().Trim()) ? "0" : DA.Find_CongNhan2(row[11].ToString().Trim());
                            param[9] = string.IsNullOrEmpty(row[12].ToString().Trim()) ? "0" : row[12].ToString().Trim();
                            param[10] = "0";
                            param[11] = "0";
                            param[12] = string.IsNullOrEmpty(row[13].ToString().Trim()) ? "0" : DA.Find_CongNhan2(row[13].ToString().Trim());
                            param[13] = string.IsNullOrEmpty(row[14].ToString().Trim()) ? "0" : row[14].ToString().Trim();
                            param[14] = "0";
                            param[15] = "0";
                            param[16] = string.IsNullOrEmpty(row[4].ToString().Trim()) ? "0" : row[4].ToString().Trim();
                            param[17] = string.IsNullOrEmpty(row[5].ToString().Trim()) ? "0" : row[5].ToString().Trim();
                            param[18] = string.IsNullOrEmpty(row[6].ToString().Trim()) ? "0" : row[6].ToString().Trim();
                            DA.Add_CongCat(param);
                            numResult++;
                        }
                    }
                }
                LoadGrid();
                MessageBox.Show("Hệ thống đã nhập dữ liệu từ file vào thành công " + numResult + " dòng dữ liệu");
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

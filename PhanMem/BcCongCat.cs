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
    public partial class BcCongCat : Form
    {
        DataAccess DA = new DataAccess();

        public BcCongCat()
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

        private void BcCongCat_Load(object sender, EventArgs e)
        {
            LoadGrid(DateTimeSQLite(dtpNgayCong.Value));
        }

        public void LoadGrid(string ngayCong)
        {
            gvBaoCaoNgay.AutoGenerateColumns = false;
            gvBaoCaoNgay.DataSource = DA.ChiTietCongCat(ngayCong);
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            LoadGrid(DateTimeSQLite(dtpNgayCong.Value));
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            try
            {
                sfdXuatExcel.FileName = "Cat-Ngay-" + DateTimeSQLite(dtpNgayCong.Value) + ".xlsx";
                sfdXuatExcel.Filter = "Excel File|*.xlsx";
                if (sfdXuatExcel.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfdXuatExcel.FileName))
                        File.Delete(sfdXuatExcel.FileName);
                    string source = DA.SourceFile() + @"Data\Cat-Ngay.xlsx";
                    string des = @"D:\Cat-Ngay.xlsx";
                    if (File.Exists(des))
                        File.Delete(des);
                    string newdes = sfdXuatExcel.FileName;
                    File.Copy(source, des);

                    using (ExcelPackage package = new ExcelPackage(new FileInfo(des)))
                    {
                        DataTable dt = DA.ChiTietCongCat(DateTimeSQLite(dtpNgayCong.Value));
                        DataTable dtth = DA.TongHopCongCat(DateTimeSQLite(dtpNgayCong.Value));

                        ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                        worksheet.Name = "Chi tiết ngày cắt";
                        int rowCount = dt.Rows.Count;
                        int rowCountTH = dtth.Rows.Count;
                        worksheet.Cells[2, 1].Value = "Ngày: " + dtpNgayCong.Text;
                        worksheet.Cells["M2"].Value = "Ngày: " + dtpNgayCong.Text;

                        for (int i = 0; i < rowCount; i++)
                        {
                            worksheet.Cells[i + 6, 1].Value = Convert.ToInt32(dt.Rows[i]["STT"].ToString());
                            worksheet.Cells[i + 6, 2].Value = dt.Rows[i]["CongViec"].ToString();
                            worksheet.Cells[i + 6, 3].Value = dt.Rows[i]["HoTen"].ToString();
                            worksheet.Cells[i + 6, 4].Value = double.Parse(dt.Rows[i]["TongKgCat"].ToString());
                            worksheet.Cells[i + 6, 5].Value = Convert.ToInt32(dt.Rows[i]["TongOng"].ToString());
                            worksheet.Cells[i + 6, 6].Value = double.Parse(dt.Rows[i]["TongSpTruPhe"].ToString());
                            worksheet.Cells[i + 6, 7].Value = Convert.ToInt32(dt.Rows[i]["TongSoLuongSP"].ToString());
                            worksheet.Cells[i + 6, 8].Value = Convert.ToInt32(dt.Rows[i]["DonGia"].ToString());
                            worksheet.Cells[i + 6, 9].Value = Convert.ToInt32(dt.Rows[i]["TienSP"].ToString());
                            worksheet.Cells[i + 6, 10].Value = Convert.ToInt32(dt.Rows[i]["TienCong"].ToString());
                            worksheet.Cells[i + 6, 11].Value = Convert.ToInt32(dt.Rows[i]["TienCongPhu"].ToString());
                        }

                        for (int i = 0; i < rowCountTH; i++)
                        {
                            worksheet.Cells[i + 6, 13].Value = dtth.Rows[i]["HoTen"].ToString();
                            worksheet.Cells[i + 6, 14].Value = Convert.ToInt32(dtth.Rows[i]["TienSP"].ToString());
                            worksheet.Cells[i + 6, 15].Value = Convert.ToInt32(dtth.Rows[i]["TienCong"].ToString());
                            worksheet.Cells[i + 6, 16].Value = Convert.ToInt32(dtth.Rows[i]["TienCongPhu"].ToString());
                            worksheet.Cells[i + 6, 17].Value = Convert.ToInt32(dtth.Rows[i]["TongTien"].ToString());
                        }

                        worksheet.Cells[5, 4].Value = double.Parse(dt.Compute("SUM(TongKgCat)", "").ToString());
                        worksheet.Cells[5, 5].Value = Convert.ToInt32(dt.Compute("SUM(TongOng)", ""));
                        worksheet.Cells[5, 6].Value = double.Parse(dt.Compute("SUM(TongSpTruPhe)", "").ToString());
                        worksheet.Cells[5, 7].Value = Convert.ToInt32(dt.Compute("SUM(TongSoLuongSP)", ""));
                        worksheet.Cells[5, 9].Value = Convert.ToInt32(dt.Compute("SUM(TienSP)", ""));
                        worksheet.Cells[5, 10].Value = Convert.ToInt32(dt.Compute("SUM(TienCong)", ""));
                        worksheet.Cells[5, 11].Value = Convert.ToInt32(dt.Compute("SUM(TienCongPhu)", ""));

                        worksheet.Cells[5, 14].Value = Convert.ToInt32(dtth.Compute("SUM(TienSP)", ""));
                        worksheet.Cells[5, 15].Value = Convert.ToInt32(dtth.Compute("SUM(TienCong)", ""));
                        worksheet.Cells[5, 16].Value = Convert.ToInt32(dtth.Compute("SUM(TienCongPhu)", ""));
                        worksheet.Cells[5, 17].Value = Convert.ToInt32(dtth.Compute("SUM(TongTien)", ""));

                        worksheet.Column(7).Style.Numberformat.Format = "#,##0";
                        worksheet.Column(9).Style.Numberformat.Format = "#,##0";
                        worksheet.Column(10).Style.Numberformat.Format = "#,##0";
                        worksheet.Column(11).Style.Numberformat.Format = "#,##0";
                        worksheet.Column(14).Style.Numberformat.Format = "#,##0";
                        worksheet.Column(15).Style.Numberformat.Format = "#,##0";
                        worksheet.Column(16).Style.Numberformat.Format = "#,##0";
                        worksheet.Column(17).Style.Numberformat.Format = "#,##0";

                        // fill dữ liệu vào sheet xuất nhập tồn
                        ExcelWorksheet ew = package.Workbook.Worksheets["Sheet2"];
                        DA.Edit_ThamSo(GetParam());
                        DataTable dtxnt = DA.TongHopCat();
                        int xntCount = dtxnt.Rows.Count;
                        ew.Name = "Xuất Nhập Tồn";
                        ew.Cells[2, 1].Value = "Ngày: " + dtpNgayCong.Text;

                        for (int i = 0; i < xntCount; i++)
                        {
                            ew.Cells[i + 6, 1].Value = Convert.ToInt32(dtxnt.Rows[i]["STT"].ToString());
                            ew.Cells[i + 6, 2].Value = dtxnt.Rows[i]["KhoVai"].ToString();
                            ew.Cells[i + 6, 7].Value = double.Parse(dtxnt.Rows[i]["TongKgCat"].ToString());
                            ew.Cells[i + 6, 8].Value = Convert.ToInt32(dtxnt.Rows[i]["TongOng"].ToString());
                            ew.Cells[i + 6, 9].Value = Convert.ToInt32(dtxnt.Rows[i]["TongSP"].ToString());
                        }

                        ew.Cells[5, 7].Value = double.Parse(dtxnt.Compute("SUM(TongKgCat)", "").ToString());
                        ew.Cells[5, 8].Value = Convert.ToInt32(dtxnt.Compute("SUM(TongOng)", ""));
                        ew.Cells[5, 9].Value = Convert.ToInt32(dtxnt.Compute("SUM(TongSP)", ""));

                        // format theo phần ngàn
                        ew.Cells[5, 3, xntCount + 5, 11].Style.Numberformat.Format = "#,##0";

                        package.Save();

                        File.Move(des, newdes);
                        MessageBox.Show("Đã xuất file thành công, đường dẫn: " + newdes);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Quá trình xuất excel có lỗi, nếu bạn đang mở file excel, hãy đóng nó lại!");
            }
        }

        private void SetDefault()
        {
            dtpNgayCong.Value = DateTime.Today;
            dtpNgayCong.Format = DateTimePickerFormat.Custom;
            dtpNgayCong.CustomFormat = "dd/MM/yyyy";
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
            string[] param = new string[3];
            param[0] = "0";
            param[1] = DateTimeSQLite(dtpNgayCong.Value);
            param[2] = "0";
            return param;
        }
    }
}

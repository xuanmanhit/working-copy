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
    public partial class BcLuongCat : Form
    {
        DataAccess DA = new DataAccess();
        static string idCongNhan = "0";

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

        private void LoadGrid()
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
            if (dtpTuNgay.Value.Month != dtpDenNgay.Value.Month)
                MessageBox.Show("Thời gian xem phải chọn trong cùng một tháng!");
            else
            {
                DA.Edit_ThamSo(GetParam());
                LoadGrid();
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Month != dtpDenNgay.Value.Month)
                MessageBox.Show("Thời gian xem phải chọn trong cùng một tháng!");
            else
            {
                try
                {
                    DA.Edit_ThamSo(GetParam());
                    sfdXuatExcel.FileName = "Cat-Luong-TH-" + DateTimeSQLite(dtpTuNgay.Value) + "-" + DateTimeSQLite(dtpDenNgay.Value) + ".xlsx";
                    sfdXuatExcel.Filter = "Excel File|*.xlsx";
                    if (sfdXuatExcel.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfdXuatExcel.FileName))
                            File.Delete(sfdXuatExcel.FileName);
                        string source = DA.SourceFile() + @"Data\Cat-Luong-TH.xlsx";
                        string des = @"D:\Cat-Luong-TH.xlsx";
                        if (File.Exists(des))
                            File.Delete(des);
                        string newdes = sfdXuatExcel.FileName;
                        File.Copy(source, des);

                        using (ExcelPackage package = new ExcelPackage(new FileInfo(des)))
                        {
                            DataTable dt = DA.DsLuongCat();

                            ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                            int rowCount = dt.Rows.Count;
                            worksheet.Name = "Lương tổng hợp";
                            worksheet.Cells[2, 8].Value = "Từ ngày: " + dtpTuNgay.Text + " đến ngày: " + dtpDenNgay.Text;

                            for (int i = 0; i < rowCount; i++)
                            {
                                worksheet.Cells[i + 5, 1].Value = Convert.ToInt32(dt.Rows[i]["STT"].ToString());
                                worksheet.Cells[i + 5, 2].Value = dt.Rows[i]["HoTen"].ToString();
                                worksheet.Cells[i + 5, 3].Value = Convert.ToInt32(dt.Rows[i]["TongOng"].ToString());
                                worksheet.Cells[i + 5, 4].Value = double.Parse(dt.Rows[i]["TongPhe"].ToString());
                                worksheet.Cells[i + 5, 5].Value = double.Parse(dt.Rows[i]["TongKgCat"].ToString());
                                worksheet.Cells[i + 5, 6].Value = double.Parse(dt.Rows[i]["TongSpTruPhe"].ToString());
                                worksheet.Cells[i + 5, 7].Value = Convert.ToInt32(dt.Rows[i]["TongSoLuongSP"].ToString());
                                worksheet.Cells[i + 5, 8].Value = Convert.ToInt32(dt.Rows[i]["TienSP"].ToString());
                                worksheet.Cells[i + 5, 9].Value = Convert.ToInt32(dt.Rows[i]["TienCong"].ToString());
                                worksheet.Cells[i + 5, 10].Value = Convert.ToInt32(dt.Rows[i]["TienCongPhu"].ToString());
                                worksheet.Cells[i + 5, 11].Value = Convert.ToInt32(dt.Rows[i]["TongTien"].ToString());
                            }

                            worksheet.Column(3).Style.Numberformat.Format = "#,##0";
                            worksheet.Column(4).Style.Numberformat.Format = "#,##0";
                            worksheet.Column(5).Style.Numberformat.Format = "#,##0";
                            worksheet.Column(6).Style.Numberformat.Format = "#,##0";
                            worksheet.Column(7).Style.Numberformat.Format = "#,##0";
                            worksheet.Column(8).Style.Numberformat.Format = "#,##0";
                            worksheet.Column(9).Style.Numberformat.Format = "#,##0";
                            worksheet.Column(10).Style.Numberformat.Format = "#,##0";
                            worksheet.Column(11).Style.Numberformat.Format = "#,##0";

                            for (int i = 0; i < rowCount; i++)
                            {
                                idCongNhan = dt.Rows[i]["CongNhan"].ToString();
                                DA.Edit_ThamSo(GetParam());
                                DataTable dtct = DA.LuongCatChiTiet();
                                DataTable dtth = DA.LuongCatTongHop();
                                int rownum = dtct.Rows.Count;
                                int rownum2 = dtth.Rows.Count;
                                string sheetname = "Chi tiết lương " + dt.Rows[i]["HoTen"].ToString();
                                ExcelWorksheet ew = package.Workbook.Worksheets.Add(sheetname, package.Workbook.Worksheets["Sheet2"]);
                                ew.Cells[2, 2].Value = dt.Rows[i]["HoTen"].ToString();
                                ew.Cells[2, 11].Value = "Từ ngày: " + dtpTuNgay.Text + " đến ngày: " + dtpDenNgay.Text;
                                for (int n = 0; n < rownum; n++)
                                {
                                    ew.Cells[n + 6, 1].Value = dtct.Rows[n]["NgayCong"].ToString();
                                    ew.Cells[n + 6, 2].Value = dtct.Rows[n]["CongViec"].ToString();
                                    ew.Cells[n + 6, 3].Value = Convert.ToInt32(dtct.Rows[n]["TongOng"].ToString());
                                    ew.Cells[n + 6, 4].Value = double.Parse(dtct.Rows[n]["TongPhe"].ToString());
                                    ew.Cells[n + 6, 5].Value = double.Parse(dtct.Rows[n]["TongKgCat"].ToString());
                                    ew.Cells[n + 6, 6].Value = double.Parse(dtct.Rows[n]["TongSpTruPhe"].ToString());
                                    ew.Cells[n + 6, 7].Value = Convert.ToInt32(dtct.Rows[n]["TongSoLuongSP"].ToString());
                                    ew.Cells[n + 6, 8].Value = Convert.ToInt32(dtct.Rows[n]["DonGia"].ToString());
                                    ew.Cells[n + 6, 9].Value = Convert.ToInt32(dtct.Rows[n]["TienSP"].ToString());
                                }

                                for (int k = 0; k < rownum2; k++)
                                {
                                    ew.Cells[k + 6, 11].Value = dtth.Rows[k]["NgayCong"].ToString();
                                    ew.Cells[k + 6, 12].Value = Convert.ToInt32(dtth.Rows[k]["TienSP"].ToString());
                                    ew.Cells[k + 6, 13].Value = Convert.ToInt32(dtth.Rows[k]["TienCong"].ToString());
                                    ew.Cells[k + 6, 14].Value = Convert.ToInt32(dtth.Rows[k]["TienCongPhu"].ToString());
                                    ew.Cells[k + 6, 15].Value = Convert.ToInt32(dtth.Rows[k]["TongTien"].ToString());
                                }

                                ew.Cells[5, 3].Value = Convert.ToInt32(dtct.Compute("SUM(TongOng)", "").ToString());
                                ew.Cells[5, 4].Value = double.Parse(dtct.Compute("SUM(TongPhe)", "").ToString());
                                ew.Cells[5, 5].Value = double.Parse(dtct.Compute("SUM(TongKgCat)", "").ToString());
                                ew.Cells[5, 6].Value = double.Parse(dtct.Compute("SUM(TongSpTruPhe)", "").ToString());
                                ew.Cells[5, 7].Value = Convert.ToInt32(dtct.Compute("SUM(TongSoLuongSP)", ""));
                                ew.Cells[5, 9].Value = Convert.ToInt32(dtct.Compute("SUM(TienSP)", ""));

                                ew.Cells[5, 12].Value = Convert.ToInt32(dtth.Compute("SUM(TienSP)", ""));
                                ew.Cells[5, 13].Value = Convert.ToInt32(dtth.Compute("SUM(TienCong)", ""));
                                ew.Cells[5, 14].Value = Convert.ToInt32(dtth.Compute("SUM(TienCongPhu)", ""));
                                ew.Cells[5, 15].Value = Convert.ToInt32(dtth.Compute("SUM(TongTien)", ""));

                                ew.Column(7).Style.Numberformat.Format = "#,##0";
                                ew.Column(9).Style.Numberformat.Format = "#,##0";
                                ew.Column(12).Style.Numberformat.Format = "#,##0";
                                ew.Column(13).Style.Numberformat.Format = "#,##0";
                                ew.Column(14).Style.Numberformat.Format = "#,##0";
                                ew.Column(15).Style.Numberformat.Format = "#,##0";
                            }

                            package.Workbook.Worksheets.Delete(package.Workbook.Worksheets["Sheet2"]);
                            package.Save();

                            File.Move(des, newdes);
                            MessageBox.Show("Đã xuất file thành công, đường dẫn: " + newdes);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Quá trình xuất excel có lỗi, nếu bạn đang mở file excel, hãy đóng nó lại!" + ex.Message);
                }
            }
        }

        private string[] GetParam()
        {
            string[] param = new string[3];
            param[0] = DateTimeSQLite(dtpTuNgay.Value);
            param[1] = DateTimeSQLite(dtpDenNgay.Value);
            param[2] = idCongNhan;
            return param;
        }

        private void gvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                idCongNhan = gvLuong.Rows[e.RowIndex].Cells[1].Value.ToString();
                DA.Edit_ThamSo(GetParam());
                var chitiet = new BcLuongCatChiTiet();
                chitiet.ShowDialog();
            }
        }
    }
}

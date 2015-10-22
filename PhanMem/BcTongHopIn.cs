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
    public partial class BcTongHopIn : Form
    {
        DataAccess DA = new DataAccess();

        public BcTongHopIn()
        {
            InitializeComponent();
            SetDefault();
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
                    sfdXuatExcel.FileName = "In-TongHop-" + DateTimeSQLite(dtpTuNgay.Value) + "-" + DateTimeSQLite(dtpDenNgay.Value) + ".xlsx";
                    sfdXuatExcel.Filter = "Excel File|*.xlsx";
                    if (sfdXuatExcel.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfdXuatExcel.FileName))
                            File.Delete(sfdXuatExcel.FileName);
                        string source = DA.SourceFile() + @"Data\In-TongHop.xlsx";
                        string des = @"D:\In-TongHop.xlsx";
                        if (File.Exists(des))
                            File.Delete(des);
                        string newdes = sfdXuatExcel.FileName;
                        File.Copy(source, des);

                        using (ExcelPackage package = new ExcelPackage(new FileInfo(des)))
                        {
                            DataTable dtct = DA.In_TongHopSP();
                            int rownum = dtct.Rows.Count;
                            ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                            worksheet.Name = "Tổng hợp sản phẩm";
                            worksheet.Cells[2, 1].Value = "Từ ngày: " + dtpTuNgay.Text + " đến ngày: " + dtpDenNgay.Text;

                            if (rownum > 0)
                            {
                                for (int n = 0; n < rownum; n++)
                                {
                                    worksheet.Cells[n + 6, 1].Value = dtct.Rows[n]["STT"].ToString();
                                    worksheet.Cells[n + 6, 2].Value = dtct.Rows[n]["NgayCong"].ToString();
                                    worksheet.Cells[n + 6, 3].Value = dtct.Rows[n]["TenCongViec"].ToString();
                                    worksheet.Cells[n + 6, 4].Value = dtct.Rows[n]["KhoVai"].ToString();
                                    worksheet.Cells[n + 6, 5].Value = Convert.ToInt32(dtct.Rows[n]["SanPham"].ToString());
                                    worksheet.Cells[n + 6, 6].Value = Convert.ToInt32(dtct.Rows[n]["DonGia"].ToString());
                                    worksheet.Cells[n + 6, 7].Value = Convert.ToInt32(dtct.Rows[n]["ThanhTien"].ToString());
                                    worksheet.Cells[n + 6, 8].Value = dtct.Rows[n]["Tho"].ToString();
                                    worksheet.Cells[n + 6, 9].Value = dtct.Rows[n]["GhiChu"].ToString();
                                }
                                worksheet.Cells[5, 5].Value = Convert.ToInt32(dtct.Compute("SUM(SanPham)", "").ToString());
                                worksheet.Cells[5, 7].Value = Convert.ToInt32(dtct.Compute("SUM(ThanhTien)", "").ToString());

                                worksheet.Column(5).Style.Numberformat.Format = "#,##0";
                                worksheet.Column(6).Style.Numberformat.Format = "#,##0";
                                worksheet.Column(7).Style.Numberformat.Format = "#,##0";
                            }
                            package.Save();

                            File.Move(des, newdes);
                            MessageBox.Show("Đã xuất file thành công, đường dẫn: " + newdes);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Quá trình xuất excel có lỗi, nếu bạn đang mở file excel, hãy đóng nó lại!\n" + ex.Message);
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private string[] GetParam()
        {
            string[] param = new string[3];
            param[0] = DateTimeSQLite(dtpTuNgay.Value);
            param[1] = DateTimeSQLite(dtpDenNgay.Value);
            param[2] = "0";
            return param;
        }

        private void btXNT_Click(object sender, EventArgs e)
        {
            try
            {
                DA.Edit_ThamSo(GetParam());
                sfdXuatExcel.FileName = "In-XNT-" + DateTimeSQLite(dtpDenNgay.Value) + ".xlsx";
                sfdXuatExcel.Filter = "Excel File|*.xlsx";
                if (sfdXuatExcel.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfdXuatExcel.FileName))
                        File.Delete(sfdXuatExcel.FileName);
                    string source = DA.SourceFile() + @"Data\In-XNT.xlsx";
                    string des = @"D:\In-XNT.xlsx";
                    if (File.Exists(des))
                        File.Delete(des);
                    string newdes = sfdXuatExcel.FileName;
                    File.Copy(source, des);

                    using (ExcelPackage package = new ExcelPackage(new FileInfo(des)))
                    {
                        DataTable dtct = DA.In_XNT();
                        int rownum = dtct.Rows.Count;
                        ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                        worksheet.Name = "Xuất - Nhập - Tồn";
                        worksheet.Cells[2, 1].Value = "Đến ngày: " + dtpDenNgay.Text;

                        if (rownum > 0)
                        {
                            for (int n = 0; n < rownum; n++)
                            {
                                worksheet.Cells[n + 6, 1].Value = dtct.Rows[n]["STT"].ToString();
                                worksheet.Cells[n + 6, 2].Value = dtct.Rows[n]["KhoVai"].ToString();
                                worksheet.Cells[n + 6, 4].Value = Convert.ToInt32(dtct.Rows[n]["TongSPMay"].ToString());
                                worksheet.Cells[n + 6, 5].Value = Convert.ToInt32(dtct.Rows[n]["TongSPIn"].ToString());
                            }
                            worksheet.Cells[5, 4].Value = Convert.ToInt32(dtct.Compute("SUM(TongSPMay)", "").ToString());
                            worksheet.Cells[5, 5].Value = Convert.ToInt32(dtct.Compute("SUM(TongSPIn)", "").ToString());

                            worksheet.Column(4).Style.Numberformat.Format = "#,##0";
                            worksheet.Column(5).Style.Numberformat.Format = "#,##0";
                        }
                        package.Save();

                        File.Move(des, newdes);
                        MessageBox.Show("Đã xuất file thành công, đường dẫn: " + newdes);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá trình xuất excel có lỗi, nếu bạn đang mở file excel, hãy đóng nó lại!\n" + ex.Message);
            }
        }
    }
}

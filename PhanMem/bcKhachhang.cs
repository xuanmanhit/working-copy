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
    public partial class bcKhachhang : Form
    {
        DataAccess DA = new DataAccess();
        static string idTho = "0";

        public bcKhachhang()
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
                    sfdXuatExcel.FileName = "MayIn-KhachhangN1-" + DateTimeSQLite(dtpTuNgay.Value) + "-" + DateTimeSQLite(dtpDenNgay.Value) + ".xlsx";
                    sfdXuatExcel.Filter = "Excel File|*.xlsx";
                    if (sfdXuatExcel.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfdXuatExcel.FileName))
                            File.Delete(sfdXuatExcel.FileName);
                        string source = DA.SourceFile() + @"Data\MayIn-KhachhangN1.xlsx";
                        string des = @"D:\MayIn-KhachhangN1.xlsx";
                        if (File.Exists(des))
                            File.Delete(des);
                        string newdes = sfdXuatExcel.FileName;
                        File.Copy(source, des);

                        using (ExcelPackage package = new ExcelPackage(new FileInfo(des)))
                        {
                            DataTable dtct = DA.MayIn_LuongCTThoN1();
                            DataTable dtth = DA.MayIn_LuongTHThoN1();
                            int rownum = dtct.Rows.Count;
                            int rownum2 = dtth.Rows.Count;
                            ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                            worksheet.Name = "Báo cáo Khách hàng";
                            worksheet.Cells[2, 1].Value = "Từ ngày: " + dtpTuNgay.Text + " đến ngày: " + dtpDenNgay.Text;

                            for (int n = 0; n < rownum; n++)
                            {
                                worksheet.Cells[n + 7, 1].Value = dtct.Rows[n]["NgayCong"].ToString();
                                worksheet.Cells[n + 7, 2].Value = dtct.Rows[n]["KhoVai"].ToString();
                                worksheet.Cells[n + 7, 3].Value = dtct.Rows[n]["KhachHang"].ToString();
                                worksheet.Cells[n + 7, 4].Value = Convert.ToInt32(dtct.Rows[n]["SoLuong"].ToString());
                            }

                            for (int k = 0; k < rownum2; k++)
                            {
                                worksheet.Cells[k + 7, 7].Value = Convert.ToInt32(dtth.Rows[k]["STT"].ToString());
                                worksheet.Cells[k + 7, 8].Value = dtth.Rows[k]["KhachHang"].ToString();
                                worksheet.Cells[k + 7, 9].Value = Convert.ToInt32(dtth.Rows[k]["TongSoLuong"].ToString());
                            }

                            worksheet.Cells[6, 4].Value = Convert.ToInt32(dtct.Compute("SUM(SoLuong)", "").ToString());

                            worksheet.Cells[6, 9].Value = Convert.ToInt32(dtth.Compute("SUM(TongSoLuong)", ""));

                            worksheet.Column(4).Style.Numberformat.Format = "#,##0";
                            worksheet.Column(9).Style.Numberformat.Format = "#,##0";

                            package.Save();

                            File.Move(des, newdes);
                            MessageBox.Show("Đã xuất file thành công, đường dẫn: " + newdes);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Quá trình xuất excel có lỗi, nếu bạn đang mở file excel, hãy đóng nó lại!" + ex.Message);
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
            param[2] = idTho;
            return param;
        }
    }
}

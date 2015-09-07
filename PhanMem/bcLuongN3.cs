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
    public partial class bcLuongN3 : Form
    {
        DataAccess DA = new DataAccess();
        static string idTho = "0";

        public bcLuongN3()
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
                    idTho = "0";
                    DA.Edit_ThamSo(GetParam());
                    sfdXuatExcel.FileName = "MayIn-LuongN3-" + DateTimeSQLite(dtpTuNgay.Value) + "-" + DateTimeSQLite(dtpDenNgay.Value) + ".xlsx";
                    sfdXuatExcel.Filter = "Excel File|*.xlsx";
                    if (sfdXuatExcel.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfdXuatExcel.FileName))
                            File.Delete(sfdXuatExcel.FileName);
                        string source = DA.SourceFile() + @"Data\MayIn-LuongN3.xlsx";
                        string des = @"D:\MayIn-LuongN3.xlsx";
                        if (File.Exists(des))
                            File.Delete(des);
                        string newdes = sfdXuatExcel.FileName;
                        File.Copy(source, des);

                        using (ExcelPackage package = new ExcelPackage(new FileInfo(des)))
                        {
                            DataTable dt = DA.MayIn_LuongN3();
                            ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                            int rowCount = dt.Rows.Count;
                            worksheet.Name = "Tổng hợp";

                            // fill dữ liệu tổng hợp                         
                            for (int i = 0; i < rowCount; i++)
                            {
                                worksheet.Cells[i + 6, 1].Value = Convert.ToInt32(dt.Rows[i]["STT"].ToString());
                                worksheet.Cells[i + 6, 2].Value = dt.Rows[i]["HoTen"].ToString();
                                worksheet.Cells[i + 6, 3].Value = Convert.ToInt32(dt.Rows[i]["ThanhTien"].ToString());
                            }

                            worksheet.Cells[2, 1].Value = "Từ ngày: " + dtpTuNgay.Text + " đến ngày: " + dtpDenNgay.Text;
                            worksheet.Cells[5, 3].Value = Convert.ToInt32(dt.Compute("SUM(ThanhTien)", "").ToString());
                            worksheet.Column(3).Style.Numberformat.Format = "#,##0";

                            // fill dữ liệu chi tiết
                            for (int i = 0; i < rowCount; i++)
                            {
                                idTho = dt.Rows[i]["ID"].ToString();
                                DA.Edit_ThamSo(GetParam());
                                DataTable dtct = DA.MayIn_LuongCTThoN3();
                                DataTable dtth = DA.MayIn_LuongTHThoN3();
                                int rownum = dtct.Rows.Count;
                                int rownum2 = dtth.Rows.Count;
                                string sheetname = "Chi tiết lương " + dt.Rows[i]["HoTen"].ToString();
                                ExcelWorksheet ew = package.Workbook.Worksheets.Add(sheetname, package.Workbook.Worksheets["Sheet2"]);
                                ew.Cells[4, 2].Value = dt.Rows[i]["HoTen"].ToString();
                                ew.Cells[2, 1].Value = "Từ ngày: " + dtpTuNgay.Text + " đến ngày: " + dtpDenNgay.Text;
                                for (int n = 0; n < rownum; n++)
                                {
                                    ew.Cells[n + 9, 1].Value = dtct.Rows[n]["NgayCong"].ToString();
                                    ew.Cells[n + 9, 2].Value = dtct.Rows[n]["TenViec"].ToString();
                                    ew.Cells[n + 9, 3].Value = Convert.ToInt32(dtct.Rows[n]["ThanhTien"].ToString());
                                }

                                for (int k = 0; k < rownum2; k++)
                                {
                                    ew.Cells[k + 9, 6].Value = dtth.Rows[k]["NgayCong"].ToString();
                                    ew.Cells[k + 9, 7].Value = Convert.ToInt32(dtth.Rows[k]["TongTien"].ToString());
                                }                                
                                ew.Cells[8, 3].Value = Convert.ToInt32(dtct.Compute("SUM(ThanhTien)", "").ToString());
                                ew.Cells[8, 7].Value = Convert.ToInt32(dtth.Compute("SUM(TongTien)", ""));

                                ew.Column(3).Style.Numberformat.Format = "#,##0";
                                ew.Column(7).Style.Numberformat.Format = "#,##0";
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

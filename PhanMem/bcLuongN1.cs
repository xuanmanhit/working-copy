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
    public partial class bcLuongN1 : Form
    {
        DataAccess DA = new DataAccess();
        static string idTho = "0";

        public bcLuongN1()
        {
            InitializeComponent();
            SetDefault();
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
                    sfdXuatExcel.FileName = "MayIn-LuongN1-" + DateTimeSQLite(dtpTuNgay.Value) + "-" + DateTimeSQLite(dtpDenNgay.Value) + ".xlsx";
                    sfdXuatExcel.Filter = "Excel File|*.xlsx";
                    if (sfdXuatExcel.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfdXuatExcel.FileName))
                            File.Delete(sfdXuatExcel.FileName);
                        string source = DA.SourceFile() + @"Data\MayIn-LuongN1.xlsx";
                        string des = @"D:\MayIn-LuongN1.xlsx";
                        if (File.Exists(des))
                            File.Delete(des);
                        string newdes = sfdXuatExcel.FileName;
                        File.Copy(source, des);

                        using (ExcelPackage package = new ExcelPackage(new FileInfo(des)))
                        {
                            DataTable dt = DA.MayIn_LuongN1();
                            //DataTable dtCongNhan = DA.DsLuongCat();

                            ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                            int rowCount = dt.Rows.Count;
                            //int cnCount = dtCongNhan.Rows.Count;
                            worksheet.Name = "Tổng hợp";

                            // fill dữ liệu tổng hợp                         
                            for (int i = 0; i < rowCount; i++)
                            {
                                worksheet.Cells[i + 6, 1].Value = Convert.ToInt32(dt.Rows[i]["STT"].ToString());
                                worksheet.Cells[i + 6, 2].Value = dt.Rows[i]["HoTen"].ToString();
                                worksheet.Cells[i + 6, 3].Value = Convert.ToInt32(dt.Rows[i]["SoCai"].ToString());
                                worksheet.Cells[i + 6, 4].Value = Convert.ToInt32(dt.Rows[i]["ThanhTien"].ToString());
                            }
                            /*
                            // fill dữ liệu chi tiết
                            for (int i = 0; i < cnCount; i++)
                            {
                                // copy format cell range cho list công nhân
                                worksheet.Cells[3, 7, 5, 10].Copy(worksheet.Cells[3, (i * 4) + 7, 5, (i * 4) + 10]);

                                // set giá trị vào cell
                                worksheet.Cells[3, (i * 4) + 7].Value = dtCongNhan.Rows[i]["HoTen"].ToString();
                                idCongNhan = dtCongNhan.Rows[i]["CongNhan"].ToString();
                                DA.Edit_ThamSo(GetParam());
                                DataTable dtct = DA.TongHopCat();
                                int ctCount = dtct.Rows.Count;

                                // fill theo từng công nhân
                                for (int k = 0; k < ctCount; k++)
                                {
                                    worksheet.Cells[k + 6, (i * 4) + 7].Value = double.Parse(dtct.Rows[k]["TongKgCat"].ToString());
                                    worksheet.Cells[k + 6, (i * 4) + 8].Value = Convert.ToInt32(dtct.Rows[k]["TongOng"].ToString());
                                    worksheet.Cells[k + 6, (i * 4) + 9].Value = double.Parse(dtct.Rows[k]["TongKgSP"].ToString());
                                    worksheet.Cells[k + 6, (i * 4) + 10].Value = Convert.ToInt32(dtct.Rows[k]["TongSP"].ToString());
                                }
                            }
                            */
                            worksheet.Cells[2, 1].Value = "Từ ngày: " + dtpTuNgay.Text + " đến ngày: " + dtpDenNgay.Text;

                            // sum theo cột
                            for (int i = 3; i <= 4; i++)
                            {
                                worksheet.Cells[5, i].Formula = "SUM(" + worksheet.Cells[6, i].Address + ":" + worksheet.Cells[rowCount + 5, i].Address + ")";
                            }

                            worksheet.Cells[5, 3, rowCount + 5, 4].Style.Numberformat.Format = "#,##0";

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
    }
}

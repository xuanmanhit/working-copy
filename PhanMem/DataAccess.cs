using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace PhanMem
{
    public class DataAccess
    {
        #region Data Access

        private SQLiteConnection sql_Con;
        private SQLiteCommand sql_Cmd;
        private SQLiteDataAdapter sql_DA;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        private void SetConnection()
        {
            //sql_Con = new SQLiteConnection(@"Data Source=D:\ManhHX\OutSource\PhanMem\PhanMem\Data\QuanLy.sqlite;Version=3;");
            sql_Con = new SQLiteConnection(@"Data Source=E:\Working\Github\working-copy\PhanMem\Data\QuanLy.sqlite;Version=3;");
            //sql_Con = new SQLiteConnection(@"Data Source=Data\QuanLy.sqlite;Version=3;");
        }

        public string SourceFile()
        {
            //return @"D:\ManhHX\OutSource\PhanMem\PhanMem\";
            return @"E:\Working\Github\working-copy\PhanMem\";
            //return "";
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_Con.Open();
            sql_Cmd = sql_Con.CreateCommand();
            sql_Cmd.CommandText = txtQuery;
            sql_Cmd.ExecuteNonQuery();
            sql_Con.Close();
        }

        private DataTable LoadData(string txtQuery)
        {
            SetConnection();
            sql_Con.Open();
            sql_Cmd = sql_Con.CreateCommand();
            sql_DA = new SQLiteDataAdapter(txtQuery, sql_Con);
            ds = new DataSet();
            sql_DA.Fill(ds);
            dt = ds.Tables[0];
            sql_Con.Close();
            return dt;
        }

        #endregion

        #region Công Nhân

        public DataTable List_CongNhan()
        {
            string cmd = "SELECT * FROM tblCongNhan WHERE TinhTrang=1 ORDER BY ID DESC";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable List_CongNhanTheoViec(string congviec)
        {
            string cmd = "SELECT ID,HoTen FROM tblCongNhan WHERE TinhTrang=1 AND CongViec='" + congviec + "' ORDER BY ID";
            return LoadData(cmd);
        }

        public DataTable List_CongViec()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Value");
            tbl.Rows.Add("Dệt");
            tbl.Rows.Add("Cắt");
            return tbl;
        }

        public DataTable List_NhanVien()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Value");
            tbl.Rows.Add("Cũ");
            tbl.Rows.Add("Mới");
            return tbl;
        }

        public void Add_CongNhan(string[] param)
        {
            string cmd = "INSERT INTO tblCongNhan (HoTen,CongViec,NhanVien) VALUES ('{0}','{1}','{2}')";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_CongNhan(string[] param)
        {
            string cmd = "UPDATE tblCongNhan SET HoTen='{0}',CongViec='{1}',NhanVien='{2}' WHERE ID={3}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_CongNhan(string[] param)
        {
            string cmd = "UPDATE tblCongNhan SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_CongNhan(string[] param)
        {
            string cmd = "SELECT * FROM tblCongNhan WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region Việc Phụ

        public DataTable List_ViecPhu()
        {
            string cmd = "SELECT * FROM tblViecPhu WHERE TinhTrang=1 ORDER BY ID DESC";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public void Add_ViecPhu(string[] param)
        {
            string cmd = "INSERT INTO tblViecPhu (TenViec) VALUES ('{0}')";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_ViecPhu(string[] param)
        {
            string cmd = "UPDATE tblViecPhu SET TenViec='{0}' WHERE ID={1}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_ViecPhu(string[] param)
        {
            string cmd = "UPDATE tblViecPhu SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_ViecPhu(string[] param)
        {
            string cmd = "SELECT * FROM tblViecPhu WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region Khổ Vải

        public DataTable List_KhoVai()
        {
            string cmd = "SELECT * FROM vDsKhoVai";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable List_KhoVaiChinh()
        {
            string cmd = "SELECT ID,KhoVai FROM tblKhoVai WHERE TinhTrang=1 AND KhoVaiChinh=0 ORDER BY ID";
            return LoadData(cmd);
        }

        public void Add_KhoVai(string[] param)
        {
            string cmd = "INSERT INTO tblKhoVai (KhoVai,DonGiaDet,DonGiaCat,KhoVaiChinh) VALUES ('{0}',{1},{2},{3})";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_KhoVai(string[] param)
        {
            string cmd = "UPDATE tblKhoVai SET KhoVai='{0}',DonGiaDet={1},DonGiaCat={2},KhoVaiChinh={3} WHERE ID={4}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_KhoVai(string[] param)
        {
            string cmd = "UPDATE tblKhoVai SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_KhoVai(string[] param)
        {
            string cmd = "SELECT * FROM tblKhoVai WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region Công Cắt

        public DataTable List_CongCat()
        {
            string cmd = "SELECT * FROM vCat_DsHienThi";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable List_CongNhanCat()
        {
            string cmd = "SELECT ID,HoTen FROM tblCongNhan WHERE TinhTrang=1 AND CongViec='Cắt' ORDER BY ID";
            return LoadData(cmd);
        }

        public DataTable List_KhoVaiCat()
        {
            string cmd = "SELECT ID,KhoVai FROM tblKhoVai WHERE TinhTrang=1 ORDER BY KhoVai";
            return LoadData(cmd);
        }

        public void Add_CongCat(string[] param)
        {
            string cmd = "INSERT INTO tblCongCat (NgayCat,CongNhan,KhoVai,SoKgCat,";
            cmd += "PheTH_CN1,PheTH1,PheTH_CN2,PheTH2,PheSuot_CN1,PheSuot1,PheSuot_CN2,PheSuot2,PheDC_CN1,PheDC1,PheDC_CN2,PheDC2,";
            cmd += "SoLuongSP,PhutSP,PhutCongNhat)";
            cmd += " VALUES ('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18})";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_CongCat(string[] param)
        {
            string cmd = "UPDATE tblCongCat SET NgayCat='{0}',CongNhan={1},KhoVai={2},SoKgCat={3},";
            cmd += "PheTH_CN1={4},PheTH1={5},PheTH_CN2={6},PheTH2={7},";
            cmd += "PheSuot_CN1={8},PheSuot1={9},PheSuot_CN2={10},PheSuot2={11},";
            cmd += "PheDC_CN1={12},PheDC1={13},PheDC_CN2={14},PheDC2={15},";
            cmd += "SoLuongSP={16},PhutSP={17},PhutCongNhat={18} WHERE ID={19}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_CongCat(string[] param)
        {
            string cmd = "UPDATE tblCongCat SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_CongCat(string[] param)
        {
            string cmd = "SELECT * FROM vCat_DsCapNhat WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region Công Cắt Phụ

        public DataTable List_CongCatPhu()
        {
            string cmd = "SELECT * FROM vCat_DsViecPhu";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public void Add_CongCatPhu(string[] param)
        {
            string cmd = "INSERT INTO tblCongCatPhu (NgayCong,Nhom,CongNhan,CongViec,GioCong,GiaCong)";
            cmd += " VALUES ('{0}','Cắt',{1},{2},{3},{4})";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_CongCatPhu(string[] param)
        {
            string cmd = "UPDATE tblCongCatPhu SET NgayCong='{0}',CongNhan={1},CongViec={2},GioCong={3},GiaCong={4} WHERE ID={5}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_CongCatPhu(string[] param)
        {
            string cmd = "UPDATE tblCongCatPhu SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_CongCatPhu(string[] param)
        {
            string cmd = "SELECT ID,strftime('%m/%d/%Y', NgayCong) as NgayCong,CongNhan,CongViec,GioCong,GiaCong FROM tblCongCatPhu WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region Báo cáo Cắt

        public DataTable ChiTietCongCat(string ngayCong)
        {
            string cmd = "SELECT * FROM vCat_DsCongChiTiet WHERE NgayCat='" + ngayCong + "'";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable TongHopCongCat(string ngayCong)
        {
            string cmd = "SELECT * FROM vCat_DsCongTongHop WHERE NgayCat='" + ngayCong + "'";
            return LoadData(cmd);
        }

        public void Edit_ThamSo(string[] param)
        {
            string cmd = "UPDATE tblThamSo SET TuNgay='{0}',DenNgay='{1}',CongNhan={2} WHERE ID=1";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable DsLuongCat()
        {
            string cmd = "SELECT * FROM vCat_DsLuongTongHop";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable LuongCatChiTiet()
        {
            string cmd = "SELECT * FROM vCat_LuongChiTiet";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable LuongCatTongHop()
        {
            string cmd = "SELECT * FROM vCat_LuongTongHop";
            return LoadData(cmd);
        }

        public DataTable ThongtinLuongCatChiTiet()
        {
            string cmd = "SELECT cn.HoTen, strftime('%d/%m/%Y', ts.TuNgay) AS TuNgay, strftime('%d/%m/%Y', ts.DenNgay) AS DenNgay";
            cmd += " FROM tblThamSo ts LEFT JOIN tblCongNhan cn ON ts.CongNhan = cn.ID";
            return LoadData(cmd);
        }

        #endregion
    }
}

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

        public DataTable TongHopCat()
        {
            string cmd = "SELECT * FROM vCat_TongHopSP";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        #endregion

        #region Thợ May - In

        public DataTable List_ThoMayIn()
        {
            string cmd = "SELECT * FROM tblThoMayIn WHERE TinhTrang=1 ORDER BY ID DESC";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public void Add_ThoMayIn(string[] param)
        {
            string cmd = "INSERT INTO tblThoMayIn (HoTen,SoTho) VALUES ('{0}',{1})";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_ThoMayIn(string[] param)
        {
            string cmd = "UPDATE tblThoMayIn SET HoTen='{0}',SoTho={1} WHERE ID={2}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_ThoMayIn(string[] param)
        {
            string cmd = "UPDATE tblThoMayIn SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_ThoMayIn(string[] param)
        {
            string cmd = "SELECT * FROM tblThoMayIn WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region Công việc May - In

        public DataTable List_ViecMayIn()
        {
            string cmd = "SELECT * FROM tblCongViec WHERE TinhTrang=1 ORDER BY ID DESC";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public void Add_ViecMayIn(string[] param)
        {
            string cmd = "INSERT INTO tblCongViec (TenCongViec,DonGia) VALUES ('{0}',{1})";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_ViecMayIn(string[] param)
        {
            string cmd = "UPDATE tblCongViec SET TenCongViec='{0}',DonGia={1} WHERE ID={2}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_ViecMayIn(string[] param)
        {
            string cmd = "UPDATE tblCongViec SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_ViecMayIn(string[] param)
        {
            string cmd = "SELECT * FROM tblCongViec WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region Khách hàng

        public DataTable List_KhachHang()
        {
            string cmd = "SELECT * FROM tblKhachHang WHERE TinhTrang=1 ORDER BY ID DESC";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public void Add_KhachHang(string[] param)
        {
            string cmd = "INSERT INTO tblKhachHang (HoTen) VALUES ('{0}')";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_KhachHang(string[] param)
        {
            string cmd = "UPDATE tblKhachHang SET HoTen='{0}' WHERE ID={1}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_KhachHang(string[] param)
        {
            string cmd = "UPDATE tblKhachHang SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_KhachHang(string[] param)
        {
            string cmd = "SELECT * FROM tblKhachHang WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region MayIn

        public DataTable List_MayIn()
        {
            string cmd = "SELECT * FROM tblMayIn WHERE TinhTrang=1 ORDER BY ID DESC";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public void Add_MayIn(string[] param)
        {
            string cmd = "INSERT INTO tblMayIn (MayIn) VALUES ('{0}')";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_MayIn(string[] param)
        {
            string cmd = "UPDATE tblMayIn SET MayIn='{0}' WHERE ID={1}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_MayIn(string[] param)
        {
            string cmd = "UPDATE tblMayIn SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_MayIn(string[] param)
        {
            string cmd = "SELECT * FROM tblMayIn WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region Thông tin chung Công May In

        public DataTable List_Tho()
        {
            string cmd = "SELECT ID,HoTen FROM tblThoMayIn WHERE TinhTrang=1 ORDER BY HoTen";
            return LoadData(cmd);
        }

        public DataTable List_CongviecMayIn()
        {
            string cmd = "SELECT ID,TenCongViec FROM tblCongViec WHERE TinhTrang=1 ORDER BY TenCongViec";
            return LoadData(cmd);
        }

        public DataTable List_KhoVaiMayIn()
        {
            string cmd = "SELECT ID,KhoVai FROM tblKhoVai WHERE TinhTrang=1 ORDER BY KhoVai";
            return LoadData(cmd);
        }

        public DataTable List_KhgMayIn()
        {
            string cmd = "SELECT ID,HoTen FROM tblKhachHang WHERE TinhTrang=1 ORDER BY HoTen";
            return LoadData(cmd);
        }

        public DataTable List_DsMayIn()
        {
            string cmd = "SELECT ID,MayIn FROM tblMayIn WHERE TinhTrang=1 ORDER BY MayIn";
            return LoadData(cmd);
        }

        #endregion

        #region Công May In N1

        public DataTable List_CongN1()
        {
            string cmd = "SELECT * FROM vN1_DsHienThi";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public void Add_CongN1(string[] param)
        {
            string cmd = "INSERT INTO tblCongNhom1 (NgayCong,ThoMayIn,CongViec,KhoVai,KhachHang,SoLuong,GhiChu)";
            cmd += " VALUES ('{0}',{1},{2},{3},{4},{5},'{6}')";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_CongN1(string[] param)
        {
            string cmd = "UPDATE tblCongNhom1 SET NgayCong='{0}',ThoMayIn={1},CongViec={2},KhoVai={3},";
            cmd += "KhachHang={4},SoLuong={5},GhiChu='{6}' WHERE ID={7}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_CongN1(string[] param)
        {
            string cmd = "UPDATE tblCongNhom1 SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_CongN1(string[] param)
        {
            string cmd = "SELECT * FROM vN1_DsCapNhat WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region Công May In N2

        public DataTable List_CongN2()
        {
            string cmd = "SELECT * FROM vN2_DsHienThi";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public void Add_CongN2(string[] param)
        {
            string cmd = "INSERT INTO tblCongNhom2 (NgayCong,MayIn,ThoChinh,ThoPhu1,ThoPhu2,ThoPhu3,ThoPhu4,GioNhanIn,GioBatDauIn,GioInXong,";
            cmd += "KhoVai,CongViec,ThoCat,SoLuong,InHu,ThoInHu,InPhe,ThoInPhe,InVayMuc,ThoInVayMuc,InLoi,ThoInLoi,GhiChu)";
            cmd += " VALUES ('{0}',{1},{2},{3},{4},{5},{6},'{7}','{8}','{9}',{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},'{22}')";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_CongN2(string[] param)
        {
            string cmd = "UPDATE tblCongNhom2 SET NgayCong='{0}',MayIn={1},ThoChinh={2},ThoPhu1={3},ThoPhu2={4},ThoPhu3={5},ThoPhu4={6},";
            cmd += "GioNhanIn='{7}',GioBatDauIn='{8}',GioInXong='{9}',KhoVai={10},CongViec={11},ThoCat={12},SoLuong={13},";
            cmd += "InHu={14},ThoInHu={15},InPhe={16},ThoInPhe={17},InVayMuc={18},ThoInVayMuc={19},InLoi={20},ThoInLoi={21},";
            cmd += "GhiChu='{22}' WHERE ID={23}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_CongN2(string[] param)
        {
            string cmd = "UPDATE tblCongNhom2 SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_CongN2(string[] param)
        {
            string cmd = "SELECT * FROM vN2_DsCapNhat WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region Công May In N3

        public DataTable List_CongN3()
        {
            string cmd = "SELECT * FROM vN3_DsHienThi";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public void Add_CongN3(string[] param)
        {
            string cmd = "INSERT INTO tblCongNhom3 (NgayCong,ThoPhu,CongViec,GioCong,GiaCong,GhiChu)";
            cmd += " VALUES ('{0}',{1},{2},{3},{4},'{5}')";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Edit_CongN3(string[] param)
        {
            string cmd = "UPDATE tblCongNhom3 SET NgayCong='{0}',ThoPhu={1},CongViec={2},GioCong={3},";
            cmd += "GiaCong={4},GhiChu='{5}' WHERE ID={6}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public void Del_CongN3(string[] param)
        {
            string cmd = "UPDATE tblCongNhom3 SET TinhTrang=0 WHERE ID={0}";
            cmd = String.Format(cmd, param);
            ExecuteQuery(cmd);
        }

        public DataTable Load_CongN3(string[] param)
        {
            string cmd = "SELECT * FROM vN3_DsCapNhat WHERE ID={0}";
            cmd = String.Format(cmd, param);
            return LoadData(cmd);
        }

        #endregion

        #region Báo cáo May - In

        //NHÓM 1
        public DataTable MayIn_LuongN1()
        {
            string cmd = "SELECT * FROM vN1_BcLuongTH";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable MayIn_LuongCTThoN1()
        {
            string cmd = "SELECT * FROM vN1_BcLuongThoCT";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable MayIn_LuongTHThoN1()
        {
            string cmd = "SELECT * FROM vN1_BcLuongThoTH";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable MayIn_KhachhangCTN1()
        {
            string cmd = "SELECT * FROM vN1_BcKhachHangCT";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable MayIn_KhachhangTHN1()
        {
            string cmd = "SELECT * FROM vN1_BcKhachHangTH";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }
        //END NHÓM 1

        //NHÓM 2
        public DataTable MayIn_LuongN2()
        {
            string cmd = "SELECT * FROM vN2_BcLuongTH";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable MayIn_LuongCTThoN2()
        {
            string cmd = "SELECT * FROM vN2_BcLuongThoCT";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable MayIn_LuongTHThoN2()
        {
            string cmd = "SELECT * FROM vN2_BcLuongThoTH";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }
        //END NHÓM 2

        //NHÓM 3
        public DataTable MayIn_CongviecN3()
        {
            string cmd = "SELECT * FROM vN3_BcCongViecTH";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable MayIn_LuongN3()
        {
            string cmd = "SELECT * FROM vN3_BcLuongTH";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable MayIn_LuongCTThoN3()
        {
            string cmd = "SELECT * FROM vN3_BcLuongThoCT";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }

        public DataTable MayIn_LuongTHThoN3()
        {
            string cmd = "SELECT * FROM vN3_BcLuongThoTH";
            DataTable tbl = LoadData(cmd);
            tbl.Columns.Add("STT", typeof(Int32));
            for (int i = 0; i < tbl.Rows.Count; i++)
                tbl.Rows[i]["STT"] = i + 1;
            return tbl;
        }
        //END NHÓM 3

        #endregion
    }
}

--
-- File generated with SQLiteStudio v3.0.6 on Sat Aug 15 00:11:19 2015
--
-- Text encoding used: windows-1252
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: tblThamSo
CREATE TABLE tblThamSo (ID INTEGER PRIMARY KEY NOT NULL DEFAULT (1), TuNgay NUMERIC, DenNgay NUMERIC, CongNhan INTEGER);
INSERT INTO tblThamSo (ID, TuNgay, DenNgay, CongNhan) VALUES (1, '2015-07-01', '2015-07-31', 2);

-- Table: tblCongCat
CREATE TABLE tblCongCat (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, NgayCat NUMERIC, CongNhan INTEGER, KhoVai INTEGER, SoKgCat INTEGER, SoLuongSP INTEGER, PhutSP INTEGER, PhutCongNhat INTEGER, PheTH_CN1 INTEGER, PheTH1 INTEGER, PheTH_CN2 INTEGER, PheTH2 INTEGER, PheSuot_CN1 INTEGER, PheSuot1 INTEGER, PheSuot_CN2 INTEGER, PheSuot2 INTEGER, PheDC_CN1 INTEGER, PheDC1 INTEGER, PheDC_CN2 INTEGER, PheDC2 INTEGER, SoOng INTEGER, SoKgOng INTEGER, PheTH INTEGER, PheSuot INTEGER, PheDC INTEGER, TongPhe INTEGER, SoSPTruPhe INTEGER, DonGia INTEGER, TongTien INTEGER, TienCong INTEGER, TinhTrang INTEGER DEFAULT (1));
INSERT INTO tblCongCat (ID, NgayCat, CongNhan, KhoVai, SoKgCat, SoLuongSP, PhutSP, PhutCongNhat, PheTH_CN1, PheTH1, PheTH_CN2, PheTH2, PheSuot_CN1, PheSuot1, PheSuot_CN2, PheSuot2, PheDC_CN1, PheDC1, PheDC_CN2, PheDC2, SoOng, SoKgOng, PheTH, PheSuot, PheDC, TongPhe, SoSPTruPhe, DonGia, TongTien, TienCong, TinhTrang) VALUES (1, '2015-07-01', 2, 28, 107, 2500, 54, 21, 10, 1.6, 11, 0.6, 0, 0, 0, 0, 0, 0, 0, 0, 1, 3, 2.2, 0, 0, 2.2, 101.8, 19, 47500, 18472, 1);
INSERT INTO tblCongCat (ID, NgayCat, CongNhan, KhoVai, SoKgCat, SoLuongSP, PhutSP, PhutCongNhat, PheTH_CN1, PheTH1, PheTH_CN2, PheTH2, PheSuot_CN1, PheSuot1, PheSuot_CN2, PheSuot2, PheDC_CN1, PheDC1, PheDC_CN2, PheDC2, SoOng, SoKgOng, PheTH, PheSuot, PheDC, TongPhe, SoSPTruPhe, DonGia, TongTien, TienCong, TinhTrang) VALUES (2, '2015-07-01', 2, 29, 116, 690, 270, 105, 10, 1.2, 11, 0.2, 0, 0, 0, 0, 0, 0, 0, 0, 1, 3, 1.4, 0, 0, 1.4, 111.6, 21, 14490, 5635, 1);
INSERT INTO tblCongCat (ID, NgayCat, CongNhan, KhoVai, SoKgCat, SoLuongSP, PhutSP, PhutCongNhat, PheTH_CN1, PheTH1, PheTH_CN2, PheTH2, PheSuot_CN1, PheSuot1, PheSuot_CN2, PheSuot2, PheDC_CN1, PheDC1, PheDC_CN2, PheDC2, SoOng, SoKgOng, PheTH, PheSuot, PheDC, TongPhe, SoSPTruPhe, DonGia, TongTien, TienCong, TinhTrang) VALUES (3, '2015-07-01', 2, 30, 414, 2200, 162, 63, 10, 1.3, 11, 0.3, 0, 0, 0, 0, 0, 0, 0, 0, 1, 3, 1.6, 0, 0, 1.6, 409.4, 21, 46200, 17967, 1);
INSERT INTO tblCongCat (ID, NgayCat, CongNhan, KhoVai, SoKgCat, SoLuongSP, PhutSP, PhutCongNhat, PheTH_CN1, PheTH1, PheTH_CN2, PheTH2, PheSuot_CN1, PheSuot1, PheSuot_CN2, PheSuot2, PheDC_CN1, PheDC1, PheDC_CN2, PheDC2, SoOng, SoKgOng, PheTH, PheSuot, PheDC, TongPhe, SoSPTruPhe, DonGia, TongTien, TienCong, TinhTrang) VALUES (4, '2015-07-01', 2, 31, 85, 3200, 54, 21, 10, 1, 11, 0.4, 0, 0, 0, 0, 0, 0, 0, 0, 1, 3, 1.4, 0, 0, 1.4, 80.6, 19, 60800, 23645, 1);
INSERT INTO tblCongCat (ID, NgayCat, CongNhan, KhoVai, SoKgCat, SoLuongSP, PhutSP, PhutCongNhat, PheTH_CN1, PheTH1, PheTH_CN2, PheTH2, PheSuot_CN1, PheSuot1, PheSuot_CN2, PheSuot2, PheDC_CN1, PheDC1, PheDC_CN2, PheDC2, SoOng, SoKgOng, PheTH, PheSuot, PheDC, TongPhe, SoSPTruPhe, DonGia, TongTien, TienCong, TinhTrang) VALUES (5, '2015-07-02', 3, 31, 91, 3342, 130, 470, 10, 0.2, 11, 0.2, 0, 0, 0, 0, 0, 0, 0, 0, 1, 3, 0.4, 0, 0, 0.4, 87.6, 19, 63498, 229572, 1);
INSERT INTO tblCongCat (ID, NgayCat, CongNhan, KhoVai, SoKgCat, SoLuongSP, PhutSP, PhutCongNhat, PheTH_CN1, PheTH1, PheTH_CN2, PheTH2, PheSuot_CN1, PheSuot1, PheSuot_CN2, PheSuot2, PheDC_CN1, PheDC1, PheDC_CN2, PheDC2, SoOng, SoKgOng, PheTH, PheSuot, PheDC, TongPhe, SoSPTruPhe, DonGia, TongTien, TienCong, TinhTrang) VALUES (6, '2015-08-01', 3, 36, 88, 1340, 600, 0, 10, 0.8, 11, 0.8, 0, 0, 0, 0, 0, 0, 0, 0, 1, 3, 1.6, 0, 0, 1.6, 83.4, 19, 25460, 0, 1);
INSERT INTO tblCongCat (ID, NgayCat, CongNhan, KhoVai, SoKgCat, SoLuongSP, PhutSP, PhutCongNhat, PheTH_CN1, PheTH1, PheTH_CN2, PheTH2, PheSuot_CN1, PheSuot1, PheSuot_CN2, PheSuot2, PheDC_CN1, PheDC1, PheDC_CN2, PheDC2, SoOng, SoKgOng, PheTH, PheSuot, PheDC, TongPhe, SoSPTruPhe, DonGia, TongTien, TienCong, TinhTrang) VALUES (7, '2015-08-01', 3, 37, 92, 1754, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 3, 0, 0, 0, 0, 89, 19, 33326, 0, 1);

-- Table: tblMayDet
CREATE TABLE tblMayDet (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, SoMay TEXT, TinhTrang INTEGER DEFAULT (1));
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (1, '1', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (2, '2', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (3, '3', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (4, '4', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (5, '5', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (6, '6', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (7, '7', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (8, '8', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (9, '9', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (10, '10', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (11, '11', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (12, '12', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (13, '13', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (14, '14', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (15, '15', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (16, '16', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (17, '17', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (18, '18', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (19, '19', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (20, '20', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (21, '21', 1);
INSERT INTO tblMayDet (ID, SoMay, TinhTrang) VALUES (22, '22', 1);

-- Table: tblPheCat
CREATE TABLE tblPheCat (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, IDCongCat INTEGER, CongNhan1 INTEGER, PheCat1 INTEGER, CongNhan2 INTEGER, PheCat2 INTEGER, TinhTrang INTEGER DEFAULT (1));

-- Table: tblCongCatPhu
CREATE TABLE tblCongCatPhu (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, NgayCong NUMERIC, Nhom TEXT, CongNhan INTEGER, CongViec INTEGER, GioCong INTEGER, GiaCong INTEGER, ThanhTien INTEGER, TinhTrang INTEGER DEFAULT (1));
INSERT INTO tblCongCatPhu (ID, NgayCong, Nhom, CongNhan, CongViec, GioCong, GiaCong, ThanhTien, TinhTrang) VALUES (1, '2015-07-01', 'C?t', 3, 3, 750, 227, 170250, 1);
INSERT INTO tblCongCatPhu (ID, NgayCong, Nhom, CongNhan, CongViec, GioCong, GiaCong, ThanhTien, TinhTrang) VALUES (2, '2015-07-01', 'C?t', 4, 3, 750, 188, 141000, 1);
INSERT INTO tblCongCatPhu (ID, NgayCong, Nhom, CongNhan, CongViec, GioCong, GiaCong, ThanhTien, TinhTrang) VALUES (3, '2015-07-01', 'C?t', 5, 3, 750, 184, 138000, 1);
INSERT INTO tblCongCatPhu (ID, NgayCong, Nhom, CongNhan, CongViec, GioCong, GiaCong, ThanhTien, TinhTrang) VALUES (4, '2015-07-01', 'C?t', 6, 1, 750, 247, 185250, 1);

-- Table: tblCongNhan
CREATE TABLE tblCongNhan (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, HoTen TEXT (50), CongViec TEXT, NhanVien TEXT, TinhTrang INTEGER DEFAULT (1));
INSERT INTO tblCongNhan (ID, HoTen, CongViec, NhanVien, TinhTrang) VALUES (1, 'Vi?t - c?t máy', 'C?t', 'C?', 1);
INSERT INTO tblCongNhan (ID, HoTen, CongViec, NhanVien, TinhTrang) VALUES (2, 'Vi?t', 'C?t', 'C?', 1);
INSERT INTO tblCongNhan (ID, HoTen, CongViec, NhanVien, TinhTrang) VALUES (3, 'Giang', 'C?t', 'C?', 1);
INSERT INTO tblCongNhan (ID, HoTen, CongViec, NhanVien, TinhTrang) VALUES (4, 'Hùng (vít)', 'C?t', 'C?', 1);
INSERT INTO tblCongNhan (ID, HoTen, CongViec, NhanVien, TinhTrang) VALUES (5, 'B?o', 'C?t', 'C?', 1);
INSERT INTO tblCongNhan (ID, HoTen, CongViec, NhanVien, TinhTrang) VALUES (6, 'Nguyên', 'C?t', 'C?', 1);
INSERT INTO tblCongNhan (ID, HoTen, CongViec, NhanVien, TinhTrang) VALUES (7, 'H?i - c?t máy', 'C?t', 'C?', 1);
INSERT INTO tblCongNhan (ID, HoTen, CongViec, NhanVien, TinhTrang) VALUES (8, 'H?i', 'C?t', 'C?', 1);
INSERT INTO tblCongNhan (ID, HoTen, CongViec, NhanVien, TinhTrang) VALUES (9, 'Thu?n', 'C?t', 'C?', 1);
INSERT INTO tblCongNhan (ID, HoTen, CongViec, NhanVien, TinhTrang) VALUES (10, 'Thành', 'D?t', 'C?', 1);
INSERT INTO tblCongNhan (ID, HoTen, CongViec, NhanVien, TinhTrang) VALUES (11, 'Công', 'D?t', 'C?', 1);

-- Table: tblCongDet
CREATE TABLE tblCongDet (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, NgayCong NUMERIC, CaLam TEXT, CongNhan INTEGER, MayDet INTEGER, KhoDet INTEGER, SoMetTrenMay INTEGER, SoMetSanPham INTEGER, SoOngXuong INTEGER, SoKgSanPhamXuong INTEGER, SoKgSanPhamThuc INTEGER, DonGia INTEGER, ThanhTien INTEGER, TinhTrang INTEGER DEFAULT (1));

-- Table: tblKhoVai
CREATE TABLE tblKhoVai (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, KhoVai TEXT, DonGiaDet INTEGER, DonGiaCat INTEGER, KhoVaiChinh INTEGER DEFAULT (0), TinhTrang INTEGER DEFAULT (1));
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (1, '31mk', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (2, '31lan', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (3, '31tráng', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (4, '31ts', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (5, '37mk', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (6, '37ts', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (7, '45x?p', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (8, '45nd', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (9, '45ts', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (10, '49xanh', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (11, '49lan', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (12, '49mk', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (13, '49g', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (14, '52', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (15, '55', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (16, '55vàng', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (17, '59', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (18, '59n', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (19, '59c75', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (20, '61', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (21, '66', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (22, '68s?c', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (23, '70', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (24, '70nd', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (25, '70n', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (26, '75', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (27, '75nd', 0, 0, 0, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (28, '37mk x57', 0, 19, 5, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (29, '70 x113', 0, 21, 23, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (30, '75 x130', 0, 21, 26, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (31, '31mk x46', 0, 19, 1, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (32, '70n x113', 0, 21, 25, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (33, '59 x88', 0, 19, 17, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (34, '70 x103', 0, 21, 23, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (35, '59 x100', 0, 19, 17, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (36, '45x?p x74', 0, 19, 7, 1);
INSERT INTO tblKhoVai (ID, KhoVai, DonGiaDet, DonGiaCat, KhoVaiChinh, TinhTrang) VALUES (37, '45nd x78', 0, 19, 8, 1);

-- Table: tblViecPhu
CREATE TABLE tblViecPhu (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, TenViec TEXT, TinhTrang INTEGER DEFAULT (1));
INSERT INTO tblViecPhu (ID, TenViec, TinhTrang) VALUES (1, 'Ph? in', 1);
INSERT INTO tblViecPhu (ID, TenViec, TinhTrang) VALUES (2, 'Ph? ch?', 1);
INSERT INTO tblViecPhu (ID, TenViec, TinhTrang) VALUES (3, 'Ph? may', 1);

-- Trigger: ccpAfterUpdate
CREATE TRIGGER ccpAfterUpdate AFTER UPDATE ON tblCongCatPhu BEGIN update tblCongCatPhu
set ThanhTien = GioCong * GiaCong
where ID = old.ID; END;

-- Trigger: ccAfterInsert
CREATE TRIGGER ccAfterInsert AFTER INSERT ON tblCongCat BEGIN UPDATE tblCongCat SET DonGia = (SELECT DonGiaCat FROM tblKhoVai WHERE ID = tblCongCat.KhoVai), SoOng = 1, SoKgOng = 3, PheTH = PheTH1 + PheTH2, PheSuot = PheSuot1 + PheSuot2, PheDC = PheDC1 + PheDC2 WHERE ID = new.ID;
UPDATE tblCongCat SET TongPhe = PheTH + PheSuot + PheDC, SoSPTruPhe = SoKgCat - (PheTH + PheSuot + PheDC) - 3, TongTien = SoLuongSP * DonGia WHERE ID = new.ID;
UPDATE tblCongCat SET TienCong = case when PhutSP = 0 then 0 else round(round(CAST (TongTien * 60 AS real) / PhutSP, 0) * PhutCongNhat / 60, 0) end WHERE ID = new.ID; END;

-- Trigger: ccpAfterInsert
CREATE TRIGGER ccpAfterInsert AFTER INSERT ON tblCongCatPhu BEGIN update tblCongCatPhu
set ThanhTien = GioCong * GiaCong
where ID = new.ID; END;

-- Trigger: ccAfterUpdate
CREATE TRIGGER ccAfterUpdate AFTER UPDATE ON tblCongCat BEGIN UPDATE tblCongCat SET DonGia = (SELECT DonGiaCat FROM tblKhoVai WHERE ID = tblCongCat.KhoVai), SoOng = 1, SoKgOng = 3, PheTH = PheTH1 + PheTH2, PheSuot = PheSuot1 + PheSuot2, PheDC = PheDC1 + PheDC2 WHERE ID = old.ID;
UPDATE tblCongCat SET TongPhe = PheTH + PheSuot + PheDC, SoSPTruPhe = SoKgCat - (PheTH + PheSuot + PheDC) - 3, TongTien = SoLuongSP * DonGia WHERE ID = old.ID;
UPDATE tblCongCat SET TienCong = case when PhutSP = 0 then 0 else round(round(CAST (TongTien * 60 AS real) / PhutSP, 0) * PhutCongNhat / 60, 0) end WHERE ID = old.ID; END;

-- View: vCat_DsLuongTongHop
CREATE VIEW vCat_DsLuongTongHop AS select b.*, (TienSP + TienCong + TienCongPhu) as TongTien from (
    select
        a.CongNhan,
        a.HoTen,
        sum(a.TongOng) as TongOng,
        sum(a.TongPhe) as TongPhe,
        sum(a.TongKgCat) as TongKgCat,        
        sum(a.TongSpTruPhe) as TongSpTruPhe,
        sum(a.TongSoLuongSP) as TongSoLuongSP,
        sum(a.TienSP) as TienSP,
        sum(a.TienCong) as TienCong,
        sum(a.TienCongPhu) as TienCongPhu
    from (
        select
            cc.CongNhan,
            cn.HoTen,
            sum(cc.SoOng) as TongOng,
            sum(cc.TongPhe) as TongPhe,
            sum(cc.SoKgCat) as TongKgCat,        
            sum(cc.SoSPTruPhe) as TongSpTruPhe,
            sum(cc.SoLuongSP) as TongSoLuongSP,
            sum(cc.TongTien) as TienSP,
            sum(cc.TienCong) as TienCong,
            0 as TienCongPhu
        from tblCongCat cc
        left join tblKhoVai kv on cc.KhoVai = kv.ID
        left join tblCongNhan cn on cc.CongNhan = cn.ID
        where cc.TinhTrang = 1
            and cc.NgayCat >= (select ts.TuNgay from tblThamSo ts where ts.ID = 1)
            and cc.NgayCat <= (select ts.DenNgay from tblThamSo ts where ts.ID = 1)
        group by cc.CongNhan,cn.HoTen
        union
        select
            ccp.CongNhan,
            cn.HoTen,
            0 as TongOng,
            0 as TongPhe,
            0 as TongKgCat,        
            0 as TongSpTruPhe,
            0 as TongSoLuongSP,
            0 as TienSP,
            0 as TienCong,
            sum(ccp.ThanhTien) as TienCongPhu
        from tblCongCatPhu ccp
        left join tblViecPhu vp on ccp.CongViec = vp.ID
        left join tblCongNhan cn on ccp.CongNhan = cn.ID
        where ccp.TinhTrang = 1
            and ccp.NgayCong >= (select ts.TuNgay from tblThamSo ts where ts.ID = 1)
            and ccp.NgayCong <= (select ts.DenNgay from tblThamSo ts where ts.ID = 1)
        group by ccp.CongNhan, cn.HoTen
    ) a group by a.CongNhan, a.HoTen
) b
order by b.HoTen;

-- View: vCat_LuongTongHop
CREATE VIEW vCat_LuongTongHop AS select th.*, (th.TienSP + th.TienCong + th.TienCongPhu) as TongTien from (
    select
        cc.NgayCat,
        strftime('%d/%m/%Y', cc.NgayCat) AS NgayCong,
        cn.HoTen,
        sum(cc.TongTien) as TienSP,
        sum(cc.TienCong) as TienCong,
        0 as TienCongPhu
    from tblCongCat cc
    left join tblKhoVai kv on cc.KhoVai = kv.ID
    left join tblCongNhan cn on cc.CongNhan = cn.ID
    where cc.TinhTrang = 1
        and cc.NgayCat >= (select ts.TuNgay from tblThamSo ts where ts.ID = 1)
        and cc.NgayCat <= (select ts.DenNgay from tblThamSo ts where ts.ID = 1)
        and cn.ID = (select ts.CongNhan from tblThamSo ts where ts.ID = 1)
    group by cc.NgayCat, cn.HoTen
    union
    select
        ccp.NgayCong as NgayCat,
        strftime('%d/%m/%Y', ccp.NgayCong) AS NgayCong,
        cn.HoTen,
        0 as TienSP,
        0 as TienCong,
        sum(ccp.ThanhTien) as TienCongPhu
    from tblCongCatPhu ccp
    left join tblViecPhu vp on ccp.CongViec = vp.ID
    left join tblCongNhan cn on ccp.CongNhan = cn.ID
    where ccp.TinhTrang = 1
        and ccp.NgayCong >= (select ts.TuNgay from tblThamSo ts where ts.ID = 1)
        and ccp.NgayCong <= (select ts.DenNgay from tblThamSo ts where ts.ID = 1)
        and cn.ID = (select ts.CongNhan from tblThamSo ts where ts.ID = 1)
    group by ccp.NgayCong, cn.HoTen
) th order by th.NgayCat, th.HoTen;

-- View: vCat_DsCongTongHop
CREATE VIEW vCat_DsCongTongHop AS select th.*, (th.TienSP + th.TienCong + th.TienCongPhu) as TongTien from (
    select
        cc.NgayCat,
        cn.HoTen,
        sum(cc.TongTien) as TienSP,
        sum(cc.TienCong) as TienCong,
        0 as TienCongPhu
    from tblCongCat cc
    left join tblKhoVai kv on cc.KhoVai = kv.ID
    left join tblCongNhan cn on cc.CongNhan = cn.ID
    where cc.TinhTrang = 1
    group by cc.NgayCat, cn.HoTen
    union
    select
        ccp.NgayCong as NgayCat,
        cn.HoTen,
        0 as TienSP,
        0 as TienCong,
        sum(ccp.ThanhTien) as TienCongPhu
    from tblCongCatPhu ccp
    left join tblViecPhu vp on ccp.CongViec = vp.ID
    left join tblCongNhan cn on ccp.CongNhan = cn.ID
    where ccp.TinhTrang = 1
    group by ccp.NgayCong, cn.HoTen
) th order by th.NgayCat, th.HoTen;

-- View: vCat_DsCongChiTiet
CREATE VIEW vCat_DsCongChiTiet AS select * from (
    select
        cc.NgayCat,
        strftime('%d/%m/%Y', cc.NgayCat) AS NgayCong,
        kv.KhoVai as CongViec,
        cn.HoTen,
        sum(cc.SoKgCat) as TongKgCat,
        sum(cc.SoOng) as TongOng,
        sum(cc.TongPhe) as TongPhe,
        sum(cc.SoSPTruPhe) as TongSpTruPhe,
        sum(cc.SoLuongSP) as TongSoLuongSP,
        cc.DonGia,
        sum(cc.TongTien) as TienSP,
        sum(cc.TienCong) as TienCong,
        0 as TienCongPhu
    from tblCongCat cc
    left join tblKhoVai kv on cc.KhoVai = kv.ID
    left join tblCongNhan cn on cc.CongNhan = cn.ID
    where cc.TinhTrang = 1
    group by cc.NgayCat, cc.KhoVai, cn.HoTen, cc.DonGia
    union
    select
        ccp.NgayCong as NgayCat,
        strftime('%d/%m/%Y', ccp.NgayCong) AS NgayCong,
        vp.TenViec as CongViec,
        cn.HoTen,
        0 as TongKgCat,
        0 as TongOng,
        0 as TongPhe,
        0 as TongSpTruPhe,
        0 as TongSoLuongSP,
        0 as DonGia,
        0 as TienSP,
        0 as TienCong,
        sum(ccp.ThanhTien) as TienCongPhu
    from tblCongCatPhu ccp
    left join tblViecPhu vp on ccp.CongViec = vp.ID
    left join tblCongNhan cn on ccp.CongNhan = cn.ID
    where ccp.TinhTrang = 1
    group by ccp.NgayCong, vp.TenViec, cn.HoTen
) a order by a.NgayCat, a.HoTen;

-- View: vCat_LuongChiTiet
CREATE VIEW vCat_LuongChiTiet AS select a.* from (
    select
        cc.NgayCat,
        strftime('%d/%m/%Y', cc.NgayCat) AS NgayCong, 
        kv.KhoVai as CongViec,
        cn.HoTen,
        sum(cc.SoKgCat) as TongKgCat,
        sum(cc.SoOng) as TongOng,
        sum(cc.TongPhe) as TongPhe,
        sum(cc.SoSPTruPhe) as TongSpTruPhe,
        sum(cc.SoLuongSP) as TongSoLuongSP,
        cc.DonGia,
        sum(cc.TongTien) as TienSP,
        sum(cc.TienCong) as TienCong,
        0 as TienCongPhu
    from tblCongCat cc
    left join tblKhoVai kv on cc.KhoVai = kv.ID
    left join tblCongNhan cn on cc.CongNhan = cn.ID
    where cc.TinhTrang = 1
        and cc.NgayCat >= (select ts.TuNgay from tblThamSo ts where ts.ID = 1)
        and cc.NgayCat <= (select ts.DenNgay from tblThamSo ts where ts.ID = 1)
        and cn.ID = (select ts.CongNhan from tblThamSo ts where ts.ID = 1)
    group by cc.NgayCat, cc.KhoVai, cn.HoTen, cc.DonGia
    union
    select
        ccp.NgayCong as NgayCat,
        strftime('%d/%m/%Y', ccp.NgayCong) AS NgayCong, 
        vp.TenViec as CongViec,
        cn.HoTen,
        0 as TongKgCat,
        0 as TongOng,
        0 as TongPhe,
        0 as TongSpTruPhe,
        0 as TongSoLuongSP,
        0 as DonGia,
        0 as TienSP,
        0 as TienCong,
        sum(ccp.ThanhTien) as TienCongPhu
    from tblCongCatPhu ccp
    left join tblViecPhu vp on ccp.CongViec = vp.ID
    left join tblCongNhan cn on ccp.CongNhan = cn.ID
    where ccp.TinhTrang = 1
        and ccp.NgayCong >= (select ts.TuNgay from tblThamSo ts where ts.ID = 1)
        and ccp.NgayCong <= (select ts.DenNgay from tblThamSo ts where ts.ID = 1)
        and cn.ID = (select ts.CongNhan from tblThamSo ts where ts.ID = 1)
    group by ccp.NgayCong, vp.TenViec, cn.HoTen
) a order by a.NgayCat;

-- View: vCat_DsCapNhat
CREATE VIEW vCat_DsCapNhat AS SELECT cc.ID, strftime('%m/%d/%Y', cc.NgayCat) AS NgayCat, cc.CongNhan, cc.KhoVai, CAST (cc.SoKgCat AS text) AS SoKgCat, cc.PheTH_CN1, CAST (cc.PheTH1 AS text) AS PheTH1, cc.PheTH_CN2, CAST (cc.PheTH2 AS text) AS PheTH2, cc.PheSuot_CN1, CAST (cc.PheSuot1 AS text) AS PheSuot1, cc.PheSuot_CN2, CAST (cc.PheSuot2 AS text) AS PheSuot2, cc.PheDC_CN1, CAST (cc.PheDC1 AS text) AS PheDC1, cc.PheDC_CN2, CAST (cc.PheDC2 AS text) AS PheDC2, cc.SoLuongSP, cc.PhutSP, cc.PhutCongNhat FROM tblCongCat cc;

-- View: vCat_TongHopSP
CREATE VIEW vCat_TongHopSP AS select
    kv.KhoVai,
    /*case when a.CongNhan is null then 0 else a.CongNhan end as CongNhan,
    case when a.KhoVaiChinh is null then 0 else a.KhoVaiChinh end as KhoVaiChinh,*/
    case when a.TongKgCat is null then 0 else a.TongKgCat end as TongKgCat,
    case when a.TongOng is null then 0 else a.TongOng end as TongOng,
    case when a.TongKgSP is null then 0 else a.TongKgSP end as TongKgSP,
    case when a.TongSP is null then 0 else a.TongSP end as TongSP
from tblKhoVai kv
left join (
    select
        /*cc.CongNhan,*/
        case
            when kv.KhoVaiChinh <> 0 then kv.KhoVaiChinh
            else kv.ID end as KhoVaiChinh,
        sum(cc.SoKgCat) as TongKgCat,
        sum(cc.SoOng) as TongOng,
        sum(cc.SoSPTruPhe) as TongKgSP,
        sum(cc.SoLuongSP) as TongSP
    from tblCongCat cc
    left join tblKhoVai kv on cc.KhoVai = kv.ID
    where cc.TinhTrang = 1
        and ((select ts.TuNgay from tblThamSo ts where ts.ID = 1) = 0 or cc.NgayCat >= (select ts.TuNgay from tblThamSo ts where ts.ID = 1))
        and cc.NgayCat <= (select ts.DenNgay from tblThamSo ts where ts.ID = 1)
        and ((select ts.CongNhan from tblThamSo ts where ts.ID = 1) = 0 or cc.CongNhan = (select ts.CongNhan from tblThamSo ts where ts.ID = 1))
    group by /*cc.CongNhan,*/ cc.KhoVai
) a on kv.ID = a.KhoVaiChinh
where kv.TinhTrang = 1 and kv.KhoVaiChinh = 0;

-- View: vCat_DsHienThi
CREATE VIEW vCat_DsHienThi AS SELECT cc.ID, strftime('%d/%m/%Y', cc.NgayCat) AS NgayCat, cn.HoTen, kv.KhoVai, CAST (cc.SoKgCat AS text) AS SoKgCat, CAST (cc.PheTH AS text) AS PheTH, CAST (cc.PheSuot AS text) AS PheSuot, CAST (cc.PheDC AS text) AS PheDC, cc.SoLuongSP, cc.PhutSP, cc.PhutCongNhat FROM tblCongCat cc LEFT JOIN tblCongNhan cn ON cc.CongNhan = cn.ID LEFT JOIN tblKhoVai kv ON cc.KhoVai = kv.ID WHERE cc.TinhTrang = 1 ORDER BY cc.NgayCat DESC, cc.ID DESC;

-- View: vCat_DsViecPhu
CREATE VIEW vCat_DsViecPhu AS select
    ccp.ID,
    strftime('%d/%m/%Y', ccp.NgayCong) as NgayCong,
    cn.HoTen, vp.TenViec,
    ccp.GioCong, ccp.GiaCong    
from tblCongCatPhu ccp
left join tblCongNhan cn on ccp.CongNhan = cn.ID
left join tblViecPhu vp on ccp.CongViec = vp.ID
where ccp.TinhTrang = 1
order by ccp.NgayCong desc, ccp.ID desc;

-- View: vDsKhoVai
CREATE VIEW vDsKhoVai AS SELECT a.*, case when b.ID is null then '' else b.KhoVai end as KVC
FROM tblKhoVai a
LEFT JOIN (
    SELECT * FROM tblKhoVai
    WHERE KhoVaiChinh = 0 AND TinhTrang = 1
) b ON b.ID = a.KhoVaiChinh
WHERE a.TinhTrang = 1
ORDER BY a.ID DESC;

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;

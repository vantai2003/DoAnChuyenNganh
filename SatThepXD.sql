﻿create database QL_SatThepXD
GO
use QL_SatThepXD
GO

-- Bảng LoaiSanPham
CREATE TABLE LoaiSanPham (
    MaLoai VARCHAR(50) PRIMARY KEY NOT NULL,
    TenLoai NVARCHAR(200)
);

-- Bảng NhaCungCap
CREATE TABLE NhaCungCap (
    MaNCC VARCHAR(50) PRIMARY KEY NOT NULL,
    TenNCC NVARCHAR(200),
    SDT VARCHAR(11) UNIQUE,
    Email VARCHAR(100) UNIQUE,
    DiaChi NVARCHAR(500),
	ThanhPho NVARCHAR(20),
    QuocGia NVARCHAR(50),
    NgayTao DATE
);

-- Bảng Kho
CREATE TABLE Kho (
    MaKho VARCHAR(50) PRIMARY KEY NOT NULL,
    TenKho NVARCHAR(100),
    DiaChi NVARCHAR(500)
);

-- Bảng SanPham
CREATE TABLE SanPham (
    MaSP VARCHAR(50) PRIMARY KEY  NOT NULL,
    TenSP NVARCHAR(200),
    DVT NVARCHAR(20),
    MaLoai VARCHAR(50) NOT NULL,
    FOREIGN KEY (MaLoai) REFERENCES LoaiSanPham(MaLoai)
);
CREATE TABLE Kho_SanPham (
    MaKho VARCHAR(50) NOT NULL,
    MaSP VARCHAR(50) NOT NULL,
    SoLuongTon DECIMAL(18, 2) DEFAULT 0,
    PRIMARY KEY (MaKho, MaSP),
    FOREIGN KEY (MaKho) REFERENCES Kho(MaKho),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

CREATE TABLE CT_SanPhamNCC (
    NgayBatDauHopTac DATE,
    MaNCC VARCHAR(50) NOT NULL,
    MaSP VARCHAR(50) NOT NULL,
    PRIMARY KEY (MaNCC, MaSP),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);
CREATE TABLE LoaiKH (
    MaLoaiKH VARCHAR(50) PRIMARY KEY NOT NULL,
    TenLoaiKH NVARCHAR(200) UNIQUE,
);
-- Bảng KhachHang
CREATE TABLE KhachHang (
    MaKH VARCHAR(50) PRIMARY KEY NOT NULL,
    TenKH NVARCHAR(100),
    SoDienThoai VARCHAR(20) UNIQUE,
    Email VARCHAR(100) UNIQUE,
    DiaChi NVARCHAR(255),
    NgayTao DATE,
	MaLoaiKH VARCHAR(50) NOT NULL,
	FOREIGN KEY (MaLoaiKH) REFERENCES LoaiKH(MaLoaiKH)
);

-- Bảng NhanVien
CREATE TABLE NhanVien (
    MaNV VARCHAR(50) PRIMARY KEY NOT NULL,
    TenNV NVARCHAR(100),
    ChucVu NVARCHAR(100),
    SDT VARCHAR(20) UNIQUE,
    Email VARCHAR(100) UNIQUE,
    NgayTuyenDung DATE,
    Luong DECIMAL(18, 0)
);

-- Bảng HoaDon
CREATE TABLE HoaDon (
    MaHD VARCHAR(50) PRIMARY KEY NOT NULL,
    NgayDatHang DATE,
    TongTien DECIMAL(18, 0),
	TrangThai NVARCHAR(20),
    DiaChiGiaoHang NVARCHAR(500),
    TienCoc DECIMAL(18, 0),
    ThanhToan DECIMAL(18, 0),
    MaKH VARCHAR(50)NOT NULL,
    MaNV VARCHAR(50)NOT NULL,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng CT_HoaDon (Chi tiết hóa đơn)
CREATE TABLE CT_HoaDon (
    MaCTHD VARCHAR(50) PRIMARY KEY NOT NULL,
    SoLuong DECIMAL(18, 3),
    DonGia DECIMAL(18, 0),
    DVT VARCHAR(20),
    ThanhTien DECIMAL(18, 0),
    MaSP VARCHAR(50)NOT NULL,
    MaHD VARCHAR(50)NOT NULL,
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD)
);

-- Bảng PhieuNhapHang
CREATE TABLE PhieuNhapHang (
    MaPhieuNH VARCHAR(50) PRIMARY KEY NOT NULL,
    NgayDatHang DATE,
    TongTien DECIMAL(18, 0) CHECK (TongTien >= 0),
    TrangThai NVARCHAR(20),
    MaNCC VARCHAR(50) NOT NULL,
    MaKho VARCHAR(50) NOT NULL,
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
    FOREIGN KEY (MaKho) REFERENCES Kho(MaKho)
);
go
alter table PhieuNhapHang
add MaNV VARCHAR(50)

go
ALTER TABLE NhanVien
ADD CONSTRAINT FK_PhieuNhanHang_NhanVien
FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)

go
-- Bảng CTPhieuNhapHang (Chi tiết phiếu nhập hàng)
CREATE TABLE CTPhieuNhapHang (
    MaCTPhieuNH VARCHAR(50) PRIMARY KEY NOT NULL,
    SoLuong DECIMAL(18, 2) (SoLuong > 0),
    DonGia DECIMAL(18, 0) (DonGia >= 0),
    NgayNhapHang DATE,
    MaSP VARCHAR(50) NOT NULL,
    MaPhieuNH VARCHAR(50) NOT NULL,
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
    FOREIGN KEY (MaPhieuNH) REFERENCES PhieuNhapHang(MaPhieuNH)
);

-- Bảng PhieuTraHangKH
CREATE TABLE PhieuTraHangKH (
    MaPhieuTraHang VARCHAR(50) PRIMARY KEY NOT NULL,
    LyDo NVARCHAR(255),
    MaNV VARCHAR(50) NOT NULL,
    MaHoaDon VARCHAR(50) NOT NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHD)
);

--sửa lại bảng PhieuTraHangKH
ALTER TABLE PhieuTraHangKH
DROP COLUMN SoLuong;

ALTER TABLE PhieuTraHangKH
DROP COLUMN MaKH;
go
ALTER TABLE PhieuTraHangKH
DROP CONSTRAINT FK__PhieuTraH__MaKho__5070F446;
go

ALTER TABLE PhieuTraHangKH
DROP COLUMN MaKho;
go
ALTER TABLE PhieuTraHangKH
ADD MaHD VARCHAR(50) NOT NULL;
go

----Lưu ý xóa khóa ngooaiji KH luôn
ALTER TABLE PhieuTraHangKH
ADD CONSTRAINT FK_PhieuTraHangKH_HoaDon
FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD);

-- Bảng PhieuTraHangNCC
CREATE TABLE PhieuTraHangNCC (
    MaPhieuTraHang VARCHAR(50) PRIMARY KEY NOT NULL,
    SoLuong DECIMAL (18, 3),
    LyDo NVARCHAR(255),
    MaPhieuNH VARCHAR(50) NOT NULL,
    MaNCC VARCHAR(50) NOT NULL,
    FOREIGN KEY (MaPhieuNH) REFERENCES PhieuNhapHang(MaPhieuNH),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
);

-- Bảng KhuyenMai
CREATE TABLE KhuyenMai (
    MaKM VARCHAR(50) PRIMARY KEY NOT NULL,
    TenKM NVARCHAR(100),
    NgayBatDau DATE,
    NgayKetThuc DATE,
    MoTa NVARCHAR(200),
    TrangThai NVARCHAR(20),
    GiaTriKM DECIMAL(18, 2)
);

-- Bảng CTDieuKienKM
CREATE TABLE CTDieuKienKM (
    LoaiDieuKien VARCHAR(50),
    MaKM VARCHAR(50) NOT NULL,
    MaHD VARCHAR(50) NOT NULL,
	PRIMARY KEY (MaKM, MaHD),
    FOREIGN KEY (MaKM) REFERENCES KhuyenMai(MaKM),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD)
);
-- Bảng Quyen
CREATE TABLE Quyen (
    Id INTEGER PRIMARY KEY NOT NULL,
    TenQuyen VARCHAR(50)
);
-- Bảng NguoiDung
CREATE TABLE NguoiDung (
    TenDN VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(100),
    NgayTao DATE,
    MaNV VARCHAR(50) NOT NULL,
    QuyenID int NOT NULL,
	FOREIGN KEY (QuyenID) REFERENCES Quyen(Id),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO
INSERT INTO Quyen VALUES(0,N'Admin'),
(1, N'Giám đốc'),
(2, N'kế toán'),
(3, N'Nhân viên bán hàng'),
(4, N'Nhân viên giao hàng'),
(5, N'Nhân viên kho')
GO
INSERT INTO NhanVien VALUES('NV001',N'Nguyễn Văn Tài',N'Quản trị viên', '0326588524', 'banpro@gmail.com','2024-10-10', 20000000)
GO
INSERT INTO NguoiDung(TenDN, MatKhau, NgayTao ,QuyenID, MaNV) VALUES('admin', CONVERT(VARCHAR(32),HASHBYTES('MD5', 'admin@123'),2),GETDATE() ,0, 'NV001')

GO 
INSERT INTO LoaiKH (MaLoaiKH,TenLoaiKH) VALUES('LK001',N'Khách hàng thân thiết'),
                                              ('LK002',N'Khách hàng thường')
GO
INSERT INTO LoaiSanPham(MaLoai,TenLoai)VALUES('ML001',N'Hòa Phát'),
											 ('ML002',N'Việt Nhật')
GO
INSERT INTO KhachHang(MaKH, TenKH, SoDienThoai, Email, DiaChi, NgayTao, MaLoaiKH) VALUES('KH001',N'Trần Thế An','0981888213','tranan11@gmail.com',N'Thành phố Hồ Chí Minh','2024-11-23','LK002')

GO
INSERT INTO NhaCungCap(MaNCC,TenNCC,SDT,Email,DiaChi,ThanhPho,QuocGia,NgayTao) VALUES('NCC001',N'Công ty sắt thép Việt Phát','0988388111','info@VietPhat',N'66 Nguyễn Du, P. Nguyễn Du, Q. Hai Bà Trưng',N'Hà Nội',N'Việt Nam','2024-11-27')
GO
INSERT INTO KHO VALUES('MK001',N'Kho Thép A','Lê trọng tấn TP.Hồ Chí Minh')


-- Stored Procedures Login
GO
CREATE PROC SP_Login
@TenDN varchar(100), @MatKhau varchar(50)
AS 
BEGIN
	SELECT * FROM NguoiDung WHERE TenDN = @TenDN AND MatKhau = @MatKhau
END
GO
--thủ tục getlist người dùng
GO
CREATE PROC SP_GetListNguoiDung
AS
BEGIN
	SELECT * FROM NguoiDung
END
GO

----------------------------------Người dùng-----------------------------
--thủ tục tìm người dùng
CREATE PROC SP_TimKiemNguoiDung
@SearchValue varchar(50)
AS
BEGIN
	SELECT * FROM NguoiDung WHERE TenDN LIKE '%' + @SearchValue + '%'
	or MaNV LIKE '%' + @SearchValue + '%'
END
GO

--thủ tục thêm người dùng
CREATE PROC SP_ThemNguoiDung
@TenDN varchar(50),
@MatKhau varchar(50),
@NgayTao date,
@MaNV varchar(10),
@QuyenID int
AS 
BEGIN
	INSERT INTO NguoiDung VALUES(@TenDN, @MatKhau, @NgayTao, @MaNV, @QuyenID)
END
GO

--thủ tục kiểm tra trùng tên
CREATE PROC SP_KiemTraTrungten
@TenDN varchar(50)
AS
BEGIN
	SELECT * FROM NguoiDung WHERE TenDN = @TenDN
END
GO
--thu tuc xoa nguoi dung
CREATE PROC SP_XoaNguoiDung
@TenDN varchar(50)
AS
BEGIN
	DELETE FROM NguoiDung WHERE TenDN = @TenDN
END
GO
--thủ tục sửa người dùng
CREATE PROC SP_SuaNguoiDung
@TenDN varchar(50), @MatKhau varchar(50), @MaNV varchar(50), @QuyenId int
AS
BEGIN
	UPDATE NguoiDung
	SET  MatKhau = @MatKhau, MaNV = @MaNV, QuyenID = @QuyenId
	WHERE NguoiDung.TenDN = @TenDN
END
GO



----------------------------------Nhân viên-----------------------------
--thu tuc getlist nhan vien

CREATE PROC SP_GetListNhanVien
AS
BEGIN
	SELECT * FROM NhanVien
END
GO
----------------------------------Quyền-----------------------------
--thu tuc getlist quyen
CREATE PROC SP_GetListQuyen
AS
BEGIN
	SELECT * FROM Quyen
END
GO



----------------------------------Loại Sản phẩm-----------------------------
--thủ tục getlist Loại sản phẩm
CREATE PROC SP_GetListNLoaiSP
AS
BEGIN
	SELECT * FROM LoaiSanPham
END
GO
---thur tuc them loai sp
CREATE PROC SP_ThemLoaiSP
@MaLoai varchar(50),
@TenLoai nvarchar(50)
AS 
BEGIN
	INSERT INTO LoaiSanPham VALUES(@MaLoai, @TenLoai)
END
GO

--kiểm tra trùng mã loại
CREATE PROC SP_KiemTraMaLoai
@MaLoai varchar(50)
AS
BEGIN
	SELECT * FROM LoaiSanPham WHERE MaLoai = @MaLoai
END
GO
--tìm kiếm loại sp
CREATE PROC SP_TimKiemLSP
@SearchValue varchar(50)
AS
BEGIN
	SELECT * FROM LoaiSanPham WHERE MaLoai LIKE '%' + @SearchValue + '%'
	or TenLoai LIKE '%' + @SearchValue + '%'
END
GO

--thu tuc xoa loai sp
CREATE PROC SP_XoaLoaiSP
@MaLoai varchar(50)
AS
BEGIN
	DELETE FROM LoaiSanPham WHERE MaLoai = @MaLoai
END
GO
exec SP_XoaLoaiSP @MaLoai = 'VA';

--thủ tục sửa loại sản phẩm
CREATE PROC SP_SuaLoaiSP
@Maloai varchar(100), @TenLoai nvarchar(50)
AS
BEGIN
	UPDATE LoaiSanPham
	SET  TenLoai = @TenLoai
	WHERE LoaiSanPham.MaLoai = @Maloai
END

---------Lấy tất cả các cột trong bảng Khách Hàng----------------------
CREATE PROC sp_SelectAll_KhachHang
AS
BEGIN
    SELECT * FROM KhachHang;
END;
GO

----------Insert Khách Hàng----------------
CREATE PROC  sp_Insert_KhachHang
    @MaKH VARCHAR(50),
    @TenKH NVARCHAR(100),
    @SoDienThoai VARCHAR(20),
    @Email VARCHAR(100),
    @DiaChi NVARCHAR(255),
    @NgayTao DATE,
	@MaLoaiKH VARCHAR(50)
AS
BEGIN
    INSERT INTO KhachHang
    VALUES (@MaKH,@TenKH,@SoDienThoai,@Email,@DiaChi,@NgayTao,@MaLoaiKH)
END;
GO

GO
----------------------Cập nhật Khách Hàng----------------------------------

CREATE PROCEDURE sp_Update_KhachHang
    @MaKH VARCHAR(50),
    @TenKH NVARCHAR(100),
    @SoDienThoai VARCHAR(20),
    @Email VARCHAR(100),
    @DiaChi NVARCHAR(255),
    @NgayTao DATE,
	@MaLoaiKH VARCHAR(50)
AS
BEGIN
    UPDATE KhachHang
    SET TenKH =@TenKH,
    SoDienThoai = @SoDienThoai,
    Email = @Email,
    DiaChi = @DiaChi,
    NgayTao = @NgayTao,
	MaLoaiKH = @MaLoaiKH
    WHERE MaKH = @MaKH;
END;
GO
----------------------Xóa Khách Hàng----------------------
CREATE PROCEDURE sp_Delete_KhachHang
    @MaKH VARCHAR(50)
AS
BEGIN
    DELETE FROM KhachHang
    WHERE MaKH = @MaKH
END;
GO
---------Lấy tất cả các cột trong bảng Loại Sản Phẩm----------------------
CREATE PROC sp_SelectAll_LoaiSanPham
AS
BEGIN
    SELECT * FROM LoaiSanPham;
END;
GO
----------Insert Lọai Sản Phẩm-----------------------------------
CREATE PROC  sp_Insert_LoaiSanPham
    @MaLoai VARCHAR(50),
    @TenLoai NVARCHAR(50)
AS
BEGIN
    INSERT INTO LoaiSanPham(MaLoai,TenLoai)
    VALUES (@MaLoai, @TenLoai);
END;
GO

GO
----------------------Cập nhật Lọai Sản Phẩm----------------------------------

CREATE PROCEDURE sp_Update_LoaiSanPham
    @MaLoai VARCHAR(10),
    @TenLoai NVARCHAR(50)
AS
BEGIN
    UPDATE LoaiSanPham
    SET TenLoai = @TenLoai
    WHERE MaLoai = @MaLoai;
END;
GO
----------------------Xóa Lọai Sản Phẩm----------------------
CREATE PROCEDURE sp_Delete_LoaiSanPham
    @MaLoai VARCHAR(50)
AS
BEGIN
    DELETE FROM LoaiSanPham
    WHERE MaLoai = @MaLoai
END;
GO

---------Lấy tất cả các cột trong bảng Loại Khách Hàng----------------------
CREATE PROC sp_SelectAll_LoaiKH
AS
BEGIN
    SELECT * FROM LoaiKH;
END;
GO
---------------------Thêm Loại Khách Hàng-------------------
CREATE PROC sp_Insert_LoaiKhachHang
	@MaLKH VARCHAR(50),
	@TenLKH NVARCHAR(50)
AS
BEGIN 
	INSERT INTO LoaiKH(MaLoaiKH, TenLoaiKH)
    VALUES (@MaLKH,@TenLKH);
END;
GO
-----------Cập nhật Loại Khách Hàng-------------------
CREATE PROC sp_Update_LoaiKhachHang
    @MaLKH VARCHAR(50),
	@TenLKH NVARCHAR(50)
AS
BEGIN
    UPDATE LoaiKH
    SET TenLoaiKH = @TenLKH
    WHERE MaLoaiKH = @MaLKH;
END;
GO
----------------------Xóa Loại Khách Hàng----------------------
CREATE PROC sp_Delete_LoaiKhachHang
    @MaLKH VARCHAR(50)
AS
BEGIN
    DELETE FROM LoaiKH
    WHERE MaLoaiKH = @MaLKH;
END;
GO


---------Lấy tất cả các cột trong bảng Nhà Cung Cấp ----------------------
CREATE PROC sp_SelectAll_NCC
AS
BEGIN
    SELECT * FROM NhaCungCap;
END;
GO
--------------------Thêm Nhà cung cấp--------------------------------------
CREATE PROC sp_Insert_NhaCungCap
    @MaNCC VARCHAR(50) ,
    @TenNCC NVARCHAR(200),
    @SDT VARCHAR(11) ,
    @Email VARCHAR(100) ,
    @DiaChi NVARCHAR(500),
	@ThanhPho NVARCHAR(20),
    @QuocGia NVARCHAR(50),
    @NgayTao DATE
AS
BEGIN
    INSERT INTO NHACUNGCAP
    VALUES (@MaNCC, @TenNCC, @SDT, @Email, @DiaChi, @ThanhPho, @QuocGia, @NgayTao);
END;
GO
------------------------Cập nhật Nhà cung cấp-----------------------
CREATE PROCEDURE sp_Update_NhaCungCap
    @MaNCC VARCHAR(50) ,
    @TenNCC NVARCHAR(200),
    @SDT VARCHAR(11) ,
    @Email VARCHAR(100) ,
    @DiaChi NVARCHAR(500),
	@ThanhPho NVARCHAR(20),
    @QuocGia NVARCHAR(50),
    @NgayTao DATE
AS
BEGIN
    UPDATE NHACUNGCAP
    SET TENNCC = @TenNCC,
        SDT = @SDT,
        Email = @Email,
        DiaChi = @DiaChi,
		ThanhPho =@ThanhPho,
		QuocGia =@QuocGia,
		NgayTao =@NgayTao
    WHERE MANCC = @MaNCC;
END;
GO
----------------------------Xóa Nhà cung cấp----------------------------
CREATE PROCEDURE sp_Delete_NhaCungCap
    @MaNCC VARCHAR(50)
AS
BEGIN
    DELETE FROM NHACUNGCAP
    WHERE MANCC = @MaNCC;
END;
GO

---------Lấy tất cả các cột trong bảng Kho----------------------
CREATE PROC sp_SelectAll_Kho
AS
BEGIN
    SELECT * FROM Kho;
END;
GO
---------------------Thêm Kho-------------------
CREATE PROC sp_Insert_Kho
	@MaKho VARCHAR(50),
	@TenKho NVARCHAR(100),
	@DiaChi NVARCHAR(500)
AS
BEGIN 
	INSERT INTO Kho
    VALUES (@MaKho,@TenKho,@DiaChi);
END;
GO
-----------Cập nhật Kho-------------------
CREATE PROC sp_Update_Kho
	@MaKho VARCHAR(50),
	@TenKho NVARCHAR(100),
	@DiaChi NVARCHAR(500)
AS
BEGIN
    UPDATE Kho
    SET TenKho = @TenKho,
		DiaChi = @DiaChi
    WHERE MaKho = @MaKho;
END;
GO
----------------------Xóa Kho----------------------
CREATE PROC sp_Delete_Kho
    @MaKho VARCHAR(50)
AS
BEGIN
    DELETE FROM Kho
    WHERE MaKho = @MaKho;
END;
GO

----------------------------------Sản phẩm-----------------------------
--thủ tục getlist Loại sản phẩm
CREATE PROC SP_GetListSP
AS
BEGIN
	SELECT * FROM SanPham
END
GO
---thur tuc them loai sp
CREATE PROC SP_TaoMaSP
AS
BEGIN
    DECLARE @LastMaSP varchar(10);
    DECLARE @NewNumber int;
    DECLARE @NewMaSP varchar(10);
    
    -- Truy vấn mã NV lớn nhất hiện có, bỏ qua phần "NV" và chỉ lấy số
    SELECT @LastMaSP = MAX(MaSP) FROM SanPham;
    
    -- Nếu bảng chưa có bản ghi nào thì bắt đầu từ NV001
    IF @LastMaSP IS NULL
    BEGIN
        SET @NewNumber = 1;
    END
    ELSE
    BEGIN
        -- Lấy phần số của MaNV (bỏ đi 2 ký tự đầu "NV")
        SET @NewNumber = CAST(SUBSTRING(@LastMaSP, 3, LEN(@LastMaSP) - 2) AS INT) + 1;
    END
    
    -- Tạo MaNV mới với định dạng NV + số mới
    SET @NewMaSP = 'SP' + RIGHT('000' + CAST(@NewNumber AS VARCHAR), 3);
    
    -- Trả về MaNV mới
    SELECT @NewMaSP;
END
GO


CREATE PROC SP_ThemSP
@MaSP varchar(50), @TenSP nvarchar(200), @DVT nvarchar(10), @MaLoai varchar(10)
AS 
BEGIN
	INSERT INTO SanPham VALUES(@MaSP , @TenSP , @DVT , @MaLoai)
END
GO

--kiểm tra trùng mã loại
CREATE PROC SP_KiemTraMaSP
@MaSP varchar(50)
AS
BEGIN
	SELECT * FROM SanPham WHERE MaSP = @MaSP
END
GO

--thu tuc xoa sp
CREATE PROC SP_XoaSP
@MaSP varchar(50)
AS
BEGIN
	DELETE FROM SanPham WHERE MaSP = @MaSP
END
GO


--thủ tục sửa sản phẩm
CREATE PROC SP_SuaSP
@MaSP varchar(50), @TenSP nvarchar(200), @DVT nvarchar(10), @MaLoai varchar(10)
AS
BEGIN
	UPDATE SanPham
	SET  TenSP = @TenSP, DVT = @DVT, MaLoai = @MaLoai
	WHERE SanPham.MaSP = @MaSP
END

--thủ tục tìm sản phẩm
CREATE PROC SP_TimKiemSP
@SearchValue varchar(50)
AS
BEGIN
	SELECT * FROM SanPham WHERE MaSP LIKE '%' + @SearchValue + '%'
	or TenSP LIKE '%' + @SearchValue + '%'
END
GO
--lọc sản phẩm theo kho


--thủ tục sao lưu
CREATE PROCEDURE SP_BackupDatabase
	@BackupPath nvarchar(200)
AS
BEGIN
	BACKUP DATABASE QL_SatThepXD TO DISK = @BackupPath WITH FORMAT, INIT;
END

--THỦ TỤC PHỤC HỒI
CREATE PROCEDURE SP_RestoreDatabase
    @BackupPath NVARCHAR(200)
AS
BEGIN
    -- Đặt database vào chế độ single-user để ngắt kết nối hiện tại
    ALTER DATABASE QL_SatThepXD SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    
    -- Thực hiện phục hồi
    RESTORE DATABASE QL_SatThepXD FROM DISK = @BackupPath WITH REPLACE;
    
    -- Đặt lại chế độ multi-user sau khi hoàn tất
    ALTER DATABASE QL_SatThepXD SET MULTI_USER;
END


----------------quản lý tồn kho
--chạy lại cái này
ALTER TABLE SanPham
DROP CONSTRAINT FK__SanPham__MaKho__2C3393D0;
ALTER TABLE SanPham
DROP COLUMN MaKho;
exec SP_GetListSP
drop proc SP_GetProductsInStock
--thủ tục lấy dữ liệu tồn
CREATE PROCEDURE SP_GetProductsInStock
AS
BEGIN
    SELECT sp.MaSP, sp.TenSP, sp.DVT, k.TenKho, ks.SoLuongTon, lp.TenLoai
    FROM Kho_SanPham ks
    JOIN SanPham sp ON ks.MaSP = sp.MaSP
    JOIN Kho k ON ks.MaKho = k.MaKho
    JOIN LoaiSanPham lp ON sp.MaLoai = lp.MaLoai; -- Kết nối với bảng LoaiSanPham
END
GO
--Lấy thông tin người dùng 
CREATE PROCEDURE SP_GetThongTinNguoiDung
@TenDN varchar(50)
AS
BEGIN
	SELECT nv.MaNV, nv.TenNV, nv.Email, nv.NgayTuyenDung, nv.SDT, nv.ChucVu
	FROM NguoiDung nd
	JOIN NhanVien nv ON nd.MaNV = nv.MaNV
	WHERE nd.TenDN = @TenDN
END
GO
-----------------------------------Nhaapj Hang
CREATE PROC SP_TaoMaPN
AS
BEGIN
    DECLARE @LastMaPN varchar(10);
    DECLARE @NewNumber int;
    DECLARE @NewMaPN varchar(10);
    
    -- Truy vấn mã PN lớn nhất hiện có
    SELECT @LastMaPN = MAX(MaPhieuNH) FROM PhieuNhapHang;
    
    -- Nếu bảng chưa có thì bắt đầu từ NV001
    IF @LastMaPN IS NULL
    BEGIN
        SET @NewNumber = 1;
    END
    ELSE
    BEGIN
        -- Lấy phần số của MaNV (bỏ đi 2 ký tự đầu "NV")
        SET @NewNumber = CAST(SUBSTRING(@LastMaPN, 3, LEN(@LastMaPN) - 2) AS INT) + 1;
    END
    
    -- Tạo mới với định dạng PN + số mới
    SET @NewMaPN = 'PN' + RIGHT('000' + CAST(@NewNumber AS VARCHAR), 3);
    
    -- Trả về MaNV mới
    SELECT @NewMaPN;
END
GO
--thu tuc tao phieu nhap hang
CREATE PROCEDURE SP_ThemPhieuNhapHang
    @MaPhieuNH VARCHAR(50),
    @NgayDatHang DATE,
    @TongTien DECIMAL(18, 0),
    @TrangThai NVARCHAR(20),
	@MaNV VARCHAR(50),
    @MaNCC VARCHAR(50),
    @MaKho VARCHAR(50)
AS
BEGIN
    INSERT INTO PhieuNhapHang (MaPhieuNH, NgayDatHang, TongTien, TrangThai, MaNV, MaNCC, MaKho)
    VALUES (@MaPhieuNH, @NgayDatHang, @TongTien, @TrangThai, @MaNV, @MaNCC, @MaKho)
END
GO

------thủ tục tăng mã ct phiếu nhập
CREATE PROC SP_TaoMaCTPN
AS
BEGIN
    DECLARE @LastMaCTPN varchar(10);
    DECLARE @NewNumber int;
    DECLARE @NewMaPN varchar(10);
    SELECT @LastMaCTPN = MAX(MaCTPhieuNH) FROM CTPhieuNhapHang;
    
    -- Nếu bảng chưa có thì bắt đầu từ CTPN001
    IF @LastMaCTPN IS NULL
    BEGIN
        SET @NewNumber = 1;
    END
    ELSE
    BEGIN
        IF LEN(@LastMaCTPN) >= 4 
        BEGIN
            SET @NewNumber = CAST(SUBSTRING(@LastMaCTPN, 5, LEN(@LastMaCTPN) - 4) AS INT) + 1;
        END
        ELSE
        BEGIN
            SET @NewNumber = 1;
        END
    END
    SET @NewMaPN = 'CTPN' + RIGHT('00000' + CAST(@NewNumber AS VARCHAR), 3);
    SELECT @NewMaPN AS NewMaCTPN;
END
GO

--Thu tuc tao CTPhieuNhapHang
CREATE PROCEDURE SP_ThemCTPhieuNhapHang
    @MaCTPhieuNH VARCHAR(50),
    @MaPhieuNH VARCHAR(50),
    @MaSP VARCHAR(50),
    @SoLuong DECIMAL(18, 2),
    @DonGia DECIMAL(18, 0),
    @NgayNhapHang DATE
AS
BEGIN
    INSERT INTO CTPhieuNhapHang (MaCTPhieuNH, MaPhieuNH, MaSP, SoLuong, DonGia, NgayNhapHang)
    VALUES (@MaCTPhieuNH, @MaPhieuNH, @MaSP, @SoLuong, @DonGia, @NgayNhapHang)
END
GO
----------thủ tục cập nhật lại số lượng sản phẩm trong kho(QL tồn kho)
CREATE PROCEDURE SP_CapNhatTonKho
    @MaSP VARCHAR(10),
    @MaKho VARCHAR(10),
    @SoLuong INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Kho_SanPham WHERE MaSP = @MaSP AND MaKho = @MaKho)
    BEGIN
        UPDATE Kho_SanPham
        SET SoLuongTon = SoLuongTon + @SoLuong
        WHERE MaSP = @MaSP AND MaKho = @MaKho;
    END
    ELSE
    BEGIN
        -- Thêm mới sản phẩm vào kho nếu chưa tồn tại
        INSERT INTO Kho_SanPham(MaSP, MaKho, SoLuongTon)
        VALUES (@MaSP, @MaKho, @SoLuong);
    END
END
GO
---lay list san pham tu nha cung cap 
CREATE PROCEDURE SP_GetSanPhamByIdNCC
@MaNCC varchar(50)
AS
BEGIN
	SELECT sp.MaSP, sp.TenSP, sp.DVT, lp.TenLoai
	FROM CT_SanPhamNCC spncc
	JOIN SanPham sp ON spncc.MaSP = sp.MaSP
	JOIN LoaiSanPham lp ON sp.MaLoai = lp.MaLoai
	WHERE spncc.MaNCC = @MaNCC
END
GO

CREATE PROC SP_GetListPN
AS
BEGIN
	SELECT MaPhieuNH, NgayDatHang, TongTien, TrangThai, ncc.TenNCC, k.TenKho, MaNV
	FROM PhieuNhapHang pn
	JOIN NhaCungCap ncc ON ncc.MaNCC = pn.MaNCC
    JOIN Kho k ON k.MaKho = pn.MaKho
END
GO



---Tạo thêm bảng CTPhieuTraHang
create table CTPhieuTraHang
(
	IDCTPhieuTH varchar(50) primary key,
	MaPhieuTraHang varchar(50),
	MaSP varchar(50),
	SoLuongTra DECIMAL(18, 3),
	DonGiaTra DECIMAL(18, 0),
	FOREIGN KEY (MaPhieuTraHang) REFERENCES PhieuTraHangKH(MaPhieuTraHang),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
)

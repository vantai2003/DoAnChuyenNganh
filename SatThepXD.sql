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
alter table CT_SanPhamNCC
drop column NgayBatDauHopTac
select * from CT_SanPhamNCC
alter table CT_SanPhamNCC
add GiaNhap decimal(18, 0), NgayCapNhat date
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
    SDT VARCHAR(20),
    Email VARCHAR(100),
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
    LyDo NVARCHAR(255),
    MaPhieuNH VARCHAR(50) NOT NULL,
    TongTienNhan DECIMAL(18, 0),
    FOREIGN KEY (MaPhieuNH) REFERENCES PhieuNhapHang(MaPhieuNH),
    
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
drop table BangBaoGia
-- Bảng Báo giá
CREATE TABLE BangBaoGiaTuNCC (
    MaSP VARCHAR(50) NOT NULL,
    MaNCC VARCHAR(50) NOT NULL,
    DonGia decimal(18, 2) DEFAULT 0,
	NgayCapNhat date,
	PRIMARY KEY (MaSP, MaNCC),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
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
drop proc SP_GetListNguoiDung
GO
CREATE PROC SP_GetListNguoiDung
AS
BEGIN
	SELECT TenDN, NgayTao, nd.MaNV, nv.TenNV,nd.QuyenID ,q.TenQuyen
	FROM NguoiDung nd
	join NhanVien nv ON nd.MaNV = nv.MaNV
	Join Quyen q ON nd.QuyenID = q.Id
END
GO
CREATE PROC SP_DoiMK
@TenDN varchar(400),
@MatKhau varchar(500)
as
begin
	UPDATE NguoiDung SET MatKhau = @MatKhau
	WHERE TenDN
end
select * from NguoiDung


CREATE PROCEDURE SP_DoiMatKhau
    @TenDN NVARCHAR(500),        
    @MatKhauCu NVARCHAR(500),   
    @MatKhauMoi NVARCHAR(500)   
AS
BEGIN
        UPDATE NguoiDung
        SET MatKhau = @MatKhauMoi
        WHERE TenDN = @TenDN AND MatKhau = @MatKhauCu
END
----------------------------------Người dùng-----------------------------
--thủ tục tìm người dùng

CREATE PROC SP_TimKiemNguoiDung
@SearchValue nvarchar(50)
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
drop proc sp_SelectAll_KhachHang
exec sp_SelectAll_KhachHang
---------Lấy tất cả các cột trong bảng Khách Hàng----------------------
CREATE PROC sp_SelectAll_KhachHang
AS
BEGIN
    SELECT kh.MaKH, kh.TenKH, kh.DiaChi, kh.SoDienThoai, kh.Email, kh.NgayTao, lkh.TenLoaiKH
	FROM KhachHang kh
	JOIN LoaiKH lkh ON lkh.MaLoaiKH = kh.MaLoaiKH
END
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
	@TenLKH NVARCHAR(50),
	@MucChiTieuToiThieu DECIMAL(18,0),
	@MucChiTieuToiDa DECIMAL(18, 0)
AS
BEGIN 
	INSERT INTO LoaiKH
    VALUES (@MaLKH,@TenLKH, @MucChiTieuToiThieu, @MucChiTieuToiDa);
END;
GO

drop proc sp_Update_LoaiKhachHang
-----------Cập nhật Loại Khách Hàng-------------------
CREATE PROC sp_Update_LoaiKhachHang
    @MaLKH VARCHAR(50),
	@TenLKH NVARCHAR(50),
	@MucChiTieuToiThieu DECIMAL(18,0),
	@MucChiTieuToiDa DECIMAL(18, 0)
AS
BEGIN
    UPDATE LoaiKH
    SET TenLoaiKH = @TenLKH , MucChiTieuToiThieu = @MucChiTieuToiThieu, MucChiTieuToiDa = @MucChiTieuToiDa
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
drop proc SP_GetListSP
----------------------------------Sản phẩm-----------------------------
--thủ tục getlist Loại sản phẩm
exec SP_GetListSP
CREATE PROC SP_GetListSP
AS
BEGIN
	SELECT sp.MaSP, sp.TenSP, sp.DVT, lsp.TenLoai
	FROM SanPham sp
	JOIN LoaiSanPham lsp on lsp.MaLoai = sp.MaLoai
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
drop proc SP_TimKiemSP
--thủ tục tìm sản phẩm
CREATE PROC SP_TimKiemSP
@SearchValue varchar(50)
AS
BEGIN
	SELECT sp.MaSP, sp.TenSP, sp.DVT, lsp.TenLoai
	FROM SanPham sp
	JOIN LoaiSanPham lsp on lsp.MaLoai = sp.MaLoai
	WHERE MaSP LIKE '%' + @SearchValue + '%'
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
--thủ tục tìm sản phẩm trong kho
CREATE PROC SP_TimKiemSPKho
@SearchValue varchar(50)
AS
BEGIN
	SELECT  sp.MaSP, sp.TenSP, sp.DVT, k.TenKho, ks.SoLuongTon, lp.TenLoai  
	FROM Kho_SanPham ks 
	JOIN SanPham sp ON ks.MaSP = sp.MaSP
    JOIN Kho k ON ks.MaKho = k.MaKho
    JOIN LoaiSanPham lp ON sp.MaLoai = lp.MaLoai
	WHERE sp.MaSP LIKE '%' + @SearchValue + '%'
	OR sp.TenSP LIKE '%' + @SearchValue + '%';
END
GO
--
CREATE PROCEDURE SP_GetProductsInStock
AS
BEGIN
    SELECT sp.MaSP, sp.TenSP, sp.DVT, k.TenKho, ks.SoLuongTon, lp.TenLoai
    FROM Kho_SanPham ks
    JOIN SanPham sp ON ks.MaSP = sp.MaSP
    JOIN Kho k ON ks.MaKho = k.MaKho
    JOIN LoaiSanPham lp ON sp.MaLoai = lp.MaLoai;
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
alter table CTPhieuNhapHang
drop column DVT
select * from CTPhieuNhapHang
--------sửa phiếu nhập
drop proc SP_SuaPhieuNhapHang
CREATE PROCEDURE SP_SuaPhieuNhapHang
    @MaPhieuNH VARCHAR(50),
    @TongTien DECIMAL(18, 0),
	@MaNV VARCHAR(50)
AS
BEGIN
     UPDATE PhieuNhapHang SET TongTien = @TongTien, MaNV = @MaNV
	 WHERE MaPhieuNH = @MaPhieuNH
END
GO
---------sửa chi tiết phiếu nhập
drop proc SP_SuaCTPhieuNhapHang
CREATE PROCEDURE SP_SuaCTPhieuNhapHang
    @MaCTPhieuNH VARCHAR(50),
    @SoLuong DECIMAL(18, 2),
    @DonGia DECIMAL(18, 0)
AS
BEGIN
    UPDATE CTPhieuNhapHang SET SoLuong = @SoLuong, DonGia = @DonGia
    WHERE MaCTPhieuNH = @MaCTPhieuNH
END
GO

-----xóa CT phiếu nhập
CREATE PROC SP_XoaCTPN
@MaCTPhieuNH VARCHAR(50)
as
begin
	DELETE FROM CTPhieuNhapHang
	WHERE MaCTPhieuNH = @MaCTPhieuNH
end
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

------------thủ tục lấy đơn giá

create proc SP_LayDonGiaNhap
@MaSP varchar(50),
@MaNCC varchar(50)
as
begin
	select GiaNhap
	from CT_SanPhamNCC
	WHERE MaSP = @MaSP AND MaNCC = @MaNCC
end
go
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
---Lọc bảng giá
CREATE PROCEDURE SP_LocBangGia
    @SanPham NVARCHAR(255) = NULL,           
    @NhaCungCap NVARCHAR(255) = NULL     
AS
BEGIN
    SELECT spncc.MaNCC, ncc.TenNCC, sp.MaSP, sp.TenSP, lp.TenLoai, sp.DVT, spncc.GiaNhap, spncc.NgayCapNhat
	FROM CT_SanPhamNCC spncc
	JOIN NhaCungCap ncc ON spncc.MaNCC = ncc.MaNCC
	JOIN SanPham sp ON spncc.MaSP = sp.MaSP
	JOIN LoaiSanPham lp ON sp.MaLoai = lp.MaLoai
    WHERE 
        (@SanPham IS NULL OR sp.TenSP = @SanPham) AND
        (@NhaCungCap IS NULL OR ncc.TenNCC = @NhaCungCap)
END
-------list Bảng giá
CREATE PROCEDURE SP_ListBangGia
AS
BEGIN
	SELECT spncc.MaNCC, ncc.TenNCC, sp.MaSP, sp.TenSP, lp.TenLoai, sp.DVT, spncc.GiaNhap, spncc.NgayCapNhat
	FROM CT_SanPhamNCC spncc
	JOIN NhaCungCap ncc ON spncc.MaNCC = ncc.MaNCC
	JOIN SanPham sp ON spncc.MaSP = sp.MaSP
	JOIN LoaiSanPham lp ON sp.MaLoai = lp.MaLoai
END
GO
---------cập nhật giá
CREATE PROC SP_CapNhatGia
@MaSP varchar(50),
@MaNCC varchar(50),
@GiaNhap decimal(18, 0),
@NgayCapNhat date
as
begin
	UPDATE CT_SanPhamNCC SET GiaNhap = @GiaNhap, NgayCapNhat = @NgayCapNhat
	WHERE MaNCC = @MaNCC AND MaSP = @MaSP
end

------list nahf cung ứng
Drop proc SP_GetListSanPhamNCC
exec SP_GetListSanPhamNCC
CREATE PROCEDURE SP_GetListSanPhamNCC
AS
BEGIN
	SELECT spncc.MaNCC, ncc.TenNCC, sp.MaSP, sp.TenSP, lp.TenLoai, sp.DVT
	FROM CT_SanPhamNCC spncc
	JOIN NhaCungCap ncc ON spncc.MaNCC = ncc.MaNCC
	JOIN SanPham sp ON spncc.MaSP = sp.MaSP
	JOIN LoaiSanPham lp ON sp.MaLoai = lp.MaLoai
END
GO

---------Lọc nahf cung ứng theo nhà cung cấp
drop proc SP_GetListSanPhamNCCByIdNCC
CREATE PROCEDURE SP_GetListSanPhamNCCByIdNCC
@MaNCC varchar(50)
AS
BEGIN
	SELECT spncc.MaNCC, ncc.TenNCC, sp.MaSP, sp.TenSP, lp.TenLoai, sp.DVT
	FROM CT_SanPhamNCC spncc
	JOIN NhaCungCap ncc ON spncc.MaNCC = ncc.MaNCC
	JOIN SanPham sp ON spncc.MaSP = sp.MaSP
	JOIN LoaiSanPham lp ON sp.MaLoai = lp.MaLoai
	WHERE spncc.MaNCC = @MaNCC
END
GO

---------Lọc nhà cung ứng theo sản phẩm
drop proc SP_GetListSanPhamNCCBySP
CREATE PROCEDURE SP_GetListSanPhamNCCBySP
@SearchValues nvarchar(500)
AS
BEGIN
	SELECT spncc.MaNCC, ncc.TenNCC, sp.MaSP, sp.TenSP, lp.TenLoai, sp.DVT
	FROM CT_SanPhamNCC spncc
	JOIN NhaCungCap ncc ON spncc.MaNCC = ncc.MaNCC
	JOIN SanPham sp ON spncc.MaSP = sp.MaSP
	JOIN LoaiSanPham lp ON sp.MaLoai = lp.MaLoai
	 WHERE (sp.TenSP LIKE '%' + @SearchValues + '%')
		OR (spncc.MaSP LIKE '%' + @SearchValues + '%')
END
GO
---------------lọc ra những sản phẩm mà nhà cung cấp đó đã cung cấp rồi

drop proc GetSanPhamChuaCungCap
CREATE PROCEDURE GetSanPhamChuaCungCap
    @MaNCC VARCHAR(50)
AS
BEGIN
    -- Chỉ hiển thị các sản phẩm mà nhà cung cấp chưa cung cấp
    SELECT SP.MaSP, SP.TenSP, SP.DVT,lsp.TenLoai
    FROM SanPham SP
	JOIN LoaiSanPham lsp ON sp.MaLoai = lsp.MaLoai
    WHERE NOT EXISTS (
        SELECT 1 
        FROM CT_SanPhamNCC CTSN
        WHERE CTSN.MaSP = SP.MaSP 
          AND CTSN.MaNCC = @MaNCC
    );
END;
select * from CT_SanPhamNCC
---------thủ tục thêm SanPham_NhaCungCap\
drop proc SP_ThemSanPhamNNCC
CREATE PROC SP_ThemSanPhamNNCC
@MaNCC varchar(50),
@MaSP varchar(50)
AS
BEGIN
	INSERT INTO CT_SanPhamNCC(MaNCC, MaSP) VALUES(@MaNCC, @MaSP)
END
drop proc SP_GetListPN
exec SP_GetListPN
CREATE PROC SP_GetListPN
AS
BEGIN
	SELECT MaPhieuNH, NgayDatHang, TrangThai, ncc.TenNCC, k.TenKho, pn.MaNV, nv.TenNV, TongTien
	FROM PhieuNhapHang pn
	JOIN NhaCungCap ncc ON ncc.MaNCC = pn.MaNCC
    JOIN Kho k ON k.MaKho = pn.MaKho
	JOIN NhanVien nv ON nv.MaNV = pn.MaNV
END
GO

----tìm phiếu nhập
drop proc SP_SearchPN
CREATE PROC SP_SearchPN
@MaPN varchar(50)
AS
BEGIN
	SELECT MaPhieuNH, NgayDatHang, TrangThai, ncc.TenNCC, k.TenKho, pn.MaNV, nv.TenNV, TongTien
	FROM PhieuNhapHang pn
	JOIN NhaCungCap ncc ON ncc.MaNCC = pn.MaNCC
    JOIN Kho k ON k.MaKho = pn.MaKho
	JOIN NhanVien nv ON nv.MaNV = pn.MaNV
	WHERE MaPhieuNH = @MaPN
END
GO
--------thủ tục lọc phieus nhập theo kho, theo ncc
exec SP_LocPN N'Kho Sắt Việt Nhật 1'
drop proc SP_LocPN
CREATE PROCEDURE SP_LocPN
    @Kho NVARCHAR(255) = NULL,           
    @NhaCungCap NVARCHAR(255) = NULL     
AS
BEGIN
    SELECT MaPhieuNH, NgayDatHang, TrangThai, ncc.TenNCC, k.TenKho, pn.MaNV, nv.TenNV, TongTien
    FROM PhieuNhapHang pn
    JOIN NhaCungCap ncc ON ncc.MaNCC = pn.MaNCC
    JOIN Kho k ON k.MaKho = pn.MaKho
	JOIN NhanVien nv ON nv.MaNV = pn.MaNV
    WHERE 
        (@Kho IS NULL OR k.TenKho = @Kho) AND
        (@NhaCungCap IS NULL OR ncc.TenNCC = @NhaCungCap)
END

-----Lọc phiếu nhập theo ngày
drop proc SP_LocTheoNgay
CREATE PROC SP_LocTheoNgay
@TuNgay date,
@DenNgay date
AS
BEGIN
	SELECT MaPhieuNH, NgayDatHang, TrangThai, ncc.TenNCC, k.TenKho, pn.MaNV, nv.TenNV, TongTien
    FROM PhieuNhapHang pn
    JOIN NhaCungCap ncc ON ncc.MaNCC = pn.MaNCC
    JOIN Kho k ON k.MaKho = pn.MaKho
	JOIN NhanVien nv ON nv.MaNV = pn.MaNV
    WHERE NgayDatHang BETWEEN @TuNgay AND @DenNgay
END;
----Xóa phiếu nhập chờ duyệt
CREATE PROC SP_XoaChoDuyetPN
@MaPN varchar(50)
as
begin
	UPDATE PhieuNhapHang SET TrangThai = N'Chờ phê duyệt xóa'
	where MaPhieuNH = @MaPN
end
-----Lấy danh sách phiếu nhập chưa phê duyệt
drop proc SP_GetListPNStatus
CREATE PROC SP_GetListPNStatus
AS
BEGIN
	SELECT MaPhieuNH, NgayDatHang, TrangThai, ncc.TenNCC, k.TenKho, pn.MaNV, nv.TenNV, TongTien
	FROM PhieuNhapHang pn

	JOIN NhaCungCap ncc ON ncc.MaNCC = pn.MaNCC
    JOIN Kho k ON k.MaKho = pn.MaKho
	JOIN NhanVien nv ON nv.MaNV = pn.MaNV
	where pn.TrangThai = N'Chờ phê duyệt nhập' or pn.TrangThai = N'Chờ phê duyệt xóa'
END
GO
----thủ tục phê duyệt xóa
CREATE PROC SP_PheDuyetXoaPN
@MaPN varchar(50)
AS
BEGIN
	UPDATE PhieuNhapHang
	SET TrangThai = N'Đã phê duyệt xóa'
	WHERE MaPhieuNH = @MaPN
END
GO
------------từ chối yêu cầu xóa
CREATE PROC SP_TuChoiYeuCauXoa
@MaPN varchar(50)
AS
BEGIN
	UPDATE PhieuNhapHang
	SET TrangThai = N'Đã từ chối yêu cầu xóa'
	WHERE MaPhieuNH = @MaPN
END
GO
----Thủ tục phê duyệt phiếu nhập hàng

CREATE PROC SP_PheDuyetPN
@MaPN varchar(50)
AS
BEGIN
	UPDATE PhieuNhapHang
	SET TrangThai = N'Đã phê duyệt nhập'
	WHERE MaPhieuNH = @MaPN
END
GO
----Thủ tục từ chối PN

CREATE PROC SP_TuChoiPN
@MaPN varchar(50)
AS
BEGIN
	UPDATE PhieuNhapHang
	SET TrangThai = N'Đã từ chối phiếu nhập hàng'
	WHERE MaPhieuNH = @MaPN
END
GO
drop proc SP_GetListCTPN
exec SP_GetListCTPN 'PN005'
----Thủ tục chi tiết phiếu nhập hàng
CREATE PROC SP_GetListCTPN
@MaPhieuNH varchar(50)
AS
BEGIN
	SELECT MaCTPhieuNH, pnh.MaPhieuNH, NgayNhapHang, sp.MaSP,sp.TenSP , lsp.TenLoai, ncc.TenNCC, SoLuong, DonGia, sp.DVT, pnh.TongTien, pnh.TrangThai, pnh.MaNV, nv.TenNV
	FROM CTPhieuNhapHang ctpn
	JOIN PhieuNhapHang pnh ON pnh.MaPhieuNH = ctpn.MaPhieuNH
	JOIN NhaCungCap ncc ON ncc.MaNCC = pnh.MaNCC
    JOIN SanPham sp ON sp.MaSP = ctpn.MaSP
	JOIN LoaiSanPham lsp ON lsp.MaLoai = sp.MaLoai
	JOIN NhanVien nv ON nv.MaNV = pnh.MaNV
	WHERE ctpn.MaPhieuNH = @MaPhieuNH
END
GO
select * from NhaCungCap
-----Lấy danh sách phiếu nhập đã phê duyệt
drop proc SP_ListPNDaDuyet
CREATE PROC SP_ListPNDaDuyet
AS
BEGIN
	SELECT MaPhieuNH, NgayDatHang, TrangThai, ncc.TenNCC, k.TenKho, pn.MaNV, nv.TenNV, TongTien
	FROM PhieuNhapHang pn

	JOIN NhaCungCap ncc ON ncc.MaNCC = pn.MaNCC
    JOIN Kho k ON k.MaKho = pn.MaKho
	JOIN NhanVien nv ON nv.MaNV = pn.MaNV
	where pn.TrangThai = N'Đã phê duyệt nhập'
END
GO
--------------Lấy thông tin Nhà cung cấp từ phiếu nhập
drop proc SP_TTNhaCCDeInPhieuNhap
exec SP_TTNhaCCDeInPhieuNhap 'PN005'
CREATE PROC SP_TTNhaCCDeInPhieuNhap
	@MaPN varchar(50)
AS
BEGIN
	SELECT MaPhieuNH, NgayDatHang, ncc.TenNCC, ncc.DiaChi, ncc.SDT, TongTien
	FROM PhieuNhapHang pn
	JOIN NhaCungCap ncc ON ncc.MaNCC = pn.MaNCC
	where pn.MaPhieuNH = @MaPN
END
GO
----truy xuất ngược từ tên kho
CREATE PROCEDURE SP_GetMaKhoByTenKho
@TenKho NVARCHAR(400)
AS
BEGIN
    SELECT MaKho
    FROM Kho
    WHERE TenKho = @TenKho
END
GO
--chuyen trang thai ve đã cập nhật vào kho
CREATE PROC SP_CapNhatTonKo
@MaPN varchar(50)
AS
BEGIN
	UPDATE PhieuNhapHang
	SET TrangThai = N'Đã cập nhật vào kho'
	WHERE MaPhieuNH = @MaPN
END
GO
---Tạo thêm bảng CTPhieuTraHang
create table CTPhieuTraHangKH
(
	IDCTPhieuTH varchar(50) primary key,
	MaPhieuTraHang varchar(50),
	MaSP varchar(50),
	SoLuongTra DECIMAL(18, 3),
	DonGiaTra DECIMAL(18, 0),
	FOREIGN KEY (MaPhieuTraHang) REFERENCES PhieuTraHangKH(MaPhieuTraHang),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)

)---hóa đơn
---------Lấy tất cả các cột trong bảng Hóa đơn----------------------
drop PROC sp_SelectAll_HD
CREATE PROC sp_SelectAll_HD
AS
BEGIN
    SELECT hd.MaHD, hd.NgayDatHang, hd.TongTien, hd.TrangThai, hd.DiaChiGiaoHang, hd.TienCoc, hd.ThanhToan, hd.MaKH, kh.TenKH, nv.TenNV, hd.TienKM 
	FROM HoaDon hd
	JOIN KhachHang kh ON hd.MaKH = kh.MaKH
	JOIN NhanVien nv ON hd.MaNV = nv.MaNV
END;
GO
---------------------Thêm Hóa đơn------------------

CREATE PROC sp_Insert_HD
    @MaHD VARCHAR(50) ,
    @NgayDatHang DATE,
    @TongTien DECIMAL(18, 0),
	@TrangThai NVARCHAR(20),
    @DiaChiGiaoHang NVARCHAR(500),
    @TienCoc DECIMAL(18, 0),
    @ThanhToan DECIMAL(18, 0),
    @MaKH VARCHAR(50),
    @MaNV VARCHAR(50)
AS
BEGIN 
	INSERT INTO HoaDon(MaHD, NgayDatHang, TongTien, TrangThai, DiaChiGiaoHang, TienCoc, ThanhToan, MaKH, MaNV)
    VALUES (@MaHD,@NgayDatHang,@TongTien,@TrangThai,@DiaChiGiaoHang,@TienCoc,@ThanhToan,@MaKH,@MaNV);
END;
GO
select * from HoaDon
-----------Cập nhật Hóa đơn-------------------
CREATE PROC sp_Update_HD
	@MaHD VARCHAR(50),
    @NgayDatHang DATE,
    @TongTien DECIMAL(18, 0),
	@TrangThai NVARCHAR(20),
    @DiaChiGiaoHang NVARCHAR(500),
    @TienCoc DECIMAL(18, 0),
    @ThanhToan DECIMAL(18, 0),
    @MaKH VARCHAR(50),
    @MaNV VARCHAR(50)
AS
BEGIN
    UPDATE HoaDon
    SET 
	NgayDatHang = @NgayDatHang,
	TongTien=@TongTien,
	TrangThai=@TrangThai,
	DiaChiGiaoHang=@DiaChiGiaoHang,
	TienCoc=@TienCoc,
	ThanhToan=@ThanhToan,
	MaKH=@MaKH,
	MaNV=@MaNV
    WHERE MaHD = @MaHD;
END;
GO
--thu tuc xoa sp
CREATE PROC SP_Delete_HD
@MaHD varchar(50)
AS
BEGIN
    DELETE FROM CT_HoaDon 
    WHERE MaHD = @MaHD;

    DELETE FROM HoaDon 
    WHERE MaHD = @MaHD;
END
select * from NguoiDung
GO
select * from PhieuTraHangKH
select * from CTPhieuTraHangKH
---Cap nhat so tien thanh toan hoa don
CREATE PROC sp_Update_HD_ThanhToan
	@MaHD VARCHAR(50),
    @ThanhToan DECIMAL(18, 0)
AS
BEGIN
    UPDATE HoaDon
    SET 
	TrangThai=N'Đã giao',
	ThanhToan=@ThanhToan
    WHERE MaHD = @MaHD;
END;
GO
-- Bảng CT_HoaDon (Chi tiết hóa đơn)
CREATE PROC sp_SelectAll_CTHD
AS
BEGIN
    SELECT * FROM CT_HoaDon;
END;
GO

CREATE PROC sp_SelectOne_CTHD
@MaHD VARCHAR(50) 
AS
BEGIN
    SELECT * FROM CT_HoaDon
	WHERE MaHD = @MaHD
END;
GO

exec sp_SelectOne_CTHD 'HD006'

---------------------Thêm CT Hóa đơn-------------------

CREATE PROC sp_Insert_CTHD
	@MaCTHD VARCHAR(50),
    @SoLuong DECIMAL(18, 3),
    @DonGia DECIMAL(18, 0),
    @DVT VARCHAR(20),
    @ThanhTien DECIMAL(18, 0),
	@MaSP VARCHAR(50),
    @MaHD VARCHAR(50)
AS
BEGIN 
	INSERT INTO CT_HoaDon(MaCTHD, SoLuong, DonGia, DVT, ThanhTien, MaSP, MaHD)
    VALUES (@MaCTHD, @SoLuong, @DonGia, @DVT, @ThanhTien, @MaSP, @MaHD);
END;

GO
-----------Cập nhật CT Hóa đơn-------------------
CREATE PROC sp_Update_CTHD
	@MaCTHD VARCHAR(50),
    @SoLuong DECIMAL(18, 3),
    @DonGia DECIMAL(18, 0),
    @DVT VARCHAR(20),
    @ThanhTien DECIMAL(18, 0),
	@MaSP VARCHAR(50),
    @MaHD VARCHAR(50)
AS
BEGIN
    UPDATE CT_HoaDon
    SET 
	MaCTHD= @MaCTHD,
	SoLuong=@SoLuong,
	DonGia=@DonGia,
	DVT=@DVT,
	ThanhTien=@ThanhTien,
	MaSP=@MaSP,
	MaHD=@MaHD
    WHERE MaCTHD = @MaCTHD;
END;
GO
--thu tuc xoa cthd
CREATE PROC SP_Delete_CTHD
@MaCTHD varchar(50)
AS
BEGIN
    DELETE FROM CT_HoaDon 
    WHERE MaCTHD = @MaCTHD;

)
GO
----Tạo thêm bảng CTPhieuTraHangNCC
CREATE TABLE CTPhieuTraHangNCC
(
	IDCTPhieuTHNCC varchar(50) primary key,
	MaPhieuTraHang varchar(50) not null,
	MaSP varchar(50) not null,
	SoLuong decimal(18, 2),
	DonGiaTra decimal (18, 0),
	ThanhTien as (SoLuong * DonGiaTra),
	FOREIGN KEY (MaPhieuTraHang) REFERENCES PhieuTraHangNCC(MaPhieuTraHang),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
)
ALTER TABLE CTPhieuTraHangNCC
DROP COLUMN ThanhTien;

ALTER TABLE PhieuTraHangNCC
DROP CONSTRAINT FK__PhieuTraH__MaNCC__5441852A;
ALTER TABLE PhieuTraHangNCC
DROP COLUMN MaKho;
ALTER TABLE PhieuTraHangNCC
DROP COLUMN SoLuong;
ALTER TABLE PhieuTraHangNCC
ADD TongTienNhan DECIMAL(18, 0)
ALTER TABLE PhieuTraHangNCC
ADD MaNV varchar(50) not null;
ALTER TABLE PhieuTraHangNCC
ADD FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
ALTER TABLE PhieuTraHangNCC
ADD NgayTao DATE
SELECT * FROM PhieuTraHangNCC
select * from CTPhieuTraHangNCC

---Thủ tục Thêm phiếu trả hàng
CREATE PROCEDURE SP_ThemPhieuTraHang
    @MaPhieuTH VARCHAR(50),
    @TongTienNhan DECIMAL(18,0),
    @LyDo NVARCHAR(500),
    @NgayTao DATE,
	@MaNV VARCHAR(50),
    @MaPhieuNH VARCHAR(50)
AS
BEGIN
    INSERT INTO PhieuTraHangNCC(MaPhieuTraHang, TongTienNhan, LyDo, NgayTao, MaNV, MaPhieuNH)
    VALUES (@MaPhieuTH, @TongTienNhan, @LyDo, @NgayTao, @MaNV, @MaPhieuNH)
END
GO

------thủ tục tăng mã phiếu trả
CREATE PROC SP_TaoMaCTPTra
AS
BEGIN
    DECLARE @LastMaCTPT varchar(10);
    DECLARE @NewNumber int;
    DECLARE @NewMaPT varchar(10);
    SELECT @LastMaCTPT = MAX(MaPhieuTraHang) FROM PhieuTraHangNCC;
    
    -- Nếu bảng chưa có thì bắt đầu từ CTPN001
    IF @LastMaCTPT IS NULL
    BEGIN
        SET @NewNumber = 1;
    END
    ELSE
    BEGIN
        IF LEN(@LastMaCTPT) >= 4 
        BEGIN
            SET @NewNumber = CAST(SUBSTRING(@LastMaCTPT, 5, LEN(@LastMaCTPT) - 4) AS INT) + 1;
        END
        ELSE
        BEGIN
            SET @NewNumber = 1;
        END
    END
    SET @NewMaPT = 'PTRH' + RIGHT('00000' + CAST(@NewNumber AS VARCHAR), 3);
    SELECT @NewMaPT AS NewMaPhieuTra
END
GO
drop proc SP_ThemCTPhieuTraHang
--Thu tuc tao CTPhieuNhapHang
CREATE PROCEDURE SP_ThemCTPhieuTraHang
    @MaCTPT VARCHAR(50),
    @MaPhieuTH VARCHAR(50),
    @MaSP VARCHAR(50),
    @SoLuong DECIMAL(18, 2),
    @DonGiaTra DECIMAL(18, 0)
   
AS
BEGIN
    INSERT INTO CTPhieuTraHangNCC(IDCTPhieuTHNCC, MaPhieuTraHang, MaSP, SoLuong, DonGiaTra)
    VALUES (@MaCTPT, @MaPhieuTH, @MaSP, @SoLuong, @DonGiaTra)
END
go

------thủ tục tăng mã ct phiếu trả
CREATE PROC SP_TaoMaCTPTraHang
AS
BEGIN
    DECLARE @LastMaCTPT varchar(10);
    DECLARE @NewNumber int;
    DECLARE @NewMaPT varchar(10);
    SELECT @LastMaCTPT = MAX(IDCTPhieuTHNCC) FROM CTPhieuTraHangNCC;
    
    -- Nếu bảng chưa có thì bắt đầu từ CTPN001
    IF @LastMaCTPT IS NULL
    BEGIN
        SET @NewNumber = 1;
    END
    ELSE
    BEGIN
        IF LEN(@LastMaCTPT) >= 4 
        BEGIN
            SET @NewNumber = CAST(SUBSTRING(@LastMaCTPT, 5, LEN(@LastMaCTPT) - 4) AS INT) + 1;
        END
        ELSE
        BEGIN
            SET @NewNumber = 1;
        END
    END
    SET @NewMaPT = 'CTPT' + RIGHT('00000' + CAST(@NewNumber AS VARCHAR), 3);
    SELECT @NewMaPT AS NewMaPhieuTra
END
GO

exec SP_GetSoLuongNhapGoc @MaSP = 'SP018' , @MaPN = 'PN012'
---thủ tục lấy số lượng nhập gốc
CREATE PROCEDURE SP_GetSoLuongNhapGoc
    @MaSP VARCHAR(10),
    @MaPN VARCHAR(10)
AS
BEGIN
    SELECT SoLuong
    FROM CTPhieuNhapHang
    WHERE MaSP = @MaSP AND MaPhieuNH = @MaPN;
END
GO

--chuyen trang thai về đã xử lý hàng
CREATE PROC SP_CapNhatXuLyHang
@MaPN varchar(50)
AS
BEGIN
	UPDATE PhieuNhapHang
	SET TrangThai = N'Đã xử lý hàng'
	WHERE MaPhieuNH = @MaPN
END
GO


-------------thủ tục lọc số lượng tồn theo kho----------
CREATE PROC SP_LocTonKhoTheoKho
@MaKho nvarchar(200)
AS
BEGIN
	SELECT * FROM Kho_SanPham
	WHERE MaKho = @MaKho
END

GO
CREATE PROCEDURE SP_LocTonKhoTheoKho
@MaKho nvarchar(500)
AS
BEGIN
    SELECT sp.MaSP, sp.TenSP, sp.DVT, k.TenKho, ks.SoLuongTon, lp.TenLoai
    FROM Kho_SanPham ks
    JOIN SanPham sp ON ks.MaSP = sp.MaSP
    JOIN Kho k ON ks.MaKho = k.MaKho
    JOIN LoaiSanPham lp ON sp.MaLoai = lp.MaLoai
	WHERE ks.MaKho= @MaKho;-- Kết nối với bảng LoaiSanPham
END
GO
----Lọc theo tên sản phẩm hoặc loại
CREATE PROCEDURE SP_LocTonKhoTheoSanPham
@ReSearch nvarchar(200)
AS
BEGIN
    SELECT sp.MaSP, sp.TenSP, sp.DVT, k.TenKho, ks.SoLuongTon, lp.TenLoai
    FROM Kho_SanPham ks
    JOIN SanPham sp ON ks.MaSP = sp.MaSP
    JOIN Kho k ON ks.MaKho = k.MaKho
    JOIN LoaiSanPham lp ON sp.MaLoai = lp.MaLoai
    WHERE (sp.TenSP LIKE '%' + @ReSearch + '%')
		OR (lp.TenLoai LIKE '%' + @ReSearch + '%')
END
GO


----thủ tục thêm nhân viên
CREATE PROC SP_ThemNhanVien
@MaNV varchar(50),
@TenNV nvarchar(50),
@ChucVu nvarchar(50),
@SDT varchar(12),
@Email varchar(70),
@NgayTuyenDung date,
@Luong decimal(18, 0)
AS 
BEGIN
	INSERT INTO NhanVien VALUES(@MaNV, @TenNV, @ChucVu, @SDT, @Email, @NgayTuyenDung, @Luong)
END
GO
drop proc SP_TaoMaNV
exec SP_TaoMaNV
------thủ tục tăng mã tạo nhân viên
CREATE PROC SP_TaoMaNV
AS
BEGIN
    DECLARE @LastMaNV varchar(10);
    DECLARE @NewNumber int;
    DECLARE @NewMaNV varchar(10);
    
    -- Truy vấn mã NV lớn nhất hiện có, bỏ qua phần "NV" và chỉ lấy số
    SELECT @LastMaNV = MAX(MaNV) FROM NhanVien;
    
    -- Nếu bảng chưa có bản ghi nào thì bắt đầu từ NV001
    IF @LastMaNV IS NULL
    BEGIN
        SET @NewNumber = 1;
    END
    ELSE
    BEGIN
        -- Lấy phần số của MaNV (bỏ đi 2 ký tự đầu "NV")
        SET @NewNumber = CAST(SUBSTRING(@LastMaNV, 3, LEN(@LastMaNV) - 2) AS INT) + 1;
    END
    
    -- Tạo MaNV mới với định dạng NV + số mới
    SET @NewMaNV = 'NV' + RIGHT('000' + CAST(@NewNumber AS VARCHAR), 3);
    
    -- Trả về MaNV mới
    SELECT @NewMaNV;
END
GO
------thủ tục kiểm tra số điện thoại
CREATE PROC SP_KiemTraTrungSDT
@SDT varchar(12)
AS
BEGIN
	SELECT * FROM NhanVien WHERE SDT = @SDT
END
GO

CREATE PROC SP_KiemTraTrungEmail
@email varchar(12)
AS
BEGIN
	SELECT * FROM NhanVien WHERE Email = @email
END

------thủ tục Xóa nhân viên
CREATE PROC SP_XoaNhanVien
@MaNV varchar(50)
AS
BEGIN
	DELETE FROM NhanVien WHERE MaNV = @MaNV
END
GO
-----Thủ tục sửa nhân viên
CREATE PROC SP_NhanVien
@MaNV varchar(50), 
@TenNV nvarchar(100), 
@ChucVu nvarchar(50),
@SDT varchar(12),
@Email varchar(70),
@NgayTuyenDung date,
@Luong decimal(18, 0)
AS
BEGIN
	UPDATE NhanVien
	SET  TenNV = @TenNV, ChucVu = @ChucVu, SDT = @SDT, Email = @Email, NgayTuyenDung = @NgayTuyenDung, Luong = @Luong
	WHERE NhanVien.MaNV = @MaNV
END
GO

--thủ tục tìm nhân viên
CREATE PROC SP_TimKiemNhanVien
@SearchValue varchar(50)
AS
BEGIN
	SELECT * FROM NhanVien WHERE MaNV LIKE '%' + @SearchValue + '%'
	or TenNV LIKE '%' + @SearchValue + '%'
	or SDT LIKE '%' + @SearchValue + '%'
	or Email LIKE '%' + @SearchValue + '%'
END
GO
---Lọc Sản phẩm theo Kho, theo loại
CREATE PROCEDURE FilterHangHoa
    @TenLoai NVARCHAR(500)
AS
BEGIN
	SELECT sp.MaSP, sp.TenSP, sp.DVT, lsp.TenLoai
	FROM SanPham sp
	JOIN LoaiSanPham lsp on lsp.MaLoai = sp.MaLoai
	WHERE TenLoai = @TenLoai
END
GO
select * from KhuyenMai
drop proc SP_ThemKM
-----------------------Khuyến mãi---------------
----thủ tục thêm khuyến mãi
CREATE PROC SP_ThemKM
@MaKM varchar(50),
@TenKM nvarchar(50),
@NgayBatDau date,
@NgayKetThuc date,
@MoTa nvarchar(500),
@TrangThai nvarchar(50),
@GiaTriKM decimal (18, 2),
@LoaiDK nvarchar(50)
AS 
BEGIN
	INSERT INTO KhuyenMai(MaKM, TenKM, NgayBatDau, NgayKetThuc, MoTa, TrangThai, GiaTriKM, LoaiDieuKien) VALUES(@MaKM, @TenKM, @NgayBatDau, @NgayKetThuc, @MoTa, @TrangThai, @GiaTriKM, @LoaiDK)
END
GO

------thủ tục tăng mã tạo nhân viên
CREATE PROC SP_TaoMaKM
AS
BEGIN
    DECLARE @LastMaKM varchar(10);
    DECLARE @NewNumber int;
    DECLARE @NewMaKM varchar(10);

    SELECT @LastMaKM = MAX(MaKM) FROM KhuyenMai;
    
    IF @LastMaKM IS NULL
    BEGIN
        SET @NewNumber = 1;
    END
    ELSE
    BEGIN
        -- Lấy phần số của MaNV (bỏ đi 2 ký tự đầu "NV")
        SET @NewNumber = CAST(SUBSTRING(@LastMaKM, 3, LEN(@LastMaKM) - 2) AS INT) + 1;
    END
    
    -- Tạo MaNV mới với định dạng NV + số mới
    SET @NewMaKM = 'KM' + RIGHT('000' + CAST(@NewNumber AS VARCHAR), 3);
    
    -- Trả về MaNV mới
    SELECT @NewMaKM;
END
GO
--tìm kiếm khuyến mãi
exec SP_TimKiemKhuyenMai 'Khuyến mãi cho hóa đơn trên 50'
drop proc SP_TimKiemKhuyenMai
CREATE PROC SP_TimKiemKhuyenMai
@SearchValue nvarchar(100)
AS
BEGIN
    SELECT * FROM KhuyenMai
    WHERE TenKM LIKE '%' + LTRIM(RTRIM(@SearchValue)) + '%'
    OR MaKM LIKE '%' + LTRIM(RTRIM(@SearchValue)) + '%'
END
GO

CREATE PROC SP_TimKiemKhuyenMaiTheoTrangThai
@SearchValue nvarchar(100)
AS
BEGIN
    SELECT * FROM KhuyenMai
    WHERE TrangThai = @SearchValue
    
END
GO
--loadlist Danh sách khuyến mãi
CREATE PROC SP_ListKM
AS
BEGIN
	SELECT * FROM KhuyenMai
END
exec SP_ListKMCanPheDuyet
---list khuyến mãi cần phê duyệt
CREATE PROC SP_ListKMCanPheDuyet
AS
BEGIN
	SELECT * FROM KhuyenMai
	WHERE TrangThai = N'Chờ phê duyệt'
END

----thủ tục duyệt khuyến mãi
CREATE PROC SP_DuyetKhuyenMai
@MaKM varchar(50)
AS
BEGIN
	UPDATE KhuyenMai SET TrangThai = N'Đang hoạt động'
	WHERE MaKM = @MaKM
END

----thủ tục từ chối khuyến mãi
CREATE PROC SP_TuChoiKhuyenMai
@MaKM varchar(50)
AS
BEGIN
	UPDATE KhuyenMai SET TrangThai = N'Đã từ chối'
	WHERE MaKM = @MaKM
END
----NGƯNG KHUYẾN MÃI
CREATE PROC SP_NgungKhuyenMai
@MaKM varchar(50)
AS
BEGIN
	UPDATE KhuyenMai SET TrangThai = N'Ngưng hoạt động'
	WHERE MaKM = @MaKM
END

---thủ tục bật khuyến mãi (với điều kiện là trạng thái phải  là ngưng hoạt động)

CREATE PROC SP_BatKhuyenMai
@MaKM varchar(50)
AS
BEGIN
	UPDATE KhuyenMai SET TrangThai = N'Đang hoạt động'
	WHERE TrangThai = N'Ngưng hoạt động' AND MaKM = @MaKM
END
----sửa khuyến mãi
CREATE PROC SP_SuaKM
@MaKM varchar(50),
@TenKM nvarchar(500),
@NgayDB date,
@NgayKT date,
@GiaTriKM decimal(18, 2),
@MoTa nvarchar(1000)
AS
BEGIN
	UPDATE KhuyenMai SET TenKM = @TenKM, NgayBatDau = @NgayDB, NgayKetThuc = @NgayKT, GiaTriKM = @GiaTriKM, MoTa = @MoTa
	WHERE MaKM = @MaKM
END
-----------sủa khuyến mãi với loại tổng tiền
CREATE PROC SP_SuaKMLoaiTongTien
@MaKM varchar(50),
@TenKM nvarchar(500),
@GiaTriKM decimal(18, 2),
@MoTa nvarchar(1000),
@DieuKienTongTien decimal(18, 2)
AS
BEGIN
	UPDATE KhuyenMai SET TenKM = @TenKM, GiaTriKM = @GiaTriKM, MoTa = @MoTa, DieuKienTongTien = @DieuKienTongTien
	WHERE MaKM = @MaKM
END

-----------sửa khuyến mãi theo loại kh
CREATE PROC SP_SuaKMLoaiKhachHang
@MaKM varchar(50),
@GiaTriKM decimal(18, 2),
@MoTa nvarchar(1000)
AS
BEGIN
	UPDATE KhuyenMai SET GiaTriKM = @GiaTriKM, MoTa = @MoTa
	WHERE MaKM = @MaKM
END
-----------------------------------------------------------Của minh--------------
CREATE PROC sp_SelectAll_HD
AS
BEGIN
    SELECT * FROM HoaDon;
END;
GO
drop proc sp_Insert_HD
---------------------Thêm Hóa đơn------------------

CREATE PROC sp_Insert_HD
    @MaHD VARCHAR(50) ,
    @NgayDatHang DATE,
    @TongTien DECIMAL(18, 0),
	@TrangThai NVARCHAR(20),
    @DiaChiGiaoHang NVARCHAR(500),
    @TienCoc DECIMAL(18, 0),
    @ThanhToan DECIMAL(18, 0),
    @MaKH VARCHAR(50),
    @MaNV VARCHAR(50)
AS
BEGIN 
	INSERT INTO HoaDon(MaHD, NgayDatHang, TongTien, TrangThai, DiaChiGiaoHang, TienCoc, ThanhToan, MaKH, MaNV)
    VALUES (@MaHD,@NgayDatHang,@TongTien,@TrangThai,@DiaChiGiaoHang,@TienCoc,@ThanhToan,@MaKH,@MaNV);
END;
GO
-----------Cập nhật Hóa đơn-------------------
CREATE PROC sp_Update_HD
	@MaHD VARCHAR(50),
    @NgayDatHang DATE,
    @TongTien DECIMAL(18, 0),
	@TrangThai NVARCHAR(20),
    @DiaChiGiaoHang NVARCHAR(500),
    @TienCoc DECIMAL(18, 0),
    @ThanhToan DECIMAL(18, 0),
    @MaKH VARCHAR(50),
    @MaNV VARCHAR(50)
AS
BEGIN
    UPDATE HoaDon
    SET 
	NgayDatHang = @NgayDatHang,
	TongTien=@TongTien,
	TrangThai=@TrangThai,
	DiaChiGiaoHang=@DiaChiGiaoHang,
	TienCoc=@TienCoc,
	ThanhToan=@ThanhToan,
	MaKH=@MaKH,
	MaNV=@MaNV
    WHERE MaHD = @MaHD;
END;
GO

CREATE PROCEDURE SP_CapNhatSoLuongSP
    @MaSP VARCHAR(10),
    @MaKho VARCHAR(10),
    @SoLuong decimal(18,2)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Kho_SanPham WHERE MaSP = @MaSP AND MaKho = @MaKho)
    BEGIN
        UPDATE Kho_SanPham
        SET SoLuongTon = @SoLuong
        WHERE MaSP = @MaSP AND MaKho = @MaKho;
    END
END
GO
--thu tuc xoa sp
CREATE PROC SP_Delete_HD
@MaHD varchar(50)
AS
BEGIN
    DELETE FROM CT_HoaDon 
    WHERE MaHD = @MaHD;

    DELETE FROM HoaDon 
    WHERE MaHD = @MaHD;
END
GO
-- Bảng CT_HoaDon (Chi tiết hóa đơn)
CREATE PROC sp_SelectAll_CTHD
AS
BEGIN
    SELECT * FROM CT_HoaDon;
END;
GO

CREATE PROC sp_SelectOne_CTHD
@MaHD VARCHAR(50) 
AS
BEGIN
    SELECT * FROM CT_HoaDon
	WHERE MaHD = @MaHD
END;
GO

---------------------Thêm CT Hóa đơn-------------------

CREATE PROC sp_Insert_CTHD
	@MaCTHD VARCHAR(50),
    @SoLuong DECIMAL(18, 3),
    @DonGia DECIMAL(18, 0),
    @DVT VARCHAR(20),
    @ThanhTien DECIMAL(18, 0),
	@MaSP VARCHAR(50),
    @MaHD VARCHAR(50)
AS
BEGIN 
	INSERT INTO CT_HoaDon(MaCTHD, SoLuong, DonGia, DVT, ThanhTien, MaSP, MaHD)
    VALUES (@MaCTHD, @SoLuong, @DonGia, @DVT, @ThanhTien, @MaSP, @MaHD);
END;

GO
-----------Cập nhật CT Hóa đơn-------------------
CREATE PROC sp_Update_CTHD
	@MaCTHD VARCHAR(50),
    @SoLuong DECIMAL(18, 3),
    @DonGia DECIMAL(18, 0),
    @DVT VARCHAR(20),
    @ThanhTien DECIMAL(18, 0),
	@MaSP VARCHAR(50),
    @MaHD VARCHAR(50)
AS
BEGIN
    UPDATE CT_HoaDon
    SET 
	MaCTHD= @MaCTHD,
	SoLuong=@SoLuong,
	DonGia=@DonGia,
	DVT=@DVT,
	ThanhTien=@ThanhTien,
	MaSP=@MaSP,
	MaHD=@MaHD
    WHERE MaCTHD = @MaCTHD;
END;
GO
--thu tuc xoa cthd
CREATE PROC SP_Delete_CTHD
@MaCTHD varchar(50)
AS
BEGIN
    DELETE FROM CT_HoaDon 
    WHERE MaCTHD = @MaCTHD;
end
go
----------------Thêm cột vào Loại khách hàng để quản lý khuyến mãi theo loại khách hàng
ALTER TABLE KhuyenMai
ADD DieuKienTongTien decimal(18, 0)

ALTER TABLE LoaiKH
ADD MucChiTieuToiThieu decimal(18, 0)

ALTER TABLE LoaiKH
ADD MucChiTieuToiDa decimal(18, 0)

select *From LoaiKH
drop proc SP_GetTenLoaiKHById
CREATE PROC SP_GetTenLoaiKHById
@TenLoaiKH nvarchar(50)
as
BEGIN
	select MaLoaiKH
	from LoaiKH
	where TenLoaiKH = @TenLoaiKH
END
-----------------trigger cập nhật loại khách hàng
ng tiền của các hóa đơn. Trigger sẽ tự động cập nhật khi có một bản ghi mới được thêm vào hoặc cập nhật trong bảng HoaDon.

DROP TRIGGER trg_UpdateLoaiKH
CREATE TRIGGER trg_UpdateLoaiKH
ON HoaDon
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaKH varchar(50);
    DECLARE @TongThanhToan DECIMAL(18, 2);
    DECLARE @LoaiKHCurrent varchar(50);
    DECLARE @LoaiKHNew varchar(50);

    -- Con trỏ để duyệt qua từng khách hàng có hóa đơn mới, sửa hoặc xóa
    DECLARE cur CURSOR FOR
    SELECT DISTINCT MaKH
    FROM inserted
    UNION
    SELECT DISTINCT MaKH
    FROM deleted;

    OPEN cur;
    FETCH NEXT FROM cur INTO @MaKH;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Tính tổng số tiền thanh toán của khách hàng từ tất cả các hóa đơn
        SELECT @TongThanhToan = SUM(TongTien)
        FROM HoaDon
        WHERE MaKH = @MaKH;

        -- Lấy loại khách hàng hiện tại
        SELECT @LoaiKHCurrent = MaLoaiKH
        FROM KhachHang
        WHERE MaKH = @MaKH;

        -- Tìm loại khách hàng mới dựa trên tổng tiền thanh toán
        SELECT @LoaiKHNew = MaLoaiKH
        FROM LoaiKH
        WHERE @TongThanhToan BETWEEN MucChiTieuToiThieu AND MucChiTieuToiDa
        ORDER BY MucChiTieuToiThieu DESC; -- Chọn loại khách hàng phù hợp nhất

        -- Chỉ cập nhật nếu loại khách hàng mới không thấp hơn loại hiện tại
        IF @LoaiKHCurrent <> @LoaiKHNew
        BEGIN
            -- Chỉ nâng cấp (không hạ cấp), kiểm tra nếu loại mới có mức chi tiêu tối thiểu cao hơn loại cũ
            IF (
                SELECT MucChiTieuToiThieu 
                FROM LoaiKH 
                WHERE MaLoaiKH = @LoaiKHNew
            ) >= (
                SELECT MucChiTieuToiThieu 
                FROM LoaiKH 
                WHERE MaLoaiKH = @LoaiKHCurrent
            )
            BEGIN
                -- Cập nhật loại khách hàng nếu điều kiện nâng cấp thỏa mãn
                UPDATE KhachHang
                SET MaLoaiKH = @LoaiKHNew
                WHERE MaKH = @MaKH;
            END
        END

        FETCH NEXT FROM cur INTO @MaKH;
    END;

    CLOSE cur;
    DEALLOCATE cur;
END;
GO

ALTER TABLE HOADON 
ADD TienKM DECIMAL(18, 2)

ALTER TABLE KhuyenMai
ADD LoaiDieuKien nvarchar(200)
ALTER TABLE KhuyenMai
ADD DieuKienTongTien decimal(18, 0)
ALTER TABLE CTDieuKienKM
DROP COLUMN LoaiDieuKien

ALTER TABLE CTDieuKienKM
ADD SoTienKM decimal(18, 0)

------------------thủ tục áp dụng khuyến mãi
Drop proc SP_ApDungKhuyenMaiChung
CREATE PROCEDURE SP_ApDungKhuyenMaiChung
    @MaHD VARCHAR(50)
AS
BEGIN
    DECLARE @TongTien DECIMAL(18, 2);
    DECLARE @NgayDatHang DATE;
    DECLARE @MaKH VARCHAR(50);
    DECLARE @MaKM VARCHAR(50);
    DECLARE @GiaTriKM DECIMAL(18, 2);
    DECLARE @LoaiDieuKien NVARCHAR(50);
    DECLARE @SoTienGiam DECIMAL(18, 2);
    DECLARE @TongTienSauKhuyenMai DECIMAL(18, 2);
	DECLARE @TienCoc DECIMAL(18, 2);
    DECLARE @TienKM DECIMAL(18, 2) = 0; -- Mặc định là 0 nếu không có khuyến mãi

    -- Lấy thông tin hóa đơn và khách hàng
    SELECT @TongTien = TongTien, @NgayDatHang = NgayDatHang, @MaKH = MaKH, @TienCoc = TienCoc
    FROM HoaDon
    WHERE MaHD = @MaHD;

    -- Kiểm tra khuyến mãi theo thời gian
    SELECT TOP 1 @MaKM = MaKM, @GiaTriKM = GiaTriKM, @LoaiDieuKien = LoaiDieuKien
    FROM KhuyenMai
    WHERE LoaiDieuKien = N'Theo khoảng thời gian'
      AND @NgayDatHang BETWEEN NgayBatDau AND NgayKetThuc
      AND TrangThai = N'Đang hoạt động';

    IF @MaKM IS NOT NULL
    BEGIN
        -- Tính số tiền giảm
        SET @SoTienGiam = @TongTien * @GiaTriKM;
        SET @TienKM = @TienKM + @SoTienGiam;

        -- Lưu thông tin khuyến mãi vào bảng CTDieuKienKM
        INSERT INTO CTDieuKienKM (MaKM, MaHD, SoTienKM)
        VALUES (@MaKM, @MaHD, @SoTienGiam);
    END

    -- Kiểm tra khuyến mãi theo tổng tiền hóa đơn
    SELECT TOP 1 @MaKM = MaKM, @GiaTriKM = GiaTriKM, @LoaiDieuKien = LoaiDieuKien
    FROM KhuyenMai
    WHERE LoaiDieuKien = N'Theo tổng tiền'
      AND @TongTien >= DieuKienTongTien
      AND TrangThai = N'Đang hoạt động';

    IF @MaKM IS NOT NULL
    BEGIN
        -- Tính số tiền giảm
        SET @SoTienGiam = @TongTien * @GiaTriKM;
        SET @TienKM = @TienKM + @SoTienGiam;

        -- Lưu thông tin khuyến mãi vào bảng CTDieuKienKM
        INSERT INTO CTDieuKienKM (MaKM, MaHD, SoTienKM)
        VALUES (@MaKM, @MaHD, @SoTienGiam);
    END

    -- Kiểm tra khuyến mãi theo loại khách hàng
    SELECT TOP 1 @MaKM = km.MaKM, @GiaTriKM = km.GiaTriKM, @LoaiDieuKien = km.LoaiDieuKien
    FROM KhuyenMai km
    JOIN KhachHang kh ON kh.MaKH = @MaKH
    JOIN LoaiKH lkh ON kh.MaLoaiKH = lkh.MaLoaiKH
    WHERE km.LoaiDieuKien = N'Theo loại khách hàng'
      AND km.TenKM = lkh.TenLoaiKH
      AND km.TrangThai = N'Đang hoạt động';

    IF @MaKM IS NOT NULL
    BEGIN
        -- Tính số tiền giảm
        SET @SoTienGiam = @TongTien * @GiaTriKM;
        SET @TienKM = @TienKM + @SoTienGiam;

        -- Lưu thông tin khuyến mãi vào bảng CTDieuKienKM
        INSERT INTO CTDieuKienKM (MaKM, MaHD, SoTienKM)
        VALUES (@MaKM, @MaHD, @SoTienGiam);
    END

    -- Cập nhật cột TienKM từ tổng các SoTienKM trong bảng CTDieuKienKM
		SELECT @TienKM = ISNULL(SUM(SoTienKM), 0)
		FROM CTDieuKienKM
		WHERE MaHD = @MaHD;

    -- Cập nhật cột ThanhToan và TienKM trong bảng HoaDon
    SET @TongTienSauKhuyenMai = @TongTien - @TienKM - @TienCoc;

    UPDATE HoaDon
    SET ThanhToan = @TongTienSauKhuyenMai,
        TienKM = @TienKM
    WHERE MaHD = @MaHD;

    -- Trả về thông tin chi tiết
    SELECT MaHD, TongTien, ThanhToan, TienKM
    FROM HoaDon
    WHERE MaHD = @MaHD;
END

CREATE PROC SP_SuaKMLoaiTongTien
@MaKM varchar(50),
@TenKM nvarchar(500),
@GiaTriKM decimal(18, 2),
@MoTa nvarchar(1000),
@DieuKienTongTien decimal(18, 2)
AS
BEGIN
	UPDATE KhuyenMai SET TenKM = @TenKM, GiaTriKM = @GiaTriKM, MoTa = @MoTa, DieuKienTongTien = @DieuKienTongTien
	WHERE MaKM = @MaKM
END

CREATE PROC SP_SuaKMLoaiKhachHang
@MaKM varchar(50),
@GiaTriKM decimal(18, 2),
@MoTa nvarchar(1000)
AS
BEGIN
	UPDATE KhuyenMai SET GiaTriKM = @GiaTriKM, MoTa = @MoTa
	WHERE MaKM = @MaKM
END

CREATE PROC SP_TimKiemKhuyenMai
@SearchValue nvarchar(100)
AS
BEGIN
    SELECT * FROM KhuyenMai
    WHERE TenKM LIKE '%' + LTRIM(RTRIM(@SearchValue)) + '%'
    OR MaKM LIKE '%' + LTRIM(RTRIM(@SearchValue)) + '%'
END
GO
CREATE PROC SP_TimKiemKhuyenMaiTheoTrangThai
@SearchValue nvarchar(100)
AS
BEGIN
    SELECT * FROM KhuyenMai
    WHERE TrangThai = @SearchValue
    
END
GO


----------------Nhan vien giao hang va tra hang-------------------
create table CTPhieuTraHangKH
(
	IDCTPhieuTH varchar(50) primary key,
	MaPhieuTraHang varchar(50),
	MaSP varchar(50),
	SoLuongTra DECIMAL(18, 3),
	DonGiaTra DECIMAL(18, 0),
	FOREIGN KEY (MaPhieuTraHang) REFERENCES PhieuTraHangKH(MaPhieuTraHang),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
)

ALTER TABLE PhieuTraHangKH
ADD TongTienNhan DECIMAL(18, 0)
ALTER TABLE PhieuTraHangKH
ADD NgayTao Date
ALTER TABLE PhieuTraHangKH
ADD MaKho varchar(50)
ALTER TABLE PhieuTraHangKH
ADD CONSTRAINT FK_PhieuNhanHangKH_Kho
FOREIGN KEY (MaKho) REFERENCES Kho(MaKho)

drop proc SP_ThemPhieuTraHang_KH
CREATE PROCEDURE SP_ThemPhieuTraHang_KH
    @MaPhieuTH VARCHAR(50),
    @TongTienNhan DECIMAL(18,0),
    @LyDo NVARCHAR(500),
    @NgayTao DATE,
	@MaNV VARCHAR(50),
    @MaHD VARCHAR(50),
	@MaKho VARCHAR(50)
AS
BEGIN
    INSERT INTO PhieuTraHangKH(MaPhieuTraHang, TongTienNhan, LyDo, NgayTao, MaNV, MaHD, MaKho)
    VALUES (@MaPhieuTH, @TongTienNhan, @LyDo, @NgayTao, @MaNV, @MaHD, @MaKho)
	-- Kiểm tra kết quả thêm
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR('Thêm phiếu trả hàng không thành công', 16, 1);
    END

END
GO

drop proc SP_ThemPhieuTraHang_KH
drop proc SP_TaoMaCTPTra_KH
------thủ tục tăng mã phiếu trả
CREATE PROC SP_TaoMaPTra_KH
AS
BEGIN
    DECLARE @LastMaCTPT varchar(10);
    DECLARE @NewNumber int;
    DECLARE @NewMaPT varchar(10);
    SELECT @LastMaCTPT = MAX(MaPhieuTraHang) FROM PhieuTraHangKH;
    
    IF @LastMaCTPT IS NULL
    BEGIN
        SET @NewNumber = 1;
    END
    ELSE
    BEGIN
        IF LEN(@LastMaCTPT) >= 4 
        BEGIN
            SET @NewNumber = CAST(SUBSTRING(@LastMaCTPT, 5, LEN(@LastMaCTPT) - 4) AS INT) + 1;
        END
        ELSE
        BEGIN
            SET @NewNumber = 1;
        END
    END
    SET @NewMaPT = 'PTRH' + RIGHT('00000' + CAST(@NewNumber AS VARCHAR), 3);
    SELECT @NewMaPT AS NewMaPhieuTra
END
GO
------thủ tục tăng mã phiếu ct trả
drop PROC SP_TaoMaCTPTra_KH
CREATE PROC SP_TaoMaCTPTra_KH
AS
BEGIN
    DECLARE @LastMaCTPT varchar(10);
    DECLARE @NewNumber int;
    DECLARE @NewMaPT varchar(10);
    SELECT @LastMaCTPT = MAX(IDCTPhieuTH) FROM CTPhieuTraHangKH;
    
    IF @LastMaCTPT IS NULL
    BEGIN
        SET @NewNumber = 1;
    END
    ELSE
    BEGIN
        IF LEN(@LastMaCTPT) >= 4 
        BEGIN
            SET @NewNumber = CAST(SUBSTRING(@LastMaCTPT, 7, LEN(@LastMaCTPT) - 4) AS INT) + 1;
        END
        ELSE
        BEGIN
            SET @NewNumber = 1;
        END
    END
    SET @NewMaPT = 'CTPTRH' + RIGHT('00000' + CAST(@NewNumber AS VARCHAR), 3);
    SELECT @NewMaPT AS NewMaPhieuTra
END


exec SP_TaoMaCTPTra_KH
GO
select * from CTPhieuTraHangKH

select * from CTPhieuTraHangKH
select * from Kho_SanPham
--Thu tuc tao CTPhieuNhapHang
CREATE PROCEDURE SP_ThemCTPhieuTraHang_KH
    @MaCTPT VARCHAR(50),
    @MaPhieuTH VARCHAR(50),
    @MaSP VARCHAR(50),
    @SoLuongTra DECIMAL(18, 2),
    @DonGiaTra DECIMAL(18, 0)
   
AS
BEGIN
    INSERT INTO CTPhieuTraHangKH(IDCTPhieuTH, MaPhieuTraHang, MaSP, SoLuongTra, DonGiaTra)
    VALUES (@MaCTPT, @MaPhieuTH, @MaSP, @SoLuongTra, @DonGiaTra)
END
go

drop proc SP_ThemCTPhieuTraHang_KH

------thủ tục tăng mã ct phiếu trả
CREATE PROC SP_TaoMaCTPTraHang_KH
AS
BEGIN
    DECLARE @LastMaCTPT varchar(10);
    DECLARE @NewNumber int;
    DECLARE @NewMaPT varchar(10);
    SELECT @LastMaCTPT = MAX(IDCTPhieuTH) FROM CTPhieuTraHangKH;
    
    -- Nếu bảng chưa có thì bắt đầu từ CTPN001
    IF @LastMaCTPT IS NULL
    BEGIN
        SET @NewNumber = 1;
    END
    ELSE
    BEGIN
        IF LEN(@LastMaCTPT) >= 4 
        BEGIN
            SET @NewNumber = CAST(SUBSTRING(@LastMaCTPT, 5, LEN(@LastMaCTPT) - 4) AS INT) + 1;
        END
        ELSE
        BEGIN
            SET @NewNumber = 1;
        END
    END
    SET @NewMaPT = 'CTPT' + RIGHT('00000' + CAST(@NewNumber AS VARCHAR), 3);
    SELECT @NewMaPT AS NewMaPhieuTra
END
GO

drop proc SP_CapNhatKho_KHTraHang
CREATE PROCEDURE SP_CapNhatKho_KHTraHang
    @MaSP VARCHAR(10),
    @MaKho VARCHAR(10),
    @SoLuong INT
AS
BEGIN
    -- Kiểm tra sản phẩm đã tồn tại trong kho
    IF EXISTS (SELECT 1 FROM Kho_SanPham WHERE MaSP = @MaSP AND MaKho = @MaKho)
    BEGIN
        -- Cập nhật số lượng tồn
        UPDATE Kho_SanPham
        SET SoLuongTon = SoLuongTon + @SoLuong
        WHERE MaSP = @MaSP AND MaKho = @MaKho;
    END
    ELSE
    BEGIN
        -- Chèn sản phẩm mới vào kho
        INSERT INTO Kho_SanPham(MaSP, MaKho, SoLuongTon)
        VALUES (@MaSP, @MaKho, @SoLuong);
    END
END;


----------thủ tục cập nhật lại số lượng sản phẩm trong kho()
drop PROC SP_CapNhatSoLuongSP
CREATE PROCEDURE SP_CapNhatSoLuongSP
    @MaSP VARCHAR(10),
    @MaKho VARCHAR(10),
    @SoLuong decimal(18,2)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Kho_SanPham WHERE MaSP = @MaSP AND MaKho = @MaKho)
    BEGIN
        UPDATE Kho_SanPham
        SET SoLuongTon = @SoLuong
        WHERE MaSP = @MaSP AND MaKho = @MaKho;
    END
END
GO
select * from CTDieuKienKM
----------------
CREATE PROC SP_GetTienBanHang
@NgayTu Date,
@NgayDen Date
AS
BEGIN
    SELECT SUM(TongTien), SUM(ThanhToan)
	FROM Hoadon 
    WHERE NgayDatHang >=@NgayTu 
	AND NgayDatHang <=@NgayDen
END
GO
--------------
CREATE PROC SP_GetTienNhapHang
@NgayTu Date,
@NgayDen Date
AS
BEGIN
    SELECT Sum(TongTien)
	FROM PhieuNhapHang 
    WHERE NgayDatHang >=@NgayTu 
	AND NgayDatHang <=@NgayDen

END
GO
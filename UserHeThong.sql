CREATE LOGIN admin WITH PASSWORD = '123';
ALTER SERVER ROLE sysadmin ADD MEMBER admin;
exec SP_TaoTKHeThong 'NV010', '123'
drop proc SP_TaoTKHeThong
CREATE PROCEDURE SP_TaoTKHeThong
    @TenDN NVARCHAR(50),
    @MatKhau NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Lấy QuyenID từ bảng NguoiDung
    DECLARE @QuyenID INT;
    SELECT @QuyenID = QuyenID FROM NguoiDung WHERE MaNV = @TenDN;

    IF @QuyenID IS NULL
    BEGIN
        RAISERROR('Không thể lấy quyền của người dùng.', 16, 1);
        RETURN;
    END

    -- Tạo Login
    DECLARE @Sql NVARCHAR(MAX);
    SET @Sql = 'CREATE LOGIN [' + @TenDN + '] WITH PASSWORD = ''' + @MatKhau + ''';';
    EXEC sp_executesql @Sql;

    -- Tạo User trong database
    SET @Sql = 'CREATE USER [' + @TenDN + '] FOR LOGIN [' + @TenDN + '];';
    EXEC sp_executesql @Sql;

    -- Gán quyền tương ứng
    DECLARE @Role NVARCHAR(50);
    SET @Role = CASE 
                    WHEN @QuyenID = 0 THEN 'admin'
                    WHEN @QuyenID = 1 THEN 'giamdoc'
                    WHEN @QuyenID = 2 THEN 'ke_toan'
                    WHEN @QuyenID = 3 THEN 'ban_hang'
					WHEN @QuyenID = 4 THEN 'giao_hang'
					WHEN @QuyenID = 5 THEN 'kho'
                    ELSE 'default_role'
                END;

    SET @Sql = 'EXEC sp_addrolemember ''' + @Role + ''', ''' + @TenDN + ''';';
    EXEC sp_executesql @Sql;

    PRINT 'Người dùng đã được tạo thành công.';
END;

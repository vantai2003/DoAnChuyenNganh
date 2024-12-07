CREATE LOGIN admin WITH PASSWORD = '123';
ALTER SERVER ROLE sysadmin ADD MEMBER admin;
exec SP_TaoTKHeThong 'NV010', '123'
drop proc SP_TaoTKHeThong

------------------sửa lại thủ tục tạo người dùng đồng thời cấp quyền sử dụng thủ tục
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

    -- Cấp quyền EXECUTE cho người dùng để sử dụng tất cả thủ tục trong schema dbo
    SET @Sql = 'GRANT EXECUTE ON SCHEMA::dbo TO [' + @TenDN + '];';
    EXEC sp_executesql @Sql;

    PRINT 'Người dùng đã được tạo thành công và cấp quyền sử dụng tất cả thủ tục.';
END;
--------------thủ tục đăng xuất
drop proc KillUserSessions
exec KillUserSessions 'nv001'
CREATE PROCEDURE KillUserSessions
    @UserName NVARCHAR(128) -- Tên tài khoản người dùng cần kill
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SessionID INT;
    DECLARE @SQL NVARCHAR(MAX);

    -- Lấy session_id của tất cả các phiên (session) liên quan đến user
    DECLARE session_cursor CURSOR FOR
    SELECT session_id
    FROM sys.dm_exec_sessions
    WHERE login_name = @UserName;

    OPEN session_cursor;
    FETCH NEXT FROM session_cursor INTO @SessionID;

    -- Duyệt qua tất cả các session và thực thi lệnh KILL
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @SQL = N'KILL ' + CAST(@SessionID AS NVARCHAR(10));
        EXEC sp_executesql @SQL;
        FETCH NEXT FROM session_cursor INTO @SessionID;
    END

    CLOSE session_cursor;
    DEALLOCATE session_cursor;
END;
exec KillUserSessions 'nv001'

CREATE PROCEDURE KillUserSessions
    @UserName NVARCHAR(128) -- Tên tài khoản người dùng cần kill
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SessionID INT;
    DECLARE @KillCommand NVARCHAR(MAX);

    -- Lấy session_id của tất cả các phiên (session) liên quan đến user
    DECLARE session_cursor CURSOR FOR
    SELECT session_id
    FROM sys.dm_exec_sessions
    WHERE login_name = @UserName;

    OPEN session_cursor;
    FETCH NEXT FROM session_cursor INTO @SessionID;

    -- Duyệt qua tất cả các session và thực thi lệnh KILL
    WHILE @@FETCH_STATUS = 0
    BEGIN
        BEGIN TRY
            -- Xây dựng lệnh KILL và thực thi
            SET @KillCommand = 'KILL ' + STR(@SessionID);
            EXEC sp_executesql @KillCommand;

            PRINT 'Đã KILL session ID: ' + STR(@SessionID);
        END TRY
        BEGIN CATCH
            PRINT 'Lỗi khi KILL session ID: ' + STR(@SessionID);
        END CATCH

        FETCH NEXT FROM session_cursor INTO @SessionID;
    END

    CLOSE session_cursor;
    DEALLOCATE session_cursor;

    PRINT 'Hoàn tất KillUserSessions cho user: ' + @UserName;
END;

SELECT 
    s.session_id,
    s.login_name AS LoggedInUser,
    s.status,
    s.host_name,
    s.program_name,
    s.client_interface_name,
    s.database_id,
    db_name(s.database_id) AS DatabaseName,
    s.login_time
FROM 
    sys.dm_exec_sessions s
WHERE 
    s.is_user_process = 1; 

SELECT session_id, login_name, host_name
FROM sys.dm_exec_sessions
WHERE login_name = 'nv001';

KILL 52;
KILL 57;
KILL 60;

-------Thêm trạng thái
ALTER TABLE NguoiDung
add TrangThaiDangNhap int default 0;
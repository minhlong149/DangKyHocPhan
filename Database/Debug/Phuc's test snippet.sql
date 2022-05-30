﻿-- DELETE DATABASE
USE master
GO
DROP DATABASE DKHP;

-- LIST ALL DATABASE
SELECT name, database_id, create_date  
FROM sys.databases;  
GO 

-- LIST ALL TABLE IN DB
SELECT *
FROM INFORMATION_SCHEMA.TABLES;
GO

-- DÙNG DATABASE NHÓM
use "D:\DANGKYHOCPHAN\DATABASE\DKHP.MDF"
GO
-- TEST APP
use "D:\DANGKYHOCPHAN\DANGKYHOCPHAN\BIN\DEBUG\DKHP.MDF"
GO

-- TEST
USE DKHP
GO

SELECT * FROM THUHOCPHI
SELECT * FROM KHOA

INSERT INTO THUHOCPHI VALUES ('0001',000112022,6000000,CURRENT_TIMESTAMP);

SELECT Count(MaSV) from SINHVIEN

-- TRIGER kiểm tra xem có tồn tại MaSV trong csdl hay không
CREATE TRIGGER KIEM_TRA_MSSV_THUHOCPHI
FOR INSERT, UPDATE
AS
BEGIN
declare @MaSV VARCHAR(8), TON_TAI_MSSV INT
SELECT @MaSV = MaSV from inserted
SELECT @TON_TAI_MSSV = count(MaSV) from SINHVIEN where MaSV = @MaSV
IF (@TON_TAI_MSSV < 1)
	BEGIN
	PRINT 'KHONG TON TAI MASV'
	ROLLBACK TRANSACTION
	END
END

-- BACKUP DB
USE [master];
GO
BACKUP DATABASE [DKHP]
TO DISK = N'D:\tempDB\DKHP.bak' 
WITH NOFORMAT, NOINIT,
NAME = N'SQLTestDB-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10;
GO

-- test backup db
use "D:\tempDB\DKHP.bak"
GO
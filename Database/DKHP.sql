-- GO cho phép các lệnh thực hiện tuần tự

CREATE DATABASE DKHP;
GO
USE DKHP;
GO
SET DATEFORMAT DMY;
GO

CREATE TABLE TINH(
	MaTinh VARCHAR(5) PRIMARY KEY,
	TenTinh NVARCHAR(40) NOT NULL
)

INSERT INTO TINH VALUES ('SG', N'TP. Hồ Chí Minh');
INSERT INTO TINH VALUES ('HN', N'Hà Nội');

CREATE TABLE HUYEN(
	MaHuyen VARCHAR(5) PRIMARY KEY,
	TenHuyen NVARCHAR(40) NOT NULL,
	ThuocTinh VARCHAR(5) FOREIGN KEY REFERENCES TINH(MaTinh) NOT NULL,
	VungSau INT NOT NULL
)

INSERT INTO HUYEN VALUES ('BT', N'Bình Thạnh', 'SG', 0);
INSERT INTO HUYEN VALUES ('Q1', N'Quận 1', 'SG', 1);
INSERT INTO HUYEN VALUES ('TB', N'Tân Bình', 'SG', 1);
INSERT INTO HUYEN VALUES ('CG', N'Cầu Giấy', 'HN', 0);
INSERT INTO HUYEN VALUES ('HK', N'Hoàn Kiếm', 'HN', 1);

CREATE TABLE DOITUONG(
	MaDT VARCHAR(5) PRIMARY KEY,
	TenDT NVARCHAR(40) NOT NULL,
	MienGiam FLOAT NOT NULL,
	NhomUuTien INT NOT NULL	
)

INSERT INTO DOITUONG VALUES ('DT01', N'Dân tộc thiểu số', 0.4, 1);
INSERT INTO DOITUONG VALUES ('DT02', N'Con thương binh liệt sĩ', 0.3, 1);
INSERT INTO DOITUONG VALUES ('DT03', N'Khuyết tật', 0.1, 2);

CREATE TABLE KHOA(
	MaKhoa VARCHAR(4) PRIMARY KEY,
	TenKhoa NVARCHAR(40) NOT NULL
)

INSERT INTO KHOA VALUES ('SE', N'Công nghệ phần mềm');
INSERT INTO KHOA VALUES ('IT', N'Khoa học và Kỹ thuật Thông tin');

CREATE TABLE NGANH(
	MaNganh VARCHAR(4) PRIMARY KEY,
	TenNganh NVARCHAR(40) NOT NULL,
	ThuocKhoa VARCHAR(4) FOREIGN KEY REFERENCES KHOA(MaKhoa) NOT NULL
)

INSERT INTO NGANH VALUES ('KTPM', N'Kỹ thuật phần mềm', 'SE');
INSERT INTO NGANH VALUES ('CNTT', N'Công nghệ thông tin', 'IT');
INSERT INTO NGANH VALUES ('KHDL', N'Khoa học dữ liệu', 'IT');

CREATE TABLE SINHVIEN(
	MaSV VARCHAR(8) PRIMARY KEY,
	TenSV NVARCHAR(40) NOT NULL,
	NgaySinh VARCHAR(50) NOT NULL,
	GioiTinh INT NOT NULL,
	DoiTuong VARCHAR(5) FOREIGN KEY REFERENCES DOITUONG(MaDT),
	Huyen VARCHAR(5) FOREIGN KEY REFERENCES HUYEN(MaHuyen) NOT NULL,
	Tinh VARCHAR(5) FOREIGN KEY REFERENCES TINH(MaTinh) NOT NULL,
	NganhHoc VARCHAR(4) FOREIGN KEY REFERENCES NGANH(MaNganh) NOT NULL
)


INSERT INTO SINHVIEN (MaSV, TenSV, NgaySinh, GioiTinh, Huyen, Tinh, NganhHoc)
VALUES ('0001', N'Nguyễn Văn Thành', '20/4/2001', 1, 'Q1', 'SG', 'KTPM');
INSERT INTO SINHVIEN (MaSV, TenSV, NgaySinh, GioiTinh, Huyen, Tinh, NganhHoc)
VALUES ('0002', N'Đỗ Văn Quang Minh', '23/9/2002', 1, 'Q1', 'SG', 'KHDL');
INSERT INTO SINHVIEN (MaSV, TenSV, NgaySinh, GioiTinh, Huyen, Tinh, NganhHoc)
VALUES ('0003', N'Trần Hoàng Lưu Ly Thiên Chức', '12/9/2001', 0, 'HK', 'HN', 'CNTT');
INSERT INTO SINHVIEN VALUES ('0020', N'Phạm Thị Thu Trang', '11/8/2001', 0, 'DT03', 'BT', 'SG', 'CNTT');
INSERT INTO SINHVIEN VALUES ('0021', N'Lê Thị Thanh Hương', '2/7/2004', 0, 'DT01', 'CG', 'HN', 'KHDL');
INSERT INTO SINHVIEN VALUES ('0022', N'Võ Văn Trung', '17/1/2003', 1, 'DT02', 'TB', 'SG', 'KTPM');
INSERT INTO SINHVIEN VALUES ('1427', N'Trần Hà', '23/6/2003', 1, 'DT03', 'CG', 'HN', 'KHDL');
INSERT INTO SINHVIEN VALUES ('2038', N'Jennifer Phạm', '19/5/2002', 0, 'DT01', 'Q1', 'SG', 'CNTT');

CREATE TABLE LOAIMON(
	MaLoaiMon VARCHAR(5) PRIMARY KEY,
	TenLoaiMon NVARCHAR(40) NOT NULL,
	SoTinChi INT NOT NULL,
	GiaTien INT NOT NULL
)

INSERT INTO LOAIMON VALUES ('LT', N'Lý thuyết', 15, 27000);
INSERT INTO LOAIMON VALUES ('TH', N'Thực hành', 30, 37000);

CREATE TABLE MONHOC(
	MaMon VARCHAR(5) PRIMARY KEY,
	TenMon NVARCHAR(40) NOT NULL,
	SoTiet INT NOT NULL,
	LoaiMon VARCHAR(5) FOREIGN KEY REFERENCES LOAIMON(MaLoaiMon) NOT NULL
)

INSERT INTO MONHOC VALUES ('SS007', N'Triết học Mác – Lênin', 12, 'LT');
INSERT INTO MONHOC VALUES ('MA005', N'Xác suất thống kê', 13, 'LT');
INSERT INTO MONHOC VALUES ('IT001', N'Nhập môn lập trình', 14, 'TH');
INSERT INTO MONHOC VALUES ('IT002', N'Lập trình hướng đối tượng', 14, 'TH');
INSERT INTO MONHOC VALUES ('IE106', N'Thiết kế giao diện người dùng', 14, 'LT');
INSERT INTO MONHOC VALUES ('IS334', N'Thương mại điện tử', 11, 'TH');
INSERT INTO MONHOC VALUES ('SE114', N'Nhập môn ứng dụng di động', 13, 'TH');

CREATE TABLE HOCKYCHINH(
	MaHKC INT PRIMARY KEY,
	TenHKC NVARCHAR(40) NOT NULL
)

INSERT INTO HOCKYCHINH VALUES (1, N'Học kỳ 1');
INSERT INTO HOCKYCHINH VALUES (2, N'Học kỳ 2');
INSERT INTO HOCKYCHINH VALUES (0, N'Học kỳ hè');

CREATE TABLE DSHOCKY(
	MaHK VARCHAR(5) PRIMARY KEY,
	HocKy INT FOREIGN KEY REFERENCES HOCKYCHINH (MaHKC) NOT NULL,
	NamHoc INT NOT NULL,
	ThoiHan DATE NOT NULL
)

INSERT INTO DSHOCKY VALUES ('12022',1, 2022, '15-9-2022');
INSERT INTO DSHOCKY VALUES ('22022',2, 2022, '20-1-2022');
INSERT INTO DSHOCKY VALUES ('12021',1, 2021, '15-8-2021');
INSERT INTO DSHOCKY VALUES ('22021',2, 2021, '19-1-2021');
INSERT INTO DSHOCKY VALUES ('02021',0, 2021, '1-6-2021');

CREATE TABLE CHUONGTRINH(
	NganhHoc VARCHAR(4) FOREIGN KEY REFERENCES NGANH(MaNganh),
	Khoa VARCHAR(4)  FOREIGN KEY REFERENCES KHOA(MAKHOA),
	HocKy INT,
	MonHoc VARCHAR(5) FOREIGN KEY REFERENCES MONHOC(MAMON),
	GhiChu VARCHAR(40),
	PRIMARY KEY (NganhHoc, Khoa, HocKy, MonHoc)
)

CREATE TABLE MONHOCMO(
	MaHK VARCHAR(5) FOREIGN KEY REFERENCES DSHOCKY(MaHK),
	MonHoc VARCHAR(5) FOREIGN KEY REFERENCES MONHOC(MAMON),
	PRIMARY KEY (MaHK, MonHoc)
)

INSERT INTO MONHOCMO VALUES ('12022','MA005');
INSERT INTO MONHOCMO VALUES ('12022','IT001');
INSERT INTO MONHOCMO VALUES ('12022','IT002');

CREATE TABLE PHIEUDK(
	SoPhieu VARCHAR(15) PRIMARY KEY,
	MaSV VARCHAR(8) FOREIGN KEY REFERENCES SINHVIEN(MaSV) NOT NULL,
	MaHK VARCHAR(5) FOREIGN KEY REFERENCES DSHOCKY(MaHK) NOT NULL,
	NgayLap DATE NOT NULL
)

INSERT INTO PHIEUDK VALUES ('000112022','0001', '12022', '27-5-2022');
INSERT INTO PHIEUDK VALUES ('000112069','2038', '12022', '5-27-2022');

CREATE TABLE DKHOCPHAN(
	SoPhieu VARCHAR(15) FOREIGN KEY REFERENCES PHIEUDK (SoPhieu),
	MonHoc VARCHAR(5),
	PRIMARY KEY (SoPhieu, MonHoc)
)

INSERT INTO DKHOCPHAN VALUES ('000112022','IT001');
INSERT INTO DKHOCPHAN VALUES ('000112069', 'MA005')
GO

CREATE TABLE THUHOCPHI(
	MaThuPhi INT IDENTITY(1,1) PRIMARY KEY,
	MaSV VARCHAR(8) FOREIGN KEY REFERENCES SINHVIEN(MaSV) NOT NULL,
	SoPhieu VARCHAR(15) FOREIGN KEY REFERENCES PHIEUDK (SoPhieu),
	SoTienThu MONEY NOT NULL,
	NgayThu DATE NOT NULL 
)

INSERT INTO THUHOCPHI VALUES ('0003','000112022',6000000,CURRENT_TIMESTAMP);
GO

CREATE TABLE CHUAHTHP(
	SoPhieu VARCHAR(15) FOREIGN KEY REFERENCES PHIEUDK (SoPhieu),
	MaSV VARCHAR(8) FOREIGN KEY REFERENCES SINHVIEN(MaSV) NOT NULL,
	SoTienDangKy MONEY NOT NULL,
	SoTienPhaiDong MONEY NOT NULL,
	SoTienConLai MONEY	
)


ALTER TABLE CHUAHTHP
ADD CONSTRAINT ktra_sotienphaidong CHECK (SoTienPhaiDong <= SoTienDangKy)

--INSERT INTO CHUAHTHP VALUES ('0001', '1000000', '900000', '200000');
--INSERT INTO CHUAHTHP VALUES ('0002', '2000000', '200000', '200000');
--INSERT INTO CHUAHTHP VALUES ('0003', '1500000', '500000', '100000');
--INSERT INTO CHUAHTHP VALUES ('0022', '1700000', '1700000', '0');

-- TRIGGER TINH TIEN MOI KHI INSERT VAO BANG DKHOCPHAN

CREATE TRIGGER TINH_TOAN_HP_CHUAHTHP
ON DKHOCPHAN AFTER INSERT
AS
BEGIN
declare @SoPhieu VARCHAR(15), @MonHoc VARCHAR(5), @MaSV VARCHAR(8),
@SoTienDangKy MONEY, @SoTienPhaiDong MONEY, @SoTienConLai MONEY,
@SoTinChi INT, @GiaTien INT, @DoiTuong VARCHAR(5), @SoTiet INT

SELECT @SoPhieu=SoPhieu, @MonHoc=MonHoc from inserted
SELECT @MaSV=MaSV from PHIEUDK WHERE SoPhieu=@SoPhieu

-- query tim so tin chi va gia tien cua tat ca mon dang ky
select @SoTinChi=sum(SoTinChi), @GiaTien=sum(GiaTien), @SoTiet=sum(SoTiet) from (
SELECT MaMon, SoTinChi, GiaTien, SoTiet
from MONHOC join LOAIMON on MONHOC.LoaiMon=LOAIMON.MaLoaiMon
join DKHOCPHAN on DKHOCPHAN.MonHoc = MONHOC.MaMon
Where SoPhieu = @SoPhieu
) TEMP

-- tinh so tien dang ky
SET @SoTienDangKy = @SoTiet / @SoTinChi * @GiaTien
SET @SoTienPhaiDong = @SoTienDangKy

-- kiem tra sinh vien thuoc dien nao
SELECT * FROM DOITUONG
select @DoiTuong=DoiTuong from SINHVIEN where MaSV=@MaSV
IF @DoiTuong = 'DT03'
BEGIN
SET @SoTienPhaiDong = @SoTienDangKy * 0.9
END
IF @DoiTuong = 'DT02'
BEGIN
SET @SoTienPhaiDong = @SoTienDangKy * 0.7
END
IF @DoiTuong = 'DT01'
BEGIN
SET @SoTienPhaiDong = @SoTienDangKy * 0.6
END
-- update so tien con lai
SET @SoTienConLai = @SoTienPhaiDong-- kiem tra sinh vien thuoc dien nao
SELECT * FROM DOITUONG
select @DoiTuong=DoiTuong from SINHVIEN where MaSV=@MaSV
IF @DoiTuong = 'DT03'
BEGIN
SET @SoTienPhaiDong = @SoTienDangKy * 0.9
END
IF @DoiTuong = 'DT02'
BEGIN
SET @SoTienPhaiDong = @SoTienDangKy * 0.7
END
IF @DoiTuong = 'DT01'
BEGIN
SET @SoTienPhaiDong = @SoTienDangKy * 0.6
END
-- update so tien con lai
SET @SoTienConLai = @SoTienPhaiDong
-- ghi vao bang
INSERT INTO CHUAHTHP VALUES (@SoPhieu, @MaSV, @SoTienDangKy, @SoTienPhaiDong, @SoTienConLai);
END
GO

ALTER TABLE MONHOC
ADD NguoiTao nvarchar(50)

ALTER TABLE MONHOC
ADD NguoiCapNhat nvarchar(50)

ALTER TABLE MONHOC
ADD NgayTao datetime

ALTER TABLE MONHOC
ADD NgayCapNhat datetime


GO
create procedure selectmh
	@mamh varchar(5)
as
begin
	select 
		MaMon,
		TenMon,
		SoTiet,
		LoaiMon
	from MONHOC
	where MaMon = @mamh;
end

GO
 create procedure insertMH
	@mamh varchar(5),
	@nguoitao nvarchar(50),
	@tenmonhoc nvarchar(40),
	@sotiet int,
	@loaimon varchar(5)
as
begin
	insert into MONHOC(MaMon,NguoiTao,TenMon, SoTiet, LoaiMon)
	values(@mamh,@nguoitao,@tenmonhoc,@sotiet,@loaimon);
	if @@ROWCOUNT > 0 return 1 else return 0;
end

GO
create procedure updateMH
	@nguoicapnhat nvarchar(50),
	@mamh varchar(5),
	@tenmonhoc nvarchar(50),
	@sotiet int,
	@loaimon varchar(5)
as
begin
	update MONHOC
	set
		NguoiCapNhat = @nguoicapnhat,
		NgayCapNhat = getdate(),
		TenMon = @tenmonhoc,
		SoTiet = @sotiet,
		LoaiMon = @loaimon
	where MaMon = @mamh;
	if @@ROWCOUNT > 0 return 1 else return 0;
end

drop procedure updateMH


GO
create procedure selectAllMonHocMo
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		MaHK,5
		MonHoc
	from MONHOCMO
	where MonHoc like '%'+@tukhoa+'%'
	or lower(MaHK) like '%'+@tukhoa+'%'
	order by MaHK;	
end;



GO
create procedure selectHK
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		MaHK,
		HocKy
	from DSHOCKY
	where MaHK like '%'+@tukhoa+'%'
	or lower(HocKy) like '%'+@tukhoa+'%'
	order by HocKy;	
end;


GO
create proc selectMHMo
	@mamonhoc varchar(5),
	@mahocky varchar(5)
as
begin
	select
		MaHK,
		MonHoc
	from MONHOCMO
	where MonHoc = @mamonhoc and MaHK = @mahocky;
end

drop procedure selectMHMo

exec selectmh 'IT1001'
exec selectMHMo '12022', 'IT001'


ALTER TABLE MONHOCMO
ADD NguoiTao nvarchar(50)

ALTER TABLE MONHOCMO
ADD NguoiCapNhat nvarchar(50)

GO
create proc insertMonHocMo
	@nguoitao nvarchar(50),
	@mahocky varchar(5),
	@mamonhoc varchar(5)
as
begin
	insert into MONHOCMO(NguoiTao,MaHK,MonHoc)
	values(@nguoitao,@mahocky, @mamonhoc);
	if @@ROWCOUNT > 0 return 1 else return 0;
end

GO
create proc updateMonHocMo
	@nguoicapnhat nvarchar(50),
	@mahocky varchar(5),
	@mamonhoc varchar(5),
	@mahockybandau varchar(5),
	@mamonhocbandau varchar(5)
as
begin
	update MONHOCMO
	set
		NguoiCapNhat = @nguoicapnhat,		
		MaHK = @mahocky,
		MonHoc = @mamonhoc
	where MonHoc = @mamonhocbandau and MaHK = @mahockybandau;
	if @@ROWCOUNT > 0 return 1 else return 0;
end

drop proc updateMonHocMo

create procedure XoaSV
	@MaSV varchar(8)
as 
begin
	delete from SINHVIEN where MaSV=@MaSV
	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
		ELSE BEGIN RETURN 0 END;
end

create procedure ThemTK
	@TenDangNhap varchar(8)
as 
begin
	insert into TAIKHOAN(TenDangNhap,MatKhau,Quyen)
	values (@TenDangNhap,'1','user');
	if @@ROWCOUNT >0 begin return 1 end
	else begin return 0 end
end

create procedure XoaTK
	@TenDangNhap varchar(8)
as 
begin
	delete from TAIKHOAN where TenDangNhap=@TenDangNhap
	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
		ELSE BEGIN RETURN 0 END;
end

go
CREATE procedure deleteMonHoc
	@mamonhoc varchar(5)
AS 
BEGIN
	--XOA CAC DU LIEU LIEN QUAN TOI MONHOC DANG DUOC XOA 
	--XOA DU LIEU TUNG BANG VOI mamonhoc VUA TIM DUOC 
	DELETE FROM CHUONGTRINH
	WHERE MonHoc = @mamonhoc

	DELETE FROM DKHOCPHAN
	WHERE MonHoc = @mamonhoc

	DELETE FROM MONHOCMO
	WHERE MonHoc = @mamonhoc

	DELETE FROM MONHOC
	WHERE MaMon = @mamonhoc
END
GO

go
CREATE procedure deleteMonHocMo
	@mahocky  varchar(5),
	@mamonhoc varchar(5)
AS 
BEGIN
	--XOA CAC DU LIEU LIEN QUAN TOI MONHOC DANG DUOC XOA 
	--XOA DU LIEU TUNG BANG VOI mamonhoc VUA TIM DUOC 
	DELETE FROM MONHOCMO
	WHERE MaHK = @mahocky AND MonHoc = @mamonhoc
END


GO
create procedure selectNganhHoc
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		MaNganh,
		TenNganh
	from NGANH
	where MaNganh like '%'+@tukhoa+'%'
	or lower(TenNganh) like '%'+@tukhoa+'%'
	order by TenNganh;	
end;

go
create procedure selectKhoa
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		MaKhoa,
		TenKhoa
	from KHOA
	where MaKhoa like '%'+@tukhoa+'%'
	or lower(TenKhoa) like '%'+@tukhoa+'%'
	order by TenKhoa;	
end;


GO
create proc selectChuongTrinhHoc
	@manganh varchar(4),
	@makhoa varchar(4),
	@hocky int,
	@mamonhoc varchar(5)
as
begin
	select
		NganhHoc,
		Khoa,
		HocKy,
		MonHoc
	from CHUONGTRINH
	where NganhHoc = @manganh and Khoa = @makhoa and HocKy = @hocky and MonHoc = @mamonhoc;
end


GO
create procedure selectAllChuongTrinhHoc
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		NganhHoc,
		Khoa,
		HocKy,
		MonHoc
	from CHUONGTRINH
	where NganhHoc like '%'+@tukhoa+'%'
	or Khoa like '%'+@tukhoa+'%'
	or HocKy like '%'+@tukhoa+'%'
	or MonHoc like '%'+@tukhoa+'%'
	order by NganhHoc;	
end;

go
CREATE procedure deleteChuongTrinhHoc
	@manganh varchar(4),
	@makhoa varchar(4),
	@hocky int,
	@mamonhoc varchar(5)
AS 
BEGIN
	DELETE FROM CHUONGTRINH
	WHERE NganhHoc = @manganh AND Khoa = @makhoa AND HocKy = @hocky AND MonHoc = @mamonhoc
END



GO
create proc insertChuongTrinhHoc
	@manganh varchar(4),
	@makhoa varchar(4),
	@hocky int,
	@mamonhoc varchar(5)
as
begin
	insert into CHUONGTRINH(NganhHoc,Khoa,HocKy,MonHoc)
	values(@manganh,@makhoa,@hocky, @mamonhoc);
	if @@ROWCOUNT > 0 return 1 else return 0;
end

GO
create proc updateChuongTrinhHoc
	@manganhbandau varchar(4),
	@makhoabandau varchar(4),
	@mamonbandau varchar(5),
	@manganh varchar(4),
	@makhoa varchar(4),
	@hocky int,
	@mamonhoc varchar(5)
as
begin
	update CHUONGTRINH
	set
		NganhHoc = @manganh,		
		Khoa = @makhoa,
		MonHoc = @mamonhoc,
		HocKy = @hocky
	where NganhHoc = @manganhbandau and Khoa = @makhoabandau and MonHoc = @mamonbandau and HocKy = @hocky
	if @@ROWCOUNT > 0 return 1 else return 0;
end

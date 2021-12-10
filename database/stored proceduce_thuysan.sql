use QL_THUYSAN
go
------------------------------------------------------------------------KHÁCH HÀNG --------------------------------------------------------------------------------------
-------viết stored Procedure để thêm khách hàng
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_ThemKH')
	DROP PROC pr_ThemKH
GO
CREATE PROC pr_ThemKH
(
	@MsKH		CHAR(10), 
	@TENKH		NVARCHAR(30), 
	@PHAI		NCHAR(5), 
	@DIACHI		NVARCHAR(100), 
	@DIENTHOAI	VARCHAR(10)
)
AS
BEGIN
	IF EXISTS(SELECT MSKH FROM KHACHHANG WHERE MSKH = @MsKH)
		RAISERROR(N'Mã số khách hàng: %s này đã có trong bảng KH!', 16, 1, @MsKH)
	ELSE
	BEGIN
		INSERT INTO KHACHHANG(MsKH, TENKH, PHAI, DIACHI, DIENTHOAI)
			VALUES(@MsKH, @TENKH, @PHAI, @DIACHI, @DIENTHOAI)
		RAISERROR(N'Thêm mới khách hàng: %s - %s này thành công!', 16, 1, @MsKH, @TENKH)
	END
END
GO
--EXEC pr_ThemKH 'KH0454', N'Nguyễn Văn Tý', 'Nam', N'Nguyễn Trãi, F5, Q.5, HCM', '0903657832' 

----------2.Viết Stored Procedure để sửa thông tin khách hàng 
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_SuaKH')
	DROP PROC pr_SuaKH
GO
CREATE PROC pr_SuaKH
(
	@MsKH		CHAR(10), 
	@TENKH		NVARCHAR(30), 
	@PHAI		NCHAR(5), 
	@DIACHI		NVARCHAR(100), 
	@DIENTHOAI	VARCHAR(10)
)
AS
BEGIN
	IF EXISTS(SELECT MSKH FROM KHACHHANG WHERE MSKH = @MsKH)
	BEGIN
		UPDATE	KHACHHANG
		SET		TENKH = @TENKH,
				PHAI = @PHAI,
				DIACHI = @DIACHI,
				DIENTHOAI = @DIENTHOAI
		WHERE	MsKH = 	@MsKH
		RAISERROR(N'Sửa thông tin khách hàng thành công!', 16, 1)
	END
	ELSE
		RAISERROR(N'Mã số khách hàng: %s này KHÔNG có trong bảng KH!', 16, 1, @MsKH)
END
GO

----------3.Viết Stored Procedure để xóa thông tin khách hàng 
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_XoaKH')
	DROP PROC pr_XoaKH
GO
CREATE PROC pr_XoaKH
(
	@MsKH		CHAR(10)
)
AS
BEGIN
	IF NOT EXISTS(SELECT MSKH FROM HOADON WHERE MSKH = @MsKH)
	BEGIN
		DELETE KHACHHANG WHERE MsKH = @MsKH
		RAISERROR(N'Xóa khách hàng trong bảng khách hàng thành công!', 16, 1)
	END
	ELSE
		IF EXISTS(SELECT * FROM HOADON hd, CHITIET_HD ct WHERE hd.MSHD = ct.MSHD and hd.MSKH = @MsKH)
		BEGIN
			----Lấy mã số hóa đơn dựa vào mã số khách hàng
			DECLARE @hd char(10)
			SELECT @hd = MSHD FROM HOADON WHERE MSKH = @MsKH

			DELETE CHITIET_HD	WHERE	MSHD = @hd						-----Xóa hóa đơn ở bảng CHITIET_HD
			DELETE HOADON		WHERE	MSHD = @hd  AND MSKH = @MsKH	-----Xóa hóa đơn ở bảng HOADON
			DELETE KHACHHANG	WHERE	MsKH = @MsKH					-----Xóa khách hàng ở bảng khách hàng
			RAISERROR(N'Đã xóa khách hàng khách hàng thành công!', 16, 1)
		END
END
-----------------------------------------------------------------------------THIẾT BỊ --------------------------------------------------------------------------------------------------

----1.  Viết stored Procedure để thêm thông tin của thiết bị
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_ThemTB')
	DROP PROC pr_ThemTB
GO
CREATE PROC pr_ThemTB
(
	@MSTB		char(10),
	@TENTB		nvarchar(50),
	@XUATXU		nvarchar(50),
	@HANGSX		nvarchar(50),	
	@SL_TON		int,
	@DONGIA		float,
	@DONVITINH	nchar(10)
)
AS
BEGIN
	IF EXISTS(SELECT MSTB FROM THIETBI WHERE MSTB = @MSTB)
		RAISERROR(N'Mã số thiết bị: %s này đã có trong bảng thiết bị!', 16, 1, @MSTB)
	ELSE
	BEGIN
		INSERT INTO THIETBI(MSTB, TENTB,XUATXU,HANGSX,SL_TON, DONGIA, DONVITINH)
			VALUES(@MSTB, @TENTB,@XUATXU,@HANGSX, @SL_TON, @DONGIA, @DONVITINH)
		RAISERROR(N'Thêm mới thiết bị: %s - %s này thành công!', 16, 1, @MSTB, @TENTB)
	END
END
GO

----------2. Viết Stored Procedure để sửa thông tin thiết bị
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_SuaTB')
	DROP PROC pr_SuaTB
GO
CREATE PROC pr_SuaTB
(
	
	@MSTB		char(10),
	@TENTB		nvarchar(50),	
	@XUATXU		nvarchar(50),
	@HANGSX		nvarchar(50),		
	@SL_TON		int,
	@DONGIA		float,
	@DONVITINH	nchar(10)
)
AS
BEGIN
	IF EXISTS(SELECT MSTB FROM THIETBI WHERE MSTB = @MSTB)
	BEGIN
		UPDATE	THIETBI
		SET		TENTB = @TENTB,
				XUATXU= @XUATXU,
				HANGSX = @HANGSX,
				SL_TON = @SL_TON,
				DONGIA = @DONGIA,
				DONVITINH = @DONVITINH
		WHERE	MSTB = 	@MSTB
		RAISERROR(N'Sửa thông tin thiết bị thành công!', 16, 1)
	END
	ELSE
		RAISERROR(N'Mã số thiết bị : %s này KHÔNG có trong bảng thiết bị!', 16, 1, @MSTB)
END
GO
----------3.Viết Stored Procedure để xóa thông tin thiết bị
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_XoaTB')
	DROP PROC pr_XoaTB
GO
CREATE PROC pr_XoaTB
(
	@MSTB		CHAR(10)
)
AS
BEGIN
	IF NOT EXISTS(SELECT MSTB FROM THIETBI WHERE MSTB = @MSTB)
	
	BEGIN
		DELETE THIETBI WHERE MSTB = @MSTB
		RAISERROR(N'Xóa thiết bị trong bảng thiết bị thành công!', 16, 1)
	END
	ELSE
		IF EXISTS(SELECT * FROM THIETBI tb, CHITIET_HD ct WHERE  tb.MSTB = @MSTB)
		BEGIN
			----Lấy mã số thiết bị 
			DECLARE @tb char(10)
			SELECT @tb = MSTB FROM THIETBI WHERE MSTB = @MSTB

			DELETE CHITIET_HD	WHERE	MSTB = @tb					-----Xóa thiết bị ở bảng CHITIET_HD
			DELETE THIETBI		WHERE	MSTB = @tb					-----Xóa thiết bị ở bảng THIETBI

		
			RAISERROR(N'Đã xóa thiết bị thành công!', 16, 1)
		END
END
------------------------------------------------------------------------ NHÀ CUNG CẤP ----------------------------------------------------------------------------------------------------

----1.  Viết stored Procedure để thêm thông tin của nhà cung cấp
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_ThemNCC')
	DROP PROC pr_ThemNCC
GO
CREATE PROC pr_ThemNCC
(
	@MSNCC		char(10),
	@TENNCC		nvarchar(50),	
	@HANG		nvarchar(50)
)
AS
BEGIN
	IF EXISTS(SELECT MSNCC FROM NHACUNGCAP WHERE MSNCC = @MSNCC)
		RAISERROR(N'Mã số nhà cung cấp : %s này đã có trong bảng !', 16, 1, @MSNCC)
	ELSE
	BEGIN
		INSERT INTO NHACUNGCAP(MSNCC,TENNCC,HANG)
			VALUES(@MSNCC, @TENNCC,@HANG)
		RAISERROR(N'Thêm mới nhà cung cấp: %s - %s này thành công!', 16, 1, @MSNCC, @TENNCC)
	END
END
GO

----------2. Viết Stored Procedure để sửa thông tin nhà cung cấp
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_SuaNCC')
	DROP PROC pr_SuaNCC
GO
CREATE PROC pr_SuaNCC
(
	@MSNCC		char(10),
	@TENNCC		nvarchar(50),	
	@HANG		nvarchar(50)
	
)
AS
BEGIN
	IF EXISTS(SELECT MSNCC FROM NHACUNGCAP WHERE MSNCC = @MSNCC)
	BEGIN
		UPDATE	NHACUNGCAP
		SET		TENNCC = @TENNCC,
				HANG = @HANG
		WHERE	MSNCC = 	@MSNCC
		RAISERROR(N'Sửa thông tin nhà cung cấp thành công!', 16, 1)
	END
	ELSE
		RAISERROR(N'Mã số nhà cung cấp : %s này KHÔNG có trong bảng nhà cung cấp!', 16, 1, @MSNCC)
END
GO
-----3.Viết Stored Procedure để xóa thông tin nhà cung cấp
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_XoaNCC')
	DROP PROC pr_XoaNCC
GO
CREATE PROC pr_XoaNCC
(
	@MSNCC		CHAR(10)
)
AS
BEGIN
	IF NOT EXISTS(SELECT MSNCC FROM NHACUNGCAP WHERE MSNCC = @MSNCC)
	
	BEGIN
		DELETE NHACUNGCAP WHERE MSNCC = @MSNCC
		RAISERROR(N'Xóa  nhà cung cấp trong bảng nhà cung cấp thành công!', 16, 1)
	END

END

-------------------------------------------------------------------------VẬT TƯ-----------------------------------------------------------------------------------------------------

----1.  Viết stored Procedure để thêm thông tin của vật tư
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_ThemVT')
	DROP PROC pr_ThemVT
GO
CREATE PROC pr_ThemVT
(
	@MSVT		char(10),
	@TENVT		nvarchar(50),
	@XUATXU		nvarchar(50),
	@HANGSX		nvarchar(50),	
	@SL_TON		int,
	@DONGIA		float,
	@DONVITINH	nchar(10)
)
AS
BEGIN
	IF EXISTS(SELECT MSVT FROM VATTU WHERE MSVT = @MSVT)
		RAISERROR(N'Mã số mặt hàng: %s này đã có trong bảng mặt hàng!', 16, 1, @MSVT)
	ELSE
	BEGIN
		INSERT INTO VATTU(MSVT, TENVT,XUATXU,HANGSX,SL_TON, DONGIA, DONVITINH)
			VALUES(@MSVT, @TENVT,@XUATXU,@HANGSX, @SL_TON, @DONGIA, @DONVITINH)
		RAISERROR(N'Thêm mới mặt hàng: %s - %s này thành công!', 16, 1, @MSVT, @TENVT)
	END
END
GO

----------2. Viết Stored Procedure để sửa thông tin vật tư
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_SuaVT')
	DROP PROC pr_SuaVT
GO
CREATE PROC pr_SuaVT
(
	
	@MSVT		char(10),
	@TENVT		nvarchar(50),	
	@XUATXU		nvarchar(50),
	@HANGSX		nvarchar(50),		
	@SL_TON		int,
	@DONGIA		float,
	@DONVITINH	nchar(10)
)
AS
BEGIN
	IF EXISTS(SELECT MSVT FROM VATTU WHERE MSVT = @MSVT)
	BEGIN
		UPDATE	VATTU
		SET		TENVT = @TENVT,
				XUATXU= @XUATXU,
				HANGSX = @HANGSX,
				SL_TON = @SL_TON,
				DONGIA = @DONGIA,
				DONVITINH = @DONVITINH
		WHERE	MSVT = 	@MSVT
		RAISERROR(N'Sửa thông tin Vật tư thành công!', 16, 1)
	END
	ELSE
		RAISERROR(N'Mã số vật tư: %s này KHÔNG có trong bảng vật tư!', 16, 1, @MSVT)
END
GO
-----3.Viết Stored Procedure để xóa thông tin vật tư
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_XoaVT')
	DROP PROC pr_XoaVT
GO
CREATE PROC pr_XoaVT
(
	@MSVT		CHAR(10)
)
AS
BEGIN
	IF NOT EXISTS(SELECT MSVT FROM VATTU WHERE MSVT = @MSVT)
	
	BEGIN
		DELETE VATTU WHERE MSVT = @MSVT
		RAISERROR(N'Xóa vật tư trong bảng vật tư thành công!', 16, 1)
	END
	ELSE
		IF EXISTS(SELECT * FROM VATTU vt, CHITIET_HD ct WHERE  vt.MSVT = @MSVT)
		BEGIN
			----Lấy mã số vật tư
			DECLARE @vt char(10)
			SELECT @vt = MSVT FROM VATTU WHERE MSVT = @MSVT

			DELETE CHITIET_HD	WHERE	MSVT = @vt				-----Xóa vật tư ở bảng CHITIET_HD
			DELETE VATTU		WHERE	MSVT = @vt				-----Xóa vật tư ở bảng THIETBI

		
			RAISERROR(N'Đã xóa vật tư thành công!', 16, 1)
		END
END

GO
--------------------------------------------------------------------NHÂN VIÊN---------------------------------------------------------------------------------------------

---- Viết stored Procedure để thêm thông tin của nhân viên
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_ThemNV')
	DROP PROC pr_ThemNV
GO
CREATE PROC pr_ThemNV
(
	@MANV		char(10),
	@TENNV		nvarchar(30),
	@TENDANGNHAP	nvarchar(256)	,
	@NGAYSINH	datetime	,
	@PHAI		nchar(10)	,
	@DIACHI		nvarchar(50),
	@DIENTHOAI	nvarchar(10),
	@SO_HD_THUCHIEN	int,
	@NGAYDANGNHAP	datetime,
	@SOLANDN		int		,
	@QUYENHAN	nvarchar(20)
)
AS
BEGIN
	IF EXISTS(SELECT MANV FROM NHANVIEN WHERE MANV = @MANV)
		RAISERROR(N'Mã số nhân viên: %s này đã có trong bảng mặt hàng!', 16, 1, @MANV)
	ELSE
	BEGIN
		INSERT INTO NHANVIEN(MANV,TENNV,TENDANGNHAP,NGAYSINH,PHAI,DIACHI,DIENTHOAI,SO_HD_THUCHIEN,NGAYDANGNHAP,SOLANDN,QUYENHAN)
			VALUES(@MANV,@TENNV,@TENDANGNHAP,@NGAYSINH,@PHAI,@DIACHI,@DIENTHOAI,@SO_HD_THUCHIEN,@NGAYDANGNHAP,@SOLANDN,@QUYENHAN)
		RAISERROR(N'Thêm mới nhân viên: %s - %s này thành công!', 16, 1, @MANV, @TENNV)
	END
END
GO

----2.Viết stored Procedure để Sửa thông tin của Nhân viên
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_SuaNV')
	DROP PROC pr_SuaNV
GO
CREATE PROC pr_SuaNV
(
	

	@MANV		char(10),
	@TENNV		nvarchar(30),
	@TENDANGNHAP	nvarchar(256)	,
	@NGAYSINH	datetime	,
	@PHAI		nchar(10)	,
	@DIACHI		nvarchar(50),
	@DIENTHOAI	nvarchar(10),
	@SO_HD_THUCHIEN	int,
	@NGAYDANGNHAP	datetime,
	@SOLANDN		int		,
	@QUYENHAN	nvarchar(20)					
)
AS
BEGIN
	IF EXISTS(SELECT MANV FROM NHANVIEN WHERE MANV = @MANV)
	BEGIN
		UPDATE	NHANVIEN
		SET		MANV = @MANV,
				TENNV = @TENNV,
				TENDANGNHAP = @TENDANGNHAP,
				NGAYSINH = @NGAYSINH,
				PHAI = @PHAI,
				DIACHI = @DIACHI,
				DIENTHOAI = @DIENTHOAI,
				SO_HD_THUCHIEN = @SO_HD_THUCHIEN,
				NGAYDANGNHAP = @NGAYDANGNHAP,
				SOLANDN  = @SOLANDN,
				QUYENHAN = @QUYENHAN
			
				
		WHERE	MANV = 	@MANV
		RAISERROR(N'Sửa thông tin Nhân viên thành công!', 16, 1)
	END
	ELSE
		RAISERROR(N'Mã số  nhân viên : %s này KHÔNG có trong bảng  nhân viên!', 16, 1, @MANV)
END
GO


-----3.Viết stored Procedure để xóa thông tin của nhân viên

IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_XoaNHANVIEN')
	DROP PROC pr_XoaNHANVIEN
GO
CREATE PROC pr_XoaNHANVIEN
(
	@MANV		CHAR(10)
)
AS
BEGIN
	IF NOT EXISTS(SELECT MANV FROM NHANVIEN WHERE MANV = @MANV)
	BEGIN
		DELETE NHANVIEN WHERE MANV = @MANV
		RAISERROR(N'Xóa  nhân viên trong bảng nhân viên thành công!', 16, 1)
	END
	ELSE
		IF EXISTS(SELECT * FROM HOADON hd, NHANVIEN nv WHERE  nv.MANV = @MANV)
		BEGIN
			----Lấy mã số  nhân viên dựa vào mã nhân viên
			DECLARE @nv char(10)
			SELECT @nv = MANV FROM NHANVIEN WHERE MANV = @MANV

			DELETE NHANVIEN		WHERE   MANV = @MANV						-----Xóa mã nhân viên ở bảng nhân viên				
			DELETE HOADON		WHERE	MANV = @MANV						-----Xóa mã nhân viên ở bảng HOADON
		
			RAISERROR(N'Đã xóa nhân viên  thành công!', 16, 1)
		END
END


GO
--------------------------------------------------------------------------------------HÓA ĐƠN----------------------------------------------------------------------
----1. Viết stored Procedure để thêm thông tin của hóa đơn
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_ThemHD')
	DROP PROC pr_ThemHD
GO
CREATE PROC pr_ThemHD
(
	@MSHD		char(10),
	@MANV		char(10),
	@MSKH		char(10),
	@NGAYHD		datetime,
	@TONGTIEN	float	
)
AS
BEGIN
	IF EXISTS(SELECT MSHD FROM HOADON WHERE MSHD = @MSHD)
		RAISERROR(N'Mã số mặt hàng: %s này đã có trong bảng mặt hàng!', 16, 1, @MSHD)
	ELSE
	BEGIN
		INSERT INTO HOADON(MSHD,MANV,MSKH, NGAYHD, TONGTIEN)
			VALUES(@MSHD,@MANV,@MSKH, @NGAYHD, @TONGTIEN)
		RAISERROR(N'Thêm mới mặt hàng: %s - %s này thành công!', 16, 1, @MSHD, @MANV)
	END
END
GO
----2.Viết stored Procedure để Sửa thông tin của hóa đơn
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_SuaHOADON')
	DROP PROC pr_SuaHOADON
GO
CREATE PROC pr_SuaHOADON
(
	

	@MSHD		char(10)		,
	@MANV		char(10)		,
	@MSKH		char(10)		,
	@NGAYHD		datetime		,
	@TONGTIEN	float						
)
AS
BEGIN
	IF EXISTS(SELECT MSHD FROM HOADON WHERE MSHD = @MSHD)
	BEGIN
		UPDATE	HOADON
		SET		MSHD = @MSHD,
				MANV = @MANV,
				MSKH = @MSKH,
				NGAYHD = @NGAYHD,
				TONGTIEN = @TONGTIEN
				
		WHERE	MSHD = 	@MSHD
		RAISERROR(N'Sửa thông tin hóa đơn thành công!', 16, 1)
	END
	ELSE
		RAISERROR(N'Mã số  hóa đơn: %s này KHÔNG có trong bảng  hóa đơn!', 16, 1, @MSHD)
END
GO


-----3.Viết stored Procedure để xóa thông tin của hóa đơn

IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_XoaHOADON')
	DROP PROC pr_XoaHOADON
GO
CREATE PROC pr_XoaHOADON
(
	@MSHD		CHAR(10)
)
AS
BEGIN
	IF NOT EXISTS(SELECT MSHD FROM HOADON WHERE MSHD = @MSHD)
	BEGIN
		DELETE HOADON WHERE MSHD = @MSHD
		RAISERROR(N'Xóa mã  hóa đơn trong bảng chi tiết hóa đơn thành công!', 16, 1)
	END
	ELSE
		IF EXISTS(SELECT * FROM HOADON hd, CHITIET_HD ct WHERE  hd.MSHD = @MSHD)
		BEGIN
			----Lấy mã số  chi tiết hóa đơn dựa vào mã số hóa đơn
			DECLARE @hd char(10)
			SELECT @hd = MSHD FROM HOADON WHERE MSHD = @MSHD

			DELETE CHITIET_HD	WHERE	MSHD = @hd						-----Xóa hóa đơn ở bảng CHITIET_HD
			DELETE HOADON		WHERE	MSHD = @hd						-----Xóa hóa đơn ở bảng HOADON
		
			RAISERROR(N'Đã xóa mã chi tiết hóa đơn thành công!', 16, 1)
		END
END

---------------------------------------------------------------------------CHI TIẾT HÓA ĐƠN-------------------------------------------------------------------------------------------
---- 1.Viết stored Procedure để thêm thông tin của chi tiết hóa đơn
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_Themct_hoadon')
	DROP PROC pr_Themct_hoadon
GO
CREATE PROC pr_Themct_hoadon
(
	@MSHD		char(10)		,
	@MSVT		char(10)		,
	@MSTB		char(10)		,
	@SOLUONGVT		int			,
	@SOLUONGTB	int			,
	@THANHTIEN	money			
)
AS
BEGIN
	IF EXISTS(SELECT MSHD FROM CHITIET_HD WHERE MSHD = @MSHD)
		RAISERROR(N'Mã số chi tiết hóa đơn  %s này đã có trong bảng mặt hàng!', 16, 1, @MSHD)
	ELSE
	BEGIN
		INSERT INTO CHITIET_HD(MSHD,MSVT,MSTB,SOLUONGVT,SOLUONGTB,THANHTIEN)
			VALUES(@MSHD,@MSVT,@MSTB,@SOLUONGVT,@SOLUONGTB, @THANHTIEN)
		RAISERROR(N'Thêm mới chi tiết hóa đơn: %s - %s -% này thành công!!', 16, 1, @MSHD, @MSVT,@MSTB)
	END
END
GO


---------2. -Viết Stored Procedure để sửa thông tin chi tiết hóa đơn
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_Suact_hoadon')
	DROP PROC pr_Suact_hoadon
GO
CREATE PROC pr_Suact_hoadon
(
	

	@MSHD		char(10)		,
	@MSVT		char(10)		,
	@MSTB		char(10)		,
	@SOLUONGVT		int			,
	@SOLUONGTB	int			null,
	@THANHTIEN	money			
)
AS
BEGIN
	IF EXISTS(SELECT MSHD FROM CHITIET_HD WHERE MSHD = @MSHD)
	BEGIN
		UPDATE	CHITIET_HD
		SET		MSVT = @MSVT,
				MSTB= @MSTB,
				SOLUONGVT = @SOLUONGVT,
				SOLUONGTB = @SOLUONGTB,
				THANHTIEN = @THANHTIEN
				
		WHERE	MSHD = 	@MSHD
		RAISERROR(N'Sửa thông tin chi tiết hóa đơn thành công!', 16, 1)
	END
	ELSE
		RAISERROR(N'Mã số chi tiết hóa đơn: %s này KHÔNG có trong bảng chi tiết hóa đơn!', 16, 1, @MSHD)
END
GO

----------3.Viết Stored Procedure để xóa chi tiết hóa đơn
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'pr_XoaCT_HOADON')
	DROP PROC pr_XoaCT_HOADON
GO
CREATE PROC pr_XoaCT_HOADON
(
	@MsHD		CHAR(10)
)
AS
BEGIN
	IF NOT EXISTS(SELECT MSHD FROM CHITIET_HD WHERE MSHD = @MSHD)
	BEGIN
		DELETE CHITIET_HD WHERE MSHD = @MSHD
		RAISERROR(N'Xóa mã chi tiết hóa đơn trong bảng chi tiết hóa đơn thành công!', 16, 1)
	END
	ELSE
		IF EXISTS(SELECT * FROM HOADON hd, CHITIET_HD ct WHERE  ct.MSHD = @MSHD)
		BEGIN
			----Lấy mã số  chi tiết hóa đơn dựa vào mã số hóa đơn
			DECLARE @hd char(10)
			SELECT @hd = MSHD FROM HOADON WHERE MSHD = @MSHD

			DELETE CHITIET_HD	WHERE	MSHD = @hd						-----Xóa hóa đơn ở bảng CHITIET_HD
			DELETE HOADON		WHERE	MSHD = @hd  -----Xóa hóa đơn ở bảng HOADON
		
			RAISERROR(N'Đã xóa mã chi tiết hóa đơn thành công!', 16, 1)
		END
END

-------------------------------------------------------------------------------------SAP Crystal Reports----------------------------------------------------------------------------------------
---------------1.Viết Stored Procedure báo cáo doanh thu của vật tư
GO
IF EXISTS (SELECT NAME FROM SYSOBJECTS WHERE NAME='prBCDSVT')
	DROP PROC prBCDSVT
GO
CREATE PROC prBCDSVT
(
	@TUDAY		DATETIME,
	@DENNGAY	DATETIME
)
AS
BEGIN
		SELECT	vt.MSVT,
				vt.TENVT,
				vt.DONVITINH,
				sum(ct.SOLUONGVT) as SOLUONG,
				sum(vt.DONGIA*ct.SOLUONGVT) as THANHTIEN
		FROM	HOADON hd, CHITIET_HD ct, VATTU vt
		WHERE	hd.MSHD = ct.MSHD	and
				ct.MSVT =  vt.MSVT	and
				hd.NGAYHD Between @TUDAY AND @DENNGAY
		GROUP BY vt.MSVT,
				 vt.TENVT,
				 vt.DONVITINH
END
GO

---------------2.Viết Stored Procedure báo cáo doanh thu của thiết bị
GO
IF EXISTS (SELECT NAME FROM SYSOBJECTS WHERE NAME='prBCDSTB')
	DROP PROC prBCDSTB
GO
CREATE PROC prBCDSTB
(
	@TUDAY		DATETIME,
	@DENNGAY	DATETIME
)
AS
BEGIN
		SELECT	tb.MSTB,
				tb.TENTB,
				tb.DONVITINH,
				sum(ct.SOLUONGTB) as SOLUONG,
				sum(tb.DONGIA*ct.SOLUONGTB) as THANHTIEN
		FROM	HOADON hd, CHITIET_HD ct, THIETBI tb
		WHERE	hd.MSHD = ct.MSHD	and
				ct.MSTB =  tb.MSTB	and
				hd.NGAYHD Between @TUDAY AND @DENNGAY
		GROUP BY tb.MSTB,
				 tb.TENTB,
				 tb.DONVITINH
END



---------------3.Viết Stored Procedure báo cáo doanh thu tháng của từng Vật tư
GO
IF EXISTS (SELECT NAME FROM SYSOBJECTS WHERE NAME='prBCDTTNVT')
	DROP PROC prBCDTTNVT
GO
CREATE PROC prBCDTTNVT
(
	@THANG		INT,
	@NAM		INT
)
AS
BEGIN
		SELECT	vt.MSVT,
				vt.TENVT,
				vt.DONVITINH,
				sum(ct.SOLUONGVT) as SOLUONGVT,
				sum(vt.DONGIA*ct.SOLUONGVT) as THANHTIEN
		FROM	HOADON hd, CHITIET_HD ct, VATTU vt
		WHERE	hd.MSHD = ct.MSHD	and
				ct.MSVT =  vt.MSVT	and
				MONTH(hd.NGAYHD)= @THANG AND
				YEAR(hd.NGAYHD)=@NAM
		GROUP BY vt.MSVT,
				vt.TENVT,
				vt.DONVITINH
END
GO


select*from HOADON
select*from CHITIET_HD
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
---------------4.Viết Stored Procedure báo cáo doanh thu tháng của từng Thiết bị
GO
IF EXISTS (SELECT NAME FROM SYSOBJECTS WHERE NAME='prBCDTTNTB')
	DROP PROC prBCDTTNTB
GO
CREATE PROC prBCDTTNTB
(
	@THANG		INT,
	@NAM		INT
)
AS
BEGIN
		SELECT	tb.MSTB,
				tb.TENTB,
				tb.DONVITINH,
				sum(ct.SOLUONGTB) as SOLUONGTB,
				sum(tb.DONGIA*ct.SOLUONGTB) as THANHTIEN
		FROM	HOADON hd, CHITIET_HD ct, THIETBI tb
		WHERE	hd.MSHD = ct.MSHD	and
				ct.MSTB =  tb.MSTB	and
				MONTH(hd.NGAYHD)= @THANG AND
				YEAR(hd.NGAYHD)=@NAM
		GROUP BY tb.MSTB,
				tb.TENTB,
				tb.DONVITINH
END
GO


---------------5.Viết Stored Procedure báo cáo doanh thu của từng nhân viên
GO
IF EXISTS (SELECT NAME FROM SYSOBJECTS WHERE NAME='prBCDSNV')
	DROP PROC prBCDSNV
GO
CREATE PROC prBCDSNV
(
	@TUDAY		DATETIME,
	@DENNGAY	DATETIME
)
AS
BEGIN
		SELECT	nv.MANV,
				nv.TENNV,
				
				sum(ct.THANHTIEN) as TONGTIEN
		FROM	HOADON hd, CHITIET_HD ct, NHANVIEN nv
		WHERE	hd.MSHD = ct.MSHD	and
				nv.MANV =  hd.MANV	and
				hd.NGAYHD Between @TUDAY AND @DENNGAY
		GROUP BY nv.MANV,
				nv.TENNV
				
END
GO

---------------6.Viết Stored Procedure báo cáo doanh thu tháng của từng NHÂN VIÊN
GO
IF EXISTS (SELECT NAME FROM SYSOBJECTS WHERE NAME='prBCDTTNNV')
	DROP PROC prBCDTTNNV
GO
CREATE PROC prBCDTTNNV
(
	@THANG		INT,
	@NAM		INT
)
AS
BEGIN
		SELECT	nv.MANV,
				nv.TENNV,
				
		
				sum(ct.THANHTIEN) as THANHTIEN
		FROM	HOADON hd, CHITIET_HD ct, NHANVIEN nv
		WHERE	hd.MSHD = ct.MSHD	and
				nv.MANV =  hd.MANV	and
				MONTH(hd.NGAYHD)= @THANG AND
				YEAR(hd.NGAYHD)=@NAM
		GROUP BY nv.MANV,
				 nv.TENNV
END
GO


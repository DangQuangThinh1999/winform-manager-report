use master
go
if exists(select name from master..sysdatabases where name='QL_THUYSAN')
	drop database QL_THUYSAN
go
go
create database QL_THUYSAN
go
use QL_THUYSAN
go
create table NHANVIEN
(
	MANV		char(10) 	not null primary key,
	TENNV		nvarchar(30)	not null,
	TENDANGNHAP	nvarchar(256)	not null,
	NGAYSINH	datetime	not null,
	PHAI		nchar(10)	not null,
	DIACHI		nvarchar(50)	not null,
	DIENTHOAI	nvarchar(10)	null,
	SO_HD_THUCHIEN	int		null,
	NGAYDANGNHAP	datetime	null,
	SOLANDN		int		null,
	QUYENHAN	nvarchar(20)	not null
)
go
create table KHACHHANG
(
	MsKH		char(10) primary key 	not null,
	TENKH		nvarchar(30)		not null,
	PHAI		nchar(10)		null,
	DIACHI		nvarchar(50)		not null,
	DIENTHOAI	varchar(10)		null
)
go
create table VATTU
(
	MSVT		char(10)primary key	not null,
	TENVT		nvarchar(50)		not null,
	XUATXU		nvarchar(50)		not null,
	HANGSX		nvarchar(50)		not null,
	SL_TON		int,
	
	DONGIA		float,
	DONVITINH	nchar(10)
)
go

create table THIETBI
(
	MSTB		char(10)primary key	not null,
	TENTB		nvarchar(50)		not null,
	XUATXU		nvarchar(50)		not null,
	HANGSX		nvarchar(50)		not null,
	SL_TON		int,
	
	DONGIA		float,
	DONVITINH	nchar(10)
)
go
create table HOADON
(
	MSHD		char(10) primary key	not null,
	MANV		char(10)		not null,
	MSKH		char(10)		not null,
	NGAYHD		datetime		not null,
	TONGTIEN	float			null
	constraint	FK_HD_NV foreign key(MANV) references NHANVIEN(MANV),
	constraint	FK_HD_KH foreign key(MSKH) references KHACHHANG(MSKH)
)
go
create table CHITIET_HD
(
	MSHD		char(10)		not null,
	MSVT		char(10)		not null,
	MSTB		char(10)		not null,
	SOLUONGVT		int			null,
	SOLUONGTB	int			null,
	THANHTIEN	money			null
	constraint PK_CTHD primary key(MSHD,MSVT,MSTB),
	constraint	FK_CT_TB foreign key(MSTB) references THIETBI(MSTB),
	constraint	FK_CT_VT foreign key(MSVT) references VATTU(MSVT),
	constraint	FK_CT_HD foreign key(MSHD) references HOADON(MSHD)
)


create table NHACUNGCAP
(
	MSNCC		char(10)			not null,
	TENNCC		nvarchar(50)	not null,
	HANG		nvarchar(50)	not null
	constraint PK_NHACUNGCAP primary key(MSNCC)	
)


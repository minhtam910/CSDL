use master
create database QLTTN
use QLTTN

create table CoSo(
	MaCS nchar(3),
	TenCS nVarchar(40) unique,
	Diachi nVarchar(100),
	primary key(MaCS)
)

create table Khoa(
	MaKH nchar(8),
	TenKH nvarchar(40) unique,
	MaCS nchar(3),
	primary key(MaKH),
	foreign key(MaCS) references CoSo(MaCS)
)

create table Lop(
	MaLop char(8),
	TenLop varchar(40) unique,
	MaKH nchar(8),
	primary key(MaLop),
	foreign key(MaKH) references Khoa(MaKH)
)

create table MonHoc(
	MaMH char(5),
	TenMH varchar(40) unique,
	primary key(MaMH)
)

create table SinhVien(
	MaSV char(8),
	Ho varchar(40),
	Ten varchar(40),
	NgaySinh datetime,
	DiaChi varchar(40),
	MaLop char(8),
	primary key(MaSV),
	foreign key(MaLop) references Lop(MaLop)
)

create table Giaovien(
	MaGV char(8),
	Ho varchar(40),
	Ten varchar(40),
	HocVi varchar(40),
	MaKH nchar(8),
	primary key(MaGV),
	foreign key(MaKH) references Khoa(MaKH)
)

create table Giaovien_Dangky(
	MaGV char(8),
	MaLop char(8),
	MaMH char(5),
	trinhDo char(1) check(trinhDo like 'A' or trinhDo like 'B' or trinhDo like 'C'),
	ngaythi datetime,
	Lan smallint check(Lan>=1 or Lan<=2),
	soCauthi smallint check(soCauthi>=10 or soCauthi<=100),
	thoigian smallint check(thoigian >=15 or thoigian <=60)
	foreign key(MaGV) references Giaovien(MaGV),
	foreign key(MaLop) references Lop(MaLop),
	foreign key(MaMH) references MonHoc(MaMH)
)

create table BODE(
	MaMH char(5),
	Cauhoi int,
	trinhDo char(1),
	noidung text,
	A varchar(30),
	B varchar(30),
	C varchar(30),
	D varchar(30),
	Dap_an char(1),
	MaGV char(8),
	primary key(Cauhoi),
	foreign key(MaMH) references MonHoc(MaMH),
	foreign key(MaGV) references Giaovien(MaGV)
)	

create table BangDiem(
	MaSV char(8),
	MaMH char(5),
	Lan smallint check(Lan>=1 or Lan<=2),
	ngaythi datetime,
	Diem float check(Diem>=0 or Diem<=10),
	Baithi text,
	primary key(MaSV, MaMH, Lan)
)

alter table SinhVien add constraint check_nhap_ho check (Ho not like  '%[^0-9]%')
alter table SinhVien add constraint check_nhap_ten check (Ten not like  '%[^0-9]%')

alter table Giaovien_Dangky add constraint default_ngay_thi default getDate() for ngaythi

alter table BODE add constraint check_trinh_do check (trinhDo like 'A' or trinhDo like 'B' or trinhDo like 'C')
alter table BODE add constraint check_dap_an check (Dap_an like 'A' or Dap_an like 'B' or Dap_an like 'C' or Dap_an like 'D')

alter table BangDiem add constraint default_ngay_thi_bd default getDate() for ngaythi

create database QLLK
use QLLK

create table KHACHHANG(
	idKhachHang int identity(1,1) primary key,
	TenKhachHang nvarchar(255),
	DienThoai varchar(10)
);
create table LINHKIEN(
	idLinhKien int identity(1,1) primary key,
	TenLinhKien nvarchar(255),
	LoaiLinhKien nvarchar(100),
	GiaBan float,
	idKhachHang int foreign key references KHACHHANG(idKhachHang)
);
INSERT INTO KHACHHANG (TenKhachHang, DienThoai) VALUES
(N'Nguyễn Văn A', '0901234567'),
(N'Trần Thị B', '0912345678'),
(N'Lê Văn C', '0923456789'),
(N'Phạm Thị D', '0934567890'),
(N'Hoàng Văn E', '0945678901');

-- Thêm dữ liệu giả vào bảng LINHKIEN
INSERT INTO LINHKIEN (TenLinhKien, LoaiLinhKien, GiaBan, idKhachHang) VALUES
(N'RAM 8GB', N'Bộ nhớ', 800000, 1),
(N'SSD 256GB', N'Lưu trữ', 1200000, 1),
(N'Màn hình 24 inch', N'Màn hình', 2500000, 2),
(N'Chuột không dây', N'Phụ kiện', 300000, 3),
(N'Bàn phím cơ', N'Phụ kiện', 900000, 4),
(N'Card đồ họa GTX 1660', N'Card đồ họa', 5000000, 5),
(N'Nguồn 650W', N'Nguồn máy', 1200000, 2),
(N'Tản nhiệt CPU', N'Phụ kiện', 400000, 3);
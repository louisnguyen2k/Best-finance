CREATE DATABASE QUANLYTAISAN
GO


USE QUANLYTAISAN
GO

-- 1. TẠO BẢNG TÀI KHOẢN
CREATE TABLE TaiKhoan(
	taikhoan VARCHAR(17) PRIMARY KEY,
	matkhau VARCHAR(17) NOT NULL,
	name NVARCHAR(50) NOT NULL,
	img IMAGE,
)
GO

-- 2. TẠO BẢNG NGƯỜI QUEN
CREATE TABLE NguoiQuen(
	ma_nguoi_quen INT IDENTITY(1,1) PRIMARY KEY,
	ten_nguoi_quen NVARCHAR(50) NOT NULL,
	sdt VARCHAR(12),
	dia_chi NVARCHAR(50),
	so_tien MONEY NOT NULL,
	taikhoan VARCHAR(17) NOT NULL,
	FOREIGN KEY (taikhoan) REFERENCES TaiKhoan(taikhoan)
)
GO


-- 3. TẠO BẢNG NHÓM GIAO DỊCH
CREATE TABLE NhomGiaoDich(
	ma_nhom_gd INT IDENTITY(1,1) PRIMARY KEY,
	ten_nhom_gd NVARCHAR(50) NOT NULL,
)
GO

-- 4. TẠO BẢNG LOẠI GIAO DỊCH
CREATE TABLE LoaiGiaoDich(
	ma_loai_gd INT IDENTITY(1,1) PRIMARY KEY,
	ten_loai_gd NVARCHAR(50) NOT NULL,
	ma_nhom_gd INT NOT NULL,
	FOREIGN KEY (ma_nhom_gd) REFERENCES NhomGiaoDich(ma_nhom_gd)
)
GO


-- 5. TẠO BẢNG VÍ
CREATE TABLE VI(
	ma_vi INT IDENTITY(1,1) PRIMARY KEY,
	ten_vi NVARCHAR(50) NOT NULL,
	don_vi NVARCHAR(30) NOT NULL,
	so_tien MONEY NOT NULL,
	taikhoan VARCHAR(17) NOT NULL,
	FOREIGN KEY (taikhoan) REFERENCES TaiKhoan(taikhoan)
)
GO


-- 6. TẠO BẢNG TÀI SẢN
CREATE TABLE TaiSan(
	ma_tai_san INT IDENTITY(1,1) PRIMARY KEY,
	ten_tai_san NVARCHAR(50) NOT NULL,
	so_luong int NOT NULL,
	tri_gia MONEY NOT NULL,
	mo_ta NVARCHAR(150),
	img IMAGE,
	taikhoan VARCHAR(17) NOT NULL,
	FOREIGN KEY (taikhoan) REFERENCES TaiKhoan(taikhoan)
)
GO

-- 7. TẠO BẢNG GIAO DỊCH TÀI CHÍNH
CREATE TABLE GiaoDichTaiChinh(
	ma_giao_dich INT IDENTITY(1,1) PRIMARY KEY,
	ma_vi INT NOT NULL,
	ma_loai_gd INT NOT NULL,
	ma_nguoi_quen INT ,
	so_tien MONEY NOT NULL,
	thoi_gian DATE NOT NULL,
	ghi_chu NVARCHAR(150),
	FOREIGN KEY (ma_vi) REFERENCES Vi(ma_vi),
	FOREIGN KEY (ma_loai_gd) REFERENCES LoaiGiaoDich(ma_loai_gd),
	FOREIGN KEY (ma_nguoi_quen) REFERENCES NguoiQuen(ma_nguoi_quen)
)
GO


-- 8. TẠO BẢNG GIAO DỊCH TÀI SẢN
CREATE TABLE GiaoDichTaiSan(
	ma_giao_dich INT IDENTITY(1,1) PRIMARY KEY,
	ma_vi INT NOT NULL,
	ma_loai_gd INT NOT NULL,
	ma_tai_san INT NOT NULL,
	so_luong MONEY NOT NULL,
	thoi_gian DATE NOT NULL,
	ghi_chu NVARCHAR(150),
	FOREIGN KEY (ma_vi) REFERENCES Vi(ma_vi),
	FOREIGN KEY (ma_loai_gd) REFERENCES LoaiGiaoDich(ma_loai_gd),
	FOREIGN KEY (ma_tai_san) REFERENCES TaiSan(ma_tai_san)
)
GO

-- 9. TẠO BẢNG NGÂN SÁCH
CREATE TABLE NganSach(
	ma_vi INT NOT NULL,
	ma_loai_gd INT NOT NULL,
	PRIMARY KEY(ma_vi, ma_loai_gd),
	so_tien MONEY NOT NULL,
	ngay_bat_dau DATE NOT NULL,
	ngay_ket_thuc DATE NOT NULL,
	FOREIGN KEY (ma_vi) REFERENCES Vi(ma_vi),
	FOREIGN KEY (ma_loai_gd) REFERENCES LoaiGiaoDich(ma_loai_gd)
)
GO


-- 10. TẠO BẢNG GIAO DỊCH ĐỊNH KÌ
CREATE TABLE GiaoDichDinhKi(
	ma_vi INT NOT NULL,
	ma_loai_gd INT NOT NULL,
	PRIMARY KEY(ma_vi, ma_loai_gd),
	so_tien MONEY NOT NULL,
	mo_ta NVARCHAR(150),
	tan_suat INT NOT NULL,
	ngay_bat_dau DATE NOT NULL,
	ngay_ket_thuc DATE NOT NULL,
	FOREIGN KEY (ma_vi) REFERENCES Vi(ma_vi),
	FOREIGN KEY (ma_loai_gd) REFERENCES LoaiGiaoDich(ma_loai_gd)
)
GO


-- 11. TẠO BẢNG NOTIFICATION
CREATE TABLE Noti(
	title NVARCHAR(100) NOT NULL,
	content NVARCHAR (150) NOT NULL,
	time DATE
)
GO


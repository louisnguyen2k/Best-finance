USE QUANLYTAISAN
GO


-- 12. TẠO BẢNG GIAO DỊCH TÀI SẢN
CREATE TABLE ChuyenTien(
	ma_chuyen INT IDENTITY(1,1) PRIMARY KEY,
	ma_vi_chuyen INT NOT NULL,
	ma_vi_nhan INT NOT NULL,
	so_tien MONEY NOT NULL,
	thoi_gian DATE NOT NULL,
	ghi_chu NVARCHAR(150),
	FOREIGN KEY (ma_vi_chuyen) REFERENCES Vi(ma_vi),
	FOREIGN KEY (ma_vi_nhan) REFERENCES Vi(ma_vi)
)
GO

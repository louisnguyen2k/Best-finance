USE QUANLYTAISAN
GO

select * from NhomGiaoDich

----- KHOẢN THU
SELECT SUM(so_tien) FROM GiaoDichTaiChinh, LoaiGiaoDich, NhomGiaoDich
WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
AND (LoaiGiaoDich.ten_loai_gd = N'Đi vay' OR NhomGiaoDich.ten_nhom_gd = N'Khoản thu')
--AND ma_vi = '1'

----
SELECT SUM(TaiSan.tri_gia * GiaoDichTaiSan.so_luong) FROM GiaoDichTaiSan, LoaiGiaoDich, TaiSan
WHERE GiaoDichTaiSan.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
AND GiaoDichTaiSan.ma_tai_san = TaiSan.ma_tai_san
AND LoaiGiaoDich.ten_loai_gd = N'Bán'
--AND ma_vi = '1'

----

SELECT SUM(so_tien) FROM ChuyenTien
--WHERE ma_vi_nhan = '1'


----------------------------------------

----- KHOẢN CHI TIÊU
SELECT SUM(so_tien) FROM GiaoDichTaiChinh, LoaiGiaoDich, NhomGiaoDich
WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
AND (LoaiGiaoDich.ten_loai_gd = N'Cho vay' OR NhomGiaoDich.ten_nhom_gd = N'Khoản chi')
AND ma_vi = '1'

----
SELECT SUM(TaiSan.tri_gia * GiaoDichTaiSan.so_luong) FROM GiaoDichTaiSan, LoaiGiaoDich, TaiSan
WHERE GiaoDichTaiSan.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
AND GiaoDichTaiSan.ma_tai_san = TaiSan.ma_tai_san
AND LoaiGiaoDich.ten_loai_gd = N'Mua'
AND ma_vi = '1'

----

SELECT SUM(so_tien) FROM ChuyenTien
WHERE ma_vi_chuyen = '1'


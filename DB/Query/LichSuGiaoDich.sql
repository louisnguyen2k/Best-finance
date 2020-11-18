USE QUANLYTAISAN
GO


SELECT ma_giao_dich, ma_loai_gd, GiaoDichTaiChinh.ma_vi, GiaoDichTaiChinh.so_tien, thoi_gian, ghi_chu, ma_nguoi_quen FROM GiaoDichTaiChinh, VI
WHERE GiaoDichTaiChinh.ma_vi = VI.ma_vi
AND VI.ma_vi = '1'

SELECT ma_giao_dich, ma_loai_gd, GiaoDichTaiSan.ma_vi, ma_tai_san, so_luong, thoi_gian, ghi_chu
FROM GiaoDichTaiSan, VI
WHERE GiaoDichTaiSan.ma_vi = VI.ma_vi
AND VI.ma_vi = '1'

SELECT ten_loai_gd FROM LoaiGiaoDich
WHERE ma_loai_gd = 25

SELECT ten_nguoi_quen FROM NguoiQuen
WHERE ma_nguoi_quen = 1

SELECT ten_tai_san FROM TaiSan
WHERE ma_tai_san = 1


SELECT img FROM LoaiGiaoDich
WHERE ma_loai_gd = 25


SELECT tri_gia FROM TaiSan
WHERE ma_tai_san = 1

SELECT ma_giao_dich, ma_loai_gd, GiaoDichTaiChinh.ma_vi, GiaoDichTaiChinh.so_tien, thoi_gian, ghi_chu, ma_nguoi_quen 
FROM GiaoDichTaiChinh, VI
WHERE GiaoDichTaiChinh.ma_vi = VI.ma_vi
AND VI.ma_vi = '1'
AND taikhoan = 'admin'
AND (thoi_gian >= '11/9/2020' AND thoi_gian <= '11/17/2020')


SELECT * FROM NhomGiaoDich -- Khoản thu / Khoản chi
SELECT * FROM LoaiGiaoDich -- 


SELECT ten_nhom_gd FROM NhomGiaoDich, LoaiGiaoDich
WHERE NhomGiaoDich.ma_nhom_gd = LoaiGiaoDich.ma_nhom_gd
AND ma_loai_gd = 29

SELECT LoaiGiaoDich.img, LoaiGiaoDich.ten_loai_gd, GiaoDichTaiChinh.ghi_chu,NguoiQuen.ten_nguoi_quen , GiaoDichTaiChinh.so_tien, GiaoDichTaiChinh.thoi_gian, VI.img, VI.ten_vi
FROM GiaoDichTaiChinh, VI, LoaiGiaoDich, NguoiQuen
WHERE GiaoDichTaiChinh.ma_vi = VI.ma_vi
AND GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
AND GiaoDichTaiChinh.ma_nguoi_quen = NguoiQuen.ma_nguoi_quen
AND GiaoDichTaiChinh.ma_giao_dich = 21




SELECT LoaiGiaoDich.img, LoaiGiaoDich.ten_loai_gd, GiaoDichTaiSan.ghi_chu, TaiSan.ten_tai_san, (GiaoDichTaiSan.so_luong * TaiSan.tri_gia), GiaoDichTaiSan.thoi_gian, VI.img, VI.ten_vi
FROM GiaoDichTaiSan, VI, LoaiGiaoDich, TaiSan
WHERE GiaoDichTaiSan.ma_vi = VI.ma_vi
AND GiaoDichTaiSan.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
AND GiaoDichTaiSan.ma_tai_san = TaiSan.ma_tai_san
AND GiaoDichTaiSan.ma_giao_dich = 1

SELECT * FROM GiaoDichTaiChinh
SELECT * FROM GiaoDichTaiSan

DELETE GiaoDichTaiChinh WHERE ma_giao_dich = ''

DELETE GiaoDichTaiSan WHERE ma_giao_dich = ''
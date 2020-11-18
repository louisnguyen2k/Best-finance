USE QUANLYTAISAN
GO


-- QUERY GIAO DỊCH

SELECT * FROM NhomGiaoDich
WHERE ma_nhom_gd = 4


SELECT * FROM LoaiGiaoDich
WHERE ma_nhom_gd = 1

SELECT ma_nguoi_quen, ten_nguoi_quen, sdt, dia_chi, so_tien
FROM NguoiQuen

SELECT NguoiQuen.ma_nguoi_quen, ten_nguoi_quen, sdt, dia_chi, GiaoDichTaiChinh.so_tien, GiaoDichTaiChinh.ma_giao_dich, GiaoDichTaiChinh.ghi_chu
FROM NguoiQuen, GiaoDichTaiChinh, LoaiGiaoDich
WHERE NguoiQuen.ma_nguoi_quen = GiaoDichTaiChinh.ma_nguoi_quen
AND GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
AND NguoiQuen.taikhoan = 'admin'
AND NguoiQuen.ma_nguoi_quen != 13
AND LoaiGiaoDich.ten_loai_gd = N'Cho vay' -- thu nợ
----------------------
AND LoaiGiaoDich.ten_loai_gd = N'Đi vay' -- trả nợ

SELECT ma_nguoi_quen, ten_nguoi_quen, sdt, dia_chi
                                    FROM NguoiQuen
                                    WHERE taikhoan = 'admin'
                                    AND NguoiQuen.ma_nguoi_quen != 13


select * from GiaoDichTaiChinh
-- INSERT GiaoDichTaiChinh

INSERT INTO GiaoDichTaiChinh(ma_vi, ma_loai_gd, ma_nguoi_quen, so_tien, thoi_gian, ghi_chu) 
VALUES('', '', '', 1, '', N'')

DELETE GiaoDichTaiChinh WHERE ma_giao_dich = ''

SELECT ten_nhom_gd 
FROM NhomGiaoDich, LoaiGiaoDich
WHERE NhomGiaoDich.ma_nhom_gd = LoaiGiaoDich.ma_nhom_gd
AND LoaiGiaoDich.ma_loai_gd = '35'



-- LẤY MÃ VÍ

SELECT ma_vi FROM GiaoDichTaiChinh
WHERE ma_giao_dich = ''

-- LẤY TIỀN TRONG VÍ
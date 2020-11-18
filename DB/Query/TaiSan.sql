USE QUANLYTAISAN
GO




SELECT ma_tai_san, ten_tai_san, so_luong, tri_gia, mo_ta, img
FROM TaiSan
WHERE taikhoan = 'admin'
ORDER BY so_luong * tri_gia DESC


SELECT ma_tai_san, ten_tai_san, so_luong, tri_gia, mo_ta, img
FROM TaiSan
WHERE ma_tai_san = 1


INSERT INTO TaiSan(ten_tai_san, so_luong, tri_gia, mo_ta, img, taikhoan)
VALUES(N'', 1, 2, N'', @img , '')

UPDATE TaiSan SET ten_tai_san = N'', so_luong = 0, tri_gia = 0, mo_ta = N'', img = '' 
WHERE ma_tai_san = ''


DELETE TaiSan WHERE ma_tai_san = ''

UPDATE TaiSan SET so_luong =1
WHERE ma_tai_san = 1

SELECT tri_gia FROM TaiSan
WHERE ma_tai_san = '1'



SELECT so_luong FROM TaiSan
WHERE ma_tai_san = '1'

SELECT * FROM LoaiGiaoDich
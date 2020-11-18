USE QUANLYTAISAN
GO

SELECT ma_vi, img, ten_vi, so_tien, don_vi FROM VI
WHERE taikhoan = 'admin'

SELECT * FROM VI

INSERT INTO VI(ten_vi, don_vi, so_tien, img, taikhoan)
VALUES(N'', N'',1 , '', '')


UPDATE VI SET so_tien = 1 WHERE ma_vi = ''


DELETE VI WHERE ma_vi = ''

SELECT ma_vi, img, ten_vi, so_tien, don_vi FROM VI
WHERE ma_vi = '1'

SELECT don_vi FROM VI
WHERE ma_vi = '1'

-- LẤY TIỀN TRONG VÍ
SELECT so_tien FROM VI
WHERE ma_vi = '1'
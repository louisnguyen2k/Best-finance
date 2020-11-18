USE QUANLYTAISAN
GO



SELECT * FROM NguoiQuen


INSERT INTO NguoiQuen(ten_nguoi_quen, sdt, dia_chi, so_tien, taikhoan) VALUES
(N'', '', N'', 0, '')


SELECT ROW_NUMBER() OVER (ORDER BY ma_nguoi_quen) AS [STT],
--ma_nguoi_quen,
ten_nguoi_quen AS N'Tên người quen',
sdt AS N'SDT',
dia_chi AS N'Địa chỉ',
so_tien AS N'Số tiền'
FROM NguoiQuen, TaiKhoan
WHERE TaiKhoan.taikhoan = 'admin'



SELECT ten_nguoi_quen, so_tien, sdt, dia_chi
FROM NguoiQuen
WHERE ma_nguoi_quen = 7


UPDATE NguoiQuen SET ten_nguoi_quen = N'', so_tien = 1, sdt = '', dia_chi = N''
WHERE ma_nguoi_quen = ''

DELETE NguoiQuen WHERE ma_nguoi_quen = ''


-- query tổng quan cho vay và đi vay
SELECT NguoiQuen.ten_nguoi_quen, LoaiGiaoDich.ten_loai_gd , SUM(GiaoDichTaiChinh.so_tien) , COUNT(*)
                                FROM GiaoDichTaiChinh, TaiKhoan, VI, NguoiQuen, LoaiGiaoDich
                                WHERE TaiKhoan.taikhoan = VI.taikhoan
                                AND TaiKhoan.taikhoan = NguoiQuen.taikhoan

                                AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
                                AND GiaoDichTaiChinh.ma_nguoi_quen = NguoiQuen.ma_nguoi_quen

                                AND GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd

                                AND TaiKhoan.taikhoan = 'admin'
								AND (LoaiGiaoDich.ten_loai_gd = N'Đi vay' OR LoaiGiaoDich.ten_loai_gd = N'Cho vay')
                                AND NguoiQuen.ma_nguoi_quen != 13
                                GROUP BY NguoiQuen.ten_nguoi_quen, LoaiGiaoDich.ten_loai_gd


SELECT ma_nguoi_quen, ten_nguoi_quen, sdt, dia_chi
                                    FROM NguoiQuen
                                    WHERE taikhoan = 'admin'
                                    AND NguoiQuen.ma_nguoi_quen != 13
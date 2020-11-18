USE QUANLYTAISAN
GO


-- HÀM LẤY SỐ TIỀN THU THEO MÃ VÍ

ALTER FUNCTION GET_Paying
(@id_vi INT = '', @id VARCHAR(17))
RETURNS MONEY
AS
BEGIN
		DECLARE @GD_TaiChinh MONEY
		DECLARE @GD_TaiSan MONEY
		DECLARE @GD_ChuyenTien MONEY

		IF (@id_vi != '') -- LẤY THEO MÃ
		BEGIN
			SELECT @GD_TaiChinh = SUM(GiaoDichTaiChinh.so_tien) FROM GiaoDichTaiChinh, LoaiGiaoDich, NhomGiaoDich, VI
			WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
				AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
				AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
				AND (LoaiGiaoDich.ten_loai_gd = N'Cho vay' OR NhomGiaoDich.ten_nhom_gd = N'Khoản chi')
				AND VI.ma_vi = @id_vi
				AND taikhoan = @id

			SELECT @GD_TaiSan = SUM(TaiSan.tri_gia * GiaoDichTaiSan.so_luong) FROM GiaoDichTaiSan, LoaiGiaoDich, TaiSan
			WHERE GiaoDichTaiSan.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
				AND GiaoDichTaiSan.ma_tai_san = TaiSan.ma_tai_san
				AND LoaiGiaoDich.ten_loai_gd = N'Mua'
				AND ma_vi = @id_vi
				AND taikhoan = @id


			SELECT @GD_ChuyenTien = SUM(ChuyenTien.so_tien) FROM ChuyenTien, VI
				WHERE VI.ma_vi =  ChuyenTien.ma_vi_chuyen
				AND ma_vi_chuyen = @id_vi
				AND taikhoan = @id
		END
		ELSE -- LẤY TẤT
		BEGIN
			SELECT @GD_TaiChinh = SUM(GiaoDichTaiChinh.so_tien) FROM GiaoDichTaiChinh, LoaiGiaoDich, NhomGiaoDich, VI
			WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
				AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
				AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
				AND (LoaiGiaoDich.ten_loai_gd = N'Cho vay' OR NhomGiaoDich.ten_nhom_gd = N'Khoản chi')
				AND taikhoan = @id

			SELECT @GD_TaiSan = SUM(TaiSan.tri_gia * GiaoDichTaiSan.so_luong) FROM GiaoDichTaiSan, LoaiGiaoDich, TaiSan
			WHERE GiaoDichTaiSan.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
				AND GiaoDichTaiSan.ma_tai_san = TaiSan.ma_tai_san
				AND LoaiGiaoDich.ten_loai_gd = N'Mua'
				AND taikhoan = @id

			SELECT @GD_ChuyenTien = SUM(ChuyenTien.so_tien) FROM ChuyenTien, VI
				WHERE VI.ma_vi =  ChuyenTien.ma_vi_chuyen
				AND taikhoan = @id
		END
		
		
		DECLARE @SUM MONEY = 0

		IF(@GD_TaiChinh IS NOT NULL)
		BEGIN
			SET @SUM = @SUM + @GD_TaiChinh
		END

		IF(@GD_TaiSan IS NOT NULL)
		BEGIN
			SET @SUM = @SUM + @GD_TaiSan
		END

		IF(@GD_ChuyenTien IS NOT NULL)
		BEGIN
			SET @SUM = @SUM + @GD_ChuyenTien
		END
RETURN @SUM
END


PRINT dbo.GET_Paying('','admin')
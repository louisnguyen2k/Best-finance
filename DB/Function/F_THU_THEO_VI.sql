USE QUANLYTAISAN
GO


-- HÀM LẤY SỐ TIỀN THU THEO MÃ VÍ

ALTER FUNCTION GET_Earnings
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
				AND (LoaiGiaoDich.ten_loai_gd = N'Đi vay' OR NhomGiaoDich.ten_nhom_gd = N'Khoản thu')
				AND VI.ma_vi = @id_vi
				AND taikhoan = @id

			SELECT @GD_TaiSan = SUM(TaiSan.tri_gia * GiaoDichTaiSan.so_luong) FROM GiaoDichTaiSan, LoaiGiaoDich, TaiSan
				WHERE GiaoDichTaiSan.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
				AND GiaoDichTaiSan.ma_tai_san = TaiSan.ma_tai_san
				AND LoaiGiaoDich.ten_loai_gd = N'Bán'
				AND ma_vi = @id_vi
				AND taikhoan = @id


			SELECT @GD_ChuyenTien = SUM(ChuyenTien.so_tien) FROM ChuyenTien, VI
				WHERE VI.ma_vi =  ChuyenTien.ma_vi_nhan
				AND ma_vi_nhan = @id_vi
				AND taikhoan = @id
				
		END
		ELSE -- LẤY TẤT
		BEGIN
			SELECT @GD_TaiChinh = SUM(GiaoDichTaiChinh.so_tien) FROM GiaoDichTaiChinh, LoaiGiaoDich, NhomGiaoDich, VI
			WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
				AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
				AND (LoaiGiaoDich.ten_loai_gd = N'Đi vay' OR NhomGiaoDich.ten_nhom_gd = N'Khoản thu')
				AND taikhoan = @id

			SELECT @GD_TaiSan = SUM(TaiSan.tri_gia * GiaoDichTaiSan.so_luong) FROM GiaoDichTaiSan, LoaiGiaoDich, TaiSan
				WHERE GiaoDichTaiSan.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
				AND GiaoDichTaiSan.ma_tai_san = TaiSan.ma_tai_san
				AND LoaiGiaoDich.ten_loai_gd = N'Bán'
				AND taikhoan = @id

			SELECT @GD_ChuyenTien = SUM(ChuyenTien.so_tien) FROM ChuyenTien, VI
				WHERE VI.ma_vi =  ChuyenTien.ma_vi_nhan
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


PRINT dbo.GET_Earnings('','admin')
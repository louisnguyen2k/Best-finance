USE QUANLYTAISAN
GO



-----------------------------------------------
--DROP TRIGGER GIAO_DICH_TAI_SAN

CREATE TRIGGER GIAO_DICH_TAI_SAN ON GiaoDichTaiSan
FOR INSERT
AS
BEGIN
	-- LẤY MÃ VÍ THỰC HIỆN GIAO DỊCH
	DECLARE @ma_vi INT
	SELECT TOP(1) @ma_vi = ma_vi FROM inserted ORDER BY ma_giao_dich DESC

	-- LẤY SỐ TIỀN ĐANG CÓ TRONG VÍ THỰC HIỆN GIAO DỊCH
	DECLARE @tien_vi MONEY
	SELECT @tien_vi = so_tien FROM VI WHERE ma_vi = @ma_vi

	-- LẤY MÃ LOẠI GIAO DỊCH
	DECLARE @ma_loai_gd INT
	SELECT TOP(1) @ma_loai_gd = ma_loai_gd FROM inserted ORDER BY ma_giao_dich DESC

	-- LẤY TÊN LOẠI GIAO DỊCH
	DECLARE @ten_loai_gd NVARCHAR(50)
	SELECT @ten_loai_gd = ten_loai_gd 
		FROM LoaiGiaoDich
		WHERE @ma_loai_gd = ma_loai_gd
	
	-- LẤY SỐ LƯỢNG TÀI SẢN TRONG GIAO DỊCH
	DECLARE @so_luong INT
	SELECT TOP(1) @so_luong = so_luong FROM inserted ORDER BY ma_giao_dich DESC
	

	-- LẤY MÃ TÀI SẢN
	DECLARE @ma_tai_san INT
	SELECT TOP(1) @ma_tai_san = ma_tai_san FROM inserted ORDER BY ma_giao_dich DESC


	-- LẤY GIÁ TRỊ CỦA TÀI SẢN
	-- LẤY TÊN LOẠI GIAO DỊCH
	DECLARE @tri_gia MONEY
	SELECT @tri_gia = tri_gia 
		FROM TaiSan
		WHERE @ma_tai_san = ma_tai_san


	
	-- LẤY SỐ LƯỢNG TÀI SẢN HIỆN ĐANG SỞ HỮU
		DECLARE @so_luong_so_huu INT
		SELECT @so_luong_so_huu = so_luong FROM TaiSan
		WHERE ma_tai_san = @ma_tai_san


	IF (@ten_loai_gd = N'Mua')
	BEGIN
		-- UPDATE VÍ SAU KHI MUA TÀI SẢN
		UPDATE Vi SET so_tien = @tien_vi - (@tri_gia * @so_luong)
		WHERE ma_vi = @ma_vi

		-- UPDATE SỐ LƯỢNG TÀI SẢN SỞ HỮU SAU KHI THỰC HIỆN GIAO DỊCH
		UPDATE TaiSan SET so_luong = @so_luong_so_huu + @so_luong
				WHERE ma_tai_san = @ma_tai_san
	END

	ELSE IF (@ten_loai_gd = N'Bán')
	BEGIN
		-- UPDATE VÍ SAU KHI BÁN TÀI SẢN 
		UPDATE Vi SET so_tien = @tien_vi + (@tri_gia * @so_luong)
		WHERE ma_vi = @ma_vi

		-- UPDATE SỐ LƯỢNG TÀI SẢN SỞ HỮU SAU KHI THỰC HIỆN GIAO DỊCH BÁN
		UPDATE TaiSan SET so_luong = @so_luong_so_huu - @so_luong
				WHERE ma_tai_san = @ma_tai_san
	END

	ELSE
	BEGIN
		PRINT N'Không được thêm trường thuộc giao dịch tài chính vào bảng'
		ROLLBACK TRAN
	END

END

GO
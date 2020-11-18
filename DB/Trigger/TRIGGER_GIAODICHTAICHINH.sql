USE QUANLYTAISAN
GO



-----------------------------------------------
--DROP TRIGGER GIAO_DICH_TAI_CHINH

CREATE TRIGGER GIAO_DICH_TAI_CHINH ON GiaoDichTaiChinh
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
	SELECT @ten_loai_gd = ten_loai_gd FROM LoaiGiaoDich WHERE ma_loai_gd = @ma_loai_gd

	-- LẤY MÃ NGƯỜI QUEN THỰC HIỆN GIAO DỊCH
	DECLARE @ma_nguoi_quen INT
	SELECT TOP(1) @ma_nguoi_quen = ma_nguoi_quen FROM inserted ORDER BY ma_giao_dich DESC

	-- LẤY TÊN NHÓM GIAO DỊCH
	DECLARE @ten_nhom_gd NVARCHAR(50)
	SELECT @ten_nhom_gd = ten_nhom_gd 
		FROM NhomGiaoDich, LoaiGiaoDich
		WHERE NhomGiaoDich.ma_nhom_gd = LoaiGiaoDich.ma_nhom_gd
			AND LoaiGiaoDich.ma_loai_gd = @ma_loai_gd

	-- LẤY SỐ TIỀN THỰC HIỆN GIAO DỊCH
	DECLARE @so_tien  INT
	SELECT TOP(1) @so_tien = so_tien FROM inserted ORDER BY ma_giao_dich DESC

	IF (@ten_nhom_gd = N'Đi vay/Cho vay')
	BEGIN
		IF (@ten_loai_gd = N'Cho vay')
		BEGIN
			-- UPDATE VÍ SAU KHI CHO VAY
			UPDATE Vi SET so_tien = @tien_vi - @so_tien
			WHERE ma_vi = @ma_vi
		END
		ELSE IF (@ten_loai_gd = N'Trả nợ')
		BEGIN
			-- UPDATE VÍ SAU KHI TRẢ NỢ
			UPDATE Vi SET so_tien = @tien_vi - @so_tien
			WHERE ma_vi = @ma_vi
		END
		ELSE IF (@ten_loai_gd = N'Đi vay')
		BEGIN
			-- UPDATE VÍ SAU KHI ĐI VAY
			UPDATE Vi SET so_tien = @tien_vi + @so_tien
			WHERE ma_vi = @ma_vi
		END
		ELSE IF (@ten_loai_gd = N'Thu nợ')
		BEGIN
			-- UPDATE VÍ SAU KHI THU NỢ
			UPDATE Vi SET so_tien = @tien_vi + @so_tien
			WHERE ma_vi = @ma_vi
		END
	END
	ELSE IF (@ten_nhom_gd = N'Khoản chi')
	BEGIN
		-- UPDATE VÍ KHI TIÊU TIỀN
		UPDATE Vi SET so_tien = @tien_vi - @so_tien
		WHERE ma_vi = @ma_vi
	END
	ELSE IF (@ten_nhom_gd = N'Khoản thu')
	BEGIN
		-- UPDATE VÍ KHI CHI TIỀN
		UPDATE Vi SET so_tien = @tien_vi + @so_tien
		WHERE ma_vi = @ma_vi
	END
	ELSE IF (@ten_nhom_gd = N'Mua/Bán tài sản')
	BEGIN
		PRINT N'Không được thêm trường thuộc mua bán tàn sản vào trong giao dịch tài chính'
		ROLLBACK TRAN
	END
END

GO
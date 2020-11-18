USE QUANLYTAISAN
GO

-- TẠO TRIGGER CHO BẢNG Chuyen_Tien

CREATE TRIGGER CHUYEN_TIEN_VI ON ChuyenTien
FOR INSERT
AS
BEGIN

	-- LẤY MÃ VÍ CHUYỂN VÀ MÃ VÍ NHẬN
	DECLARE @ma_vi_chuyen INT
	DECLARE @ma_vi_nhan INT
	SELECT TOP(1) @ma_vi_chuyen = ma_vi_chuyen FROM inserted ORDER BY ma_chuyen DESC
	SELECT TOP(1) @ma_vi_nhan = ma_vi_nhan FROM inserted ORDER BY ma_chuyen DESC

	-- LẤY SỐ TIỀN CHUYỂN
	DECLARE @tien_chuyen MONEY
	SELECT TOP(1) @tien_chuyen = so_tien FROM inserted ORDER BY ma_chuyen DESC

	-- LẤY SỐ TIỀN HIỆN TẠI TRONG VÍ NHẬN VÀ SỐ TIỀN HIỆN TẠI TRONG VÍ CHUYỂN
	DECLARE @tien_vi_chuyen MONEY
	DECLARE @tien_vi_nhan MONEY
	SELECT @tien_vi_chuyen = so_tien FROM VI WHERE ma_vi = @ma_vi_chuyen
	SELECT @tien_vi_nhan = so_tien FROM VI WHERE ma_vi = @ma_vi_nhan

	-- LẤY ĐƠN VỊ TIỀN CỦA VÍ NHẬN VÀ VÍ CHUYỂN
	DECLARE @don_vi_vi_chuyen NVARCHAR(30)
	DECLARE @don_vi_vi_nhan NVARCHAR(30)
	SELECT @don_vi_vi_chuyen = don_vi FROM VI WHERE ma_vi = @ma_vi_chuyen
	SELECT @don_vi_vi_nhan = don_vi FROM VI WHERE ma_vi = @ma_vi_nhan


	IF (@don_vi_vi_chuyen = N'VND' AND @don_vi_vi_nhan = N'$') -- KHI VÍ CHUYỂN LÀ VND, VÍ NHẬN LÀ $
	BEGIN
		-- UPDATE VÍ CHUYỂN TIỀN
		UPDATE Vi SET so_tien = @tien_vi_chuyen - @tien_chuyen
		WHERE ma_vi = @ma_vi_chuyen

		-- UPDATE VÍ NHẬN TIỀN
		UPDATE Vi SET so_tien = @tien_vi_nhan + (@tien_chuyen / 23000)
		WHERE ma_vi = @ma_vi_nhan
	END
	ELSE IF (@don_vi_vi_chuyen = N'$' AND @don_vi_vi_nhan = N'VND') -- KHI VÍ CHUYỂN LÀ $, VÍ NHẬN LÀ VND
	BEGIN
		-- UPDATE VÍ CHUYỂN TIỀN
		UPDATE Vi SET so_tien = @tien_vi_chuyen - @tien_chuyen
		WHERE ma_vi = @ma_vi_chuyen

		-- UPDATE VÍ NHẬN TIỀN
		UPDATE Vi SET so_tien = @tien_vi_nhan + (@tien_chuyen * 23000)
		WHERE ma_vi = @ma_vi_nhan
	END
	ELSE -- KHI VÍ CHUYỂN VÀ VÍ NHẬN CÙNG ĐƠN VỊ
	BEGIN
		-- UPDATE VÍ CHUYỂN TIỀN
		UPDATE Vi SET so_tien = @tien_vi_chuyen - @tien_chuyen
		WHERE ma_vi = @ma_vi_chuyen

		-- UPDATE VÍ NHẬN TIỀN
		UPDATE Vi SET so_tien = @tien_vi_nhan + @tien_chuyen
		WHERE ma_vi = @ma_vi_nhan
	END 
END
GO



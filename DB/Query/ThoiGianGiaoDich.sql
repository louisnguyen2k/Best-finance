USE QUANLYTAISAN
GO


-- LẤY GIAO DỊCH MUỘN NHẤT Ở BẢNG GiaoDichTaiChinh
DECLARE @timeGDTaiChinh DATE
SELECT TOP(1) @timeGDTaiChinh = thoi_gian FROM GiaoDichTaiChinh
ORDER BY thoi_gian ASC
--SELECT @timeGDTaiChinh


-- LẤY GIAO DỊCH MUỘN NHẤT Ở BẢNG GiaoDichTaiSan
DECLARE @timeGDTaiSan DATE
SELECT TOP(1) @timeGDTaiSan = thoi_gian FROM GiaoDichTaiSan
ORDER BY thoi_gian ASC
--SELECT @timeGDTaiSan


DECLARE @timeResult DATE
IF(@timeGDTaiChinh < @timeGDTaiSan)
BEGIN
	SET @timeResult = @timeGDTaiChinh
END
ELSE
BEGIN
	SET @timeResult = @timeGDTaiSan
END

SELECT @timeResult
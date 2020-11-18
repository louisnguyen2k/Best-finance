USE QUANLYTAISAN
GO

-- INSERT BẢNG NhomGiaoDich
INSERT INTO NhomGiaoDich(ten_nhom_gd) VALUES
(N'Đi vay/Cho vay'),
(N'Khoản chi'),
(N'Khoản thu'),
(N'Mua/Bán tài sản')
GO


-- INSERT BẢNG NhomGiaoDich
DELETE LoaiGiaoDich
GO

INSERT INTO LoaiGiaoDich(ma_nhom_gd, ten_loai_gd, img) VALUES
(1, N'Cho vay', 'borrow.PNG'), 
(1, N'Trả nợ', 'pay.PNG'), --
(1, N'Đi vay' , 'loan.PNG'), -- 
(1, N'Thu nợ', 'debt-collection.PNG'), -- 
-------------------
(2, N'Ăn uống', 'food.PNG'),
(2, N'Hóa đơn & tiện ích', 'bill.PNG'),
(2, N'Di chuyển', 'moto-cycle.PNG'),
(2, N'Mua sắm', 'shopping.PNG'),
(2, N'Bạn bè & người yêu', 'love-and-friendship.PNG'),
(2, N'Giải trí', 'entertainment.PNG'),
(2, N'Du lịch', 'travel.PNG'),
(2, N'Sức khỏe', 'health.PNG'),
(2, N'Tặng quà & quyên góp', 'gift-money.PNG'),
(2, N'Gia đình', 'family.PNG'),
(2, N'Giáo dục', 'education.PNG'),
(2, N'Đầu tư/Kinh doanh', 'investing-business.PNG'),
(2, N'Khoản chi khác', 'different.PNG'),
-------------------
(3, N'Lương', 'salary.PNG'),
(3, N'Thưởng', 'reward.PNG'),
(3, N'Tiền lãi', 'interest.PNG'),
(3, N'Được tặng', 'gift-money.PNG'),
(3, N'Khoản thu khác', 'different.PNG'),
-------------------
(4, N'Mua', 'buy.PNG'),
(4, N'Bán', 'sell.PNG')
GO
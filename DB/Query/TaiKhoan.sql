CREATE DATABASE QUANLYTAISAN
GO

USE QUANLYTAISAN
GO

SELECT matkhau FROM TaiKhoan
WHERE taikhoan = 'admin'

SELECT COUNT(*) FROM TaiKhoan
WHERE taikhoan ='" + id_User + "' AND matkhau = '" + mk_cu + "'


UPDATE TaiKhoan SET matkhau = '" + mk_moi1 + "' WHERE taikhoan = '" + id_User + "'

INSERT TaiKhoan(taikhoan, name, matkhau) 
VALUES ('" + tk + "',N'" + name + "','" + mk1 + "')


SELECT name FROM TaiKhoan
WHERE taikhoan ='' 
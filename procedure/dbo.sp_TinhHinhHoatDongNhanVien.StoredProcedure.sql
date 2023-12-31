USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_TinhHinhHoatDongNhanVien]    Script Date: 11/12/2023 11:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_TinhHinhHoatDongNhanVien]
   @MANV int,
@LOAI nvarchar(4),
@NGAYBATDAU DATETIME,
@NGAYKETTHUC DATETIME
AS
BEGIN
	
	IF( @LOAI = 'NHAP')
	BEGIN
		SELECT FORMAT(PN.NGAYLAP,'MM-yyyy') AS THANGNAM, 
				PN.NGAYLAP,
				PN.MAPN AS MAPHIEU,
				TENVT, 	
				TENKHO,
				SOLUONG,
				DONGIA
		FROM (SELECT NGAYLAP, 
					MAPN,
					TENKHO = ( SELECT TENKHO FROM Kho WHERE PN.MAKHO = Kho.MAKHO )
				FROM PhieuNhap AS PN
				WHERE NGAYLAP BETWEEN @NGAYBATDAU AND @NGAYKETTHUC
				AND MANV = @MANV )PN,
				CTPN,
				(SELECT MAVT, TENVT FROM Vattu ) VT
		WHERE PN.MAPN =CTPN.MAPN
		AND VT.MAVT = CTPN.MAVT
		ORDER BY THANGNAM
	END

	ELSE
	BEGIN
		SELECT FORMAT(HD.NGAYLAP,'MM-yyyy') AS THANGNAM, 
				HD.NGAYLAP, 
				HD.MAHD AS MAPHIEU,
				TENVT, 
				TENKHO, 
				SOLUONG,
				DONGIA
		FROM (SELECT NGAYLAP, 
					MAHD,
					TENKHO = ( SELECT TENKHO FROM Kho WHERE HD.MAKHO = Kho.MAKHO )
				FROM HOADON AS HD
				WHERE NGAYLAP BETWEEN @NGAYBATDAU AND @NGAYKETTHUC
				AND MANV = @MANV )HD,
				CTHD,
				(SELECT MAVT, TENVT FROM Vattu ) VT
		WHERE HD.MAHD =CTHD.MAHD
		AND VT.MAVT = CTHD.MAVT
		ORDER BY THANGNAM
	END
END;
USE [QLVT_NHAPXUAT]
GO
/****** Object:  View [dbo].[view_DanhSachNhanVien]    Script Date: 11/10/2023 7:19:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_DanhSachNhanVien] 
AS
	SELECT MANV, CONCAT(HO, ' ', TEN, ' - ', MANV) as HOTEN
	FROM NHANVIEN 
	WHERE TrangThaiXoa = 0 
	AND NOT EXISTS( SELECT SUSER_SNAME(sid) 
				FROM sys.sysusers 
				WHERE name = CAST(MANV AS NVARCHAR))
GO

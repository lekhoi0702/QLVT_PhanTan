USE [QLVT_NHAPXUAT]
GO
/****** Object:  View [dbo].[view_DanhSachNhanVien]    Script Date: 11/6/2023 11:49:03 PM ******/
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
/****** Object:  View [dbo].[view_DanhSachPhanManh]    Script Date: 11/6/2023 11:49:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_DanhSachPhanManh]
AS
	SELECT TENCN=PUBS.description, TENSERVER=subscriber_server
	 FROM sysmergepublications  PUBS, sysmergesubscriptions SUBS
 	WHERE PUBS.pubid = SUBS.pubid AND  publisher <> subscriber_server

GO

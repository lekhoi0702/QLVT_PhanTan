USE [QLVT_NHAPXUAT]
GO
/****** Object:  View [dbo].[view_DanhSachPhanManh]    Script Date: 11/8/2023 8:22:11 PM ******/
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

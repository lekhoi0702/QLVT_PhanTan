USE [QLVT_NHAPXUAT]
GO
/****** Object:  View [dbo].[view_LayMaNVLonNhat]    Script Date: 11/8/2023 8:22:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_LayMaNVLonNhat] AS
SELECT MAX(MANV) AS MaxMANV
FROM link0.QLVT_NHAPXUAT.dbo.NHANVIEN
GO

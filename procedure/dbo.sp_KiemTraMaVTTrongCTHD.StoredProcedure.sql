USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaVTTrongCTHD]    Script Date: 11/10/2023 7:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_KiemTraMaVTTrongCTHD]
@MAHD NVARCHAR(10),
@MAVT NVARCHAR(5)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM CTHD WHERE CTHD.MAHD = @MAHD
	AND CTHD.MAVT = @MAVT) RETURN 1;
	RETURN 0;
END
GO

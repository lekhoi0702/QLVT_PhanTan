USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraSoLuong]    Script Date: 11/10/2023 12:01:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraSoLuong]
@MAVT NVARCHAR(5),
@SOLUONG INT
AS
BEGIN
	DECLARE @SLTVATTU int;
	SELECT @SLTVATTU = SLT  FROM VATTU WHERE VATTU.MAVT = @MAVT
	IF (@SLTVATTU >= @SOLUONG) RETURN 1;
	ELSE RETURN @SLTVATTU;
END
GO

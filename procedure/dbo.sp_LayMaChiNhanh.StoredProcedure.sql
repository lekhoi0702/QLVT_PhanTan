USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaChiNhanh]    Script Date: 11/10/2023 7:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayMaChiNhanh]
@TENCN NVARCHAR(100),
 @MACN NVARCHAR(10) OUTPUT
AS
BEGIN
	IF @TENCN IS NULL
    BEGIN
        RAISERROR('Dữ liệu đầu vào không được NULL', 16, 1);
        RETURN;
    END

    SELECT @MACN = MACN
    FROM LINK0.QLVT_NHAPXUAT.DBO.CHINHANH
    WHERE CHINHANH.TENCN = @TENCN;
END
GO

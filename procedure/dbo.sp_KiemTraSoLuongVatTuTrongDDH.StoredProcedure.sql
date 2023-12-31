USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraSoLuongVatTuTrongDDH]    Script Date: 11/10/2023 7:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraSoLuongVatTuTrongDDH]
@MAPN NVARCHAR(10),
@SOLUONG INT,
@MAVT NVARCHAR(5)
AS
BEGIN
    DECLARE @MADDH NVARCHAR(10);
    DECLARE @SOLUONGDDH INT;

    -- Kiểm tra NULL
    IF @MAPN IS NULL OR @SOLUONG IS NULL OR @MAVT IS NULL
    BEGIN
		RAISERROR('Dữ liệu đầu vào bị NULL', 16, 1);
       
        RETURN 0; 
    END

    SELECT @MADDH = MADDH FROM PHIEUNHAP AS PN 
    WHERE PN.MAPN = @MAPN;

  
    IF @MADDH IS NULL
    BEGIN
        RAISERROR('không tìm thấy mã ddh trong phieu nhap', 16, 1);
		RETURN;
    END

    SELECT @SOLUONGDDH = SOLUONG FROM CTDDH
    WHERE @MADDH = CTDDH.MADDH AND CTDDH.MAVT = @MAVT;

    
    IF @SOLUONGDDH IS NULL
    BEGIN
        RAISERROR('không tìm thấy số lượng trong ddh', 16, 1);
		RETURN;
    END

    IF (@SOLUONGDDH >= @SOLUONG) RETURN 1;

    RETURN 0;
END
GO

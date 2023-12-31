USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatSLT]    Script Date: 11/10/2023 7:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatSLT]
    @CHEDO NVARCHAR(6),
    @MAVT NCHAR(4),
    @SOLUONG INT
AS
BEGIN
    BEGIN TRY
        BEGIN DISTRIBUTED TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000);

        UPDATE DBO.Vattu
        SET SLT = CASE
                    WHEN @CHEDO = 'XUAT' THEN SLT - @SOLUONG
                    WHEN @CHEDO = 'NHAP' THEN SLT + @SOLUONG
                    ELSE SLT
                 END
        WHERE MAVT = @MAVT;

        COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        SET @ErrorMessage = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
        RETURN 0;
    END CATCH;
END;
GO

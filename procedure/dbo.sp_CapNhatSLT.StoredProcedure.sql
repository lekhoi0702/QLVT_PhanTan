USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatSLT]    Script Date: 11/9/2023 4:38:50 PM ******/
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
        BEGIN TRANSACTION;

        IF (@CHEDO = 'XUAT')
        BEGIN
            IF EXISTS (SELECT * FROM DBO.Vattu AS VT WHERE VT.MAVT = @MAVT)
            BEGIN
                UPDATE DBO.Vattu
                SET SLT = SLT - @SOLUONG
                WHERE MAVT = @MAVT;
            END
            ELSE
            BEGIN
                RAISERROR('Mã VT không tồn tại', 16, 1);
            END
        END
        ELSE IF (@CHEDO = 'NHAP')
        BEGIN
            IF EXISTS (SELECT * FROM DBO.Vattu AS VT WHERE VT.MAVT = @MAVT)
            BEGIN
                UPDATE DBO.Vattu
                SET SLT = SLT + @SOLUONG
                WHERE MAVT = @MAVT;
            END
            ELSE
            BEGIN
                RAISERROR('Mã VT không tồn tại', 16, 1);
            END
        END
        ELSE
        BEGIN
            RAISERROR('CHỌN CHẾ ĐỘ XUẤT HOẶC NHẬP', 16, 1);
        END

        COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
        RETURN 0;
    END CATCH;
END
GO

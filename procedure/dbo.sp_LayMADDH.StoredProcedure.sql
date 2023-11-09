USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_LayMADDH]    Script Date: 11/9/2023 4:38:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LayMADDH]
AS
BEGIN
    IF EXISTS (SELECT 1 FROM LINK0.QLVT_NHAPXUAT.DBO.DDH)
    BEGIN
        SELECT TOP 1 MADDH
        FROM LINK0.QLVT_NHAPXUAT.DBO.DDH
        ORDER BY MADDH DESC
    END
END
GO

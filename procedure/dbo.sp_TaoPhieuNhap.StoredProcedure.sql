USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoPhieuNhap]    Script Date: 11/8/2023 8:20:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[sp_TaoPhieuNhap]
	@MADDH NVARCHAR(10),
	@MAPN NVARCHAR(10)
AS
BEGIN
		BEGIN TRY
			BEGIN TRANSACTION
			
			INSERT INTO CTPN (MAPN, MAVT, SOLUONG, DONGIA)
			SELECT @MAPN, CT.MAVT, CT.SOLUONG, CT.DONGIA
			FROM CTDDH CT
			WHERE CT.MADDH = @MADDH;
			IF EXISTS (
			SELECT 1 FROM CTPN WHERE CTPN.MAPN = @MAPN
		
			) 	RETURN 1;
			COMMIT
			RETURN 0;
		END TRY
		BEGIN CATCH
		
    RETURN 0;
    END CATCH;	
END
GO

USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 11/10/2023 7:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[sp_TaoTaiKhoan]
    @LGNAME VARCHAR(50),  @PASS VARCHAR(50),
    @USERNAME VARCHAR(50),  @ROLE VARCHAR(50)     
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS, 'QLVT_NHAPXUAT'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
  BEGIN
     RAISERROR ('Login name bị trùng', 16,1)
	 RETURN
  END 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RAISERROR ('Nhân viên đã có login name', 16,2)
       RETURN
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE = 'ADMIN'
  BEGIN
      EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
      EXEC sp_addsrvrolemember @LGNAME, 'DBCREATOR'
	  EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  END


GO

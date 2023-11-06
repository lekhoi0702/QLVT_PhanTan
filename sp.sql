USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatSLT]    Script Date: 11/6/2023 11:47:12 PM ******/
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
	
	IF( @CHEDO = 'XUAT')
	BEGIN
		IF( EXISTS(SELECT * FROM DBO.Vattu AS VT WHERE VT.MAVT = @MAVT))
			BEGIN
				UPDATE DBO.Vattu
				SET SLT = SLT - @SOLUONG
				WHERE MAVT = @MAVT
			END
	END


	IF( @CHEDO = 'NHAP')
	BEGIN
		IF( EXISTS(SELECT * FROM DBO.Vattu AS VT WHERE VT.MAVT = @MAVT) )
			BEGIN
				UPDATE DBO.Vattu
				SET SLT = SLT + @SOLUONG
				WHERE MAVT = @MAVT
			END
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChuyenChiNhanh]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChuyenChiNhanh] 
	@MANV INT, 
	@MACN nVARchar(10)
AS
DECLARE @LGNAME VARCHAR(50)
DECLARE @USERNAME VARCHAR(50)
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN
	BEGIN DISTRIBUTED TRAN
		DECLARE @HONV NVARCHAR(40)
		DECLARE @TENNV NVARCHAR(10)
		DECLARE @DIACHINV NVARCHAR(100)
		DECLARE @NGAYSINHNV DATETIME
		DECLARE @SDTNV VARCHAR(10) 						
		-- Lưu lại thông tin nhân viên cần chuyển chi nhánh để làm điều kiện kiểm tra
		SELECT @HONV = HO, @TENNV = TEN, @DIACHINV = DIACHI, @NGAYSINHNV = NGAYSINH, @SDTNV = SDT FROM NhanVien WHERE MANV = @MANV
		-- Kiểm tra xem bên Site chuyển tới đã có dữ liệu nhân viên đó chưa. Nếu có rồi thì đổi trạng thái, chưa thì thêm vào
		IF EXISTS(select MANV
				from LINK1.QLVT_NHAPXUAT.dbo.NhanVien
				where HO = @HONV and TEN = @TENNV and DIACHI = @DIACHINV
				and NGAYSINH = @NGAYSINHNV and SDT = @SDTNV)
		BEGIN
				UPDATE LINK1.QLVT_NHAPXUAT.dbo.NhanVien
				SET TrangThaiXoa = 0
				WHERE MANV = (	select MANV
								from LINK1.QLVT_NHAPXUAT.dbo.NhanVien
								where HO = @HONV and TEN = @TENNV and DIACHI = @DIACHINV
										and NGAYSINH = @NGAYSINHNV and SDT = @SDTNV)
		END
		ELSE
		-- nếu chưa tồn tại thì thêm mới hoàn toàn vào chi nhánh mới với MANV sẽ là MANV lớn nhất hiện tại + 1
		BEGIN
			INSERT INTO LINK1.QLVT_NHAPXUAT.dbo.NhanVien (MANV, HO, TEN, DIACHI, NGAYSINH, SDT, MACN, TRANGTHAIXOA)
			VALUES ((SELECT MAX(MANV) FROM LINK0.QLVT_NHAPXUAT.dbo.NhanVien) + 1, @HONV, @TENNV, @DIACHINV, @NGAYSINHNV, @SDTNV, @MACN, 0)
		END
		-- Đổi trạng thái xóa đối với tài khoản cũ ở site hiện tại
		UPDATE dbo.NhanVien
		SET TrangThaiXoa = 1
		WHERE MANV = @MANV
	COMMIT TRAN;
		-- sp_droplogin và sp_dropuser không thể được thực thi trong một giao tác do người dùng định nghĩa
		-- Kiểm tra xem Nhân viên đã có login chưa. Có thì xóa
		IF EXISTS(SELECT SUSER_SNAME(sid) FROM sys.sysusers WHERE name = CAST(@MANV AS NVARCHAR))
		BEGIN
			SET @LGNAME = CAST((SELECT SUSER_SNAME(sid) FROM sys.sysusers WHERE name = CAST(@MANV AS NVARCHAR)) AS VARCHAR(50))
			SET @USERNAME = CAST(@MANV AS VARCHAR(50))
			EXEC SP_DROPUSER @USERNAME;
			EXEC SP_DROPLOGIN @LGNAME;
		END	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CreatePhieuNhapAndCTPN]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CreatePhieuNhapAndCTPN]
  @MAPN NVARCHAR(10),

  @MADDH NVARCHAR(10),

  @MAKHO NVARCHAR(10)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
		DECLARE @NGAYLAP DATE;
        SET @NGAYLAP = GETDATE();
		DECLARE @MANV NVARCHAR(10);
        SELECT @MANV = MANV FROM DDH WHERE MADDH = @MADDH;
       
        INSERT INTO PHIEUNHAP (MAPN,NGAYLAP,MADDH,MANV,MAKHO)
        VALUES (@MAPN,@NGAYLAP,@MADDH,@MANV,@MAKHO);
        INSERT INTO CTPN (MAPN, MAVT, SOLUONG, DONGIA)
        SELECT @MAPN, CT.MAVT, CT.SOLUONG, CT.DONGIA
        FROM CTDDH CT
        WHERE CT.MADDH = @MADDH;  
        COMMIT
		RETURN 1;
    END TRY
    BEGIN CATCH    
        ROLLBACK;
		RETURN 0;
    END CATCH;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DangNhap]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DangNhap]
	@TENLOGIN NVARCHAR( 100)
AS
	DECLARE @UID INT
	DECLARE @MANV NVARCHAR(100)
	SELECT @UID= uid , @MANV= NAME FROM sys.sysusers 
  	WHERE sid = SUSER_SID(@TENLOGIN)

	SELECT  MAGV= @MANV, 
       		HOTEN = (SELECT HO+ ' '+TEN FROM dbo.NHANVIEN WHERE MANV=@MANV ), 
       		TENNHOM=NAME
  	FROM sys.sysusers
    	WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@uid)
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaDDH]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaDDH]
	@MADDH nvarchar(10)
AS
BEGIN
	IF( EXISTS(SELECT * FROM DDH AS DH WHERE DH.MADDH = @MADDH) )
		RETURN 1;
	ELSE IF ( EXISTS( SELECT * FROM LINK1.QLVT_NHAPXUAT.DBO.DDH AS DH WHERE DH.MADDH = @MADDH ) )
		RETURN 1;
	RETURN 0;-- id nhap vao khong ton tai
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaKho]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_KiemTraMaKho]
	@MAKHO nvarchar(10)
as
begin
	if( exists( select 1 
				from LINK0.QLVT_NHAPXUAT.DBO.KHO as K 
				where K.MAKHO = @MAKHO ) )
		return 1; -- ton tai
	return 0;-- khong ton tai
end
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaLoaiVatTu]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraMaLoaiVatTu]
@MALVT nVARchar(5)
AS
BEGIN
	-- lấy chỉ cột mã vật tư mà thôi
	-- kiểm tra mẫ vật tư ở phân mảnh hiện tại
	IF EXISTS(SELECT 1 
			  FROM LOAIVATTU LVT  
			  WHERE LVT.MALVT = @MALVT)
			RETURN 1; -- Mã Vattu đang dùng ở phân mảnh hiện tại
	
	RETURN 0; -- Chưa tồn tại
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaPN]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaPN]
@MAPN nVARChar(10)
AS
BEGIN
	IF( EXISTS( SELECT * FROM PhieuNhap WHERE MAPN = @MAPN ) )
		RETURN 1;

	ELSE IF( EXISTS( SELECT * FROM LINK1.QLVT_NHAPXUAT.DBO.PhieuNhap WHERE MAPN = @MAPN ) )
		RETURN 1;
	RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaVatTu]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraMaVatTu]
@MAVT nVARchar(5)
AS
BEGIN
	-- lấy chỉ cột mã vật tư mà thôi
	-- kiểm tra mẫ vật tư ở phân mảnh hiện tại
	IF EXISTS(SELECT 1 
			  FROM Vattu VT  
			  WHERE VT.MAVT = @MAVT)
			RETURN 1; -- Mã Vattu đang dùng ở phân mảnh hiện tại
	
	RETURN 0; -- Chưa tồn tại
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaVatTuChiNhanhKhac]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaVatTuChiNhanhKhac]
	@MAVT NVARCHAR(5)
AS
BEGIN
	IF EXISTS( SELECT 1 FROM LINK1.QLVT_NHAPXUAT.DBO.Vattu as V
				WHERE V.MAVT = @MAVT
				AND				
				(EXISTS(SELECT 1 FROM LINK1.QLVT_NHAPXUAT.DBO.CTPN WHERE CTPN.MAVT = @MAVT))
				OR (EXISTS(SELECT 1 FROM LINK1.QLVT_NHAPXUAT.DBO.CTHD WHERE CTHD.MAVT = @MAVT)) )
		RETURN 1;

	RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaVTTrongCTDDH]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaVTTrongCTDDH]
@MADDH NVARCHAR(10),
@MAVT NVARCHAR(5)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM CTDDH WHERE CTDDH.MADDH = @MADDH
	AND CTDDH.MAVT = @MAVT) RETURN 1;
	RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraPhieuNhapCuaDDH]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraPhieuNhapCuaDDH]
@MADDH nchar(10)
AS
BEGIN
	IF(EXISTS(SELECT 1 FROM DBO.PhieuNhap AS P WHERE P.MADDH = @MADDH))
		RETURN 1;
	ELSE IF( EXISTS(SELECT 1 FROM LINK1.QLVT_NHAPXUAT.DBO.PhieuNhap AS P WHERE P.MADDH = @MADDH))
		RETURN 1;
	RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayMADDH]    Script Date: 11/6/2023 11:47:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_TaoPhieuNhap]    Script Date: 11/6/2023 11:47:12 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TaoTaiKhoan]
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
       RAISERROR ('Nhân viên dã có login name', 16,2)
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
/****** Object:  StoredProcedure [dbo].[sp_TraCuu_KiemTraMaNhanVien]    Script Date: 11/6/2023 11:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TraCuu_KiemTraMaNhanVien]
	@MANHANVIEN int
as
begin
	if exists( select * from LINK0.QLVT_NHAPXUAT.DBO.NHANVIEN as NV where NV.MANV = @MANHANVIEN)
		return 1; -- ma nhan vien ton tai
	return 0; -- ma nhan vien khong ton tai
end
GO

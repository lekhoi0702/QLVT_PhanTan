USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaLoaiVatTu]    Script Date: 11/10/2023 7:20:25 PM ******/
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

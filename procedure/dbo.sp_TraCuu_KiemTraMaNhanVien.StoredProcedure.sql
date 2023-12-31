USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraCuu_KiemTraMaNhanVien]    Script Date: 11/10/2023 7:20:25 PM ******/
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

USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaKho]    Script Date: 11/9/2023 4:38:50 PM ******/
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

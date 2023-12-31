USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDonDatHangKhongPhieuNhap]    Script Date: 11/10/2023 7:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LayDonDatHangKhongPhieuNhap]
AS
BEGIN
   SELECT dbo.DDH.MADDH, dbo.DDH.NGAYLAP, dbo.DDH.MANCC, NV.HO + ' ' + NV.TEN AS HOTEN, VT.TENVT, dbo.CTDDH.SOLUONG, dbo.CTDDH.DONGIA
FROM     dbo.DDH INNER JOIN
                  dbo.NHANVIEN AS NV ON dbo.DDH.MANV = NV.MANV INNER JOIN
                  dbo.CTDDH ON dbo.DDH.MADDH = dbo.CTDDH.MADDH INNER JOIN
                  dbo.VATTU AS VT ON dbo.CTDDH.MAVT = VT.MAVT
WHERE  (dbo.DDH.MADDH NOT IN
                      (SELECT MADDH
                       FROM      dbo.PHIEUNHAP))
END
GO

USE [QLVT_NHAPXUAT]
GO
/****** Object:  View [dbo].[view_LayDonDatHangKhongPhieuNhap]    Script Date: 11/10/2023 7:19:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_LayDonDatHangKhongPhieuNhap]
AS
    SELECT DDH.MADDH, 
            DDH.NGAYLAP, 
            DDH.MANCC, 
            HOTEN = NV.HO+' '+NV.TEN,
            VT.TENVT,
            CTDDH.SOLUONG,
            CTDDH.DONGIA
    FROM DBO.DDH
    INNER JOIN NhanVien NV ON DDH.MANV = NV.MANV
    INNER JOIN CTDDH  ON DDH.MADDH = CTDDH.MADDH
    INNER JOIN Vattu VT ON CTDDH.MAVT = VT.MAVT
    WHERE DDH.MADDH NOT IN (SELECT MADDH FROM PhieuNhap);
GO

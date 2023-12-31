USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_TongHopNhapXuat]    Script Date: 11/13/2023 12:22:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TongHopNhapXuat]
@NGAYBATDAU DATETIME,
@NGAYKETTHUC DATETIME
AS
BEGIN
    WITH NHAP AS (
        SELECT 
            PN.NGAYLAP,
            NHAP = SUM(CT.DONGIA * CT.SOLUONG),
            TYLENHAP = (SUM(CT.DONGIA * CT.SOLUONG) / NULLIF(SUM(DONGIA * SOLUONG), 0))
        FROM 
           PhieuNhap AS PN
            INNER JOIN CTPN AS CT ON PN.MAPN = CT.MAPN
        WHERE 
            PN.NGAYLAP BETWEEN @NGAYBATDAU AND @NGAYKETTHUC
        GROUP BY 
            PN.NGAYLAP
    ),
    XUAT AS (
        SELECT 
            HD.NGAYLAP,
            XUAT = SUM(CT.DONGIA * CT.SOLUONG),
            TYLEXUAT = (SUM(CT.DONGIA * CT.SOLUONG) / NULLIF(SUM(DONGIA * SOLUONG), 0))
        FROM 
            HOADON AS HD
            INNER JOIN CTHD AS CT ON HD.MAHD = CT.MAHD
        WHERE 
            HD.NGAYLAP BETWEEN @NGAYBATDAU AND @NGAYKETTHUC
        GROUP BY 
            HD.NGAYLAP
    )

    SELECT 
        ISNULL(PN.NGAYLAP, HD.NGAYLAP) AS NGAYLAP,
        ISNULL(PN.NHAP, 0) AS NHAP,
        ISNULL(PN.TYLENHAP, 0) AS TILENHAP,
        ISNULL(HD.XUAT, 0) AS XUAT,
        ISNULL(HD.TYLEXUAT, 0) AS TILEXUAT
    FROM 
        NHAP AS PN
        FULL JOIN XUAT AS HD ON PN.NGAYLAP = HD.NGAYLAP
    ORDER BY 
        NGAYLAP;
END
GO

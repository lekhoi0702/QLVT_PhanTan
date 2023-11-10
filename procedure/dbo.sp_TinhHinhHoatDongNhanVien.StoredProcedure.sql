USE [QLVT_NHAPXUAT]
GO
/****** Object:  StoredProcedure [dbo].[sp_TinhHinhHoatDongNhanVien]    Script Date: 11/10/2023 7:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TinhHinhHoatDongNhanVien]
    @MANV INT,
    @LOAIPHIEU NVARCHAR(4),
    @NGAYBATDAU DATETIME,
    @NGAYKETTHUC DATETIME
AS
BEGIN
    IF (@LOAIPHIEU = 'NHAP')
    BEGIN
        WITH PHIEUNHAP_CTE AS (
            SELECT
                N.NGAYLAP,
                N.MAPN,
                K.TENKHO,
                CTPN.MAVT,
                VT.TENVT,
                CTPN.SOLUONG,
                CTPN.DONGIA
            FROM
                PHIEUNHAP AS N
                INNER JOIN CTPN ON N.MAPN = CTPN.MAPN
                INNER JOIN Kho AS K ON N.MAKHO = K.MAKHO
                INNER JOIN Vattu AS VT ON CTPN.MAVT = VT.MAVT
            WHERE
                N.NGAYLAP BETWEEN @NGAYBATDAU AND @NGAYKETTHUC
                AND N.MANV = @MANV
        )

        SELECT
            FORMAT(PN.NGAYLAP, 'MM-yyyy') AS THANGNAM,
            PN.NGAYLAP,
            PN.MAPN ,
            PN.TENVT,
            PN.TENKHO,
            PN.SOLUONG,
            PN.SOLUONG * PN.DONGIA AS TONGTIEN
        FROM
            PHIEUNHAP_CTE AS PN
        ORDER BY
            PN.NGAYLAP      
    END
    ELSE IF (@LOAIPHIEU = 'XUAT')
    BEGIN
        WITH HOADON_CTE AS (
            SELECT
                X.NGAYLAP,
                X.MAHD,
                K.TENKHO,
                CTHD.MAVT,
                VT.TENVT,
                CTHD.SOLUONG,
                CTHD.DONGIA
            FROM
                HOADON AS X
                INNER JOIN CTHD ON X.MAHD = CTHD.MAHD
                INNER JOIN Kho AS K ON X.MAKHO = K.MAKHO
                INNER JOIN Vattu AS VT ON CTHD.MAVT = VT.MAVT
            WHERE
                X.NGAYLAP BETWEEN @NGAYBATDAU AND @NGAYKETTHUC
                AND X.MANV = @MANV
        )

        SELECT
            FORMAT(X.NGAYLAP, 'MM-yyyy') AS THANGNAM,
            X.NGAYLAP,
            X.MAHD,
            X.TENVT,
            X.TENKHO,
            X.SOLUONG,
            X.SOLUONG * X.DONGIA AS TONGTIEN
        FROM
            HOADON_CTE AS X
        ORDER BY
            X.NGAYLAP
   
    END
END;
GO

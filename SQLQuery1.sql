USE [QLVT_NHAPXUAT]
GO
INSERT [dbo].[CHINHANH] ([MACN], [TENCN], [DIACHI], [SDT], [rowguid]) VALUES (N'CN1       ', N'Chi nhánh 1', N'Thủ Đức', N'0912345678', N'1feec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[CHINHANH] ([MACN], [TENCN], [DIACHI], [SDT], [rowguid]) VALUES (N'CN2       ', N'Chi nhánh 2', N'Quận 1', N'0912345679', N'20eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [MACN], [rowguid]) VALUES (N'K1CN1     ', N'Kho 1 Chi nhánh 1', N'CN1       ', N'1ff2edf1-967f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [MACN], [rowguid]) VALUES (N'K1CN2     ', N'Kho 1 Chi nhánh 2', N'CN2       ', N'5f594216-977f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [MACN], [rowguid]) VALUES (N'K2CN1     ', N'Kho 2 Chi nhánh 1', N'CN1       ', N'b0536afc-967f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [MACN], [rowguid]) VALUES (N'K2CN2     ', N'Kho 2 Chi nhánh 2', N'CN2       ', N'30191020-977f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [MACN], [rowguid]) VALUES (N'K3CN1     ', N'Kho 3 Chi nhánh 1', N'CN1       ', N'61315605-977f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [MACN], [rowguid]) VALUES (N'K3CN2     ', N'Kho 3 Chi nhánh 2', N'CN2       ', N'25599a29-977f-ee11-bf1d-9829a63bcc99')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (1, N'Lê', N'Khôi', CAST(N'2001-01-01' AS Date), N'Long An', N'0987654321', N'CN1       ', 0, N'34eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (2, N'Trần', N'Hải', CAST(N'2001-01-01' AS Date), N'Nha Trang', N'0987654322', N'CN1       ', 0, N'35eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (3, N'Nguyễn', N'Chương', CAST(N'2001-02-03' AS Date), N' Bình Định', N'0987654323', N'CN1       ', 0, N'36eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (4, N'Phan', N'Đăng', CAST(N'2001-09-09' AS Date), N'Quảng Nam', N'0987654324', N'CN2       ', 0, N'37eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (5, N'Trần', N'Bảo', CAST(N'2001-10-10' AS Date), N'Cà Mau', N'0987654325', N'CN2       ', 0, N'38eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (6, N'Nguyễn', N'Trúc', CAST(N'2001-02-03' AS Date), N'Tiền Giang', N'0987654326', N'CN2       ', 0, N'39eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (7, N'Trần', N'Não', CAST(N'2001-01-21' AS Date), N'Long Xuyên', N'0987654321', N'CN2       ', 0, N'582ebaf7-2a7f-ee11-bf1d-9829a63bcc99')
GO
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [rowguid]) VALUES (N'NCC01     ', N'Gạch Uy tín', N'Quận 2', N'0888888888', N'2deec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [rowguid]) VALUES (N'NCC02     ', N'Xi măng Hà Tiên', N'Quận 4', N'0966654785', N'2eeec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'DDH01     ', CAST(N'2023-11-10' AS Date), N'NCC01     ', 3, N'K1CN1     ', N'b881272e-a07f-ee11-bf1d-9829a63bcc99')
GO
INSERT [dbo].[LOAIVATTU] ([MALVT], [TENLVT], [rowguid]) VALUES (N'G01  ', N'Gạch thô', N'2beec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[LOAIVATTU] ([MALVT], [TENLVT], [rowguid]) VALUES (N'G02  ', N'Gạch xây nhà', N'2ceec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT01 ', N'Gạch nung', N'Viên', N'G01  ', 900, N'21071063-8f7b-ee11-bf16-9829a63bcc99')
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT02 ', N'Gạch không nung', N'Viên', N'G01  ', 197, N'1f071063-8f7b-ee11-bf16-9829a63bcc99')
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT03 ', N'Gạch bê tông', N'Viên', N'G01  ', 100, N'1e071063-8f7b-ee11-bf16-9829a63bcc99')
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT04 ', N'Gạch tàu', N'Viên', N'G02  ', 999, N'22071063-8f7b-ee11-bf16-9829a63bcc99')
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT05 ', N'Gạch thẻ', N'Viên', N'G02  ', 888, N'23071063-8f7b-ee11-bf16-9829a63bcc99')
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT06 ', N'gạch men', N'viên', N'G02  ', 789, N'20071063-8f7b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DDH01     ', N'VT01 ', 101, 100000, N'ec050736-a07f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DDH01     ', N'VT02 ', 200, 200000, N'15a37841-a07f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DDH01     ', N'VT03 ', 300, 300000, N'bcb6354a-a07f-ee11-bf1d-9829a63bcc99')
GO
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MANV], [MAKHO], [MADDH], [rowguid]) VALUES (N'PN01      ', CAST(N'2023-11-10' AS Date), 3, N'K2CN1     ', N'DDH01     ', N'b45c394a-ad7f-ee11-bf1d-9829a63bcc99')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH01      ', N'Lê Lợi', N'Quận 1', N'0999999999', N'21eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH02      ', N'Trần Dần', N'Quận 2', N'0999999998', N'22eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH03      ', N'Nguyễn Trãi', N'Quận 3', N'0999999997', N'23eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH04      ', N'Nguyễn Khuyến', N'Quận 4', N'0999999996', N'24eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH05      ', N'Nguyễn Du', N'Quận 5', N'0999999995', N'25eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH06      ', N'Trần Não', N'Quận 6', N'0999999994', N'26eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH07      ', N'Bạch Đằng', N'Quận 7', N'0999999993', N'27eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH08      ', N'Nguyễn Huệ', N'Quận 8', N'0999999992', N'28eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH09      ', N'Quang Trung', N'Quận 9', N'0999999991', N'29eec605-6279-ee11-bf14-9829a63bcc99')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH10      ', N'Nguyễn Ánh', N'Thủ Đức', N'0999999990', N'2aeec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [MAKH], [rowguid]) VALUES (N'DH03      ', CAST(N'2023-11-10' AS Date), 3, N'K3CN1     ', N'KH03      ', N'e2f00369-bf7f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [MAKH], [rowguid]) VALUES (N'HD01      ', CAST(N'2023-11-10' AS Date), 3, N'K1CN1     ', N'KH01      ', N'e1c2b7ab-ad7f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [MAKH], [rowguid]) VALUES (N'HD02      ', CAST(N'2023-11-10' AS Date), 3, N'K2CN1     ', N'KH02      ', N'b0b7de1e-bf7f-ee11-bf1d-9829a63bcc99')
GO
INSERT [dbo].[CTHD] ([MAHD], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DH03      ', N'VT01 ', 4, 1000, N'156bde77-bf7f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[CTHD] ([MAHD], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'HD01      ', N'VT01 ', 2, 1000, N'213d4fb6-ad7f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[CTHD] ([MAHD], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'HD02      ', N'VT01 ', 2, 100, N'b9188427-bf7f-ee11-bf1d-9829a63bcc99')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN01      ', N'VT01 ', 100, 100000, N'b55c394a-ad7f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN01      ', N'VT02 ', 200, 200000, N'b65c394a-ad7f-ee11-bf1d-9829a63bcc99')
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN01      ', N'VT03 ', 300, 300000, N'b75c394a-ad7f-ee11-bf1d-9829a63bcc99')
GO

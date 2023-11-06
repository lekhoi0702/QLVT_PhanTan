USE [QLVT_NHAPXUAT]
GO
INSERT [dbo].[CHINHANH] ([MACN], [TENCN], [DIACHI], [SDT], [rowguid]) VALUES (N'CN1       ', N'Chi nhánh 1', N'Thủ Đức', N'0912345678', N'1feec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[CHINHANH] ([MACN], [TENCN], [DIACHI], [SDT], [rowguid]) VALUES (N'CN2       ', N'Chi nhánh 2', N'Quận 1', N'0912345679', N'20eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [MACN], [rowguid]) VALUES (N'K1Q1      ', N'Kho 1 Quận 1', N'CN2       ', N'2feec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [MACN], [rowguid]) VALUES (N'K1TD      ', N'Kho 1 Thủ Đức', N'CN1       ', N'30eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [MACN], [rowguid]) VALUES (N'K2Q1      ', N'Kho 2 Quận 1', N'CN2       ', N'31eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHO] ([MAKHO], [TENKHO], [MACN], [rowguid]) VALUES (N'K2TD      ', N'Kho 2 Thủ Đức', N'CN1       ', N'32eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (1, N'Lê', N'Khôi', CAST(N'2001-01-01' AS Date), N'Long An', N'0987654321', N'CN1       ', 0, N'34eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (2, N'Trần', N'Hải', CAST(N'2001-01-01' AS Date), N'Nha Trang', N'0987654322', N'CN1       ', 0, N'35eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (3, N'Nguyễn', N'Chương', CAST(N'2001-02-03' AS Date), N' Bình Định', N'0987654323', N'CN1       ', 0, N'36eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (4, N'Phan', N'Đăng', CAST(N'2001-09-09' AS Date), N'Quảng Nam', N'0987654324', N'CN2       ', 0, N'37eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (5, N'Trần', N'Bảo', CAST(N'2001-10-10' AS Date), N'Cà Mau', N'0987654325', N'CN2       ', 0, N'38eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (6, N'Nguyễn', N'Trúc', CAST(N'2001-02-03' AS Date), N'Tiền Giang', N'0987654326', N'CN2       ', 0, N'39eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (7, N'Lê', N'Dũng', CAST(N'2001-01-02' AS Date), N'Long Khê', N'0987678765', N'CN1       ', 1, N'8fa47443-6779-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [SDT], [MACN], [TRANGTHAIXOA], [rowguid]) VALUES (8, N'Lê', N'Dũng', CAST(N'2001-01-02' AS Date), N'Long Khê', N'0987678765', N'CN2       ', 0, N'61e36ace-6979-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [rowguid]) VALUES (N'NCC01     ', N'Gạch Uy tín', N'Quận 2', N'0888888888', N'2deec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [rowguid]) VALUES (N'NCC02     ', N'Xi măng Hà Tiên', N'Quận 4', N'0966654785', N'2eeec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'dasddd    ', CAST(N'2023-11-03' AS Date), N'NCC01     ', 3, N'K1TD      ', N'76ba6958-207a-ee11-bf15-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'DDH312    ', CAST(N'2023-11-03' AS Date), N'NCC02     ', 3, N'K2TD      ', N'3c20d321-177a-ee11-bf15-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'DH01      ', CAST(N'2023-11-02' AS Date), N'NCC01     ', 3, N'K1TD      ', N'40eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'DH03      ', CAST(N'2023-12-02' AS Date), N'NCC01     ', 3, N'K1Q1      ', N'b2fca5d7-fd79-ee11-bf15-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'DH04      ', CAST(N'2023-11-04' AS Date), N'NCC01     ', 3, N'K1TD      ', N'e1483c89-ee7a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'DH05      ', CAST(N'2023-11-04' AS Date), N'NCC01     ', 2, N'K1TD      ', N'46bf2287-ef7a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'DH06      ', CAST(N'2023-11-04' AS Date), N'NCC01     ', 2, N'K1TD      ', N'e0378b20-f07a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'DH07      ', CAST(N'2023-05-11' AS Date), N'NCC01     ', 3, N'K1TD      ', N'92c06a87-f87b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'DH08      ', CAST(N'2023-11-06' AS Date), N'NCC02     ', 3, N'K2Q1      ', N'fa110de1-fe7b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'test      ', CAST(N'2023-11-06' AS Date), N'NCC01     ', 3, N'K1TD      ', N'd138199a-7c7c-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'test2     ', CAST(N'2023-11-06' AS Date), N'NCC01     ', 3, N'K1TD      ', N'951f9aa8-7c7c-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[DDH] ([MADDH], [NGAYLAP], [MANCC], [MANV], [MAKHO], [rowguid]) VALUES (N'test3     ', CAST(N'2023-11-06' AS Date), N'NCC01     ', 3, N'K2TD      ', N'7c722ec1-7c7c-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[LOAIVATTU] ([MALVT], [TENLVT], [rowguid]) VALUES (N'G01  ', N'Gạch thô', N'2beec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[LOAIVATTU] ([MALVT], [TENLVT], [rowguid]) VALUES (N'G02  ', N'Gạch xây nhà', N'2ceec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT01 ', N'Gạch nung', N'Viên', N'G01  ', 102, N'21071063-8f7b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT02 ', N'Gạch không nung', N'Viên', N'G01  ', 100, N'1f071063-8f7b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT03 ', N'Gạch bê tông', N'Viên', N'G01  ', 100, N'1e071063-8f7b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT04 ', N'Gạch tàu', N'Viên', N'G02  ', 999, N'22071063-8f7b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT05 ', N'Gạch thẻ', N'Viên', N'G02  ', 888, N'23071063-8f7b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DVT], [MALVT], [SLT], [rowguid]) VALUES (N'VT06 ', N'gạch men', N'viên', N'G02  ', 789, N'20071063-8f7b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DDH312    ', N'VT02 ', 7, 5, N'2ef8323d-1e7a-ee11-bf15-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DH01      ', N'VT01 ', 99, 2000000, N'43eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DH01      ', N'VT05 ', 3, 3, N'1fb7e215-267a-ee11-bf15-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DH03      ', N'VT01 ', 27, 5000, N'562f74e7-fd79-ee11-bf15-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DH03      ', N'VT02 ', 99, 120000, N'552f74e7-fd79-ee11-bf15-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DH04      ', N'VT01 ', 99, 23123, N'771c6894-ee7a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DH05      ', N'VT02 ', 11, 110000, N'47bb7b8f-ef7a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DH06      ', N'VT01 ', 11, 1111111, N'82bd5028-f07a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DH08      ', N'VT03 ', 6, 100, N'5b797e17-ff7b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'DH08      ', N'VT04 ', 100, 100000, N'ee3f80f3-fe7b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[CTDDH] ([MADDH], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'test3     ', N'VT01 ', 1, 1000, N'd14c9b22-9d7c-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MANV], [MAKHO], [MADDH], [rowguid]) VALUES (N'PN01      ', CAST(N'2021-11-02' AS Date), 3, N'K2TD      ', N'dasddd    ', N'42eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MANV], [MAKHO], [MADDH], [rowguid]) VALUES (N'PN02      ', CAST(N'2023-11-04' AS Date), 3, N'K1TD      ', N'DH01      ', N'c3f6931d-767a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MANV], [MAKHO], [MADDH], [rowguid]) VALUES (N'PN03      ', CAST(N'2023-11-04' AS Date), 3, N'K1TD      ', N'DH04      ', N'856553e0-ee7a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MANV], [MAKHO], [MADDH], [rowguid]) VALUES (N'PN04      ', CAST(N'2023-11-04' AS Date), 2, N'K1TD      ', N'DH05      ', N'41806db5-ef7a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MANV], [MAKHO], [MADDH], [rowguid]) VALUES (N'PN05      ', CAST(N'2023-11-04' AS Date), 2, N'K1TD      ', N'DH06      ', N'880d5450-f07a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYLAP], [MANV], [MAKHO], [MADDH], [rowguid]) VALUES (N'PN06      ', CAST(N'2023-11-04' AS Date), 3, N'K1TD      ', N'DH07      ', N'f37941a5-f87b-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH01      ', N'Lê Lợi', N'Quận 1', N'0999999999', N'21eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH02      ', N'Trần Dần', N'Quận 2', N'0999999998', N'22eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH03      ', N'Nguyễn Trãi', N'Quận 3', N'0999999997', N'23eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH04      ', N'Nguyễn Khuyến', N'Quận 4', N'0999999996', N'24eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH05      ', N'Nguyễn Du', N'Quận 5', N'0999999995', N'25eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH06      ', N'Trần Não', N'Quận 6', N'0999999994', N'26eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH07      ', N'Bạch Đằng', N'Quận 7', N'0999999993', N'27eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH08      ', N'Nguyễn Huệ', N'Quận 8', N'0999999992', N'28eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH09      ', N'Quang Trung', N'Quận 9', N'0999999991', N'29eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [rowguid]) VALUES (N'KH10      ', N'Nguyễn Ánh', N'Thủ Đức', N'0999999990', N'2aeec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[HOADON] ([MAHD], [NGAYLAP], [MANV], [MAKHO], [MAKH], [rowguid]) VALUES (N'HD01      ', CAST(N'2023-11-02' AS Date), 3, N'K1TD      ', N'KH01      ', N'41eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[CTHD] ([MAHD], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'HD01      ', N'VT01 ', 20, 20000, N'45eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[CTHD] ([MAHD], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'HD01      ', N'VT02 ', 10, 5000, N'46eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN01      ', N'VT01 ', 100, 2000000, N'47eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN01      ', N'VT02 ', 90, 100000, N'48eec605-6279-ee11-bf14-9829a63bcc99')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN03      ', N'VT01 ', 99, 23123, N'866553e0-ee7a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN04      ', N'VT02 ', 11, 110000, N'42806db5-ef7a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN05      ', N'VT01 ', 11, 1111111, N'890d5450-f07a-ee11-bf16-9829a63bcc99')
GO
INSERT [dbo].[CTPN] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [rowguid]) VALUES (N'PN06      ', N'VT02 ', 99, 200000, N'7705c6bd-f87b-ee11-bf16-9829a63bcc99')
GO

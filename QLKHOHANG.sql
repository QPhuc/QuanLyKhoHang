USE [QLKHOHANG]
GO
/****** Object:  Table [dbo].[chitietKhachHang]    Script Date: 12/03/2015 12:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietKhachHang](
	[MaKH] [nvarchar](25) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[TenCTY] [nvarchar](50) NULL,
	[SDT] [nvarchar](12) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_chitietKhanhHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[chitietKhachHang] ([MaKH], [TenKH], [TenCTY], [SDT], [DiaChi]) VALUES (N'MKH1', N'Lâm', N'No', N'1236457852', N'123/12 Le Trong Tan')
INSERT [dbo].[chitietKhachHang] ([MaKH], [TenKH], [TenCTY], [SDT], [DiaChi]) VALUES (N'MKH2', N'Linh', N'NamKy Inc.', N'199001995', N'321/21/25 Nam Ky')
/****** Object:  Table [dbo].[chitietCTYNhap]    Script Date: 12/03/2015 12:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietCTYNhap](
	[MaCT] [nvarchar](25) NOT NULL,
	[TenCT] [nvarchar](50) NOT NULL,
	[TenNgDaiDien] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](12) NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_chitietCTYNhap] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[chitietCTYNhap] ([MaCT], [TenCT], [TenNgDaiDien], [SDT], [DiaChi]) VALUES (N'MCT1', N'Phong CoP.', N'Liem', N'0321654987', N'123 Truong Chinh')
INSERT [dbo].[chitietCTYNhap] ([MaCT], [TenCT], [TenNgDaiDien], [SDT], [DiaChi]) VALUES (N'MCT2', N'Long Inc.', N'Long', N'036352147', N'123 Chi Lang')
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/03/2015 12:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [nvarchar](25) NOT NULL,
	[PASS] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhanVien] ([ID], [PASS]) VALUES (N'adHuy', N'E10ADC3949BA59ABBE56E057F20F883E')
INSERT [dbo].[NhanVien] ([ID], [PASS]) VALUES (N'maHan', N'E10ADC3949BA59ABBE56E057F20F883E')
INSERT [dbo].[NhanVien] ([ID], [PASS]) VALUES (N'usphong', N'E10ADC3949BA59ABBE56E057F20F883E')
INSERT [dbo].[NhanVien] ([ID], [PASS]) VALUES (N'usVisitor', N'E10ADC3949BA59ABBE56E057F20F883E')
/****** Object:  Table [dbo].[HangHoa]    Script Date: 12/03/2015 12:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[Mahang] [nvarchar](25) NOT NULL,
	[Tenhang] [nvarchar](25) NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,
	[DVT] [nvarchar](25) NOT NULL,
	[NSX] [date] NULL,
	[HSD] [date] NULL,
	[image] [nvarchar](100) NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[Mahang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HangHoa] ([Mahang], [Tenhang], [soluong], [dongia], [DVT], [NSX], [HSD], [image]) VALUES (N'MH1', N'Sữa VinaMilk', 0, 50000, N'Thùng', CAST(0xBC3A0B00 AS Date), CAST(0xDB3A0B00 AS Date), N'E:\C#\QuanLyXuatNhapHang\QuanLyXuatNhapHang\image_hang\vinamilk.jpg')
INSERT [dbo].[HangHoa] ([Mahang], [Tenhang], [soluong], [dongia], [DVT], [NSX], [HSD], [image]) VALUES (N'MH2', N'Bàn Phím Consol', 25, 218000, N'Cái', CAST(0xBC3A0B00 AS Date), CAST(0xDB3A0B00 AS Date), N'E:\C#\QuanLyXuatNhapHang\QuanLyXuatNhapHang\image_hang\212_1352524674_1.jpg')
INSERT [dbo].[HangHoa] ([Mahang], [Tenhang], [soluong], [dongia], [DVT], [NSX], [HSD], [image]) VALUES (N'MH3', N'Áo Adđias', 105, 50000, N'Cái', CAST(0xBC3A0B00 AS Date), CAST(0xDB3A0B00 AS Date), N'E:\C#\QuanLyXuatNhapHang\QuanLyXuatNhapHang\image_hang\cat_a22746738a475a75211f96a98549a811.png')
INSERT [dbo].[HangHoa] ([Mahang], [Tenhang], [soluong], [dongia], [DVT], [NSX], [HSD], [image]) VALUES (N'MH4', N'Tai Nghe Sony', 100, 250000, N'Cái', CAST(0xBC3A0B00 AS Date), CAST(0xDB3A0B00 AS Date), N'E:\C#\QuanLyXuatNhapHang\QuanLyXuatNhapHang\image_hang\image001(488).jpg')
INSERT [dbo].[HangHoa] ([Mahang], [Tenhang], [soluong], [dongia], [DVT], [NSX], [HSD], [image]) VALUES (N'MH5', N'abc', 10, 100000, N'Cái', CAST(0xBD3A0B00 AS Date), CAST(0xC03A0B00 AS Date), N'E:\C#\QuanLyXuatNhapHang\QuanLyXuatNhapHang\image_hang\1000039998_Sony_D8_2.1_Main_480x0.jpg')
/****** Object:  Table [dbo].[chitietNhanVien]    Script Date: 12/03/2015 12:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietNhanVien](
	[MaNV] [nvarchar](25) NOT NULL,
	[ID] [nvarchar](25) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](12) NOT NULL,
	[HSL] [float] NOT NULL,
	[luongcanban] [float] NOT NULL,
	[ngayvaolam] [date] NOT NULL,
	[chucvu] [nvarchar](50) NOT NULL,
	[image] [nvarchar](100) NULL,
 CONSTRAINT [PK_chitietNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[chitietNhanVien] ([MaNV], [ID], [TenNV], [DiaChi], [SDT], [HSL], [luongcanban], [ngayvaolam], [chucvu], [image]) VALUES (N'NV1', N'adHuy', N'Hắc', N'123 Thach Lam', N'123654987', 1, 1000, CAST(0x61250B00 AS Date), N'lính', N'E:\C#\QuanLyXuatNhapHang\QuanLyXuatNhapHang\image\27723ed5e3c3e4e8a0c73a90116e5d31.jpg')
INSERT [dbo].[chitietNhanVien] ([MaNV], [ID], [TenNV], [DiaChi], [SDT], [HSL], [luongcanban], [ngayvaolam], [chucvu], [image]) VALUES (N'NV2', N'maHan', N'Cẩm Hân', N'123 Long An', N'12365402', 2, 2000, CAST(0xB73A0B00 AS Date), N'Giám Sát', N'E:\C#\QuanLyXuatNhapHang\QuanLyXuatNhapHang\image\100907113112-545-424.jpg')
INSERT [dbo].[chitietNhanVien] ([MaNV], [ID], [TenNV], [DiaChi], [SDT], [HSL], [luongcanban], [ngayvaolam], [chucvu], [image]) VALUES (N'NV3', N'usphong', N'Phong', N'213 truong chinh', N'2356489', 1, 1000, CAST(0xB73A0B00 AS Date), N'nhan vien', N'E:\C#\QuanLyXuatNhapHang\QuanLyXuatNhapHang\image_hang\image001(488).jpg')
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/03/2015 12:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[STT] [int] NOT NULL,
	[MaHD_Nhap_Xuat] [nvarchar](25) NOT NULL,
	[MANV] [nvarchar](25) NOT NULL,
	[MaKH] [nvarchar](25) NULL,
	[MACT] [nvarchar](25) NULL,
	[ngay] [date] NOT NULL,
	[thanhtien] [int] NOT NULL,
	[thanhtoan] [bit] NULL,
 CONSTRAINT [PK_HoaDon_1] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HoaDon] ([STT], [MaHD_Nhap_Xuat], [MANV], [MaKH], [MACT], [ngay], [thanhtien], [thanhtoan]) VALUES (1, N'HDN_1', N'NV1', N'khong co', N'', CAST(0xBC3A0B00 AS Date), 3520000, 1)
INSERT [dbo].[HoaDon] ([STT], [MaHD_Nhap_Xuat], [MANV], [MaKH], [MACT], [ngay], [thanhtien], [thanhtoan]) VALUES (2, N'HDN_2', N'NV1', N'khong co', N'MCT2', CAST(0xBC3A0B00 AS Date), 12500000, 1)
INSERT [dbo].[HoaDon] ([STT], [MaHD_Nhap_Xuat], [MANV], [MaKH], [MACT], [ngay], [thanhtien], [thanhtoan]) VALUES (3, N'HDX_1', N'NV1', N'MKH2', N'khong co', CAST(0xBC3A0B00 AS Date), 750000, 1)
INSERT [dbo].[HoaDon] ([STT], [MaHD_Nhap_Xuat], [MANV], [MaKH], [MACT], [ngay], [thanhtien], [thanhtoan]) VALUES (4, N'HDN_3', N'NV1', N'khong co', N'', CAST(0xBD3A0B00 AS Date), 500000, 0)
/****** Object:  Table [dbo].[NhapHang]    Script Date: 12/03/2015 12:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapHang](
	[MaHD_Nhap] [nvarchar](25) NOT NULL,
	[Mahang] [nvarchar](25) NOT NULL,
	[MaCT] [nvarchar](25) NOT NULL,
	[MaNV] [nvarchar](25) NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,
	[ngaynhap] [date] NOT NULL,
	[thanhtien] [float] NOT NULL,
 CONSTRAINT [PK_NhapHang] PRIMARY KEY CLUSTERED 
(
	[MaHD_Nhap] ASC,
	[Mahang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhapHang] ([MaHD_Nhap], [Mahang], [MaCT], [MaNV], [soluong], [dongia], [ngaynhap], [thanhtien]) VALUES (N'HDN_1', N'MH1', N'MCT1', N'NV1', 5, 50000, CAST(0xBC3A0B00 AS Date), 250000)
INSERT [dbo].[NhapHang] ([MaHD_Nhap], [Mahang], [MaCT], [MaNV], [soluong], [dongia], [ngaynhap], [thanhtien]) VALUES (N'HDN_1', N'MH2', N'MCT2', N'NV1', 15, 218000, CAST(0xBC3A0B00 AS Date), 3270000)
INSERT [dbo].[NhapHang] ([MaHD_Nhap], [Mahang], [MaCT], [MaNV], [soluong], [dongia], [ngaynhap], [thanhtien]) VALUES (N'HDN_2', N'MH4', N'MCT2', N'NV1', 50, 250000, CAST(0xBC3A0B00 AS Date), 12500000)
INSERT [dbo].[NhapHang] ([MaHD_Nhap], [Mahang], [MaCT], [MaNV], [soluong], [dongia], [ngaynhap], [thanhtien]) VALUES (N'HDN_3', N'MH3', N'MCT2', N'NV1', 10, 50000, CAST(0xBD3A0B00 AS Date), 500000)
/****** Object:  Table [dbo].[XuatHang]    Script Date: 12/03/2015 12:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XuatHang](
	[MaHD_Xuat] [nvarchar](25) NOT NULL,
	[Mahang] [nvarchar](25) NOT NULL,
	[MaKH] [nvarchar](25) NOT NULL,
	[MaNV] [nvarchar](25) NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,
	[ngayxuat] [date] NOT NULL,
	[thanhtien] [float] NOT NULL,
 CONSTRAINT [PK_XuatHang] PRIMARY KEY CLUSTERED 
(
	[MaHD_Xuat] ASC,
	[Mahang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[XuatHang] ([MaHD_Xuat], [Mahang], [MaKH], [MaNV], [soluong], [dongia], [ngayxuat], [thanhtien]) VALUES (N'HDX_1', N'MH1', N'MKH2', N'NV1', 10, 50000, CAST(0xBC3A0B00 AS Date), 500000)
INSERT [dbo].[XuatHang] ([MaHD_Xuat], [Mahang], [MaKH], [MaNV], [soluong], [dongia], [ngayxuat], [thanhtien]) VALUES (N'HDX_1', N'MH3', N'MKH2', N'NV1', 5, 50000, CAST(0xBC3A0B00 AS Date), 250000)
INSERT [dbo].[XuatHang] ([MaHD_Xuat], [Mahang], [MaKH], [MaNV], [soluong], [dongia], [ngayxuat], [thanhtien]) VALUES (N'HDX_2', N'MH1', N'MKH1', N'NV1', 5, 50000, CAST(0xBD3A0B00 AS Date), 250000)
/****** Object:  View [dbo].[View_HDNH]    Script Date: 12/03/2015 12:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_HDNH]
AS
SELECT     dbo.HangHoa.Tenhang, dbo.NhapHang.soluong, dbo.HangHoa.dongia, dbo.NhapHang.thanhtien
FROM         dbo.HangHoa INNER JOIN
                      dbo.NhapHang ON dbo.HangHoa.Mahang = dbo.NhapHang.Mahang
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "HangHoa"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NhapHang"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 210
               Right = 438
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_HDNH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_HDNH'
GO
/****** Object:  View [dbo].[HD_Xuat]    Script Date: 12/03/2015 12:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HD_Xuat]
AS
SELECT     COUNT(*) AS Expr1
FROM         dbo.XuatHang
GROUP BY MaHD_Xuat
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "XuatHang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'HD_Xuat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'HD_Xuat'
GO
/****** Object:  View [dbo].[HD_Nhap]    Script Date: 12/03/2015 12:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HD_Nhap]
AS
SELECT     COUNT(*) AS Expr1
FROM         dbo.NhapHang
GROUP BY MaHD_Nhap
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NhapHang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'HD_Nhap'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'HD_Nhap'
GO
/****** Object:  ForeignKey [FK_chitietNhanVien_NhanVien]    Script Date: 12/03/2015 12:32:46 ******/
ALTER TABLE [dbo].[chitietNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_chitietNhanVien_NhanVien] FOREIGN KEY([ID])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[chitietNhanVien] CHECK CONSTRAINT [FK_chitietNhanVien_NhanVien]
GO
/****** Object:  ForeignKey [FK_HoaDon_chitietNhanVien]    Script Date: 12/03/2015 12:32:46 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_chitietNhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[chitietNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_chitietNhanVien]
GO
/****** Object:  ForeignKey [FK_NhapHang_chitietCTYNhap]    Script Date: 12/03/2015 12:32:46 ******/
ALTER TABLE [dbo].[NhapHang]  WITH CHECK ADD  CONSTRAINT [FK_NhapHang_chitietCTYNhap] FOREIGN KEY([MaCT])
REFERENCES [dbo].[chitietCTYNhap] ([MaCT])
GO
ALTER TABLE [dbo].[NhapHang] CHECK CONSTRAINT [FK_NhapHang_chitietCTYNhap]
GO
/****** Object:  ForeignKey [FK_NhapHang_chitietNhanVien]    Script Date: 12/03/2015 12:32:46 ******/
ALTER TABLE [dbo].[NhapHang]  WITH CHECK ADD  CONSTRAINT [FK_NhapHang_chitietNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[chitietNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhapHang] CHECK CONSTRAINT [FK_NhapHang_chitietNhanVien]
GO
/****** Object:  ForeignKey [FK_NhapHang_HangHoa]    Script Date: 12/03/2015 12:32:46 ******/
ALTER TABLE [dbo].[NhapHang]  WITH CHECK ADD  CONSTRAINT [FK_NhapHang_HangHoa] FOREIGN KEY([Mahang])
REFERENCES [dbo].[HangHoa] ([Mahang])
GO
ALTER TABLE [dbo].[NhapHang] CHECK CONSTRAINT [FK_NhapHang_HangHoa]
GO
/****** Object:  ForeignKey [FK_XuatHang_chitietKhanhHang]    Script Date: 12/03/2015 12:32:46 ******/
ALTER TABLE [dbo].[XuatHang]  WITH CHECK ADD  CONSTRAINT [FK_XuatHang_chitietKhanhHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[chitietKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[XuatHang] CHECK CONSTRAINT [FK_XuatHang_chitietKhanhHang]
GO
/****** Object:  ForeignKey [FK_XuatHang_chitietNhanVien1]    Script Date: 12/03/2015 12:32:46 ******/
ALTER TABLE [dbo].[XuatHang]  WITH CHECK ADD  CONSTRAINT [FK_XuatHang_chitietNhanVien1] FOREIGN KEY([MaNV])
REFERENCES [dbo].[chitietNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[XuatHang] CHECK CONSTRAINT [FK_XuatHang_chitietNhanVien1]
GO
/****** Object:  ForeignKey [FK_XuatHang_HangHoa1]    Script Date: 12/03/2015 12:32:46 ******/
ALTER TABLE [dbo].[XuatHang]  WITH CHECK ADD  CONSTRAINT [FK_XuatHang_HangHoa1] FOREIGN KEY([Mahang])
REFERENCES [dbo].[HangHoa] ([Mahang])
GO
ALTER TABLE [dbo].[XuatHang] CHECK CONSTRAINT [FK_XuatHang_HangHoa1]
GO

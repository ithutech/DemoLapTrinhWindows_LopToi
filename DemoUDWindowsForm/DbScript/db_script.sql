USE [master]
GO
/****** Object:  Database [BanVeOnline]    Script Date: 16/10/2019 8:01:08 PM ******/
CREATE DATABASE [BanVeOnline]
 CONTAINMENT = NONE
GO
ALTER DATABASE [BanVeOnline] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BanVeOnline].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BanVeOnline] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BanVeOnline] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BanVeOnline] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BanVeOnline] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BanVeOnline] SET ARITHABORT OFF 
GO
ALTER DATABASE [BanVeOnline] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BanVeOnline] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BanVeOnline] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BanVeOnline] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BanVeOnline] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BanVeOnline] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BanVeOnline] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BanVeOnline] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BanVeOnline] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BanVeOnline] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BanVeOnline] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BanVeOnline] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BanVeOnline] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BanVeOnline] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BanVeOnline] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BanVeOnline] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BanVeOnline] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BanVeOnline] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BanVeOnline] SET  MULTI_USER 
GO
ALTER DATABASE [BanVeOnline] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BanVeOnline] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BanVeOnline] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BanVeOnline] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BanVeOnline] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BanVeOnline] SET QUERY_STORE = OFF
GO
USE [BanVeOnline]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 16/10/2019 8:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaCTHD] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [int] NULL,
	[MaGhe] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ghe]    Script Date: 16/10/2019 8:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ghe](
	[MaGhe] [int] IDENTITY(1,1) NOT NULL,
	[SoGhe] [int] NULL,
	[MaHangGhe] [int] NULL,
 CONSTRAINT [PK_Ghe] PRIMARY KEY CLUSTERED 
(
	[MaGhe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangGhe]    Script Date: 16/10/2019 8:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangGhe](
	[MaHangGhe] [int] IDENTITY(1,1) NOT NULL,
	[TenHangNghe] [nvarchar](50) NULL,
	[GiaVe] [float] NULL,
 CONSTRAINT [PK_HangGhe] PRIMARY KEY CLUSTERED 
(
	[MaHangGhe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 16/10/2019 8:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [datetime] NULL,
	[MaKH] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 16/10/2019 8:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](100) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaGhe]) VALUES (1, 1, 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaGhe]) VALUES (2, 1, 2)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaGhe]) VALUES (3, 2, 3)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaGhe]) VALUES (4, 2, 4)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaGhe]) VALUES (5, 2, 5)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaGhe]) VALUES (6, 2, 15)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaGhe]) VALUES (7, 2, 14)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaGhe]) VALUES (8, 3, 9)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
SET IDENTITY_INSERT [dbo].[Ghe] ON 

INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (1, 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (2, 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (3, 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (4, 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (5, 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (6, 6, 2)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (7, 7, 2)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (8, 8, 2)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (9, 9, 2)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (10, 10, 2)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (11, 11, 3)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (12, 12, 3)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (13, 13, 3)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (14, 14, 3)
INSERT [dbo].[Ghe] ([MaGhe], [SoGhe], [MaHangGhe]) VALUES (15, 15, 3)
SET IDENTITY_INSERT [dbo].[Ghe] OFF
SET IDENTITY_INSERT [dbo].[HangGhe] ON 

INSERT [dbo].[HangGhe] ([MaHangGhe], [TenHangNghe], [GiaVe]) VALUES (1, N'Đầu', 50000)
INSERT [dbo].[HangGhe] ([MaHangGhe], [TenHangNghe], [GiaVe]) VALUES (2, N'Hai', 70000)
INSERT [dbo].[HangGhe] ([MaHangGhe], [TenHangNghe], [GiaVe]) VALUES (3, N'Ba', 90000)
SET IDENTITY_INSERT [dbo].[HangGhe] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH]) VALUES (1, CAST(N'2019-10-02T19:49:43.167' AS DateTime), 2)
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH]) VALUES (2, CAST(N'2019-10-02T19:50:50.070' AS DateTime), 3)
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH]) VALUES (3, CAST(N'2019-10-09T18:12:28.860' AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH]) VALUES (1, N'Xuân Vi')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH]) VALUES (2, N'Thanh Huy')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH]) VALUES (3, N'Dinh Anh')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH]) VALUES (4, N'')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Ghe1] FOREIGN KEY([MaGhe])
REFERENCES [dbo].[Ghe] ([MaGhe])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Ghe1]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[Ghe]  WITH CHECK ADD  CONSTRAINT [FK_Ghe_HangGhe] FOREIGN KEY([MaHangGhe])
REFERENCES [dbo].[HangGhe] ([MaHangGhe])
GO
ALTER TABLE [dbo].[Ghe] CHECK CONSTRAINT [FK_Ghe_HangGhe]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
USE [master]
GO
ALTER DATABASE [BanVeOnline] SET  READ_WRITE 
GO

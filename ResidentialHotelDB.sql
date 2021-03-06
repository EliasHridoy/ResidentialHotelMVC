USE [master]
GO
/****** Object:  Database [ResidentialHotelDB]    Script Date: 9/23/2018 9:26:30 PM ******/
CREATE DATABASE [ResidentialHotelDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ResidentialHotelDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ResidentialHotelDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ResidentialHotelDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ResidentialHotelDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ResidentialHotelDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ResidentialHotelDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ResidentialHotelDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ResidentialHotelDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ResidentialHotelDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ResidentialHotelDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ResidentialHotelDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ResidentialHotelDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ResidentialHotelDB] SET  MULTI_USER 
GO
ALTER DATABASE [ResidentialHotelDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ResidentialHotelDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ResidentialHotelDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ResidentialHotelDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ResidentialHotelDB]
GO
/****** Object:  Table [dbo].[BookRoomTable]    Script Date: 9/23/2018 9:26:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BookRoomTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[RoomId] [int] NOT NULL,
	[SelectedDate] [date] NOT NULL,
	[BookedBy] [varchar](50) NOT NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_BookRoomTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CategoryTable]    Script Date: 9/23/2018 9:26:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CategoryTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category] [varchar](10) NOT NULL,
 CONSTRAINT [PK_CategoryTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RoomInfoTable]    Script Date: 9/23/2018 9:26:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RoomInfoTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoomNo] [varchar](50) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_RoomInfoTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BookRoomTable] ON 

INSERT [dbo].[BookRoomTable] ([Id], [CategoryId], [RoomId], [SelectedDate], [BookedBy], [Address]) VALUES (1, 1, 1, CAST(0xAD3E0B00 AS Date), N'Elias', N'Nai')
INSERT [dbo].[BookRoomTable] ([Id], [CategoryId], [RoomId], [SelectedDate], [BookedBy], [Address]) VALUES (2, 1, 1, CAST(0xB43E0B00 AS Date), N'Elias', N'Nai')
INSERT [dbo].[BookRoomTable] ([Id], [CategoryId], [RoomId], [SelectedDate], [BookedBy], [Address]) VALUES (3, 1, 12, CAST(0xB63E0B00 AS Date), N'Himel', N'Nai')
SET IDENTITY_INSERT [dbo].[BookRoomTable] OFF
SET IDENTITY_INSERT [dbo].[CategoryTable] ON 

INSERT [dbo].[CategoryTable] ([Id], [Category]) VALUES (1, N'AC')
INSERT [dbo].[CategoryTable] ([Id], [Category]) VALUES (2, N'Non-AC')
SET IDENTITY_INSERT [dbo].[CategoryTable] OFF
SET IDENTITY_INSERT [dbo].[RoomInfoTable] ON 

INSERT [dbo].[RoomInfoTable] ([Id], [RoomNo], [CategoryId], [Description]) VALUES (1, N'A-105', 1, N'Nice Room')
INSERT [dbo].[RoomInfoTable] ([Id], [RoomNo], [CategoryId], [Description]) VALUES (2, N'A-106', 1, N'Nice Room')
INSERT [dbo].[RoomInfoTable] ([Id], [RoomNo], [CategoryId], [Description]) VALUES (3, N'A-107', 1, N'Nice Room')
INSERT [dbo].[RoomInfoTable] ([Id], [RoomNo], [CategoryId], [Description]) VALUES (4, N'A-108', 1, N'Nice Room')
INSERT [dbo].[RoomInfoTable] ([Id], [RoomNo], [CategoryId], [Description]) VALUES (5, N'B-108', 2, N'Nice Room')
INSERT [dbo].[RoomInfoTable] ([Id], [RoomNo], [CategoryId], [Description]) VALUES (6, N'B-107', 2, N'Nice Room')
INSERT [dbo].[RoomInfoTable] ([Id], [RoomNo], [CategoryId], [Description]) VALUES (7, N'B-106', 2, N'Nice Room')
INSERT [dbo].[RoomInfoTable] ([Id], [RoomNo], [CategoryId], [Description]) VALUES (8, N'B-105', 2, N'Nice Room')
INSERT [dbo].[RoomInfoTable] ([Id], [RoomNo], [CategoryId], [Description]) VALUES (12, N'A-1010', 1, N'Nice Room')
SET IDENTITY_INSERT [dbo].[RoomInfoTable] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_RoomInfoTable]    Script Date: 9/23/2018 9:26:30 PM ******/
ALTER TABLE [dbo].[RoomInfoTable] ADD  CONSTRAINT [IX_RoomInfoTable] UNIQUE NONCLUSTERED 
(
	[RoomNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BookRoomTable]  WITH CHECK ADD  CONSTRAINT [FK_BookRoomTable_BookRoomTable] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[CategoryTable] ([Id])
GO
ALTER TABLE [dbo].[BookRoomTable] CHECK CONSTRAINT [FK_BookRoomTable_BookRoomTable]
GO
ALTER TABLE [dbo].[BookRoomTable]  WITH CHECK ADD  CONSTRAINT [FK_BookRoomTable_RoomInfoTable] FOREIGN KEY([RoomId])
REFERENCES [dbo].[RoomInfoTable] ([Id])
GO
ALTER TABLE [dbo].[BookRoomTable] CHECK CONSTRAINT [FK_BookRoomTable_RoomInfoTable]
GO
USE [master]
GO
ALTER DATABASE [ResidentialHotelDB] SET  READ_WRITE 
GO

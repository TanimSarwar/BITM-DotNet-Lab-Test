USE [master]
GO
/****** Object:  Database [SalesStationaryDB]    Script Date: 11/27/2019 10:15:30 PM ******/
CREATE DATABASE [SalesStationaryDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SalesStationaryDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SalesStationaryDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SalesStationaryDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SalesStationaryDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SalesStationaryDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SalesStationaryDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SalesStationaryDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SalesStationaryDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SalesStationaryDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SalesStationaryDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SalesStationaryDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SalesStationaryDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SalesStationaryDB] SET  MULTI_USER 
GO
ALTER DATABASE [SalesStationaryDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SalesStationaryDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SalesStationaryDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SalesStationaryDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SalesStationaryDB]
GO
/****** Object:  Table [dbo].[SalesTable]    Script Date: 11/27/2019 10:15:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StationaryName] [varchar](50) NULL,
	[ItemId] [int] NULL,
	[Price] [int] NULL,
	[Purpose] [varchar](50) NULL,
 CONSTRAINT [PK_SalesTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StationaryTable]    Script Date: 11/27/2019 10:15:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StationaryTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_ItemTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[SalesTable] ON 

INSERT [dbo].[SalesTable] ([Id], [StationaryName], [ItemId], [Price], [Purpose]) VALUES (2, N'Iron', 1, 145, N'To Iron The Cloths')
INSERT [dbo].[SalesTable] ([Id], [StationaryName], [ItemId], [Price], [Purpose]) VALUES (3, N'Iron', 1, 145, N'To Iron The Cloths')
INSERT [dbo].[SalesTable] ([Id], [StationaryName], [ItemId], [Price], [Purpose]) VALUES (4, N'Fan', 1, 500, N'To get some air')
INSERT [dbo].[SalesTable] ([Id], [StationaryName], [ItemId], [Price], [Purpose]) VALUES (5, N'Bench', 2, 150, N'To Sit')
INSERT [dbo].[SalesTable] ([Id], [StationaryName], [ItemId], [Price], [Purpose]) VALUES (6, N'Chair', 2, 200, N'To Sit')
INSERT [dbo].[SalesTable] ([Id], [StationaryName], [ItemId], [Price], [Purpose]) VALUES (7, N'Kitchen Brush', 3, 14, N'To clean kitchen')
INSERT [dbo].[SalesTable] ([Id], [StationaryName], [ItemId], [Price], [Purpose]) VALUES (1002, N'Chair', 2, 45, N'To sit')
INSERT [dbo].[SalesTable] ([Id], [StationaryName], [ItemId], [Price], [Purpose]) VALUES (1003, N'Chair', 2, 324, N'To Sit Araaamseee')
INSERT [dbo].[SalesTable] ([Id], [StationaryName], [ItemId], [Price], [Purpose]) VALUES (1005, N'Gas Burner', 3, 10, N'Making Fire')
SET IDENTITY_INSERT [dbo].[SalesTable] OFF
SET IDENTITY_INSERT [dbo].[StationaryTable] ON 

INSERT [dbo].[StationaryTable] ([Id], [Name]) VALUES (1, N'Electronics')
INSERT [dbo].[StationaryTable] ([Id], [Name]) VALUES (2, N'Furniture')
INSERT [dbo].[StationaryTable] ([Id], [Name]) VALUES (3, N'Kitchen')
SET IDENTITY_INSERT [dbo].[StationaryTable] OFF
ALTER TABLE [dbo].[SalesTable]  WITH CHECK ADD  CONSTRAINT [FK_SalesTable_ItemTable] FOREIGN KEY([ItemId])
REFERENCES [dbo].[StationaryTable] ([Id])
GO
ALTER TABLE [dbo].[SalesTable] CHECK CONSTRAINT [FK_SalesTable_ItemTable]
GO
USE [master]
GO
ALTER DATABASE [SalesStationaryDB] SET  READ_WRITE 
GO

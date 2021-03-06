USE [master]
GO
/****** Object:  Database [ProductDB]    Script Date: 10/26/2019 3:30:34 PM ******/
CREATE DATABASE [ProductDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProductDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ProductDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProductDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ProductDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProductDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProductDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProductDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProductDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProductDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProductDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProductDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProductDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProductDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ProductDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProductDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProductDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProductDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProductDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProductDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProductDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProductDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProductDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProductDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProductDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProductDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProductDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProductDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProductDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProductDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProductDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProductDB] SET  MULTI_USER 
GO
ALTER DATABASE [ProductDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProductDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProductDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProductDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ProductDB]
GO
/****** Object:  Table [dbo].[ProductInfo]    Script Date: 10/26/2019 3:30:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_ProductInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ProductInfo] ON 

INSERT [dbo].[ProductInfo] ([Id], [ProductCode], [Description], [Quantity]) VALUES (1, N'PEN-1', N'Gel Pen from Matador', 10)
INSERT [dbo].[ProductInfo] ([Id], [ProductCode], [Description], [Quantity]) VALUES (2, N'PEN-2', N'Normal Pen from Matador', 15)
INSERT [dbo].[ProductInfo] ([Id], [ProductCode], [Description], [Quantity]) VALUES (3, N'PEN-3', N'Fountain Pen from Matador', 15)
INSERT [dbo].[ProductInfo] ([Id], [ProductCode], [Description], [Quantity]) VALUES (5, N'Pencil-1', N'2B', 22)
INSERT [dbo].[ProductInfo] ([Id], [ProductCode], [Description], [Quantity]) VALUES (7, N'Pencil-2', N'HB', 25)
INSERT [dbo].[ProductInfo] ([Id], [ProductCode], [Description], [Quantity]) VALUES (8, N'Pencil-3', N'4B', 25)
INSERT [dbo].[ProductInfo] ([Id], [ProductCode], [Description], [Quantity]) VALUES (9, N'Pen 101', N'', 20)
INSERT [dbo].[ProductInfo] ([Id], [ProductCode], [Description], [Quantity]) VALUES (10, N'asfb', N'adsf', 11)
INSERT [dbo].[ProductInfo] ([Id], [ProductCode], [Description], [Quantity]) VALUES (11, N'qwr', N'df', 10)
INSERT [dbo].[ProductInfo] ([Id], [ProductCode], [Description], [Quantity]) VALUES (12, N'Pencil-5', N'df', 20)
SET IDENTITY_INSERT [dbo].[ProductInfo] OFF
USE [master]
GO
ALTER DATABASE [ProductDB] SET  READ_WRITE 
GO

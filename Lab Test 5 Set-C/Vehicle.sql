USE [master]
GO
/****** Object:  Database [Vehicle]    Script Date: 12/6/2019 11:25:03 PM ******/
CREATE DATABASE [Vehicle]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Vehicle', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Vehicle.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Vehicle_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Vehicle_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Vehicle] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Vehicle].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Vehicle] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Vehicle] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Vehicle] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Vehicle] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Vehicle] SET ARITHABORT OFF 
GO
ALTER DATABASE [Vehicle] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Vehicle] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Vehicle] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Vehicle] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Vehicle] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Vehicle] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Vehicle] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Vehicle] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Vehicle] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Vehicle] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Vehicle] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Vehicle] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Vehicle] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Vehicle] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Vehicle] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Vehicle] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Vehicle] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Vehicle] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Vehicle] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Vehicle] SET  MULTI_USER 
GO
ALTER DATABASE [Vehicle] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Vehicle] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Vehicle] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Vehicle] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Vehicle]
GO
/****** Object:  Table [dbo].[ScheduleTable]    Script Date: 12/6/2019 11:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ScheduleTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VehicleId] [int] NOT NULL,
	[Date] [varchar](50) NOT NULL,
	[Shift] [varchar](50) NOT NULL,
	[Customer] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SchedultTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VehiclesTable]    Script Date: 12/6/2019 11:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VehiclesTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RegNo] [varchar](50) NULL,
	[EngineNo] [varchar](50) NULL,
 CONSTRAINT [PK_VehiclesTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ScheduleTable] ON 

INSERT [dbo].[ScheduleTable] ([Id], [VehicleId], [Date], [Shift], [Customer], [Address]) VALUES (6, 1, N'Monday-30-2019-12', N'Morning', N'Mushfik', N'2 no Gate')
INSERT [dbo].[ScheduleTable] ([Id], [VehicleId], [Date], [Shift], [Customer], [Address]) VALUES (7, 1, N'Tuesday-31-2019-12', N'Evening', N'Tanim', N'Chandgaon')
INSERT [dbo].[ScheduleTable] ([Id], [VehicleId], [Date], [Shift], [Customer], [Address]) VALUES (8, 1, N'Wednesday-11-2019-12', N'Morning', N'Tanim', N'Chandgaon')
SET IDENTITY_INSERT [dbo].[ScheduleTable] OFF
SET IDENTITY_INSERT [dbo].[VehiclesTable] ON 

INSERT [dbo].[VehiclesTable] ([Id], [RegNo], [EngineNo]) VALUES (1, N'Car-101', N'123456')
INSERT [dbo].[VehiclesTable] ([Id], [RegNo], [EngineNo]) VALUES (2, N'Car-102', N'1234567')
INSERT [dbo].[VehiclesTable] ([Id], [RegNo], [EngineNo]) VALUES (3, N'Bus-101', N'1234568')
INSERT [dbo].[VehiclesTable] ([Id], [RegNo], [EngineNo]) VALUES (4, N'Bus-102', N'1234569')
INSERT [dbo].[VehiclesTable] ([Id], [RegNo], [EngineNo]) VALUES (5, N'Truck-101', N'121212')
INSERT [dbo].[VehiclesTable] ([Id], [RegNo], [EngineNo]) VALUES (6, N'Truck-102', N'121213')
SET IDENTITY_INSERT [dbo].[VehiclesTable] OFF
ALTER TABLE [dbo].[ScheduleTable]  WITH CHECK ADD  CONSTRAINT [FK_SchedultTable_VehiclesTable] FOREIGN KEY([VehicleId])
REFERENCES [dbo].[VehiclesTable] ([Id])
GO
ALTER TABLE [dbo].[ScheduleTable] CHECK CONSTRAINT [FK_SchedultTable_VehiclesTable]
GO
USE [master]
GO
ALTER DATABASE [Vehicle] SET  READ_WRITE 
GO

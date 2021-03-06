USE [master]
GO
/****** Object:  Database [Book]    Script Date: 12/6/2019 9:08:07 PM ******/
CREATE DATABASE [Book]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Book', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Book.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Book_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Book_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Book] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Book].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Book] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Book] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Book] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Book] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Book] SET ARITHABORT OFF 
GO
ALTER DATABASE [Book] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Book] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Book] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Book] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Book] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Book] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Book] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Book] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Book] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Book] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Book] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Book] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Book] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Book] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Book] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Book] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Book] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Book] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Book] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Book] SET  MULTI_USER 
GO
ALTER DATABASE [Book] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Book] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Book] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Book] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Book]
GO
/****** Object:  Table [dbo].[BookTable]    Script Date: 12/6/2019 9:08:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BookTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Author] [varchar](50) NOT NULL,
	[Publisher] [varchar](50) NOT NULL,
 CONSTRAINT [PK_BookTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BorrowedBookTable]    Script Date: 12/6/2019 9:08:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BorrowedBookTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NULL,
	[BookTitle] [int] NULL,
	[Author] [varchar](50) NULL,
	[Publisher] [varchar](50) NULL,
 CONSTRAINT [PK_BorrowedBookTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MemberTable]    Script Date: 12/6/2019 9:08:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MemberTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_MemberTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BookTable] ON 

INSERT [dbo].[BookTable] ([Id], [Title], [Author], [Publisher]) VALUES (1, N'Programmming With C', N'Byron Gottfried', N'McGrawHill')
INSERT [dbo].[BookTable] ([Id], [Title], [Author], [Publisher]) VALUES (2, N'Data Mining Concepts and Techniques', N'Han Kamber Pei', N'MK')
INSERT [dbo].[BookTable] ([Id], [Title], [Author], [Publisher]) VALUES (3, N'Data Structure', N'Seymour Lipschutz', N'McGrawHill')
INSERT [dbo].[BookTable] ([Id], [Title], [Author], [Publisher]) VALUES (4, N'TestBook', N'TestTitle', N'TestPublisher')
SET IDENTITY_INSERT [dbo].[BookTable] OFF
SET IDENTITY_INSERT [dbo].[BorrowedBookTable] ON 

INSERT [dbo].[BorrowedBookTable] ([Id], [MemberId], [BookTitle], [Author], [Publisher]) VALUES (6, 101, 1, N'Byron Gottfried', N'McGrawHill')
INSERT [dbo].[BorrowedBookTable] ([Id], [MemberId], [BookTitle], [Author], [Publisher]) VALUES (7, 101, 2, N'Han Kamber Pei', N'MK')
INSERT [dbo].[BorrowedBookTable] ([Id], [MemberId], [BookTitle], [Author], [Publisher]) VALUES (8, 102, 3, N'Seymour Lipschutz', N'McGrawHill')
SET IDENTITY_INSERT [dbo].[BorrowedBookTable] OFF
SET IDENTITY_INSERT [dbo].[MemberTable] ON 

INSERT [dbo].[MemberTable] ([Id], [Number], [Name]) VALUES (1, 101, N'Sarwar')
INSERT [dbo].[MemberTable] ([Id], [Number], [Name]) VALUES (2, 102, N'Mushfiq')
INSERT [dbo].[MemberTable] ([Id], [Number], [Name]) VALUES (3, 103, N'Shwomik')
INSERT [dbo].[MemberTable] ([Id], [Number], [Name]) VALUES (4, 104, N'Momen')
INSERT [dbo].[MemberTable] ([Id], [Number], [Name]) VALUES (5, 105, N'Tanzeed')
SET IDENTITY_INSERT [dbo].[MemberTable] OFF
ALTER TABLE [dbo].[BorrowedBookTable]  WITH CHECK ADD  CONSTRAINT [FK_BorrowedBookTable_BookTable] FOREIGN KEY([BookTitle])
REFERENCES [dbo].[BookTable] ([Id])
GO
ALTER TABLE [dbo].[BorrowedBookTable] CHECK CONSTRAINT [FK_BorrowedBookTable_BookTable]
GO
USE [master]
GO
ALTER DATABASE [Book] SET  READ_WRITE 
GO

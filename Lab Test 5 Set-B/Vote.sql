USE [master]
GO
/****** Object:  Database [Vote]    Script Date: 12/7/2019 7:19:36 PM ******/
CREATE DATABASE [Vote]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Vote', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Vote.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Vote_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Vote_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Vote] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Vote].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Vote] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Vote] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Vote] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Vote] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Vote] SET ARITHABORT OFF 
GO
ALTER DATABASE [Vote] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Vote] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Vote] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Vote] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Vote] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Vote] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Vote] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Vote] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Vote] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Vote] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Vote] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Vote] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Vote] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Vote] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Vote] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Vote] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Vote] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Vote] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Vote] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Vote] SET  MULTI_USER 
GO
ALTER DATABASE [Vote] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Vote] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Vote] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Vote] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Vote]
GO
/****** Object:  Table [dbo].[Candidate]    Script Date: 12/7/2019 7:19:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Candidate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Symbol] [varchar](50) NULL,
 CONSTRAINT [PK_Candidate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CastVote]    Script Date: 12/7/2019 7:19:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CastVote](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VoterId] [varchar](50) NOT NULL,
	[CandidateSymbol] [int] NOT NULL,
	[No] [int] NULL,
 CONSTRAINT [PK_CastVote] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Voter]    Script Date: 12/7/2019 7:19:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Voter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[VoterId] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Voter] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Candidate] ON 

INSERT [dbo].[Candidate] ([Id], [Name], [Symbol]) VALUES (8, N'Anwar Azim', N'Laptop')
INSERT [dbo].[Candidate] ([Id], [Name], [Symbol]) VALUES (9, N'Nikita', N'Mirror')
INSERT [dbo].[Candidate] ([Id], [Name], [Symbol]) VALUES (10, N'Didar', N'Candle')
INSERT [dbo].[Candidate] ([Id], [Name], [Symbol]) VALUES (11, N'Dipankar', N'Mangoe')
SET IDENTITY_INSERT [dbo].[Candidate] OFF
SET IDENTITY_INSERT [dbo].[CastVote] ON 

INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (25, N'00000000000000000', 8, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (26, N'00000000000000001', 8, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (27, N'00000000000000002', 8, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (28, N'00000000000000003', 8, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (29, N'00000000000000004', 8, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (30, N'00000000000000005', 9, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (31, N'00000000000000006', 9, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (32, N'00000000000000007', 10, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (33, N'00000000000000008', 11, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (34, N'00000000000000009', 11, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (35, N'00000000000000010', 11, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (36, N'00000000000000011', 11, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (37, N'00000000000000012', 11, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (38, N'00000000000000013', 11, 1)
INSERT [dbo].[CastVote] ([Id], [VoterId], [CandidateSymbol], [No]) VALUES (39, N'00000000000000014', 9, 1)
SET IDENTITY_INSERT [dbo].[CastVote] OFF
SET IDENTITY_INSERT [dbo].[Voter] ON 

INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (28, N'Tanim', N'00000000000000000')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (29, N'Tanim', N'00000000000000001')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (30, N'Tanim', N'00000000000000002')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (31, N'Tanim', N'00000000000000003')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (32, N'Tanim', N'00000000000000004')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (33, N'Apu', N'00000000000000005')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (34, N'Apu', N'00000000000000006')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (35, N'Apu', N'00000000000000007')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (36, N'Apu', N'00000000000000008')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (37, N'Apu', N'00000000000000009')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (38, N'Tanzeed', N'00000000000000010')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (39, N'Tanzeed', N'00000000000000011')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (40, N'Tanzeed', N'00000000000000012')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (41, N'Tanzeed', N'00000000000000013')
INSERT [dbo].[Voter] ([Id], [Name], [VoterId]) VALUES (42, N'Tanzeed', N'00000000000000014')
SET IDENTITY_INSERT [dbo].[Voter] OFF
ALTER TABLE [dbo].[CastVote]  WITH CHECK ADD  CONSTRAINT [FK_CastVote_Candidate] FOREIGN KEY([CandidateSymbol])
REFERENCES [dbo].[Candidate] ([Id])
GO
ALTER TABLE [dbo].[CastVote] CHECK CONSTRAINT [FK_CastVote_Candidate]
GO
USE [master]
GO
ALTER DATABASE [Vote] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [English]    Script Date: 06/12/2019 08:31:18 PM ******/
CREATE DATABASE [English]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'English', FILENAME = N'E:\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\English.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'English_log', FILENAME = N'E:\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\English_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [English] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [English].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [English] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [English] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [English] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [English] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [English] SET ARITHABORT OFF 
GO
ALTER DATABASE [English] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [English] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [English] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [English] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [English] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [English] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [English] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [English] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [English] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [English] SET  DISABLE_BROKER 
GO
ALTER DATABASE [English] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [English] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [English] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [English] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [English] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [English] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [English] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [English] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [English] SET  MULTI_USER 
GO
ALTER DATABASE [English] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [English] SET DB_CHAINING OFF 
GO
ALTER DATABASE [English] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [English] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [English] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'English', N'ON'
GO
ALTER DATABASE [English] SET QUERY_STORE = OFF
GO
USE [English]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [English]
GO
/****** Object:  Table [dbo].[Animals]    Script Date: 06/12/2019 08:31:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Vietnamese] [nvarchar](500) NULL,
	[ImageURL] [varchar](500) NULL,
	[PronounceURL] [varchar](500) NULL,
	[SoundURL] [varchar](500) NULL,
 CONSTRAINT [PK_Animals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Number]    Script Date: 06/12/2019 08:31:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Number](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[image] [nvarchar](100) NULL,
	[pronounce] [nvarchar](100) NULL,
 CONSTRAINT [PK_Number] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Animals] ON 

INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (1, N'Bird', N'Con chim', N'/animals/bird/image/bird.jpg', N'/animals/bird/pronounce/bird-UK.mp3', N'/animals/bird/sound/bird.wav')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (2, N'Cat', N'Con mèo', N'/animals/cat/image/cat.jpg', N'/animals/cat/pronounce/cat-US.mp3', N'/animals/cat/sound/cat.wav')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (3, N'Cock', N'Con gà trống', N'/animals/cock/image/cock.jpg', N'/animals/cock/pronounce/cock-UK.mp3', N'/animals/cock/sound/cock.mp3')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (4, N'Cow', N'Con bò', N'/animals/cow/image/cow.jpg', N'/animals/cow/pronounce/cow-UK.mp3', N'/animals/cow/sound/cow.wav')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (5, N'Cricket', N'Con dế', N'/animals/cricket/image/cricket.jpg', N'/animals/cricket/pronounce/cricket-US.mp3', N'/animals/cricket/sound/Frog.wav')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (6, N'Dog', N'Con chó', N'/animals/dog/image/dog.jpg', N'/animals/dog/pronounce/dog-US.mp3', N'/animals/dog/sound/dog.wav')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (7, N'Duck', N'Con vịt', N'/animals/duck/image/duck.jpg', N'/animals/duck/pronounce/duck-US.mp3', N'/animals/duck/sound/duck.mp3')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (8, N'Elephant', N'Con voi', N'/animals/elephant/image/elephant.jpg', N'/animals/elephant/pronounce/elephant-UK.mp3', N'/animals/elephant/sound/elephant.wav')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (10, N'Frog', N'Con ếch', N'/animals/frog/image/frog.jpg', N'/animals/frog/pronounce/frog-UK.mp3', N'/animals/frog/sound/frog.mp3')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (12, N'Horse', N'Con ngựa', N'/animals/horse/image/horse.jpg', N'/animals/horse/pronounce/horse-UK.mp3', N'/animals/horse/sound/Horse.wav')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (13, N'Lion', N'Con sư tử', N'/animals/lion/image/lion.jpg', N'/animals/lion/pronounce/lion-UK.mp3', N'~/animals/lion/sound/lion.mp3')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (14, N'Monkey', N'Con khỉ', N'/animals/monkey/image/monkey.jpg', N'/animals/monkey/pronounce/monkey-UK.mp3', N'/animals/monkey/sound/Monkey.wav')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (15, N'Mouse', N'Con chuột', N'/animals/mouse/image/mouse.jpg', N'/animals/mouse/pronounce/mouse-UK.mp3', N'/animals/mouse/sound/mouse.mp3')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (17, N'Pig', N'Con lợn', N'/animals/pig/image/pig.jpg', N'/animals/pig/pronounce/pig-UK.mp3', N'/animals/pig/sound/Pig.wav')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (18, N'Bear', N'Con gấu', N'/animals/bear/image/bear.jpg', N'/animals/bear/pronounce/bear-US.mp3', N'/animals/bear/sound/bear.mp3')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (19, N'Car', N'Xe hơi', N'/animals/car/image/car.jpg', N'/animals/car/pronounce/car-US.mp3', N'/animals/car/sound/car.mp3')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (20, N'Piano', N'Đàn dương cầm', N'/animals/piano/image/piano.jpg', N'/animals/piano/pronounce/piano-UK.mp3', N'/animals/piano/sound/piano.mp3')
INSERT [dbo].[Animals] ([Id], [Name], [Vietnamese], [ImageURL], [PronounceURL], [SoundURL]) VALUES (21, N'Smile', N'Cười', N'/animals/smile/image/smile.jpg', N'/animals/smile/pronounce/smile-US.mp3', N'/animals/smile/sound/smile.mp3')
SET IDENTITY_INSERT [dbo].[Animals] OFF
USE [master]
GO
ALTER DATABASE [English] SET  READ_WRITE 
GO

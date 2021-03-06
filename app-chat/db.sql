USE [master]
GO
/****** Object:  Database [Socket]    Script Date: 5/23/2020 4:49:07 PM ******/
CREATE DATABASE [Socket]  
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'Socket', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Socket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Socket] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Socket] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Socket] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Socket] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Socket] SET ARITHABORT OFF 
GO
ALTER DATABASE [Socket] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Socket] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Socket] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Socket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Socket] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Socket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Socket] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Socket] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Socket] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Socket] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Socket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Socket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Socket] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Socket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Socket] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Socket] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Socket] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Socket] SET  MULTI_USER 
GO
ALTER DATABASE [Socket] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Socket] SET DB_CHAINING OFF 
GO
USE [Socket]
GO
/****** Object:  Table [dbo].[User]    Script Date: 5/23/2020 4:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[DayOfBirth] [datetime] NULL,
	[Note] [ntext] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [DayOfBirth], [Note]) VALUES (1, N'client1', N'1', N'Nguyễn Văn Một', CAST(N'1999-05-20T00:00:00.000' AS DateTime), N'éc éc')
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [DayOfBirth], [Note]) VALUES (2, N'client2', N'1', N'Nguyễn Văn B', CAST(N'1999-05-20T00:00:00.000' AS DateTime), N'meo meo')
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [DayOfBirth], [Note]) VALUES (3, N'client3', N'1', N'Nguyễn Văn C', CAST(N'1999-05-20T00:00:00.000' AS DateTime), N'hihi')
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [DayOfBirth], [Note]) VALUES (4, N'client 4', N'1', N'Nguyễn Văn D', CAST(N'1999-05-20T00:00:00.000' AS DateTime), N'haha')
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [DayOfBirth], [Note]) VALUES (5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [DayOfBirth], [Note]) VALUES (6, N'client5', N'1', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
USE [master]
GO
ALTER DATABASE [Socket] SET  READ_WRITE 
GO

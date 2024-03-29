
USE [master]
GO
/****** Object:  Database [dbMilitary]    Script Date: 24/07/2019 10:35:08 PM ******/
CREATE DATABASE [dbMilitary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbMilitary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\dbMilitary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbMilitary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\dbMilitary_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbMilitary] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbMilitary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbMilitary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbMilitary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbMilitary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbMilitary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbMilitary] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbMilitary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbMilitary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbMilitary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbMilitary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbMilitary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbMilitary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbMilitary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbMilitary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbMilitary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbMilitary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbMilitary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbMilitary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbMilitary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbMilitary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbMilitary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbMilitary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbMilitary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbMilitary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbMilitary] SET  MULTI_USER 
GO
ALTER DATABASE [dbMilitary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbMilitary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbMilitary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbMilitary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbMilitary] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbMilitary', N'ON'
GO
ALTER DATABASE [dbMilitary] SET QUERY_STORE = OFF
GO
USE [dbMilitary]
GO
/****** Object:  Table [dbo].[tblInventory]    Script Date: 24/07/2019 10:35:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblInventory](
	[InventoryID] [int] IDENTITY(1,1) NOT NULL,
	[Item] [varchar](max) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Weight] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblInventory] PRIMARY KEY CLUSTERED 
(
	[InventoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblJet]    Script Date: 24/07/2019 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblJet](
	[JetID] [int] IDENTITY(1,1) NOT NULL,
	[JetModel] [varchar](50) NOT NULL,
	[FuelTankCapacity] [int] NOT NULL,
	[Height] [decimal](18, 2) NOT NULL,
	[MaxWeight] [decimal](18, 2) NOT NULL,
	[Speed] [decimal](18, 2) NOT NULL,
	[InventoryID] [int] NOT NULL,
 CONSTRAINT [PK_tblJet] PRIMARY KEY CLUSTERED 
(
	[JetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblObstacles]    Script Date: 24/07/2019 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblObstacles](
	[ObstacleID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Range] [int] NOT NULL,
 CONSTRAINT [PK_tblObstacles] PRIMARY KEY CLUSTERED 
(
	[ObstacleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblReport]    Script Date: 24/07/2019 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReport](
	[ReportID] [int] IDENTITY(1,1) NOT NULL,
	[DamageAnalysis] [varchar](50) NOT NULL,
	[SuccessRate] [int] NOT NULL,
	[TimeOfStrike] [varchar](50) NOT NULL,
	[LocationTargeted] [varchar](50) NULL,
	[LocationHit] [varchar](50) NULL,
	[TargetsIdentified] [int] NULL,
	[TargetsChoosen] [int] NULL,
	[ObstaclesIdentified] [int] NULL,
	[ObstaclesAvoided] [int] NULL,
	[ReasonForAvoidance] [varchar](80) NULL,
 CONSTRAINT [PK_tblReport] PRIMARY KEY CLUSTERED 
(
	[ReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblInventory] ON 

INSERT [dbo].[tblInventory] ([InventoryID], [Item], [Quantity], [Weight]) VALUES (1, N'Scanner', 1, CAST(23.00 AS Decimal(18, 2)))
INSERT [dbo].[tblInventory] ([InventoryID], [Item], [Quantity], [Weight]) VALUES (2, N'Rockets', 4, CAST(25.55 AS Decimal(18, 2)))
INSERT [dbo].[tblInventory] ([InventoryID], [Item], [Quantity], [Weight]) VALUES (3, N'Napalm', 10, CAST(12.50 AS Decimal(18, 2)))
INSERT [dbo].[tblInventory] ([InventoryID], [Item], [Quantity], [Weight]) VALUES (4, N'Supplies', 100, CAST(1.10 AS Decimal(18, 2)))
INSERT [dbo].[tblInventory] ([InventoryID], [Item], [Quantity], [Weight]) VALUES (5, N'Explosive', 5, CAST(10.95 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[tblInventory] OFF
SET IDENTITY_INSERT [dbo].[tblJet] ON 

INSERT [dbo].[tblJet] ([JetID], [JetModel], [FuelTankCapacity], [Height], [MaxWeight], [Speed], [InventoryID]) VALUES (1, N'Drone', 100, CAST(17000.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), CAST(7000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[tblJet] ([JetID], [JetModel], [FuelTankCapacity], [Height], [MaxWeight], [Speed], [InventoryID]) VALUES (2, N'Shooter', 120, CAST(14000.00 AS Decimal(18, 2)), CAST(187.50 AS Decimal(18, 2)), CAST(9000.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[tblJet] ([JetID], [JetModel], [FuelTankCapacity], [Height], [MaxWeight], [Speed], [InventoryID]) VALUES (4, N'Bomber', 80, CAST(5000.00 AS Decimal(18, 2)), CAST(223.70 AS Decimal(18, 2)), CAST(6000.00 AS Decimal(18, 2)), 3)
SET IDENTITY_INSERT [dbo].[tblJet] OFF
SET IDENTITY_INSERT [dbo].[tblObstacles] ON 

INSERT [dbo].[tblObstacles] ([ObstacleID], [Description], [Range]) VALUES (1, N'Long Bow Cannon', 180)
INSERT [dbo].[tblObstacles] ([ObstacleID], [Description], [Range]) VALUES (2, N'RE-45 Missile Launcher', 122)
INSERT [dbo].[tblObstacles] ([ObstacleID], [Description], [Range]) VALUES (3, N'EMP Launcher', 100)
INSERT [dbo].[tblObstacles] ([ObstacleID], [Description], [Range]) VALUES (4, N'Gunrail Cannons', 150)
SET IDENTITY_INSERT [dbo].[tblObstacles] OFF
ALTER TABLE [dbo].[tblJet]  WITH CHECK ADD  CONSTRAINT [FK_tblJet_tblInventory] FOREIGN KEY([InventoryID])
REFERENCES [dbo].[tblInventory] ([InventoryID])
GO
ALTER TABLE [dbo].[tblJet] CHECK CONSTRAINT [FK_tblJet_tblInventory]
GO
/****** Object:  StoredProcedure [dbo].[SPInsertNewJetDetails]    Script Date: 24/07/2019 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPInsertNewJetDetails]
		@newJet varchar(50),
		@newFuelTankCapacity int,
		@newHeight decimal(18, 2),
		@newMaxWeight decimal(18, 2),
		@newSpeed decimal(18, 2),
		@newInventory int

AS
BEGIN
	INSERT INTO tblReport(JetModel,FuelTankCapacity,Height,MaxWeight,Speed,InventoryID)
	VALUES (@newJet,@newFuelTankCapacity,@newHeight,@newMaxWeight,@newSpeed,@newInventory)
END

GO
/****** Object:  StoredProcedure [dbo].[SPInsertObstacle]    Script Date: 24/07/2019 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPInsertObstacle]
		@DescriptionToAdd varchar(MAX),
		@RangeToAdd int

AS
BEGIN
	INSERT INTO tblObstacles(Description,Range)
	VALUES (@DescriptionToAdd,@RangeToAdd)
	
END

GO
/****** Object:  StoredProcedure [dbo].[SPUpdateFuel]    Script Date: 24/07/2019 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPUpdateFuel]
		@idToUpdate int,
		@fuelLevelToUpdate int

AS
BEGIN
	UPDATE tblJet
	Set FuelTankCapacity = @fuelLevelToUpdate
	WHERE JetID = @idToUpdate
END

GO
USE [master]
GO
ALTER DATABASE [dbMilitary] SET  READ_WRITE 
GO

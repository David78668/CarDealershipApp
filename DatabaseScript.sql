USE [master]
GO
/****** Object:  Database [CarDealershipDB]    Script Date: 11.01.2023 21:20:08 ******/
CREATE DATABASE [CarDealershipDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarDealershipDB', FILENAME = N'C:\Users\davek\CarDealershipDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarDealershipDB_log', FILENAME = N'C:\Users\davek\CarDealershipDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CarDealershipDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarDealershipDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarDealershipDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarDealershipDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarDealershipDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarDealershipDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarDealershipDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarDealershipDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarDealershipDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarDealershipDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarDealershipDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarDealershipDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarDealershipDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarDealershipDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarDealershipDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarDealershipDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarDealershipDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarDealershipDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarDealershipDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarDealershipDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarDealershipDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarDealershipDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarDealershipDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarDealershipDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarDealershipDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CarDealershipDB] SET  MULTI_USER 
GO
ALTER DATABASE [CarDealershipDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarDealershipDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarDealershipDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarDealershipDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarDealershipDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarDealershipDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CarDealershipDB] SET QUERY_STORE = OFF
GO
USE [CarDealershipDB]
GO
/****** Object:  Table [dbo].[CarOrder]    Script Date: 11.01.2023 21:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarOrder](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[CarID] [int] NULL,
	[DealerID] [int] NULL,
 CONSTRAINT [PK_CarOrder] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 11.01.2023 21:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Brand] [nvarchar](50) NULL,
	[Model] [nvarchar](50) NULL,
	[Year] [nvarchar](50) NULL,
	[Price] [nvarchar](50) NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 11.01.2023 21:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Tel] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dealers]    Script Date: 11.01.2023 21:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dealers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Tel] [nvarchar](50) NULL,
 CONSTRAINT [PK_Dealers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CarOrder] ON 

INSERT [dbo].[CarOrder] ([ID], [CustomerID], [CarID], [DealerID]) VALUES (1, 1, 1, 3)
INSERT [dbo].[CarOrder] ([ID], [CustomerID], [CarID], [DealerID]) VALUES (2, 2, 6, 2)
INSERT [dbo].[CarOrder] ([ID], [CustomerID], [CarID], [DealerID]) VALUES (3, 6, 5, 5)
INSERT [dbo].[CarOrder] ([ID], [CustomerID], [CarID], [DealerID]) VALUES (4, 8, 7, 1)
INSERT [dbo].[CarOrder] ([ID], [CustomerID], [CarID], [DealerID]) VALUES (6, 9, 4, 1)
INSERT [dbo].[CarOrder] ([ID], [CustomerID], [CarID], [DealerID]) VALUES (7, 7, 1, 1)
SET IDENTITY_INSERT [dbo].[CarOrder] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (1, N'Toyota', N'Supra', N'1999', N'1500000', 2)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (2, N'Ford', N'Mustang', N'2014', N'1000000', 1)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (3, N'Mercedes', N'Benz S', N'2018', N'250000', 1)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (4, N'Nissan', N'Silvia S15', N'1999', N'800000', 2)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (5, N'Mazda', N'RX7', N'2002', N'600000', 2)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (6, N'Porsche', N'911', N'2019', N'3400000', 2)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (7, N'BMW', N'M2', N'2018', N'1400000', 2)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (8, N'Tesla', N'Model S', N'2022', N'3400000', 1)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (9, N'Bentley', N'Continental GT', N'2016', N'2000000', 1)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (10, N'Ferrari', N'F12', N'2018', N'6500000', 1)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (11, N'Audi', N'R8', N'2019', N'3800000', 1)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (12, N'Mercedes', N'Benz G', N'2016', N'2000000', 1)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (13, N'McLaren', N'720S', N'2018', N'5800000', 1)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (14, N'Nissan', N'GT-R', N'2021', N'3200000', 1)
INSERT [dbo].[Cars] ([ID], [Brand], [Model], [Year], [Price], [Status]) VALUES (15, N'Mazda', N'Miata', N'1990', N'150000', 1)
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (1, N'Petr', N'Přikoval', N'petr.prikoval@seznam.cz', N'746 929 284')
INSERT [dbo].[Customers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (2, N'Martin', N'Jaroš', N'martin.jaros@seznam.cz', N'724 849 924')
INSERT [dbo].[Customers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (3, N'Jaroslav', N'Liška', N'jaroslav.liska@seznam.cz', N'608 954 839')
INSERT [dbo].[Customers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (4, N'Vlastimil', N'Veselý', N'vlastimil.vesely@seznam.cz', N'794 352 678')
INSERT [dbo].[Customers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (5, N'Jiří', N'Maršálek', N'jiri.marsalek@seznam.cz', N'784 592 385')
INSERT [dbo].[Customers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (6, N'František', N'Pech', N'frantisek.pech@seznam.cz', N'738 643 257')
INSERT [dbo].[Customers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (7, N'Tomáš', N'Potocký', N'tomas.potocky', N'685 759 382')
INSERT [dbo].[Customers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (8, N'Josef', N'Hladil', N'josef.hladil@seznam.cz', N'658 326 534')
INSERT [dbo].[Customers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (9, N'Milan', N'Záruba', N'milan.zaruba', N'732 924 635')
INSERT [dbo].[Customers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (10, N'František', N'Novotný', N'frantisek.novotny', N'608 479 358')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Dealers] ON 

INSERT [dbo].[Dealers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (1, N'Petr', N'Podělka', N'petr.podelka@seznam.cz', N'724 532 894')
INSERT [dbo].[Dealers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (2, N'Jiří', N'Okradl', N'jiri.okradl@seznam.cz', N'935 862 361')
INSERT [dbo].[Dealers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (3, N'Kateřina', N'Lichvářová', N'katerina.lichvarova', N'756 382 690')
INSERT [dbo].[Dealers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (4, N'Marek', N'Revolta', N'marek.revolta@seznam.cz', N'720 069 420')
INSERT [dbo].[Dealers] ([ID], [Name], [Surname], [Email], [Tel]) VALUES (5, N'Richard', N'Watzke', N'richard.watzke@xixoio.cz', N'756 352 082')
SET IDENTITY_INSERT [dbo].[Dealers] OFF
GO
ALTER TABLE [dbo].[CarOrder]  WITH CHECK ADD  CONSTRAINT [FK_CarOrder_Cars] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([ID])
GO
ALTER TABLE [dbo].[CarOrder] CHECK CONSTRAINT [FK_CarOrder_Cars]
GO
ALTER TABLE [dbo].[CarOrder]  WITH CHECK ADD  CONSTRAINT [FK_CarOrder_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([ID])
GO
ALTER TABLE [dbo].[CarOrder] CHECK CONSTRAINT [FK_CarOrder_Customers]
GO
ALTER TABLE [dbo].[CarOrder]  WITH CHECK ADD  CONSTRAINT [FK_CarOrder_Dealers] FOREIGN KEY([DealerID])
REFERENCES [dbo].[Dealers] ([ID])
GO
ALTER TABLE [dbo].[CarOrder] CHECK CONSTRAINT [FK_CarOrder_Dealers]
GO
USE [master]
GO
ALTER DATABASE [CarDealershipDB] SET  READ_WRITE 
GO

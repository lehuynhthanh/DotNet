USE [HelloDotNet]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 9/30/2018 2:24:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product_Data]    Script Date: 9/30/2018 2:24:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Data](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (1, N'Con dấu')
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (2, N'Máy in')
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (3, N'Vật liệu xây dựng')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Product_Data] ON 

GO
INSERT [dbo].[Product_Data] ([Id], [ProductName], [Description], [Price]) VALUES (1, N'Mực in', N'Mực cho máy in', CAST(100000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Product_Data] ([Id], [ProductName], [Description], [Price]) VALUES (2, N'Máy in HP', N'Máy in hãng HP', CAST(2900000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Product_Data] ([Id], [ProductName], [Description], [Price]) VALUES (3, N'Máy in màu', N'máy in có màu', CAST(4000000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Product_Data] ([Id], [ProductName], [Description], [Price]) VALUES (4, N'Con dấu 1', N'abc', CAST(35000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Product_Data] ([Id], [ProductName], [Description], [Price]) VALUES (5, N'Con dấu 2', N'ppp', CAST(40000 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Product_Data] OFF
GO

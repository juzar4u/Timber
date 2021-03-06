USE [TimberCalc]
GO
/****** Object:  Table [dbo].[bamboo]    Script Date: 5/24/2018 3:04:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bamboo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Length_ft] [int] NULL,
	[Name] [varchar](20) NULL,
	[Price] [int] NULL,
	[ActualPrice] [int] NULL,
	[DateOfActualPrice] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pinewood]    Script Date: 5/24/2018 3:04:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pinewood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[status] [varchar](20) NULL,
	[width_inch] [float] NULL,
	[height_inch] [float] NULL,
	[length_ft] [float] NULL,
	[rate] [float] NULL,
	[fright] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[plywood]    Script Date: 5/24/2018 3:04:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[plywood](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[size] [varchar](20) NULL,
	[thickness] [varchar](20) NULL,
	[weight_KG] [int] NULL,
	[cost_per_sqft] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[bamboo] ON 

INSERT [dbo].[bamboo] ([ID], [Length_ft], [Name], [Price], [ActualPrice], [DateOfActualPrice]) VALUES (1, 24, N'Delux', 52, 244, CAST(0x0000A8EA00E77158 AS DateTime))
INSERT [dbo].[bamboo] ([ID], [Length_ft], [Name], [Price], [ActualPrice], [DateOfActualPrice]) VALUES (2, 16, N'Delux', 40, 188, CAST(0x0000A8EA00E77157 AS DateTime))
INSERT [dbo].[bamboo] ([ID], [Length_ft], [Name], [Price], [ActualPrice], [DateOfActualPrice]) VALUES (3, 24, N'Bullet', 58, 261, CAST(0x0000A8E90174CBB5 AS DateTime))
INSERT [dbo].[bamboo] ([ID], [Length_ft], [Name], [Price], [ActualPrice], [DateOfActualPrice]) VALUES (6, 10, N'Chaal', 80, NULL, NULL)
SET IDENTITY_INSERT [dbo].[bamboo] OFF
SET IDENTITY_INSERT [dbo].[pinewood] ON 

INSERT [dbo].[pinewood] ([id], [status], [width_inch], [height_inch], [length_ft], [rate], [fright]) VALUES (1, N'actual', 2.75, 1.25, 8, 470, 30)
INSERT [dbo].[pinewood] ([id], [status], [width_inch], [height_inch], [length_ft], [rate], [fright]) VALUES (2, N'selling', 3, 1.5, 8, 450, 0)
INSERT [dbo].[pinewood] ([id], [status], [width_inch], [height_inch], [length_ft], [rate], [fright]) VALUES (3, N'actual', 3.75, 2.75, 8, 470, 30)
INSERT [dbo].[pinewood] ([id], [status], [width_inch], [height_inch], [length_ft], [rate], [fright]) VALUES (4, N'selling', 4, 3, 8, 506, 0)
INSERT [dbo].[pinewood] ([id], [status], [width_inch], [height_inch], [length_ft], [rate], [fright]) VALUES (5, N'actual', 9, 1.25, 10, 480, 30)
INSERT [dbo].[pinewood] ([id], [status], [width_inch], [height_inch], [length_ft], [rate], [fright]) VALUES (6, N'selling', 9, 1.5, 10, 502, 0)
INSERT [dbo].[pinewood] ([id], [status], [width_inch], [height_inch], [length_ft], [rate], [fright]) VALUES (7, N'actual', 9, 1.125, 8, 480, 30)
INSERT [dbo].[pinewood] ([id], [status], [width_inch], [height_inch], [length_ft], [rate], [fright]) VALUES (8, N'selling', 9, 1.5, 8, 451, 0)
SET IDENTITY_INSERT [dbo].[pinewood] OFF
SET IDENTITY_INSERT [dbo].[plywood] ON 

INSERT [dbo].[plywood] ([ID], [size], [thickness], [weight_KG], [cost_per_sqft]) VALUES (1, N'8x4', N'12mm', 30, 42)
INSERT [dbo].[plywood] ([ID], [size], [thickness], [weight_KG], [cost_per_sqft]) VALUES (2, N'8x4', N'12mm', 34, 46)
INSERT [dbo].[plywood] ([ID], [size], [thickness], [weight_KG], [cost_per_sqft]) VALUES (3, N'8x4', N'12mm', 24, 31)
INSERT [dbo].[plywood] ([ID], [size], [thickness], [weight_KG], [cost_per_sqft]) VALUES (4, N'8x4', N'18mm', 45, 66)
INSERT [dbo].[plywood] ([ID], [size], [thickness], [weight_KG], [cost_per_sqft]) VALUES (5, N'8x4', N'18mm', 50, 70)
INSERT [dbo].[plywood] ([ID], [size], [thickness], [weight_KG], [cost_per_sqft]) VALUES (6, N'8x4', N'25mm', 65, 100)
INSERT [dbo].[plywood] ([ID], [size], [thickness], [weight_KG], [cost_per_sqft]) VALUES (7, N'8x4', N'25mm', 70, 98)
SET IDENTITY_INSERT [dbo].[plywood] OFF

USE [Piatnica]
GO
/****** Object:  Table [dbo].[DelaysContext]    Script Date: 2019-07-16 13:15:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DelaysContext](
	[Id] [int] NOT NULL,
	[DelayOrder] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[OrderEntryId] [int] NULL,
 CONSTRAINT [PK_DelaysContext] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventsHistoriesContext]    Script Date: 2019-07-16 13:15:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventsHistoriesContext](
	[Id] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Distance] [float] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[OrderEntryId] [int] NULL,
 CONSTRAINT [PK_EventsHistoriesContext] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LocationsHistoriesContext]    Script Date: 2019-07-16 13:15:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocationsHistoriesContext](
	[Id] [int] NOT NULL,
	[Longitude] [float] NOT NULL,
	[LatitudeL] [float] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Orderid] [int] NULL,
 CONSTRAINT [PK_LocationsHistoriesContext] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersContext]    Script Date: 2019-07-16 13:15:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersContext](
	[Id] [int] NOT NULL,
	[Number] [nvarchar](max) NULL,
 CONSTRAINT [PK_OrdersContext] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersEntriesContext]    Script Date: 2019-07-16 13:15:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersEntriesContext](
	[Id] [int] NOT NULL,
	[OrderType] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
	[FromTime] [datetime2](7) NOT NULL,
	[ToTime] [datetime2](7) NOT NULL,
	[Cargo] [nvarchar](max) NULL,
	[Comments] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[Orderid] [int] NULL,
 CONSTRAINT [PK_OrdersEntriesContext] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersStatesContext]    Script Date: 2019-07-16 13:15:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersStatesContext](
	[Id] [int] NOT NULL,
	[State] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
	[Orderid] [int] NULL,
 CONSTRAINT [PK_OrdersStatesContext] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[DelaysContext] ([Id], [DelayOrder], [Date], [OrderEntryId]) VALUES (1, 21, CAST(N'2019-07-12T15:33:00.0000000' AS DateTime2), 4)
INSERT [dbo].[DelaysContext] ([Id], [DelayOrder], [Date], [OrderEntryId]) VALUES (2, 30, CAST(N'2019-07-12T17:24:01.0000000' AS DateTime2), 6)
INSERT [dbo].[DelaysContext] ([Id], [DelayOrder], [Date], [OrderEntryId]) VALUES (3, 27, CAST(N'2019-07-13T14:55:00.0000000' AS DateTime2), 10)
INSERT [dbo].[DelaysContext] ([Id], [DelayOrder], [Date], [OrderEntryId]) VALUES (4, 32, CAST(N'2019-07-13T16:55:00.0000000' AS DateTime2), 18)
INSERT [dbo].[DelaysContext] ([Id], [DelayOrder], [Date], [OrderEntryId]) VALUES (5, 20, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 20)
INSERT [dbo].[DelaysContext] ([Id], [DelayOrder], [Date], [OrderEntryId]) VALUES (6, 15, CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), 22)
INSERT [dbo].[DelaysContext] ([Id], [DelayOrder], [Date], [OrderEntryId]) VALUES (7, 22, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 24)
INSERT [dbo].[DelaysContext] ([Id], [DelayOrder], [Date], [OrderEntryId]) VALUES (8, 15, CAST(N'2019-07-12T12:21:00.0000000' AS DateTime2), 26)
INSERT [dbo].[DelaysContext] ([Id], [DelayOrder], [Date], [OrderEntryId]) VALUES (9, 48, CAST(N'2019-07-13T10:12:12.0000000' AS DateTime2), 28)
INSERT [dbo].[DelaysContext] ([Id], [DelayOrder], [Date], [OrderEntryId]) VALUES (10, 33, CAST(N'2019-07-13T13:05:12.0000000' AS DateTime2), 30)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (1, CAST(N'2019-07-12T12:30:00.0000000' AS DateTime2), 534212, N'Dojazd do Celu', 2)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (2, CAST(N'2019-07-12T14:23:00.0000000' AS DateTime2), 534242, N'Opóźnienie', 4)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (3, CAST(N'2019-07-12T14:23:00.0000000' AS DateTime2), 534242, N'Tankowanie', 4)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (4, CAST(N'2019-07-12T15:33:00.0000000' AS DateTime2), 534282, N'Dojazd do Celu', 4)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (5, CAST(N'2019-07-12T17:24:02.0000000' AS DateTime2), 534356, N'Dojazd do Celu', 6)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (6, CAST(N'2019-07-13T11:44:00.0000000' AS DateTime2), 615215, N'Dojazd do Celu', 8)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (7, CAST(N'2019-07-13T13:35:00.0000000' AS DateTime2), 615235, N'Tankowanie ', 10)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (8, CAST(N'2019-07-13T13:55:00.0000000' AS DateTime2), 615248, N'Przerwa', 10)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (9, CAST(N'2019-07-16T14:55:00.0000000' AS DateTime2), 615288, N'Dojazd do Celu ', 10)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (10, CAST(N'2019-07-13T17:05:00.0000000' AS DateTime2), 615363, N'Dojazd do Celu ', 12)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (11, CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), 715512, N'Dojazd do Celu', 14)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (12, CAST(N'2019-07-13T13:43:00.0000000' AS DateTime2), 715581, N'Dojazd do Celu ', 16)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (13, CAST(N'2019-07-13T14:42:00.0000000' AS DateTime2), 715584, N'Przerwa', 18)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (14, CAST(N'2019-07-13T14:42:00.0000000' AS DateTime2), 715584, N'Tankowanie', 18)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (15, CAST(N'2019-07-13T16:55:00.0000000' AS DateTime2), 715655, N'Dojazd do Celu', 18)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (16, CAST(N'2019-07-12T09:51:00.0000000' AS DateTime2), 522218, N'Opóźnienie', 20)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (17, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 522224, N'Dojazd do Celu', 20)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (18, CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), 522328, N'Dojazd do Celu', 22)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (19, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 312233, N'Opóźnienie', 24)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (20, CAST(N'2019-07-12T10:21:00.0000000' AS DateTime2), 312255, N'Dojazd do Celu', 24)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (21, CAST(N'2019-07-12T12:21:00.0000000' AS DateTime2), 312310, N'Tankowanie', 26)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (22, CAST(N'2019-07-12T14:04:01.0000000' AS DateTime2), 312321, N'Dojazd do Celu', 26)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (23, CAST(N'2019-07-13T12:10:12.0000000' AS DateTime2), 410095, N'Dojazd do Celu ', 28)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (24, CAST(N'2019-07-13T10:12:12.0000000' AS DateTime2), 410043, N'Opóźnienie ', 28)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (25, CAST(N'2019-07-13T13:05:12.0000000' AS DateTime2), 410118, N'Opóźnienie ', 30)
INSERT [dbo].[EventsHistoriesContext] ([Id], [Date], [Distance], [Name], [OrderEntryId]) VALUES (26, CAST(N'2019-07-13T15:25:12.0000000' AS DateTime2), 410183, N'Dojazd do Celu', 30)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (1, 50.86103, 20.61154, CAST(N'2019-07-12T08:10:15.0000000' AS DateTime2), 1)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (2, 52.244977, 21.010463, CAST(N'2019-07-12T12:59:00.0000000' AS DateTime2), 1)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (3, 52.541212, 19.733112, CAST(N'2019-07-12T16:01:02.0000000' AS DateTime2), 1)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (4, 52.244977, 21.010463, CAST(N'2019-07-12T17:24:02.0000000' AS DateTime2), 1)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (5, 50.86103, 20.61154, CAST(N'2019-07-13T07:55:15.0000000' AS DateTime2), 2)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (6, 52.244977, 21.010463, CAST(N'2019-07-13T12:02:00.0000000' AS DateTime2), 2)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (7, 52.541212, 19.733112, CAST(N'2019-07-13T14:55:00.0000000' AS DateTime2), 2)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (8, 52.244977, 21.010463, CAST(N'2019-07-13T17:05:00.0000000' AS DateTime2), 2)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (9, 50.86103, 20.61154, CAST(N'2019-07-13T07:05:15.0000000' AS DateTime2), 3)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (10, 52.244977, 21.010463, CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), 3)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (11, 52.541212, 19.733112, CAST(N'2019-07-13T13:43:00.0000000' AS DateTime2), 3)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (12, 52.244977, 21.010463, CAST(N'2019-07-13T16:55:00.0000000' AS DateTime2), 3)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (13, 50.86103, 20.61154, CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), 4)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (14, 50.061389, 19.938333, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 4)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (15, 50.86103, 20.61154, CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), 4)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (16, 50.86103, 20.61154, CAST(N'2019-07-12T07:21:12.0000000' AS DateTime2), 5)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (17, 50.061389, 19.938333, CAST(N'2019-07-12T10:21:00.0000000' AS DateTime2), 5)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (18, 50.86103, 20.61154, CAST(N'2019-07-12T14:04:01.0000000' AS DateTime2), 5)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (19, 50.86103, 20.61154, CAST(N'2019-07-13T08:11:12.0000000' AS DateTime2), 6)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (20, 50.061389, 19.938333, CAST(N'2019-07-13T12:10:12.0000000' AS DateTime2), 6)
INSERT [dbo].[LocationsHistoriesContext] ([Id], [Longitude], [LatitudeL], [Date], [Orderid]) VALUES (21, 50.86103, 20.61154, CAST(N'2019-07-13T15:25:12.0000000' AS DateTime2), 6)
INSERT [dbo].[OrdersContext] ([Id], [Number]) VALUES (1, N'13/07/2019')
INSERT [dbo].[OrdersContext] ([Id], [Number]) VALUES (2, N'12/07/2019')
INSERT [dbo].[OrdersContext] ([Id], [Number]) VALUES (3, N'24/07/2019')
INSERT [dbo].[OrdersContext] ([Id], [Number]) VALUES (4, N'20/08/2019')
INSERT [dbo].[OrdersContext] ([Id], [Number]) VALUES (5, N'22/07/2019')
INSERT [dbo].[OrdersContext] ([Id], [Number]) VALUES (6, N'25/07/2019')
INSERT [dbo].[OrdersContext] ([Id], [Number]) VALUES (7, N'18/07/2019')
INSERT [dbo].[OrdersContext] ([Id], [Number]) VALUES (8, N'14/07/2019')
INSERT [dbo].[OrdersContext] ([Id], [Number]) VALUES (9, N'29/08/2019')
INSERT [dbo].[OrdersContext] ([Id], [Number]) VALUES (10, N'16/07/2019')
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (1, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-12T08:10:15.0000000' AS DateTime2), CAST(N'2019-07-12T08:00:51.0000000' AS DateTime2), CAST(N'2019-07-12T08:10:15.0000000' AS DateTime2), N'europalety x6', N'Załadunek na rampie B', 2, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (2, N'Rozładunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-12T12:30:00.0000000' AS DateTime2), CAST(N'2019-07-12T12:30:00.0000000' AS DateTime2), CAST(N'2019-07-12T12:52:00.0000000' AS DateTime2), N'europalety x6 ', N'Rozładunek ', 2, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (3, N'Załadunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-12T12:59:00.0000000' AS DateTime2), CAST(N'2019-07-12T12:59:00.0000000' AS DateTime2), CAST(N'2019-07-12T13:22:00.0000000' AS DateTime2), N'kartongips', N'brak', 2, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (4, N'Rozładunek', N'Płock, ul. Kościuszki 3', CAST(N'2019-07-12T15:43:00.0000000' AS DateTime2), CAST(N'2019-07-12T15:23:00.0000000' AS DateTime2), CAST(N'2019-07-12T15:56:00.0000000' AS DateTime2), N'kartongips', N'brak', 2, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (5, N'Załadunek', N'Płock, ul.Kościuszki 5', CAST(N'2019-07-12T16:01:02.0000000' AS DateTime2), CAST(N'2019-07-12T16:01:02.0000000' AS DateTime2), CAST(N'2019-07-12T16:11:02.0000000' AS DateTime2), N'styropian', N'brak', 0, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (6, N'Rozładunek', N'Warszawa, ul.Długa 6', CAST(N'2019-07-12T17:54:02.0000000' AS DateTime2), CAST(N'2019-07-12T17:44:02.0000000' AS DateTime2), CAST(N'2019-07-12T18:04:02.0000000' AS DateTime2), N'styropian', N'brak', 1, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (7, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-13T07:25:15.0000000' AS DateTime2), CAST(N'2019-07-13T07:25:15.0000000' AS DateTime2), CAST(N'2019-07-13T07:55:15.0000000' AS DateTime2), N'styropian', N'Załadunek na rampie C', 2, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (8, N'Rozładunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-13T11:44:00.0000000' AS DateTime2), CAST(N'2019-07-13T11:44:00.0000000' AS DateTime2), CAST(N'2019-07-13T12:02:00.0000000' AS DateTime2), N'styropian', N'Rozładunek przy hali ', 2, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (9, N'Załadunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-13T12:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T12:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T12:25:00.0000000' AS DateTime2), N'klinkier', N'brak', 2, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (10, N'Rozładunek', N'Płock, ul. Kościuszki 3', CAST(N'2019-07-13T14:55:00.0000000' AS DateTime2), CAST(N'2019-07-13T14:55:00.0000000' AS DateTime2), CAST(N'2019-07-13T15:25:00.0000000' AS DateTime2), N'klinkier', N'brak', 2, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (11, N'Załadunek', N'Płock, ul.Kościuszki 5', CAST(N'2019-07-13T15:35:00.0000000' AS DateTime2), CAST(N'2019-07-13T15:35:00.0000000' AS DateTime2), CAST(N'2019-07-13T15:45:00.0000000' AS DateTime2), N'cement x8', N'brak', 0, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (12, N'Rozładunek', N'Warszawa, ul.Długa 6', CAST(N'2019-07-13T17:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T17:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T17:15:00.0000000' AS DateTime2), N'cement x8', N'brak', 1, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (13, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-13T07:05:15.0000000' AS DateTime2), CAST(N'2019-07-13T07:05:15.0000000' AS DateTime2), CAST(N'2019-07-13T07:32:11.0000000' AS DateTime2), N'cement x12', N'Załadunek na rampie C', 2, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (14, N'Rozładunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), CAST(N'2019-07-13T10:54:00.0000000' AS DateTime2), N'cement x12', N'brak ', 2, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (15, N'Załadunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-13T11:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T11:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T11:25:00.0000000' AS DateTime2), N'europalety x6 ', N'brak', 2, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (16, N'Rozładunek', N'Płock, ul. Kościuszki 3', CAST(N'2019-07-13T13:43:00.0000000' AS DateTime2), CAST(N'2019-07-13T13:43:00.0000000' AS DateTime2), CAST(N'2019-07-13T14:03:00.0000000' AS DateTime2), N'europalety x6 ', N'brak', 2, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (17, N'Załadunek', N'Płock, ul.Kościuszki 5', CAST(N'2019-07-13T14:20:00.0000000' AS DateTime2), CAST(N'2019-07-13T14:20:00.0000000' AS DateTime2), CAST(N'2019-07-13T14:26:00.0000000' AS DateTime2), N'styropian', N'brak', 2, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (18, N'Rozładunek', N'Warszawa, ul.Długa 6', CAST(N'2019-07-13T16:55:00.0000000' AS DateTime2), CAST(N'2019-07-13T16:55:00.0000000' AS DateTime2), CAST(N'2019-07-13T17:11:00.0000000' AS DateTime2), N'styropian', N'brak', 1, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (19, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), CAST(N'2019-07-12T07:58:12.0000000' AS DateTime2), N'kartongips', N'Załadunek na rampie A', 2, 4)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (20, N'Rozładunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), CAST(N'2019-07-12T10:14:00.0000000' AS DateTime2), N'kartongips', N'Rozładunek ', 2, 4)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (21, N'Załadunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-12T10:31:00.0000000' AS DateTime2), CAST(N'2019-07-12T10:31:00.0000000' AS DateTime2), CAST(N'2019-07-12T11:00:00.0000000' AS DateTime2), N'europalety x6 ', N'brak', 2, 4)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (22, N'Rozładunek', N'Kielce, ul. Kielecka 30', CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), CAST(N'2019-07-12T14:44:31.0000000' AS DateTime2), N'europalety x6', N'brak', 2, 4)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (23, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-12T07:21:12.0000000' AS DateTime2), CAST(N'2019-07-12T07:21:12.0000000' AS DateTime2), CAST(N'2019-07-12T07:38:12.0000000' AS DateTime2), N'styropian', N'Załadunek przy hali', 2, 5)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (24, N'Rozładunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-12T10:21:00.0000000' AS DateTime2), CAST(N'2019-07-12T10:21:00.0000000' AS DateTime2), CAST(N'2019-07-12T10:41:00.0000000' AS DateTime2), N'styropian', N'brak', 2, 5)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (25, N'Załadunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-12T10:59:00.0000000' AS DateTime2), CAST(N'2019-07-12T11:29:00.0000000' AS DateTime2), CAST(N'2019-07-12T11:42:00.0000000' AS DateTime2), N'europalety x6 ', N'brak', 2, 5)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (26, N'Rozładunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-12T14:04:01.0000000' AS DateTime2), CAST(N'2019-07-12T14:04:01.0000000' AS DateTime2), CAST(N'2019-07-12T14:24:01.0000000' AS DateTime2), N'europalety x6', N'brak', 2, 5)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (27, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-13T08:11:12.0000000' AS DateTime2), CAST(N'2019-07-13T08:11:12.0000000' AS DateTime2), CAST(N'2019-07-13T08:32:12.0000000' AS DateTime2), N'cement x8', N'Załadunek przy hali', 2, 6)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (28, N'Rozładunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-13T12:10:12.0000000' AS DateTime2), CAST(N'2019-07-13T12:10:12.0000000' AS DateTime2), CAST(N'2019-07-13T12:30:12.0000000' AS DateTime2), N'cement x8', N'brak', 2, 6)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (29, N'Załadunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-13T12:30:12.0000000' AS DateTime2), CAST(N'2019-07-13T12:30:12.0000000' AS DateTime2), CAST(N'2019-07-13T12:45:12.0000000' AS DateTime2), N'klinkier', N'brak', 2, 6)
INSERT [dbo].[OrdersEntriesContext] ([Id], [OrderType], [Location], [Date], [FromTime], [ToTime], [Cargo], [Comments], [Status], [Orderid]) VALUES (30, N'Rozładunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-13T15:25:12.0000000' AS DateTime2), CAST(N'2019-07-13T15:25:12.0000000' AS DateTime2), CAST(N'2019-07-13T15:41:12.0000000' AS DateTime2), N'klinkier', N'brak', 2, 6)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (1, N'2', CAST(N'2019-07-12T08:10:15.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (2, N'3', CAST(N'2019-07-12T16:32:03.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (3, N'3', CAST(N'2019-07-12T16:32:03.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (4, N'0', CAST(N'2019-07-12T13:22:00.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (5, N'2', CAST(N'2019-07-12T15:56:00.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (6, N'0', CAST(N'2019-07-12T16:11:02.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (7, N'2', CAST(N'2019-07-12T18:04:02.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (8, N'2', CAST(N'2019-07-13T07:55:15.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (9, N'2', CAST(N'2019-07-13T12:02:00.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (10, N'2', CAST(N'2019-07-13T12:25:00.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (11, N'2', CAST(N'2019-07-13T15:25:00.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (12, N'0', CAST(N'2019-07-13T15:45:00.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (13, N'2', CAST(N'2019-07-13T15:45:00.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (14, N'0', CAST(N'2019-07-13T07:32:11.0000000' AS DateTime2), 3)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (15, N'2', CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), 3)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (16, N'0', CAST(N'2019-07-13T11:25:00.0000000' AS DateTime2), 3)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (17, N'2', CAST(N'2019-07-13T13:43:00.0000000' AS DateTime2), 3)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (18, N'0', CAST(N'2019-07-13T14:26:00.0000000' AS DateTime2), 3)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (19, N'0', CAST(N'2019-07-12T07:58:12.0000000' AS DateTime2), 4)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (20, N'2', CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 4)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (21, N'0', CAST(N'2019-07-12T11:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (22, N'2', CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), 4)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (23, N'0', CAST(N'2019-07-12T07:38:12.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (24, N'2', CAST(N'2019-07-12T10:21:00.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (25, N'3', CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (26, N'0', CAST(N'2019-07-12T11:42:00.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (27, N'3', CAST(N'2019-07-12T13:04:01.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (28, N'2', CAST(N'2019-07-12T14:24:01.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (29, N'0', CAST(N'2019-07-13T08:11:12.0000000' AS DateTime2), 6)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (30, N'3', CAST(N'2019-07-13T10:12:12.0000000' AS DateTime2), 6)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (31, N'1', CAST(N'2019-07-13T10:12:12.0000000' AS DateTime2), 6)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (32, N'3', CAST(N'2019-07-13T13:05:12.0000000' AS DateTime2), 6)
INSERT [dbo].[OrdersStatesContext] ([Id], [State], [Date], [Orderid]) VALUES (33, N'2', CAST(N'2019-07-13T15:25:12.0000000' AS DateTime2), 6)
ALTER TABLE [dbo].[DelaysContext]  WITH CHECK ADD  CONSTRAINT [FK_DelaysContext_OrdersEntriesContext_OrderEntryId] FOREIGN KEY([OrderEntryId])
REFERENCES [dbo].[OrdersEntriesContext] ([Id])
GO
ALTER TABLE [dbo].[DelaysContext] CHECK CONSTRAINT [FK_DelaysContext_OrdersEntriesContext_OrderEntryId]
GO
ALTER TABLE [dbo].[EventsHistoriesContext]  WITH CHECK ADD  CONSTRAINT [FK_EventsHistoriesContext_OrdersEntriesContext_OrderEntryId] FOREIGN KEY([OrderEntryId])
REFERENCES [dbo].[OrdersEntriesContext] ([Id])
GO
ALTER TABLE [dbo].[EventsHistoriesContext] CHECK CONSTRAINT [FK_EventsHistoriesContext_OrdersEntriesContext_OrderEntryId]
GO
ALTER TABLE [dbo].[LocationsHistoriesContext]  WITH CHECK ADD  CONSTRAINT [FK_LocationsHistoriesContext_OrdersContext_orderid] FOREIGN KEY([Orderid])
REFERENCES [dbo].[OrdersContext] ([Id])
GO
ALTER TABLE [dbo].[LocationsHistoriesContext] CHECK CONSTRAINT [FK_LocationsHistoriesContext_OrdersContext_orderid]
GO
ALTER TABLE [dbo].[OrdersEntriesContext]  WITH CHECK ADD  CONSTRAINT [FK_OrdersEntriesContext_OrdersContext_orderid] FOREIGN KEY([Orderid])
REFERENCES [dbo].[OrdersContext] ([Id])
GO
ALTER TABLE [dbo].[OrdersEntriesContext] CHECK CONSTRAINT [FK_OrdersEntriesContext_OrdersContext_orderid]
GO
ALTER TABLE [dbo].[OrdersStatesContext]  WITH CHECK ADD  CONSTRAINT [FK_OrdersStatesContext_OrdersContext_orderid] FOREIGN KEY([Orderid])
REFERENCES [dbo].[OrdersContext] ([Id])
GO
ALTER TABLE [dbo].[OrdersStatesContext] CHECK CONSTRAINT [FK_OrdersStatesContext_OrdersContext_orderid]
GO

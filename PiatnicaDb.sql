USE [Piatnica]
GO
/****** Object:  Table [dbo].[DelaysContext]    Script Date: 2019-07-15 13:27:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DelaysContext](
	[id] [int] NOT NULL,
	[delayOrder] [int] NOT NULL,
	[date] [datetime2](7) NOT NULL,
	[OrderEntryId] [int] NULL,
 CONSTRAINT [PK_DelaysContext] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DistancesHistoryContext]    Script Date: 2019-07-15 13:27:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DistancesHistoryContext](
	[id] [int] NOT NULL,
	[distance] [float] NOT NULL,
	[date] [datetime2](7) NOT NULL,
	[orderid] [int] NULL,
 CONSTRAINT [PK_DistancesHistoryContext] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventsContext]    Script Date: 2019-07-15 13:27:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventsContext](
	[id] [int] NOT NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_EventsContext] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventsHistoriesContext]    Script Date: 2019-07-15 13:27:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventsHistoriesContext](
	[id] [int] NOT NULL,
	[date] [datetime2](7) NOT NULL,
	[Eventid] [int] NULL,
	[OrderEntryId] [int] NULL,
 CONSTRAINT [PK_EventsHistoriesContext] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LocationsHistoriesContext]    Script Date: 2019-07-15 13:27:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocationsHistoriesContext](
	[id] [int] NOT NULL,
	[longitude] [float] NOT NULL,
	[latitudeL] [float] NOT NULL,
	[date] [datetime2](7) NOT NULL,
	[orderid] [int] NULL,
 CONSTRAINT [PK_LocationsHistoriesContext] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersContext]    Script Date: 2019-07-15 13:27:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersContext](
	[id] [int] NOT NULL,
	[number] [nvarchar](max) NULL,
 CONSTRAINT [PK_OrdersContext] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersEntriesContext]    Script Date: 2019-07-15 13:27:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersEntriesContext](
	[Id] [int] NOT NULL,
	[orderType] [nvarchar](max) NULL,
	[location] [nvarchar](max) NULL,
	[date] [datetime2](7) NOT NULL,
	[fromTime] [datetime2](7) NOT NULL,
	[toTime] [datetime2](7) NOT NULL,
	[cargo] [nvarchar](max) NULL,
	[comments] [nvarchar](max) NULL,
	[status] [int] NOT NULL,
	[orderid] [int] NULL,
 CONSTRAINT [PK_OrdersEntriesContext] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersStatesContext]    Script Date: 2019-07-15 13:27:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersStatesContext](
	[id] [int] NOT NULL,
	[state] [nvarchar](max) NULL,
	[date] [datetime2](7) NOT NULL,
	[orderid] [int] NULL,
 CONSTRAINT [PK_OrdersStatesContext] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[DelaysContext] ([id], [delayOrder], [date], [OrderEntryId]) VALUES (1, 21, CAST(N'2019-07-12T15:33:00.0000000' AS DateTime2), 4)
INSERT [dbo].[DelaysContext] ([id], [delayOrder], [date], [OrderEntryId]) VALUES (2, 30, CAST(N'2019-07-12T17:24:01.0000000' AS DateTime2), 6)
INSERT [dbo].[DelaysContext] ([id], [delayOrder], [date], [OrderEntryId]) VALUES (3, 27, CAST(N'2019-07-13T14:55:00.0000000' AS DateTime2), 10)
INSERT [dbo].[DelaysContext] ([id], [delayOrder], [date], [OrderEntryId]) VALUES (4, 32, CAST(N'2019-07-13T16:55:00.0000000' AS DateTime2), 18)
INSERT [dbo].[DelaysContext] ([id], [delayOrder], [date], [OrderEntryId]) VALUES (5, 20, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 20)
INSERT [dbo].[DelaysContext] ([id], [delayOrder], [date], [OrderEntryId]) VALUES (6, 15, CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), 22)
INSERT [dbo].[DelaysContext] ([id], [delayOrder], [date], [OrderEntryId]) VALUES (7, 22, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 24)
INSERT [dbo].[DelaysContext] ([id], [delayOrder], [date], [OrderEntryId]) VALUES (8, 15, CAST(N'2019-07-12T12:21:00.0000000' AS DateTime2), 26)
INSERT [dbo].[DelaysContext] ([id], [delayOrder], [date], [OrderEntryId]) VALUES (9, 48, CAST(N'2019-07-13T10:12:12.0000000' AS DateTime2), 28)
INSERT [dbo].[DelaysContext] ([id], [delayOrder], [date], [OrderEntryId]) VALUES (10, 33, CAST(N'2019-07-13T13:05:12.0000000' AS DateTime2), 30)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (1, 534212, CAST(N'2019-07-12T12:30:00.0000000' AS DateTime2), 1)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (2, 534242, CAST(N'2019-07-12T14:23:00.0000000' AS DateTime2), 1)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (3, 534282, CAST(N'2019-07-12T15:33:00.0000000' AS DateTime2), 1)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (4, 534324, CAST(N'2019-07-12T16:30:03.0000000' AS DateTime2), 1)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (5, 534326, CAST(N'2019-07-12T16:32:03.0000000' AS DateTime2), 1)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (6, 534356, CAST(N'2019-07-12T17:54:02.0000000' AS DateTime2), 1)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (7, 615215, CAST(N'2019-07-13T11:44:00.0000000' AS DateTime2), 2)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (8, 615235, CAST(N'2019-07-13T13:35:00.0000000' AS DateTime2), 2)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (9, 615288, CAST(N'2019-07-13T13:55:00.0000000' AS DateTime2), 2)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (10, 615363, CAST(N'2019-07-13T17:05:00.0000000' AS DateTime2), 2)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (11, 715512, CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), 3)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (12, 715581, CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), 3)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (13, 715584, CAST(N'2019-07-13T14:42:00.0000000' AS DateTime2), 3)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (14, 715584, CAST(N'2019-07-13T14:42:00.0000000' AS DateTime2), 3)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (15, 715655, CAST(N'2019-07-13T16:55:00.0000000' AS DateTime2), 3)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (16, 522144, CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), 4)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (17, 522224, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 4)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (18, 522328, CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), 4)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (19, 312223, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 5)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (20, 312255, CAST(N'2019-07-12T10:21:00.0000000' AS DateTime2), 5)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (21, 312310, CAST(N'2019-07-12T12:21:00.0000000' AS DateTime2), 5)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (22, 312321, CAST(N'2019-07-12T14:04:01.0000000' AS DateTime2), 5)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (23, 410043, CAST(N'2019-07-13T10:12:12.0000000' AS DateTime2), 6)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (24, 410095, CAST(N'2019-07-13T12:10:12.0000000' AS DateTime2), 6)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (25, 410118, CAST(N'2019-07-13T13:05:12.0000000' AS DateTime2), 6)
INSERT [dbo].[DistancesHistoryContext] ([id], [distance], [date], [orderid]) VALUES (26, 410183, CAST(N'2019-07-13T15:25:12.0000000' AS DateTime2), 6)
INSERT [dbo].[EventsContext] ([id], [name]) VALUES (1, N'Dojazd do Celu')
INSERT [dbo].[EventsContext] ([id], [name]) VALUES (2, N'Przerwa')
INSERT [dbo].[EventsContext] ([id], [name]) VALUES (3, N'Opóźnienie')
INSERT [dbo].[EventsContext] ([id], [name]) VALUES (4, N'Tankowanie')
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (1, CAST(N'2019-07-12T12:30:00.0000000' AS DateTime2), 1, 2)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (2, CAST(N'2019-07-12T15:43:00.0000000' AS DateTime2), 1, 4)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (3, CAST(N'2019-07-12T17:24:02.0000000' AS DateTime2), 1, 6)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (4, CAST(N'2019-07-13T11:44:00.0000000' AS DateTime2), 1, 8)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (5, CAST(N'2019-07-13T14:55:00.0000000' AS DateTime2), 1, 10)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (6, CAST(N'2019-07-13T17:05:00.0000000' AS DateTime2), 1, 12)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (7, CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), 1, 14)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (8, CAST(N'2019-07-13T13:43:00.0000000' AS DateTime2), 1, 16)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (9, CAST(N'2019-07-13T16:55:00.0000000' AS DateTime2), 1, 18)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (10, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 1, 20)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (11, CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), 1, 22)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (12, CAST(N'2019-07-12T09:51:00.0000000' AS DateTime2), 3, 20)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (13, CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), 3, 22)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (14, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 3, 24)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (15, CAST(N'2019-07-12T12:21:00.0000000' AS DateTime2), 4, 26)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (16, CAST(N'2019-07-12T14:04:01.0000000' AS DateTime2), 1, 26)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (17, CAST(N'2019-07-12T10:21:00.0000000' AS DateTime2), 1, 24)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (18, CAST(N'2019-07-15T14:23:00.0000000' AS DateTime2), 2, 2)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (19, CAST(N'2019-07-15T14:23:00.0000000' AS DateTime2), 3, 4)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (20, CAST(N'2019-07-12T16:32:03.0000000' AS DateTime2), 4, 4)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (21, CAST(N'2019-07-13T13:35:00.0000000' AS DateTime2), 4, 10)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (22, CAST(N'2019-07-13T13:55:00.0000000' AS DateTime2), 2, 10)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (23, CAST(N'2019-07-13T14:42:00.0000000' AS DateTime2), 2, 12)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (24, CAST(N'2019-07-13T14:42:00.0000000' AS DateTime2), 4, 12)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (26, CAST(N'2019-07-13T15:25:12.0000000' AS DateTime2), 3, 28)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (27, CAST(N'2019-07-13T12:10:12.0000000' AS DateTime2), 1, 28)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (28, CAST(N'2019-07-13T13:05:12.0000000' AS DateTime2), 2, 30)
INSERT [dbo].[EventsHistoriesContext] ([id], [date], [Eventid], [OrderEntryId]) VALUES (29, CAST(N'2019-07-13T15:25:12.0000000' AS DateTime2), 1, 30)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (1, 50.86103, 20.61154, CAST(N'2019-07-12T08:10:15.0000000' AS DateTime2), 1)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (2, 52.244977, 21.010463, CAST(N'2019-07-12T12:59:00.0000000' AS DateTime2), 1)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (3, 52.541212, 19.733112, CAST(N'2019-07-12T16:01:02.0000000' AS DateTime2), 1)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (4, 52.244977, 21.010463, CAST(N'2019-07-12T17:24:02.0000000' AS DateTime2), 1)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (5, 50.86103, 20.61154, CAST(N'2019-07-13T07:55:15.0000000' AS DateTime2), 2)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (6, 52.244977, 21.010463, CAST(N'2019-07-13T12:02:00.0000000' AS DateTime2), 2)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (7, 52.541212, 19.733112, CAST(N'2019-07-13T14:55:00.0000000' AS DateTime2), 2)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (8, 52.244977, 21.010463, CAST(N'2019-07-13T17:05:00.0000000' AS DateTime2), 2)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (9, 50.86103, 20.61154, CAST(N'2019-07-13T07:05:15.0000000' AS DateTime2), 3)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (10, 52.244977, 21.010463, CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), 3)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (11, 52.541212, 19.733112, CAST(N'2019-07-13T13:43:00.0000000' AS DateTime2), 3)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (12, 52.244977, 21.010463, CAST(N'2019-07-13T16:55:00.0000000' AS DateTime2), 3)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (13, 50.86103, 20.61154, CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), 4)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (14, 50.061389, 19.938333, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 4)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (15, 50.86103, 20.61154, CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), 4)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (16, 50.86103, 20.61154, CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), 5)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (17, 50.061389, 19.938333, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 5)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (18, 50.86103, 20.61154, CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), 5)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (19, 50.86103, 20.61154, CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), 6)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (20, 50.061389, 19.938333, CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 6)
INSERT [dbo].[LocationsHistoriesContext] ([id], [longitude], [latitudeL], [date], [orderid]) VALUES (21, 50.86103, 20.61154, CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), 6)
INSERT [dbo].[OrdersContext] ([id], [number]) VALUES (1, N'13/07/2019')
INSERT [dbo].[OrdersContext] ([id], [number]) VALUES (2, N'12/07/2019')
INSERT [dbo].[OrdersContext] ([id], [number]) VALUES (3, N'24/07/2019')
INSERT [dbo].[OrdersContext] ([id], [number]) VALUES (4, N'20/08/2019')
INSERT [dbo].[OrdersContext] ([id], [number]) VALUES (5, N'22/07/2019')
INSERT [dbo].[OrdersContext] ([id], [number]) VALUES (6, N'25/07/2019')
INSERT [dbo].[OrdersContext] ([id], [number]) VALUES (7, N'18/07/2019')
INSERT [dbo].[OrdersContext] ([id], [number]) VALUES (8, N'14/07/2019')
INSERT [dbo].[OrdersContext] ([id], [number]) VALUES (9, N'29/08/2019')
INSERT [dbo].[OrdersContext] ([id], [number]) VALUES (10, N'16/07/2019')
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (1, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-12T08:10:15.0000000' AS DateTime2), CAST(N'2019-07-12T08:00:51.0000000' AS DateTime2), CAST(N'2019-07-12T08:10:15.0000000' AS DateTime2), N'europalety x6', N'Załadunek na rampie B', 2, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (2, N'Rozładunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-12T12:30:00.0000000' AS DateTime2), CAST(N'2019-07-12T12:30:00.0000000' AS DateTime2), CAST(N'2019-07-12T12:52:00.0000000' AS DateTime2), N'europalety x6 ', N'Rozładunek ', 2, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (3, N'Załadunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-12T12:59:00.0000000' AS DateTime2), CAST(N'2019-07-12T12:59:00.0000000' AS DateTime2), CAST(N'2019-07-12T13:22:00.0000000' AS DateTime2), N'kartongips', N'brak', 2, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (4, N'Rozładunek', N'Płock, ul. Kościuszki 3', CAST(N'2019-07-12T15:43:00.0000000' AS DateTime2), CAST(N'2019-07-12T15:23:00.0000000' AS DateTime2), CAST(N'2019-07-12T15:56:00.0000000' AS DateTime2), N'kartongips', N'brak', 2, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (5, N'Załadunek', N'Płock, ul.Kościuszki 5', CAST(N'2019-07-12T16:01:02.0000000' AS DateTime2), CAST(N'2019-07-12T16:01:02.0000000' AS DateTime2), CAST(N'2019-07-12T16:11:02.0000000' AS DateTime2), N'styropian', N'brak', 0, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (6, N'Rozładunek', N'Warszawa, ul.Długa 6', CAST(N'2019-07-12T17:54:02.0000000' AS DateTime2), CAST(N'2019-07-12T17:44:02.0000000' AS DateTime2), CAST(N'2019-07-12T18:04:02.0000000' AS DateTime2), N'styropian', N'brak', 1, 1)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (7, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-13T07:25:15.0000000' AS DateTime2), CAST(N'2019-07-13T07:25:15.0000000' AS DateTime2), CAST(N'2019-07-13T07:55:15.0000000' AS DateTime2), N'styropian', N'Załadunek na rampie C', 2, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (8, N'Rozładunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-13T11:44:00.0000000' AS DateTime2), CAST(N'2019-07-13T11:44:00.0000000' AS DateTime2), CAST(N'2019-07-13T12:02:00.0000000' AS DateTime2), N'styropian', N'Rozładunek przy hali ', 2, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (9, N'Załadunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-13T12:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T12:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T12:25:00.0000000' AS DateTime2), N'klinkier', N'brak', 2, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (10, N'Rozładunek', N'Płock, ul. Kościuszki 3', CAST(N'2019-07-13T14:55:00.0000000' AS DateTime2), CAST(N'2019-07-13T14:55:00.0000000' AS DateTime2), CAST(N'2019-07-13T15:25:00.0000000' AS DateTime2), N'klinkier', N'brak', 2, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (11, N'Załadunek', N'Płock, ul.Kościuszki 5', CAST(N'2019-07-13T15:35:00.0000000' AS DateTime2), CAST(N'2019-07-13T15:35:00.0000000' AS DateTime2), CAST(N'2019-07-13T15:45:00.0000000' AS DateTime2), N'cement x8', N'brak', 0, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (12, N'Rozładunek', N'Warszawa, ul.Długa 6', CAST(N'2019-07-13T17:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T17:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T17:15:00.0000000' AS DateTime2), N'cement x8', N'brak', 1, 2)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (13, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-13T07:05:15.0000000' AS DateTime2), CAST(N'2019-07-13T07:05:15.0000000' AS DateTime2), CAST(N'2019-07-13T07:32:11.0000000' AS DateTime2), N'cement x12', N'Załadunek na rampie C', 2, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (14, N'Rozładunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), CAST(N'2019-07-13T10:54:00.0000000' AS DateTime2), N'cement x12', N'brak ', 2, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (15, N'Załadunek', N'Warszawa, ul. Długa 10', CAST(N'2019-07-13T11:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T11:05:00.0000000' AS DateTime2), CAST(N'2019-07-13T11:25:00.0000000' AS DateTime2), N'europalety x6 ', N'brak', 2, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (16, N'Rozładunek', N'Płock, ul. Kościuszki 3', CAST(N'2019-07-13T13:43:00.0000000' AS DateTime2), CAST(N'2019-07-13T13:43:00.0000000' AS DateTime2), CAST(N'2019-07-13T14:03:00.0000000' AS DateTime2), N'europalety x6 ', N'brak', 2, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (17, N'Załadunek', N'Płock, ul.Kościuszki 5', CAST(N'2019-07-13T14:20:00.0000000' AS DateTime2), CAST(N'2019-07-13T14:20:00.0000000' AS DateTime2), CAST(N'2019-07-13T14:26:00.0000000' AS DateTime2), N'styropian', N'brak', 2, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (18, N'Rozładunek', N'Warszawa, ul.Długa 6', CAST(N'2019-07-13T16:55:00.0000000' AS DateTime2), CAST(N'2019-07-13T16:55:00.0000000' AS DateTime2), CAST(N'2019-07-13T17:11:00.0000000' AS DateTime2), N'styropian', N'brak', 1, 3)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (19, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), CAST(N'2019-07-12T07:41:12.0000000' AS DateTime2), CAST(N'2019-07-12T07:58:12.0000000' AS DateTime2), N'kartongips', N'Załadunek na rampie A', 2, 4)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (20, N'Rozładunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), CAST(N'2019-07-12T10:14:00.0000000' AS DateTime2), N'kartongips', N'Rozładunek ', 2, 4)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (21, N'Załadunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-12T10:31:00.0000000' AS DateTime2), CAST(N'2019-07-12T10:31:00.0000000' AS DateTime2), CAST(N'2019-07-12T11:00:00.0000000' AS DateTime2), N'europalety x6 ', N'brak', 2, 4)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (22, N'Rozładunek', N'Kielce, ul. Kielecka 30', CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), CAST(N'2019-07-12T14:44:31.0000000' AS DateTime2), N'europalety x6', N'brak', 2, 4)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (23, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-12T07:21:12.0000000' AS DateTime2), CAST(N'2019-07-12T07:21:12.0000000' AS DateTime2), CAST(N'2019-07-12T07:38:12.0000000' AS DateTime2), N'styropian', N'Załadunek przy hali', 2, 5)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (24, N'Rozładunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-12T10:21:00.0000000' AS DateTime2), CAST(N'2019-07-12T10:21:00.0000000' AS DateTime2), CAST(N'2019-07-12T10:41:00.0000000' AS DateTime2), N'styropian', N'brak', 2, 5)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (25, N'Załadunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-12T10:59:00.0000000' AS DateTime2), CAST(N'2019-07-12T11:29:00.0000000' AS DateTime2), CAST(N'2019-07-12T11:42:00.0000000' AS DateTime2), N'europalety x6 ', N'brak', 2, 5)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (26, N'Rozładunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-12T14:04:01.0000000' AS DateTime2), CAST(N'2019-07-12T14:04:01.0000000' AS DateTime2), CAST(N'2019-07-12T14:24:01.0000000' AS DateTime2), N'europalety x6', N'brak', 2, 5)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (27, N'Załadunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-13T08:11:12.0000000' AS DateTime2), CAST(N'2019-07-13T08:11:12.0000000' AS DateTime2), CAST(N'2019-07-13T08:32:12.0000000' AS DateTime2), N'cement x8', N'Załadunek przy hali', 2, 6)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (28, N'Rozładunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-13T12:10:12.0000000' AS DateTime2), CAST(N'2019-07-13T12:10:12.0000000' AS DateTime2), CAST(N'2019-07-13T12:30:12.0000000' AS DateTime2), N'cement x8', N'brak', 2, 6)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (29, N'Załadunek', N'Kraków, ul. Kielecka 30', CAST(N'2019-07-13T12:30:12.0000000' AS DateTime2), CAST(N'2019-07-13T12:30:12.0000000' AS DateTime2), CAST(N'2019-07-13T12:45:12.0000000' AS DateTime2), N'klinkier', N'brak', 2, 6)
INSERT [dbo].[OrdersEntriesContext] ([Id], [orderType], [location], [date], [fromTime], [toTime], [cargo], [comments], [status], [orderid]) VALUES (30, N'Rozładunek', N'Kielce, Karola Olszewskiego 6', CAST(N'2019-07-13T15:25:12.0000000' AS DateTime2), CAST(N'2019-07-13T15:25:12.0000000' AS DateTime2), CAST(N'2019-07-13T15:41:12.0000000' AS DateTime2), N'klinkier', N'brak', 2, 6)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (1, N'2', CAST(N'2019-07-12T08:10:15.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (2, N'3', CAST(N'2019-07-12T16:32:03.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (3, N'3', CAST(N'2019-07-12T16:32:03.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (4, N'0', CAST(N'2019-07-12T13:22:00.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (5, N'2', CAST(N'2019-07-12T15:56:00.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (6, N'0', CAST(N'2019-07-12T16:11:02.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (7, N'2', CAST(N'2019-07-12T18:04:02.0000000' AS DateTime2), 1)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (8, N'2', CAST(N'2019-07-13T07:55:15.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (9, N'2', CAST(N'2019-07-13T12:02:00.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (10, N'2', CAST(N'2019-07-13T12:25:00.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (11, N'2', CAST(N'2019-07-13T15:25:00.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (12, N'0', CAST(N'2019-07-13T15:45:00.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (13, N'2', CAST(N'2019-07-13T15:45:00.0000000' AS DateTime2), 2)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (14, N'0', CAST(N'2019-07-13T07:32:11.0000000' AS DateTime2), 3)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (15, N'2', CAST(N'2019-07-13T10:24:00.0000000' AS DateTime2), 3)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (16, N'0', CAST(N'2019-07-13T11:25:00.0000000' AS DateTime2), 3)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (17, N'2', CAST(N'2019-07-13T13:43:00.0000000' AS DateTime2), 3)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (18, N'0', CAST(N'2019-07-13T14:26:00.0000000' AS DateTime2), 3)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (19, N'0', CAST(N'2019-07-12T07:58:12.0000000' AS DateTime2), 4)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (20, N'2', CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 4)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (21, N'0', CAST(N'2019-07-12T11:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (22, N'2', CAST(N'2019-07-12T14:34:01.0000000' AS DateTime2), 4)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (23, N'0', CAST(N'2019-07-12T07:38:12.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (24, N'2', CAST(N'2019-07-12T10:21:00.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (25, N'3', CAST(N'2019-07-12T10:01:00.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (26, N'0', CAST(N'2019-07-12T11:42:00.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (27, N'3', CAST(N'2019-07-12T13:04:01.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (28, N'2', CAST(N'2019-07-12T14:24:01.0000000' AS DateTime2), 5)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (29, N'0', CAST(N'2019-07-13T08:11:12.0000000' AS DateTime2), 6)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (30, N'3', CAST(N'2019-07-13T10:12:12.0000000' AS DateTime2), 6)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (31, N'1', CAST(N'2019-07-13T10:12:12.0000000' AS DateTime2), 6)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (32, N'3', CAST(N'2019-07-13T13:05:12.0000000' AS DateTime2), 6)
INSERT [dbo].[OrdersStatesContext] ([id], [state], [date], [orderid]) VALUES (33, N'2', CAST(N'2019-07-13T15:25:12.0000000' AS DateTime2), 6)
ALTER TABLE [dbo].[DelaysContext]  WITH CHECK ADD  CONSTRAINT [FK_DelaysContext_OrdersEntriesContext_OrderEntryId] FOREIGN KEY([OrderEntryId])
REFERENCES [dbo].[OrdersEntriesContext] ([Id])
GO
ALTER TABLE [dbo].[DelaysContext] CHECK CONSTRAINT [FK_DelaysContext_OrdersEntriesContext_OrderEntryId]
GO
ALTER TABLE [dbo].[DistancesHistoryContext]  WITH CHECK ADD  CONSTRAINT [FK_DistancesHistoryContext_OrdersContext_orderid] FOREIGN KEY([orderid])
REFERENCES [dbo].[OrdersContext] ([id])
GO
ALTER TABLE [dbo].[DistancesHistoryContext] CHECK CONSTRAINT [FK_DistancesHistoryContext_OrdersContext_orderid]
GO
ALTER TABLE [dbo].[EventsHistoriesContext]  WITH CHECK ADD  CONSTRAINT [FK_EventsHistoriesContext_EventsContext_Eventid] FOREIGN KEY([Eventid])
REFERENCES [dbo].[EventsContext] ([id])
GO
ALTER TABLE [dbo].[EventsHistoriesContext] CHECK CONSTRAINT [FK_EventsHistoriesContext_EventsContext_Eventid]
GO
ALTER TABLE [dbo].[EventsHistoriesContext]  WITH CHECK ADD  CONSTRAINT [FK_EventsHistoriesContext_OrdersEntriesContext_OrderEntryId] FOREIGN KEY([OrderEntryId])
REFERENCES [dbo].[OrdersEntriesContext] ([Id])
GO
ALTER TABLE [dbo].[EventsHistoriesContext] CHECK CONSTRAINT [FK_EventsHistoriesContext_OrdersEntriesContext_OrderEntryId]
GO
ALTER TABLE [dbo].[LocationsHistoriesContext]  WITH CHECK ADD  CONSTRAINT [FK_LocationsHistoriesContext_OrdersContext_orderid] FOREIGN KEY([orderid])
REFERENCES [dbo].[OrdersContext] ([id])
GO
ALTER TABLE [dbo].[LocationsHistoriesContext] CHECK CONSTRAINT [FK_LocationsHistoriesContext_OrdersContext_orderid]
GO
ALTER TABLE [dbo].[OrdersEntriesContext]  WITH CHECK ADD  CONSTRAINT [FK_OrdersEntriesContext_OrdersContext_orderid] FOREIGN KEY([orderid])
REFERENCES [dbo].[OrdersContext] ([id])
GO
ALTER TABLE [dbo].[OrdersEntriesContext] CHECK CONSTRAINT [FK_OrdersEntriesContext_OrdersContext_orderid]
GO
ALTER TABLE [dbo].[OrdersStatesContext]  WITH CHECK ADD  CONSTRAINT [FK_OrdersStatesContext_OrdersContext_orderid] FOREIGN KEY([orderid])
REFERENCES [dbo].[OrdersContext] ([id])
GO
ALTER TABLE [dbo].[OrdersStatesContext] CHECK CONSTRAINT [FK_OrdersStatesContext_OrdersContext_orderid]
GO

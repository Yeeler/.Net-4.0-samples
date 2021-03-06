USE [RoomReservations]
GO
/****** Object:  Table [dbo].[RoomReservations]    Script Date: 12/04/2009 22:55:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomReservations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
	[Event] [nvarchar](50) NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[RoomName] [nchar](10) NOT NULL,
 CONSTRAINT [PK_RoomReservations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [LibraryDB]
GO

/****** Object:  Table [dbo].[Author]    Script Date: 07/04/2019 09:03:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Author](
	[Id] [int] IDENTITY(100,10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Nationality] [nvarchar](50) NULL,
	[BirthDay] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


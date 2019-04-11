USE [LibraryDB]
GO

/****** Object:  Table [dbo].[Book]    Script Date: 07/04/2019 09:03:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Book](
	[IsbnCode] [nvarchar](10) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[CoverImage] [varbinary](max) NULL,
	[NbrPages] [int] NULL,
	[ReleaseDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IsbnCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


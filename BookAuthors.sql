USE [LibraryDB]
GO

/****** Object:  Table [dbo].[BookAuthors]    Script Date: 07/04/2019 09:03:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BookAuthors](
	[IsbnCode] [nvarchar](10) NOT NULL,
	[IdAuthor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IsbnCode] ASC,
	[IdAuthor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[BookAuthors]  WITH CHECK ADD  CONSTRAINT [FK_Author_ToBookAuthor1] FOREIGN KEY([IdAuthor])
REFERENCES [dbo].[Author] ([Id])
GO

ALTER TABLE [dbo].[BookAuthors] CHECK CONSTRAINT [FK_Author_ToBookAuthor1]
GO

ALTER TABLE [dbo].[BookAuthors]  WITH CHECK ADD  CONSTRAINT [FK_Book_ToBookAuthor1] FOREIGN KEY([IsbnCode])
REFERENCES [dbo].[Book] ([IsbnCode])
GO

ALTER TABLE [dbo].[BookAuthors] CHECK CONSTRAINT [FK_Book_ToBookAuthor1]
GO


USE [BlogDB]
GO

/****** Object:  Table [dbo].[Post]    Script Date: 29-08-2023 09:43:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Post](
	[PostId] [uniqueidentifier] NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[AuthorId] [varchar](100) NULL,
	[AuthorName] [varchar](100) NULL,
	[Content] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](256) NULL,
	[Creation_Date] [datetime] NOT NULL,
	[Update_Date] [datetime] NOT NULL,
	[Published_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

USE [BlogDB]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 29-08-2023 09:44:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserId] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[FullName] [nvarchar](max) NOT NULL,
	[IsAuthor] [bit] NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[JoinedOn] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Users] ADD  DEFAULT (N'') FOR [FullName]
GO

ALTER TABLE [dbo].[Users] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsAuthor]
GO

ALTER TABLE [dbo].[Users] ADD  DEFAULT (N'') FOR [Password]
GO

ALTER TABLE [dbo].[Users] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [JoinedOn]
GO


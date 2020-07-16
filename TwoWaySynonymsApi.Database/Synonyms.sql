CREATE TABLE [dbo].[Synonyms]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [bit] NOT NULL,
	[Term] [nvarchar](max) NOT NULL,
	[Synonyms] [nvarchar](max) NOT NULL,
)

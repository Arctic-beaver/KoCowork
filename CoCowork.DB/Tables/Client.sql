CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] varchar NOT NULL,
	[DateBirth] DateTime,
	[Email] varchar,
	[Phone] varchar,
	[PaperAmount] int,
	[PaperEndDay] Datetime
)

CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] varchar(30) NOT NULL,
	[DateBirth] date,
	[Email] varchar(30),
	[Phone] varchar(20),
	[PaperAmount] int,
	[PaperEndDay] Datetime
)

CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[FirstName] varchar(20) NOT NULL,
	[LastName] varchar(20) NULL,
	[DateBirth] date,
	[Email] varchar(30),
	[Phone] varchar(20),
	[PaperAmount] int,
	[PaperEndDay] Datetime,
	CONSTRAINT AK_Email UNIQUE(Email),
	CONSTRAINT AK_Phone UNIQUE(Phone)
)

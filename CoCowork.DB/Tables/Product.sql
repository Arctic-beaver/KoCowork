CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] varchar(30) NOT NULL,
	[Amount] int NOT NULL,
	[PriceForOne] int NOT NULL,
	[Description] nvarchar(200) NOT NULL
)

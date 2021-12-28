CREATE TABLE [dbo].[Laptop]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Number] int NOT NULL,
	[Name] varchar(30) NOT NULL,
	[PricePerMonth] decimal(10,2) NOT NULL,
	[Description] nvarchar(200) NOT NULL,
	CONSTRAINT AK_Number UNIQUE(Number)
)

﻿CREATE TABLE [dbo].[Laptop]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] varchar(30) NOT NULL,
	[Amount] int,
	[PricePerMonth] int NOT NULL,
	[Description] nvarchar(200) NOT NULL,
	

)
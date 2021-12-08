﻿CREATE TABLE [dbo].[LaptopOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[LaptopId] int NOT NULL, 
	[OrderId] int NOT NULL,
	[StartDate] datetime NOT NULL,
	[EndDate] datetime NOT NULL,
	[SubtotalPrice] int NOT NULL,
	CONSTRAINT [FK_LaptopId_to_Laptop] FOREIGN KEY ([LaptopId]) REFERENCES [Laptop]([Id])
)

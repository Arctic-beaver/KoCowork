CREATE TABLE [dbo].[LaptopOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[LaptopId] int NOT NULL, 
    FOREIGN KEY (LaptopId) REFERENCES Laptop(Id),
	[OrderId] int NOT NULL,
	[StartDate] datetime NOT NULL,
	[EndDate] datetime NOT NULL,
	[SubtotalPrice] int NOT NULL
)

CREATE TABLE [dbo].[LaptopOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[LaptopId] int NOT NULL, 
	[OrderId] int NOT NULL,
	[StartDate] datetime NOT NULL,
	[EndDate] datetime NOT NULL,
	[SubtotalPrice] decimal(10,2) NOT NULL,
	CONSTRAINT [FK_LaptopId_to_Laptop] FOREIGN KEY ([LaptopId]) REFERENCES [Laptop]([Id]), 
    CONSTRAINT [FK_LaptopOrder_Order] FOREIGN KEY ([OrderId]) REFERENCES [Order]([Id])
)

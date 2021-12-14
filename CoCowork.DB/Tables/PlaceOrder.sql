CREATE TABLE [dbo].[PlaceOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PlaceId] INT NOT NULL, 
    [OrderId] INT NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NOT NULL, 
    [SubtotalPrice] DECIMAL(10, 2) NOT NULL, 
    CONSTRAINT [FK_PlaceOrder_ToPlace] FOREIGN KEY ([PlaceId]) REFERENCES [dbo].[Place]([Id]), 
    CONSTRAINT [FK_PlaceOrder_Order] FOREIGN KEY ([OrderId]) REFERENCES [Order]([Id])
)

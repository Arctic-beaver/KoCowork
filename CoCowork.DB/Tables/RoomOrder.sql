CREATE TABLE [dbo].[RoomOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RoomId] INT NOT NULL, 
    [OrderId] INT NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NOT NULL, 
    [SubtotalPrice] DECIMAL(10, 2) NOT NULL, 
    CONSTRAINT [FK_RoomId_to_Room] FOREIGN KEY ([RoomId]) REFERENCES [Room]([Id]), 
    CONSTRAINT [FK_OrderId_to_Order] FOREIGN KEY ([OrderId]) REFERENCES [Order]([Id])
)

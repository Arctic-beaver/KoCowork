CREATE TABLE [dbo].[PlaceOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PlaceId] INT NOT NULL, 
    [OrderId] INT NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NOT NULL, 
    [SubtotalPrice] INT NOT NULL, 
    CONSTRAINT [FK_PlaceOrder_ToPlace] FOREIGN KEY ([PlaceId]) REFERENCES [dbo].[Place]([Id]),

)

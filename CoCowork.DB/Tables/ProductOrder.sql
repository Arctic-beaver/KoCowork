CREATE TABLE [dbo].[ProductOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductId] INT NOT NULL, 
    [OrderId] INT NOT NULL, 
    [Amount] INT NOT NULL, 
    [SubtotalPrice] DECIMAL(10, 2) NOT NULL,
    CONSTRAINT [FK_ProductOrder_ToProduct] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product]([Id]),
    CONSTRAINT [FK_OrderId_ToOrder] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order]([Id]),

)

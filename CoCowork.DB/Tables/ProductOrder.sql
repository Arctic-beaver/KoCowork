CREATE TABLE [dbo].[ProductOrder]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[ProductId] INT NOT NULL,
	[OrderId] INT NOT NULL,
	[Amount] INT NOT NULL,
	[SubtotaPrice] INT NOT NULL,
	CONSTRAINT [FK_ProductId_To_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id])
)

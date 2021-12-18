CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ClientId] INT NOT NULL, 
    [TotalPrice] DECIMAL(10, 2) NOT NULL, 
    [IsPaid] BIT NOT NULL, 
    [IsCanceled] BIT NOT NULL, 
    CONSTRAINT [FK_Order_ToTable] FOREIGN KEY ([ClientId]) REFERENCES [Client]([Id])
)

CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ClientId] INT NOT NULL, 
    [TotalPrice] DECIMAL NULL, 
    [IsPaid] BIT NOT NULL, 
    [IsCanceled] BIT NOT NULL, 
    CONSTRAINT [FK_Order_ToTable] FOREIGN KEY ([ClientId]) REFERENCES [Client]([Id])
)

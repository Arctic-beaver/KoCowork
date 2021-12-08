CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ClientId] INT NOT NULL, 
    [TotalPrice] INT NULL, 
    [IsPaid] BIT NOT NULL, 
    [IsCanceled] BIT NOT NULL, 
    CONSTRAINT [FK_Order_ToTable] FOREIGN KEY ([ClientId]) REFERENCES [Client]([Id])
)

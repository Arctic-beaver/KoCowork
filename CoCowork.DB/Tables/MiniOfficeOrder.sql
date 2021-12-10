CREATE TABLE [dbo].[MiniOfficeOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MiniOfficeId] INT NOT NULL, 
    [OrderId] INT NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NOT NULL, 
    [SubtotalPrice] DECIMAL(10, 2) NOT NULL, 
    CONSTRAINT [FK_MiniOfficeOrder_ToMiniOffice] FOREIGN KEY ([MiniOfficeId]) REFERENCES [dbo].[MiniOffice]([Id])
)

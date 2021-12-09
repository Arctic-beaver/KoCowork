CREATE TABLE [dbo].[MiniOfficeOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MiniOfficeId] INT NOT NULL, 
    [OrderId] INT NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NOT NULL, 
    [SubtotalPrice] INT NOT NULL, 
    CONSTRAINT [FK_MiniOfficeOrder_ToMiniOffice] FOREIGN KEY ([MiniOfficeId]) REFERENCES [dbo].[MiniOffice]([Id])
)

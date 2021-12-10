CREATE TABLE [dbo].[Place]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MiniOfficeId] INT NULL, 
    [PricePerDay] DECIMAL(10, 2) NOT NULL, 
    [PriceFixedPerDay] DECIMAL(10, 2) NOT NULL, 
    CONSTRAINT [FK_Place_ToMiniOffice] FOREIGN KEY ([MiniOfficeId]) REFERENCES [dbo].[MiniOffice]([Id]),
)

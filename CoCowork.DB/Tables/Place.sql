CREATE TABLE [dbo].[Place]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MiniOfficeId] INT NULL, 
    [PricePerDay] INT NOT NULL, 
    [PriceFixedPerDay] INT NOT NULL, 
    CONSTRAINT [FK_Place_ToMiniOffice] FOREIGN KEY ([MiniOfficeId]) REFERENCES [dbo].[MiniOffice]([Id]),
)

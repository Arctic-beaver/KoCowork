CREATE TABLE [dbo].[Place]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MiniOfficeId] INT NULL, 
    [PricePerDay] INT NOT NULL, 
    [PriceFixedPerDay] INT NOT NULL
)

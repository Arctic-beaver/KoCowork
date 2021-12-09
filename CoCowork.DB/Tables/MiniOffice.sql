CREATE TABLE [dbo].[MiniOffice]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(30) NOT NULL, 
    [AmountOfPlaces] INT NOT NULL, 
    [PricePerDay] INT NOT NULL, 
    [IsActive] BIT NOT NULL,

)

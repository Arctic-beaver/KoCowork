CREATE TABLE [dbo].[MiniOffice]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] VARCHAR(30) NOT NULL, 
    [AmountOfPlaces] INT NOT NULL, 
    [PricePerDay] DECIMAL(10, 2) NOT NULL, 
    [IsActive] BIT NOT NULL,
    CONSTRAINT Name_unique UNIQUE([Name]),
    CONSTRAINT [PK_PLAYER] PRIMARY KEY CLUSTERED([Id] ASC)
)

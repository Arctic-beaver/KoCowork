CREATE TABLE [dbo].[Room]
(
	[Id] INT NOT NULL  PRIMARY KEY IDENTITY, 
    [Type] VARCHAR(20) NOT NULL, 
    [AmountOfPeople] INT NOT NULL, 
    [PricePerHour] DECIMAL(10, 2) NOT NULL
    
)

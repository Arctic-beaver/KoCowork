CREATE TABLE [dbo].[Room]
(
	[Id] INT NOT NULL  PRIMARY KEY IDENTITY, 
    [Type] VARCHAR(30) NOT NULL, 
    [AmountOfPeople] INT NOT NULL, 
    [PricePerHour] DECIMAL(10, 2) NOT NULL,
    [Description] NVARCHAR(200)
    
)

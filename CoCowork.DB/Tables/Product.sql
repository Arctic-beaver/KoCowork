CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(10) NOT NULL, 
    [Amount] INT NOT NULL, 
    [PriceForOne] DECIMAL(10, 2) NOT NULL, 
    [Description] TEXT NOT NULL
)

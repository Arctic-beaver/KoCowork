CREATE TABLE [dbo].[Room]
(
	[Id] INT NOT NULL , 
    [Type] INT NOT NULL, 
    [AmountOfPeople] INT NOT NULL, 
    [PricePerHour] INT NOT NULL, 
    PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Type_to_TypeOfRomm] FOREIGN KEY (Type) REFERENCES [TypeOfRoom]([ID])
)

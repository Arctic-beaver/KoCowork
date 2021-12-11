CREATE TABLE [dbo].[Room]
(
	[Id] INT NOT NULL  PRIMARY KEY IDENTITY, 
    [TypeId] INT NOT NULL, 
    [AmountOfPeople] INT NOT NULL, 
    [PricePerHour] INT NOT NULL, 
    CONSTRAINT [FK_TypeId_to_RoomType] FOREIGN KEY (TypeId) REFERENCES [RoomType]([Id])
)

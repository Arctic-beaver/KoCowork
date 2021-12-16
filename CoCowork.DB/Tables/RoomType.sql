CREATE TABLE [dbo].[RoomType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] varchar(30) NOT NULL, 
    CONSTRAINT AK_NameTypeRoom UNIQUE([Name])
)

CREATE PROC dbo.RoomType_Update
	@Id int,
	@Name varchar(30)
AS
BEGIN
	update dbo.RoomType
	set Name = @Name
    where Id = @Id
END

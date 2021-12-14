CREATE PROC dbo.RoomType_Delete
	@Id int
AS
BEGIN
	delete from dbo.RoomType
	where Id = @Id
END

CREATE PROC dbo.RoomOrder_Delete
	@Id int
AS
BEGIN
	delete from dbo.RoomOrder
	where Id = @Id
END

CREATE PROC dbo.TypeOfRoom_Delete
	@Id int
AS
BEGIN
	delete from dbo.TypeOfRoom
	where id = @Id
END

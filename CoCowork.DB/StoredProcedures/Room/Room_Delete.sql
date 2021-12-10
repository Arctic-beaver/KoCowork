CREATE PROC dbo.Room_Delete
	@Id int
AS
BEGIN
	delete from dbo.Room
	where Id = @Id
END

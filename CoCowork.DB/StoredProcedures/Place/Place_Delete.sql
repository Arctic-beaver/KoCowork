CREATE PROC dbo.Place_Delete
	@Id int
AS
BEGIN
	delete from dbo.Place
	where Id = @Id
END
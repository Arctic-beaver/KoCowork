CREATE PROC dbo.Client_Delete
	@Id int
AS
BEGIN
	delete from dbo.Client
	where id = @Id
END
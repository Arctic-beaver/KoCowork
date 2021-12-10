CREATE PROC dbo.MiniOffice_Delete
	@Id int
AS
BEGIN
	delete from dbo.MiniOffice
	where Id = @Id
END
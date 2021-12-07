CREATE PROC dbo.Payment_Delete
	@Id int
AS
BEGIN
	delete from dbo.Payment
	where Id = @Id
END

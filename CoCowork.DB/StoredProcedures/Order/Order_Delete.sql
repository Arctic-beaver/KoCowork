CREATE PROC dbo.Order_Delete
	@Id int
AS
BEGIN
	delete from dbo.[Order]
	where Id = @Id
END

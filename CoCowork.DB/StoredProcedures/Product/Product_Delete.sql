CREATE PROC dbo.Product_Delete
	@Id int
AS
BEGIN
	delete from dbo.Product
	where Id = @Id
END

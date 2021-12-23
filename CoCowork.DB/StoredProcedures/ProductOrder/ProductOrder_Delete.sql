CREATE PROC dbo.ProductOrder_Delete
	@Id int
AS
BEGIN
	delete from dbo.[ProductOrder]
	where Id = @Id
END

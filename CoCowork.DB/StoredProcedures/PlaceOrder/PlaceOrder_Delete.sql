CREATE PROC dbo.PlaceOrder_Delete
	@Id int
AS
BEGIN
	delete from dbo.PlaceOrder
	where Id = @Id
END
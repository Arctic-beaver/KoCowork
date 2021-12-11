CREATE PROC dbo.PlaceOrder_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		PlaceId,
		OrderId,
		StartDate,
		EndDate,
		SubtotalPrice
	from dbo.PlaceOrder
	where Id = @Id
END
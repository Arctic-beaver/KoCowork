CREATE PROC dbo.PlaceOrder_SelectAll
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
END
CREATE PROC dbo.PlaceOrder_SelectAll
AS
BEGIN
	select
		po.Id,
		po.PlaceId,
		po.OrderId,
		po.StartDate,
		po.EndDate,
		po.SubtotalPrice
	from dbo.PlaceOrder po
END
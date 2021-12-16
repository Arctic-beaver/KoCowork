CREATE PROC dbo.PlaceOrder_SelectByOrderId	
	@OrderId int
AS
BEGIN
	select
		po.Id,
		po.PlaceId,
		po.OrderId,
		po.StartDate,
		po.EndDate,
		po.SubtotalPrice,
		p.Id,
		p.PricePerDay,
		p.PriceFixedPerDay
	from dbo.PlaceOrder po
	inner join dbo.Place p on po.PlaceId = p.Id
	where po.OrderId = @OrderId
END
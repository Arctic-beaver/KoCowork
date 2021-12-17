CREATE PROCEDURE [dbo].[LaptopOrder_SelectByOrderId]
	@OrderId int 
AS 
BEGIN 
 select 
		lo.Id, 
		lo.LaptopId, 
		lo.OrderId, 
		lo.StartDate, 
		lo.EndDate, 
		lo.SubtotalPrice,
		o.Id,
		o.TotalPrice 
 from dbo.LaptopOrder lo inner join dbo.[Order] o on lo.OrderId = o.Id 
 where lo.OrderId = @OrderId 
END 
GO
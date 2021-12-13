CREATE PROCEDURE [dbo].[LaptopOrder_SelectAll]
AS
BEGIN
	select
		lo.Id,
		lo.OrderId,
		lo.StartDate,
		lo.EndDate,
		lo.SubtotalPrice
	from dbo.LaptopOrder lo
END

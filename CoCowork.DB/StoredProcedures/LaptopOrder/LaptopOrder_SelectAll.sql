CREATE PROCEDURE [dbo].[LaptopOrder_SelectAll]
AS
BEGIN
	select
		Id,
		LaptopId,
		OrderId,
		StartDate,
		EndDate,
		SubtotalPrice
	from dbo.LaptopOrder
END

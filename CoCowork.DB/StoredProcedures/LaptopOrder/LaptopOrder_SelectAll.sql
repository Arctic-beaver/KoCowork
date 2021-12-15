CREATE PROCEDURE [dbo].[LaptopOrder_SelectAll]
AS
BEGIN
	select
		lo.Id, 
		lo.OrderId, 
		lo.StartDate, 
		lo.EndDate, 
		lo.SubtotalPrice, 
		lo.LaptopId, 
		l.Name, 
		l.PricePerMonth, 
		l.Description 
 from dbo.LaptopOrder lo inner join dbo.Laptop l on lo.LaptopId = l.Id
END

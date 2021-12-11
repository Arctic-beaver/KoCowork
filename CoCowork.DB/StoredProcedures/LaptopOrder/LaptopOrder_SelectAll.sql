﻿CREATE PROCEDURE [dbo].[LaptopOrder_SelectAll]
AS
BEGIN
	select
		lo.Id,
		lo.LaptopId,
		lo.OrderId,
		lo.StartDate,
		lo.EndDate,
		lo.SubtotalPrice,
		l.Name
	from dbo.LaptopOrder lo inner join dbo.Laptop l on lo.LaptopId = l.Id
END

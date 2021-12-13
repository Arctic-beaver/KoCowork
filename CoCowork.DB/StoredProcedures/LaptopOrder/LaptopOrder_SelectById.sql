CREATE PROCEDURE [dbo].[LaptopOrder_SelectById]
	@Id int
AS
BEGIN
	select
		lo.Id,
		lo.OrderId,
		lo.StartDate,
		lo.EndDate,
		lo.SubtotalPrice,
		l.Name LaptopId
	from dbo.LaptopOrder lo inner join dbo.Laptop l on lo.LaptopId = l.Id
	where lo.Id = @Id
END

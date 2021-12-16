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
		l.Id,
		l.[Name],
		l.[Description],
		l.Amount
	from dbo.LaptopOrder lo left outer join dbo.Laptop l on l.Id = lo.LaptopId
	where lo.Id = @Id
END

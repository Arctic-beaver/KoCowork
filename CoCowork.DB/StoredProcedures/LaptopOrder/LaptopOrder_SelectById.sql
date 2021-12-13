CREATE PROCEDURE [dbo].[LaptopOrder_SelectById]
	@Id int
AS
BEGIN
	select
		lo.Id,
		lo.OrderId,
		lo.StartDate,
		lo.EndDate,
		lo.SubtotalPrice
	from dbo.LaptopOrder lo
	where lo.Id = @Id
END

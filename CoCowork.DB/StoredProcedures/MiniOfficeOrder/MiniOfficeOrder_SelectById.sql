CREATE PROC dbo.MiniOfficeOrder_SelectById	
	@Id int
AS
BEGIN
	select
		dbo.MiniOfficeOrder.Id,
		dbo.MiniOfficeOrder.MiniOfficeId,
		dbo.MiniOfficeOrder.OrderId,
		dbo.MiniOfficeOrder.StartDate,
		dbo.MiniOfficeOrder.EndDate,
		dbo.MiniOfficeOrder.SubtotalPrice,
		dbo.MiniOffice.Id,
		dbo.MiniOffice.[Name],
		dbo.MiniOffice.AmountOfPlaces,
		dbo.MiniOffice.PricePerDay,
		dbo.MiniOffice.IsActive
	from dbo.MiniOfficeOrder
	left outer join dbo.MiniOffice on dbo.MiniOffice.Id = dbo.MiniOfficeOrder.MiniOfficeId
	where dbo.MiniOfficeOrder.Id = @Id
END
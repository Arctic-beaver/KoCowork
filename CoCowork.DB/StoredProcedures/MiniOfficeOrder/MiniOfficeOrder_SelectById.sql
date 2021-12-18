CREATE PROC dbo.MiniOfficeOrder_SelectById	
	@Id int
AS
BEGIN
	select
		mord.Id,
		mord.MiniOfficeId,
		mord.OrderId,
		mord.StartDate,
		mord.EndDate,
		mord.SubtotalPrice,
		mo.Id,
		mo.[Name],
		mo.AmountOfPlaces,
		mo.PricePerDay,
		mo.IsActive
	from dbo.MiniOfficeOrder mord
	left outer join dbo.MiniOffice mo on mo.Id = mord.MiniOfficeId
	where mord.Id = @Id
END
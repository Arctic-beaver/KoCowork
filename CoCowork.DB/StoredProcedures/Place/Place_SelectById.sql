CREATE PROC dbo.Place_SelectById	
	@Id int
AS
BEGIN
	select
		dbo.Place.Id,
		dbo.Place.PricePerDay,
		dbo.Place.PriceFixedPerDay,
		dbo.MiniOffice.Id,
		dbo.MiniOffice.[Name],
		dbo.MiniOffice.AmountOfPlaces,
		dbo.MiniOffice.PricePerDay,
		dbo.MiniOffice.IsActive
	from dbo.Place
	left outer join dbo.MiniOffice on dbo.MiniOffice.Id = dbo.Place.MiniOfficeId
	where dbo.Place.Id = @Id
END
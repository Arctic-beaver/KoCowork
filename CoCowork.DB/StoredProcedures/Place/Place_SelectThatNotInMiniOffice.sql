CREATE PROC dbo.Place_SelectThatNotInMiniOffice
AS
BEGIN
	select
		dbo.Place.Id,
		dbo.Place.PricePerDay,
		dbo.Place.PriceFixedPerDay
	from dbo.Place
	where dbo.Place.MiniOfficeId is null
END
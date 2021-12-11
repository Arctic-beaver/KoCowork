CREATE PROC dbo.PlaceOrder_SelectAll
AS
BEGIN
	select
		dbo.PlaceOrder.Id,
		dbo.PlaceOrder.PlaceId,
		dbo.PlaceOrder.OrderId,
		dbo.PlaceOrder.StartDate,
		dbo.PlaceOrder.EndDate,
		dbo.PlaceOrder.SubtotalPrice,
		FullPlace.PlaceId Id,
		FullPlace.PlacePriceFixedPerDay PriceFixedPerDay,
		FullPlace.PlacePricePerDay PricePerDay,
		FullPlace.MiniOfficeId Id,
		FullPlace.[Name],
		FullPlace.AmountOfPlaces,
		FullPlace.MiniOfficePricePerDay PricePerDay,
		FullPlace.IsActive
	from 
	(
		select
		dbo.Place.Id PlaceId,
		dbo.Place.PricePerDay PlacePricePerDay,
		dbo.Place.PriceFixedPerDay PlacePriceFixedPerDay,
		dbo.MiniOffice.Id MiniOfficeId,
		dbo.MiniOffice.[Name],
		dbo.MiniOffice.AmountOfPlaces,
		dbo.MiniOffice.PricePerDay MiniOfficePricePerDay,
		dbo.MiniOffice.IsActive
		from dbo.Place
		left outer join dbo.MiniOffice on dbo.MiniOffice.Id = dbo.Place.MiniOfficeId
	) as FullPlace
	left outer join FullPlace on FullPlace.PlaceId = dbo.PlaceOrder.PlaceId
END
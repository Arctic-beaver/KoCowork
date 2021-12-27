CREATE PROC dbo.Place_SelectThatNotInMiniOffice
AS
BEGIN
	select
		Id,
		Number,
		PricePerDay,
		PriceFixedPerDay,
		Description
	from dbo.Place p
	where p.MiniOfficeId is null
END
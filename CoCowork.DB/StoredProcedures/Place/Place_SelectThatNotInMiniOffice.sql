CREATE PROC dbo.Place_SelectThatNotInMiniOffice
AS
BEGIN
	select
		Id,
		PricePerDay,
		PriceFixedPerDay
	from dbo.Place p
	where p.MiniOfficeId is null
END
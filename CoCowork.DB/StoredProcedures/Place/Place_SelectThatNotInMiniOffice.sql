CREATE PROC dbo.Place_SelectThatNotInMiniOffice
AS
BEGIN
	select
		p.Id,
		p.PricePerDay,
		p.PriceFixedPerDay
	from dbo.Place p
	where p.MiniOfficeId is null
END
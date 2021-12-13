CREATE PROC dbo.Place_SelectAll
AS
BEGIN
	select
		p.Id,
		p.MiniOfficeId,
		p.PricePerDay,
		p.PriceFixedPerDay
	from dbo.Place p 
END
CREATE PROC dbo.Place_SelectAll
AS
BEGIN
	select
		p.Id,
		p.MiniOfficeId,
		p.PricePerDay,
		p.PriceFixedPerDay,
		mo.Name
	from dbo.Place p inner join dbo.MiniOffice mo on p.MiniOfficeId = mo.Id
END
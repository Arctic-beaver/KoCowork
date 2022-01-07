CREATE PROC dbo.Place_SelectById	
	@Id int
AS
BEGIN
	select
		p.Id,
		p.Number,
		p.PricePerDay,
		p.PriceFixedPerDay,
		p.[Description],
		mo.Id,
		mo.[Name],
		mo.AmountOfPlaces,
		mo.PricePerDay,
		mo.IsActive
	from dbo.Place p
	inner join dbo.MiniOffice mo on  p.MiniOfficeId = mo.Id
	where p.Id = @Id
END
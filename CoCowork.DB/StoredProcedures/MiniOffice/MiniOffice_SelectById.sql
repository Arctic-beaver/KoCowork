CREATE PROC dbo.MiniOffice_SelectById	
	@Id int
AS
BEGIN
	select
		mo.Id,
		mo.Name,
		mo.AmountOfPlaces,
		mo.PricePerDay,
		mo.IsActive,
		p.Id,
		p.PriceFixedPerDay,
		p.PricePerDay
	from dbo.MiniOffice mo
	inner join dbo.Place p on mo.Id = p.MiniOfficeId
	where mo.Id = @Id and IsActive is not null
END
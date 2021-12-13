CREATE PROC dbo.Place_SelectById	
	@Id int
AS
BEGIN
	select
		p.Id,
		p.MiniOfficeId,
		p.PricePerDay,
		p.PriceFixedPerDay
	from dbo.Place p 
	where p.Id = @Id
END
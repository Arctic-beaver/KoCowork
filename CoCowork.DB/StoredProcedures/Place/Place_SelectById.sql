CREATE PROC dbo.Place_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		MiniOfficeId,
		PricePerDay,
		PriceFixedPerDay
	from dbo.Place
	where Id = @Id
END
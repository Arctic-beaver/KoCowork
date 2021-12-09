CREATE PROC dbo.MiniOffice_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		Name,
		AmountOfPlaces,
		PricePerDay,
		IsActive
	from dbo.MiniOffice
	where Id = @Id
END
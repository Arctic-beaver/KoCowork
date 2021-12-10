CREATE PROC dbo.MiniOffice_SelectAll
AS
BEGIN
	select
		Id,
		Name,
			AmountOfPlaces,
			PricePerDay,
			IsActive
	from dbo.MiniOffice
	where IsActive is not null
END

CREATE PROC dbo.MiniOffice_Insert
	@Name varchar(30),
	@AmountOfPlaces int,
	@PricePerDay int,
	@IsActive bit
AS
BEGIN
	insert into dbo.MiniOffice
		(
			Name,
			AmountOfPlaces,
			PricePerDay,
			IsActive
		)
	values 
		(
			@Name,
			@AmountOfPlaces,
			@PricePerDay,
			@IsActive
		)
END

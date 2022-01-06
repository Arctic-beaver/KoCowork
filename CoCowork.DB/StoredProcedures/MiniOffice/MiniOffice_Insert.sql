CREATE PROC dbo.MiniOffice_Insert
	@Name varchar(30),
	@AmountOfPlaces int,
	@PricePerDay decimal(10,2),
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
SELECT SCOPE_IDENTITY()
END

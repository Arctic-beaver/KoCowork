CREATE PROC dbo.MiniOffice_Update
	@Id int,
	@Name varchar(30),
	@AmountOfPlaces int,
	@PricePerDay int,
	@IsActive bit
AS
BEGIN
	update dbo.MiniOffice
	set Name = @Name,
		AmountOfPlaces = @AmountOfPlaces,
		PricePerDay = @PricePerDay,
		IsActive = @IsActive
    where Id = @Id
END
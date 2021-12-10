CREATE PROC dbo.Room_Insert
	@Type int,
	@AmountOfPeople int,
	@PricePerHour int
AS
BEGIN
	insert into dbo.Room
		(TypeId,
		AmountOfPeople,
		PricePerHour)
	values 
		(@Type,
		@AmountOfPeople,
		@PricePerHour)
END

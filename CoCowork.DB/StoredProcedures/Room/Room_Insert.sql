CREATE PROC dbo.Room_Insert
	@Type varchar(20),
	@AmountOfPeople int,
	@PricePerHour decimal(10,2),
	@Description nvarchar(200)
AS
BEGIN
	insert into dbo.Room
		(Type,
		AmountOfPeople,
		PricePerHour,
		Description)
	values 
		(@Type,
		@AmountOfPeople,
		@PricePerHour,
		@Description)
SELECT SCOPE_IDENTITY()
END

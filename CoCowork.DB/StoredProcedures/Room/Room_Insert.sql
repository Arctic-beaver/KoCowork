CREATE PROC dbo.Room_Insert
	@Type int,
	@AmountOfPeople int,
	@PricePerHour decimal(10,2),
	@Name varchar(20)
AS
BEGIN
	insert into dbo.Room
		(Type,
		AmountOfPeople,
		PricePerHour, 
		[Name])
	values 
		(@Type,
		@AmountOfPeople,
		@PricePerHour,
		@Name)
END

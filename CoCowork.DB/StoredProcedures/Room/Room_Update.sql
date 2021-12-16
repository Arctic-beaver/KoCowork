CREATE PROC dbo.Room_Update
	@Id int,
	@Type int,
	@AmountOfPeople int,
	@PricePerHour decimal(10,2),
	@Name varchar
AS
BEGIN
	update dbo.Room
	set TypeId = @Type,
		AmountOfPeople = @AmountOfPeople,
		PricePerHour = @PricePerHour,
		[Name] = @Name
    where id = @Id
END

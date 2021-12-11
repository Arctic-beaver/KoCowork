CREATE PROC dbo.Room_Update
	@Id int,
	@Type int,
	@AmountOfPeople int,
	@PricePerHour decimal(10,2)
AS
BEGIN
	update dbo.Room
	set TypeId = @Type,
		AmountOfPeople = @AmountOfPeople,
		PricePerHour = @PricePerHour
    where id = @Id
END

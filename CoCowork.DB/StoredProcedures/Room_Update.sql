CREATE PROC dbo.Room_Update
	@Id int,
	@Type int,
	@AmountOfPeople int,
	@PricePerHour int
AS
BEGIN
	update dbo.Room
	set Type = @Type,
		AmountOfPeople = @AmountOfPeople,
		PricePerHour = @PricePerHour
    where id = @Id
END

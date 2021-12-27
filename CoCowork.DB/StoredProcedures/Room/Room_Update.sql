CREATE PROC dbo.Room_Update
	@Id int,
	@Type varchar(20),
	@AmountOfPeople int,
	@PricePerHour decimal(10,2),
	@Description nvarchar(200)
AS
BEGIN
	update dbo.Room
	set Type = @Type,
		AmountOfPeople = @AmountOfPeople,
		PricePerHour = @PricePerHour,
		Description = @Description
    where id = @Id
END

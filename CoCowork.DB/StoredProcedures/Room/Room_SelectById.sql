CREATE PROC dbo.Room_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		Type,
		AmountOfPeople,
		PricePerHour,
		Description
	from dbo.Room
	where id =@Id
END

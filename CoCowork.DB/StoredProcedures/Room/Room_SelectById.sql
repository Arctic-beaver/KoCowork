CREATE PROC dbo.Room_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		TypeId,
		AmountOfPeople,
		PricePerHour
	from dbo.Room
	where id =@Id
END

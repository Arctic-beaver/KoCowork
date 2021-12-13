CREATE PROC dbo.Room_SelectById	
	@Id int
AS
BEGIN
	select
		r.Id,
		r.AmountOfPeople,
		r.PricePerHour
	from dbo.Room r 
	where r.id =@Id
END

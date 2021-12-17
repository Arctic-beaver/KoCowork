CREATE PROC dbo.Room_SelectById	
	@Id int
AS
BEGIN
	select
		r.Id,
		r.TypeId,
		r.AmountOfPeople,
		r.PricePerHour,
		r.[Name]
	from dbo.Room r 
	where r.id =@Id
END

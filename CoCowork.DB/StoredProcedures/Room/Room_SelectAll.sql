CREATE PROC dbo.Room_SelectAll
AS
BEGIN
	select
		r.Id,
		r.TypeId,
		r.AmountOfPeople,
		r.PricePerHour,
		r.[Name]
	from dbo.Room r 
END

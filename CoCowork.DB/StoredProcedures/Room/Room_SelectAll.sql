CREATE PROC dbo.Room_SelectAll
AS
BEGIN
	select
		r.Id,
		r.Type,
		r.AmountOfPeople,
		r.PricePerHour
	from dbo.Room r 
END

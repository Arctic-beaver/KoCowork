CREATE PROC dbo.Room_SelectAll
AS
BEGIN
	select
		Id,
		Type,
		AmountOfPeople,
		PricePerHour
	from dbo.Room 
END

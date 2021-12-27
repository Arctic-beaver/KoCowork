CREATE PROC dbo.Room_SelectAll
AS
BEGIN
	select
		Id,
		Type,
		AmountOfPeople,
		PricePerHour,
		Description
	from dbo.Room 
END

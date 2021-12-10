CREATE PROC dbo.Room_SelectAll
AS
BEGIN
	select
		Id,
		TypeId,
		AmountOfPeople,
		PricePerHour
	from dbo.Room
END

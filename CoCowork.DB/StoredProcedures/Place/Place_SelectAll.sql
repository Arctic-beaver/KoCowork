CREATE PROC dbo.Place_SelectAll
AS
BEGIN
	select
		Id,
		PricePerDay,
		PriceFixedPerDay
	from dbo.Place
END
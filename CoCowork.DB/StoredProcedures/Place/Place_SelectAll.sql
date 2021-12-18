CREATE PROC dbo.Place_SelectAll
AS
BEGIN
	select
		Id,
    MiniOfficeId,
		PricePerDay,
		PriceFixedPerDay
	from dbo.Place
END
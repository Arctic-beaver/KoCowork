CREATE PROC dbo.Place_SelectAll
AS
BEGIN
	select
		Id,
        MiniOfficeId,
		Number,
		PricePerDay,
		PriceFixedPerDay,
		Description
	from dbo.Place
END
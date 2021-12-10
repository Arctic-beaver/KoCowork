CREATE PROC dbo.MiniOfficeOrder_SelectAll
AS
BEGIN
	select
		Id,
		MiniOfficeId,
		OrderId,
		StartDate,
		EndDate,
		SubtotalPrice
	from dbo.MiniOfficeOrder
END
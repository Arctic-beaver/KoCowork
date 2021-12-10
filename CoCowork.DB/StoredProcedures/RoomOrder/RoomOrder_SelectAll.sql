CREATE PROC dbo.RoomOrder_SelectAll
AS
BEGIN
	select
		Id,
		RoomId,
		OrderId,
		StartDate,
		EndDate,
		SubtotalPrice
	from dbo.RoomOrder
END
CREATE PROC dbo.RoomOrder_Insert
	@RoomId int,
	@OrderId int,
	@StartDate DateTime,
	@EndDate DateTime,
	@SubtotalPrice int
AS
BEGIN
	insert into dbo.RoomOrder
		(RoomId,
		OrderId,
		StartDate,
		SubtotalPrice,
		EndDate)
	values 
		(RoomId,
		OrderId,
		StartDate,
		SubtotalPrice,
		EndDate)
END

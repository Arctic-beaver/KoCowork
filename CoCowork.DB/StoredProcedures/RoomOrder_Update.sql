CREATE PROC dbo.RoomOrder_Update
	@Id int,
	@RoomId int,
	@OrderId int,
	@StartDate DateTime,
	@EndDate DateTime,
	@SubtotalPrice int
AS
BEGIN
	update dbo.RoomOrder
	set RoomId = @RoomId,
		OrderId = @OrderId,
		StartDate = @StartDate,
		EndDate = @EndDate,
		SubtotalPrice = @SubtotalPrice
    where id = @Id
END

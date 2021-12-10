CREATE PROC dbo.PlaceOrder_Update
	@Id int,
	@PlaceId int,
	@OrderId int,
	@StartDate datetime,
	@EndDate datetime,
	@SubtotalPrice int
AS
BEGIN
	update dbo.PlaceOrder
	set PlaceId = @PlaceId,
		OrderId = @OrderId,
		StartDate = @StartDate,
		EndDate = @EndDate,
		SubtotalPrice = @SubtotalPrice
    where Id = @Id
END
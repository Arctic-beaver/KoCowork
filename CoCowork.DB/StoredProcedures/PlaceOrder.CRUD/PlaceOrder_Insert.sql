CREATE PROC dbo.PlaceOrder_Insert
	@PlaceId int,
	@OrderId int,
	@StartDate datetime,
	@EndDate datetime,
	@SubtotalPrice int
AS
BEGIN
	insert into dbo.PlaceOrder
		(
			PlaceId,
			OrderId,
			StartDate,
			EndDate,
			SubtotalPrice
		)
	values 
		(
			@PlaceId,
			@OrderId,
			@StartDate,
			@EndDate,
			@SubtotalPrice
		)
END

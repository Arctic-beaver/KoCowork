CREATE PROC dbo.PlaceOrder_Insert
	@PlaceId int,
	@OrderId int,
	@StartDate datetime,
	@EndDate datetime,
	@SubtotalPrice decimal(10,2)
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

CREATE PROCEDURE [dbo].[LaptopOrder_Update]
	@Id int,
	@LaptopId int,
	@OrderId int,
	@StartDate datetime,
	@EndDate datetime,
	@SubtotalPrice int
AS
BEGIN
	update dbo.LaptopOrder
	set LaptopId = @LaptopId,
	OrderId = @OrderId,
	StartDate = @StartDate,
	@EndDate = @EndDate,
	@SubtotalPrice = @SubtotalPrice
	where Id = @Id
END
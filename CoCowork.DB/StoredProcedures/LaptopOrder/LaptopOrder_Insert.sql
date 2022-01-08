CREATE PROCEDURE [dbo].[LaptopOrder_Insert]
	@LaptopId int,
	@OrderId int,
	@StartDate datetime,
	@EndDate datetime,
	@SubtotalPrice int
AS
BEGIN
	insert into dbo.LaptopOrder
		(LaptopId,
		OrderId,
		StartDate,
		EndDate,
		SubtotalPrice)
	values 
		(@LaptopId,
		@OrderId,
		@StartDate,
		@EndDate,
		@SubtotalPrice)
SELECT SCOPE_IDENTITY()
END

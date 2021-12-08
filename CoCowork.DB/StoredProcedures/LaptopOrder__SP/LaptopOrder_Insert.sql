CREATE PROCEDURE [dbo].[LaptopOrder_Insert]
	@Id int,
	@LaptopId int,
	@OrderId int,
	@StartDate datetime,
	@EndDate datetime,
	@SubtotalPrice int
AS
BEGIN
	insert into dbo.LaptopOrder
		(Id,
		LaptopId,
		OrderId,
		StartDate,
		EndDate,
		SubtotalPrice)
	values 
		(@Id,
		@LaptopId,
		@OrderId,
		@StartDate,
		@EndDate,
		@SubtotalPrice)
END

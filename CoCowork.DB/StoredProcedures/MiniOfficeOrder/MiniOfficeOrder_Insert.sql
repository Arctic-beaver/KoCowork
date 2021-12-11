CREATE PROC dbo.MiniOfficeOrder_Insert
	@MiniOfficeId int,
	@OrderId int,
	@StartDate datetime,
	@EndDate datetime,
	@SubtotalPrice decimal(10,2)
AS
BEGIN
	insert into dbo.MiniOfficeOrder
		(
			MiniOfficeId,
			OrderId,
			StartDate,
			EndDate,
			SubtotalPrice
		)
	values 
		(
			@MiniOfficeId,
			@OrderId,
			@StartDate,
			@EndDate,
			@SubtotalPrice
		)
END

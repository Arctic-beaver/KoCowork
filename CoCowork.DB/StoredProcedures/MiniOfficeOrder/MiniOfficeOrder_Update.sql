CREATE PROC dbo.MiniOffficeOrder_Update
	@Id int,
	@MiniOfficeId int,
	@OrderId int,
	@StartDate datetime,
	@EndDate datetime,
	@SubtotalPrice decimal(10,2)
AS
BEGIN
	update dbo.MiniOfficeOrder
	set MiniOfficeId = @MiniOfficeId,
		OrderId = @OrderId,
		StartDate = @StartDate,
		EndDate = @EndDate,
		SubtotalPrice = @SubtotalPrice
    where Id = @Id
END
CREATE PROC dbo.MiniOffficeOrder_Update
	@Id int,
	@MiniOfficeId int,
	@StartDate datetime,
	@EndDate datetime,
	@SubtotalPrice decimal(10,2)
AS
BEGIN
	update dbo.MiniOfficeOrder
	set MiniOfficeId = @MiniOfficeId,
		StartDate = @StartDate,
		EndDate = @EndDate,
		SubtotalPrice = @SubtotalPrice
    where Id = @Id
END
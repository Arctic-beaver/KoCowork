CREATE PROC dbo.MiniOfficeOrder_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		MiniOfficeId,
		OrderId,
		StartDate,
		EndDate,
		SubtotalPrice
	from dbo.MiniOfficeOrder
	where Id = @Id
END
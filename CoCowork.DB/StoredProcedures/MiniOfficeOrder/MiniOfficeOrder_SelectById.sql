CREATE PROC dbo.MiniOfficeOrder_SelectById	
	@Id int
AS
BEGIN
	select
		mo.Id,
		mo.OrderId,
		mo.StartDate,
		mo.EndDate,
		mo.SubtotalPrice,
		m.Name MiniOfficeId
	from dbo.MiniOfficeOrder mo inner join dbo.MiniOffice m on mo.MiniOfficeId = m.Id
	where mo.Id = @Id
END
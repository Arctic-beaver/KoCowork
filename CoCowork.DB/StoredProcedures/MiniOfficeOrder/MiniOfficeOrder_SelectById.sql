CREATE PROC dbo.MiniOfficeOrder_SelectById	
	@Id int
AS
BEGIN
	select
		mo.Id,
		mo.MiniOfficeId,
		mo.OrderId,
		mo.StartDate,
		mo.EndDate,
		mo.SubtotalPrice,
		m.Name
	from dbo.MiniOfficeOrder mo inner join dbo.MiniOffice m on mo.MiniOfficeId = m.Id
	where mo.Id = @Id
END
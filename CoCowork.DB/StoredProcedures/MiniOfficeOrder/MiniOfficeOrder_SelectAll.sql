CREATE PROC dbo.MiniOfficeOrder_SelectAll
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
END
CREATE PROC dbo.Order_SelectAll
AS
BEGIN
	select
		o.Id,
		o.ClientId,
		o.TotalPrice,
		o.IsPaid,
		o.IsCanceled,
		c.Name
	from dbo.[Order] o inner join dbo.Client c on o.ClientId = c.Id
END

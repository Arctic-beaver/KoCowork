CREATE PROC dbo.Order_SelectAll
AS
BEGIN
	select
		o.Id,
		o.ClientId,
		o.TotalPrice,
		o.IsPaid,
		o.IsCanceled
	from dbo.[Order] o 
END

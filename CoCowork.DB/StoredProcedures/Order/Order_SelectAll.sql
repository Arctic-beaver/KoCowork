CREATE PROC dbo.Order_SelectAll
AS
BEGIN
	select
		Id,
		ClientId,
		TotalPrice,
		IsPaid,
		IsCanceled
	from dbo.[Order]
END

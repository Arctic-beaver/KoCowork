CREATE PROC dbo.ProductOrder_SelectAll
AS
BEGIN
	select
		Id,
		ProductId,
		OrderId,
		Amount,
		SubtotalPrice
	from dbo.[ProductOrder] o 
END

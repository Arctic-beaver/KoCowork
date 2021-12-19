CREATE PROC dbo.ProductOrder_SelectById	
	@Id int
AS
BEGIN
	select
		po.Id,
		po.ProductId,
		po.OrderId,
		po.Amount,
		po.SubtotalPrice,
		p.Id,
		p.[Name],
		p.PriceForOne,
		p.Amount,
		p.[Description],
		o.Id,
		o.IsCanceled,
		o.IsPaid,
		o.TotalPrice
	from dbo.ProductOrder po 
	inner join dbo.Product p on po.ProductId = p.Id 
	inner join dbo.[Order] o on po.OrderId = o.Id
	
	where po.Id = @Id
END

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
		p.[Description]
	from dbo.ProductOrder po inner join dbo.Product p on po.ProductId = p.Id
	where po.Id = @Id
END

CREATE PROC dbo.ProductOrder_SelectById	
	@Id int
AS
BEGIN
	select
		ProductId,
		OrderId,
		Amount,
		SubtotalPrice
	from dbo.ProductOrder  
	where id = @Id
END

CREATE PROC dbo.ProductOrder_Update
	@Id int,
	@ProductId int,
	@OrderId int,
	@Amount int,
	@SubtotalPrice int
AS
BEGIN
	update dbo.[ProductOrder]
	set 
		ProductId = @ProductId,
		OrderId = @OrderId,
		Amount = @Amount,
		SubtotalPrice = @SubtotalPrice
    where id = @Id
END

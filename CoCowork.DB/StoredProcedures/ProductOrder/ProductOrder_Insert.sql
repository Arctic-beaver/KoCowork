CREATE PROC dbo.ProductOrder_Insert
	@ProductId int,
	@OrderId int,
	@Amount int,
	@SubtotalPrice int
AS
BEGIN
	insert into dbo.[ProductOrder]
		(ProductId,
		OrderId,
		Amount,
		SubtotalPrice)
	values 
		(@ProductId,
		@OrderId,
		@Amount,
		@SubtotalPrice)
END

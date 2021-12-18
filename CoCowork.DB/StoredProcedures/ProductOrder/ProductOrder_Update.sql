CREATE PROC dbo.ProductOrder_Update
	@Id int,
	@Amount int,
	@SubtotalPrice int
AS
BEGIN
	update dbo.[ProductOrder]
	set 
		Amount = @Amount,
		SubtotalPrice = @SubtotalPrice
    where id = @Id
END

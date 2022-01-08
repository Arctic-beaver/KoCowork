CREATE PROC dbo.Payment_Insert
	@Amount decimal(10,2),
	@PaymentDate DateTime,
	@OrderId int
AS
BEGIN
	insert into dbo.Payment
		(Amount,
		PaymentDate,
		OrderId)
	values 
		(@Amount,
		@PaymentDate,
		@OrderId)
SELECT SCOPE_IDENTITY()
END

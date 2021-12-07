CREATE PROC dbo.Payment_Insert
	@Amount int,
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
END

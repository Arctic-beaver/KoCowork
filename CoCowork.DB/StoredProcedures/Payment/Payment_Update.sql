CREATE PROC dbo.Payment_Update
	@Id int,
	@Amount decimal(10,2),
	@PaymentDate DateTime
AS
BEGIN
	update dbo.Payment
	set Amount = @Amount,
		PaymentDate = @PaymentDate
    where id = @Id
END

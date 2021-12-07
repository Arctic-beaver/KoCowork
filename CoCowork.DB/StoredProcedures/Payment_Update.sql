CREATE PROC dbo.Payment_Update
	@Id int,
	@Amount int,
	@PaymentDate DateTime
AS
BEGIN
	update dbo.Payment
	set Amount = @Amount,
		PaymentDate = @PaymentDate
    where id = @Id
END

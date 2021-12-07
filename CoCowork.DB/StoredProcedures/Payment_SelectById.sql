CREATE PROC dbo.Payment_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		Amount,
		PaymentDate,
		OrderId
	from dbo.Payment
	where id =@Id
END

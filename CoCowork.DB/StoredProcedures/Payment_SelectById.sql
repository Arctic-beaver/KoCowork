CREATE PROC dbo.Payment_SelectById	
	@Id int
AS
BEGIN
	select
		id,
		amount,
		paymentDate,
		orderId
	from dbo.Payment
	where id =@Id
END

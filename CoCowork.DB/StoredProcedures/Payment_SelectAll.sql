CREATE PROC dbo.Payment_SelectAll
AS
BEGIN
	select
		id,
		amount,
		paymentDate,
		orderId
	from dbo.Payment
END
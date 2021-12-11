CREATE PROC dbo.Payment_SelectAll
AS
BEGIN
	select
		Id,
		Amount,
		PaymentDate,
		OrderId
	from dbo.Payment
END
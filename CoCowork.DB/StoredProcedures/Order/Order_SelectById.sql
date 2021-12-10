CREATE PROC dbo.Order_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		ClientId,
		TotalPrice,
		IsPaid,
		IsCanceled
	from dbo.[Order]
	where id =@Id
END

CREATE PROC dbo.Order_SelectById	
	@Id int
AS
BEGIN
	select
		o.Id,
		o.ClientId,
		o.TotalPrice,
		o.IsPaid,
		o.IsCanceled
	from dbo.[Order] o 
	where o.id =@Id
END

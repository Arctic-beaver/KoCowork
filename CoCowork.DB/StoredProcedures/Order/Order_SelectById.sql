CREATE PROC dbo.Order_SelectById	
	@Id int
AS
BEGIN
	select 
		o.Id,
		o.ClientId,
		o.TotalPrice,
		o.IsPaid,
		o.IsCanceled,

		c.Id,
		c.FirstName,
		c.LastName,
		c.Phone,
		c.Email,
		c.DateBirth,
		c.PaperAmount,
		c.PaperEndDay,
		
		p.Id,
		p.OrderId,
		p.Amount,
		p.PaymentDate

	from dbo.[Order] o 
	inner join dbo.Client c on c.Id = o.ClientId
	inner join dbo.Payment p on p.OrderId = o.Id
	where o.id =@Id
END
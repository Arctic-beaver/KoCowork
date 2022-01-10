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
		
		p.Id,
		p.OrderId,
		p.Amount,
		p.PaymentDate

	from dbo.[Order] o 
	left join dbo.Payment p on o.Id = p.OrderId
	where o.id =@Id
END
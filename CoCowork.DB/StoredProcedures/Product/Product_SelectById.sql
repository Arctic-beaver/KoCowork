CREATE PROC dbo.Product_SelectById	
	@Id int
AS
BEGIN
	select
		p.[Name],
		p.Amount,
		p.PriceForOne,
		p.[Description]
	from dbo.Product p 
	where p.id = @Id
END

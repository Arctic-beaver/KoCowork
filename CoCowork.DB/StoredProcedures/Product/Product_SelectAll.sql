CREATE PROC dbo.Product_SelectAll
AS
BEGIN
	select
		p.Id,
		p.[Name],
		p.Amount,
		p.PriceForOne,
		p.[Description]
	from dbo.Product p 
END

CREATE PROC dbo.Product_Insert
	@Name varchar(20),
	@Amount int,
	@PriceForOne decimal,
	@Description text
AS
BEGIN
	insert into dbo.Product
		([Name],
		Amount,
		PriceForOne,
		[Description])
	values 
		(@Name,
		@Amount,
		@PriceForOne,
		@Description)
END

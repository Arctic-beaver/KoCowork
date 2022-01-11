CREATE PROC dbo.Product_Insert
	@Name varchar(30),
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
SELECT SCOPE_IDENTITY()
END

CREATE PROC dbo.Product_Update
	@Id int,
	@Name varchar (30),
	@Amount int,
	@PriceForOne decimal,
	@Description text
AS
BEGIN
	update dbo.Product
	set [Name] = @Name,
		Amount = @Amount,
		PriceForOne = @PriceForOne,
		[Description] = @Description
    where id = @Id
END
